using System;
using System.Net.Http.Json;
using UI.Models;

namespace UI.Services;

public class TicketService : ITicketService
{
    private readonly HttpClient _httpClient;
    public TicketService()
    {
        // Initialize any necessary resources or dependencies here
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5224")
        };
    }

    public async Task<Ticket> CreateTicketAsync(int CustomerId, string Subject)
    {
        var payLoad = new
        {
            subject = Subject,
            customerId = CustomerId,
        };

        var response = await _httpClient.PostAsJsonAsync("/api/Tickets", payLoad);

        response.EnsureSuccessStatusCode();
        
        var ticket = await response.Content.ReadFromJsonAsync<Ticket>();

        return ticket ?? throw new Exception("Failed to create ticket.");
    }

    public async Task<List<Ticket>> GetTicketsAsync(string? status, string? sort, int pageNumber = 1, int pageSize = 10)
    {
        throw new NotImplementedException();
    }
}
