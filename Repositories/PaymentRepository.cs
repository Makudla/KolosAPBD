using KolokwiumCF.Models;

namespace KolokwiumCF.Repositories;

public class PaymentRepository(KoloContext context) : IPaymentRepository
{
    public async Task<int> AddPaymentAsync(Payment payment)
    {
        await context.Payments.AddAsync(payment);
        await context.SaveChangesAsync();
        return payment.IdPayment;
    }
}