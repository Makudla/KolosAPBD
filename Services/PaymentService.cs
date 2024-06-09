using KolokwiumCF.DTOs.Request;
using KolokwiumCF.Models;
using KolokwiumCF.Repositories;

namespace KolokwiumCF.Services;

public class PaymentService(IPaymentRepository paymentRepository, IClientRepository clientRepository) : IPaymentService
{
    public async Task<int> PayForSubscriptionAsync(PaymentDTO paymentDTO, int idSubscription, int idClient)
    {
        var client = await clientRepository.GetClientAsync(idClient);
        if (client == null)
            throw new Exception("Nie znaleziono klienta");

        var subscription = client.Sales
                         .Select(s => s.IdSubscriptionNav)
                         .FirstOrDefault(s => s.IdSubscription == idSubscription);
        if (subscription == null)
            throw new Exception("Nie znaleziono subskrypcji");

        var totalPaidAmount = subscription.Payments.Sum(p => p.Amount);
        var newTotalAmount = totalPaidAmount + paymentDTO.Amount;
        if (newTotalAmount > subscription.Price)
            throw new Exception("Wysokośc płatności przekroczyła cenę subskrypcji");

        var payment = new Payment
        {
            Amount = paymentDTO.Amount,
            Date = paymentDTO.Date,
            IdSubscription = idSubscription,
            IdClient = idClient
        };

        var paymentId = await paymentRepository.AddPaymentAsync(payment);
        return paymentId;
    }
}