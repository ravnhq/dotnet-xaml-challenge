using System;
using CommunityToolkit.Mvvm.ComponentModel;
using UI.Models;

namespace UI.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private string title = string.Empty;

    [ObservableProperty]
    private bool isBusy = false;
}
