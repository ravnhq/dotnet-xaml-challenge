namespace Api.Models;

public class Ticket
{
  private List<ExternalResources> _externalResources = new List<ExternalResources>();

  public int Id { get; set; }
  public int CustomerId { get; set; }
  public string Subject { get; set; }
  public TicketStatus Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public IReadOnlyList<ExternalResources> ExternalResources => _externalResources.AsReadOnly();

  public Customer Customer { get; set; }

  public void AddExternalResource(string url)
  {
    _externalResources.Add(new ExternalResources { Url = url });
  }

  public void DeleteExternalResource(int id)
  {
    _externalResources.RemoveAll(x => x.Id == id);
  }
}

public enum TicketStatus
{
  Open,
  InProgress,
  Closed
}
