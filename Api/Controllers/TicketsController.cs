using Api.Contracts.Input;
using Api.Contracts.Ouput;
using Api.Data;
using Api.Extensions;
using Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketsController : ControllerBase
{
    private readonly AppDbContext _dbContext;

    public TicketsController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<PagedOutputDto<TicketListOutputDto>> GetList([FromQuery] TicketListInputDto request)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<ActionResult<TicketDetailOuputDto>> CreateTicket(CreateTicketInputDto request)
    {
        var model = new Ticket()
        {
            Subject = request.Subject,
            Status = TicketStatus.Open,
            CustomerId = request.CustomerId
        };

        await _dbContext.Tickets.AddAsync(model);
        await _dbContext.SaveChangesAsync();

        var createdTicket = await _dbContext
        .Tickets
        .Where(x => x.Id == model.Id)
        .Include(x => x.Customer)
        .SingleAsync();

        return Ok(new TicketDetailOuputDto(
            model.Id,
            model.Subject,
            model.Status,
            model.CustomerId,
            model.Customer.Name));
    }
}
