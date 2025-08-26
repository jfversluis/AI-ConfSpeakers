using ConfSpeakersMaui.ViewModels;

namespace ConfSpeakersMaui.Pages;

public partial class SessionsPage : ContentPage
{
    public SessionsPage(SessionsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        
        if (BindingContext is SessionsViewModel viewModel)
        {
            await viewModel.LoadSessionsCommand.ExecuteAsync(null);
        }
    }
}