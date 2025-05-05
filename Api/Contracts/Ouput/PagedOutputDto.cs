namespace Api.Contracts.Ouput;

public record PagedOutputDto<T>(
  int TotalCount,
  int PageSize,
  int PageNumber,
  IEnumerable<T> Data);