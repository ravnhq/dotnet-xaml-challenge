using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using UI.Models;
using UI.Services;

namespace UI.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    private int customerId;

    [ObservableProperty]
    private string? subject;

     [ObservableProperty]
    private string status = string.Empty;

    [ObservableProperty]
    private string sort = string.Empty;

    [ObservableProperty]
    private List<Ticket> tickets;

    private readonly ITicketService _ticketService;
    public MainViewModel(ITicketService ticketService)
    {
        _ticketService = ticketService ?? throw new ArgumentNullException(nameof(ticketService));
        Title = "Main Page";
    }

    [RelayCommand]
    private async Task CreateTicketAsync()
    {
        if (string.IsNullOrWhiteSpace(Subject))
        {
            await Shell.Current.DisplayAlert("Error", "Please enter a subject.", "OK");
            return;
        }

        try
        {
            var response = await _ticketService.CreateTicketAsync(CustomerId, Subject);

            if (response == null)
            {
                await Shell.Current.DisplayAlert("Error", "Failed to create ticket.", "OK");
                return;
            }else{
                //Clear the form after ticket creation
                Subject = string.Empty;
                CustomerId = 0;
            }

        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            return;
        }

        await Shell.Current.DisplayAlert("Success", "Ticket created successfully!", "OK");
    }

    [RelayCommand]
    private async Task ShowTicketsAsync()
    {
        throw new NotImplementedException();
    }
}
