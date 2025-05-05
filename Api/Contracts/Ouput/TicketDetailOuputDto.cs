using Api.Models;

namespace Api.Contracts.Ouput;

public record class TicketDetailOuputDto(int Id, string Subject, TicketStatus Status, int CustomerId, string CustomerName);
