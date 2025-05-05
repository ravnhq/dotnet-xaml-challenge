using System;

namespace UI.Models;

public class Ticket
{
    public int Id {get; set;}
    public string Subject {get; set;}
    public string Status {get; set;}
    public int CustomerId {get; set;}
    public string CustomerName {get; set;}
}


public class TicketResponse
{
    public int TotalCount {get; set;}
    public int PageSize {get; set;}
    public int PageNumber {get; set;}
    public List<Ticket> Data {get; set;}

}
