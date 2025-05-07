using System;
using UI.Models;

namespace UI.Services;

public interface ITicketService
{
    Task<Ticket> CreateTicketAsync(int CustomerId, string Subject);
    Task<List<Ticket>> GetTicketsAsync(string? status, string? sort, int pageNumber = 1, int pageSize = 10);
}
