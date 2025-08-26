using System.Collections.ObjectModel;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ConfSpeakersMaui.Models;

namespace ConfSpeakersMaui.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly HttpClient _httpClient;

    [ObservableProperty]
    private ObservableCollection<Speaker> speakers = [];

    [ObservableProperty]
    private bool isLoading = false;

    [ObservableProperty]
    private string errorMessage = string.Empty;

    [ObservableProperty]
    private bool hasError = false;

    public MainViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
        LoadSpeakersCommand = new AsyncRelayCommand(LoadSpeakersAsync);
    }

    public IAsyncRelayCommand LoadSpeakersCommand { get; }

    private async Task LoadSpeakersAsync()
    {
        if (IsLoading)
        {
            return;
        }

        try
        {
            IsLoading = true;
            HasError = false;
            ErrorMessage = string.Empty;

            var response = await _httpClient.GetStringAsync("https://gerald.fyi/speaker-endpoint");
            
            var speakersData = JsonSerializer.Deserialize<List<Speaker>>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (speakersData is not null)
            {
                Speakers.Clear();
                foreach (var speaker in speakersData)
                {
                    Speakers.Add(speaker);
                }
            }
        }
        catch (Exception ex)
        {
            HasError = true;
            ErrorMessage = $"Failed to load speakers: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }
}
