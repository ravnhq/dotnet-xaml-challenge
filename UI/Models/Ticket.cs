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

}
