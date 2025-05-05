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
        var queryParameters = new List<string>();

        if( !string.IsNullOrWhiteSpace(status))
        {
            queryParameters.Add($"status={status}");
        }

        if( !string.IsNullOrWhiteSpace(sort))
        {
            queryParameters.Add($"sortOptions={sort}");
        }

        queryParameters.Add($"pageNumber={pageNumber}");
        queryParameters.Add($"size={pageSize}");

        var queryString = string.Join("&", queryParameters);

        var response = await _httpClient.GetAsync($"/api/Tickets?{queryString}");

        response.EnsureSuccessStatusCode();

        var ticketResponse = await response.Content.ReadFromJsonAsync<TicketResponse>();

        return ticketResponse?.Data ?? new List<Ticket>();
    }
}
