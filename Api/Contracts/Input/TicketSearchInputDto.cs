using Api.Models;

namespace Api.Contracts.Input;

public enum SortOptions
{
  Asc,
  Desc
}

public record class TicketListInputDto(TicketStatus? Status, SortOptions SortOptions, int Page = 1, int Size = 10) : PagedOuputDto(Page, Size);

public abstract record PagedOuputDto(int Page, int Size);


