using Api.Contracts.Input;
using Api.Contracts.Ouput;
using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Customers : ControllerBase
{
    private readonly AppDbContext _dbContext;
    public Customers(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<ActionResult<CustomerDetailOuputDto>> CreateCustomer(CreateCustomerInputDto request)
    {
        var model = new Customer()
        {
            Name = request.Name,
            Email = request.Email
        };

        await _dbContext.Customers.AddAsync(model);
        await _dbContext.SaveChangesAsync();

        return Ok(new CustomerDetailOuputDto(model.Id, model.Name, model.Email));
    }
}
