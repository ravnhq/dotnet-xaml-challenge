using System;
using System.Threading.Tasks;
using Api.Contracts.Ouput;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions;

public static class IQueryableExtensions
{

  public static async Task<PagedOutputDto<T>> ToPagedResponse<T>(this IQueryable<T> query, int size, int page)
  {
    throw new NotImplementedException();
  }

}
