using System;
using System.Threading.Tasks;
using Api.Contracts.Ouput;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions;

public static class IQueryableExtensions
{

  public static async Task<PagedOutputDto<T>> ToPagedResponse<T>(this IQueryable<T> query, int size, int page)
  {

    var skip = (page - 1) * size;
    var data = await query
      .Skip(skip)
      .Take(size)

    .ToListAsync();

    var totalItems = await query.CountAsync();

    return new PagedOutputDto<T>(totalItems, size, page, data);
  }

}
