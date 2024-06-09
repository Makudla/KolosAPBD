using KolokwiumCF.DTOs.Response;
using KolokwiumCF.Models;
using KolokwiumCF.Repositories;

namespace KolokwiumCF.Services;

public class ClientService(IClientRepository clientRepository) : IClientService
{
    public async Task<ClientDTO> GetClientAsync(int id)
    {
        var client = await clientRepository.GetClientAsync(id);

        if (client == null)
            throw new Exception("Nie znaleziono klienta");

        decimal discount = GetClientDiscount(client);

        List<SubscriptionDTO> subscriptions = GetClientSubscriptions(client);

        ClientDTO clientDTO = new ClientDTO
        {
            FirstName = client.FirstName,
            LastName = client.LastName,
            Email = client.Email,
            Phone = client.Phone,
            Discount = (int)discount,
            Subscriptions = subscriptions
        };

        return clientDTO;
    }
    private decimal GetClientDiscount(Client client)
    {
        var currentDiscount = client.Discounts
            .Where(d => d.DateFrom < DateTime.Now && d.DateTo > DateTime.Now)
            .FirstOrDefault();

        return currentDiscount != null ? currentDiscount.Value : 0;
    }
    private List<SubscriptionDTO> GetClientSubscriptions(Client client)
    {
        List<SubscriptionDTO> subscriptions = client.Sales
            .Select(sale => sale.IdSubscriptionNav)
            .Select(subscription => new SubscriptionDTO
            {
                IdSubscription = subscription.IdSubscription,
                Name = subscription.Name,
                RenewalPeriod = subscription.RenewalPeriod,
                TotalPaidAmount = subscription.Payments.Sum(payment => payment.Amount)
            })
            .ToList();

        return subscriptions;
    }

}