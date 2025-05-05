using Api.Models;

namespace Api.Contracts.Ouput;

public record class TicketListOutputDto(
  int Id,
  string Subject,
  TicketStatus Status,
  string CustomerName,
  int CustomerId,
  DateTime CreatedAt);
