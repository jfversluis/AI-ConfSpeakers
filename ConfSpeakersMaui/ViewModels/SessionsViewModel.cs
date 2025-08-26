using System.Collections.ObjectModel;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ConfSpeakersMaui.Models;

namespace ConfSpeakersMaui.ViewModels;

public partial class SessionsViewModel : ObservableObject
{
    private readonly HttpClient _httpClient;

    [ObservableProperty]
    private ObservableCollection<SessionWithSpeaker> sessions = [];

    [ObservableProperty]
    private bool isLoading = false;

    [ObservableProperty]
    private string errorMessage = string.Empty;

    [ObservableProperty]
    private bool hasError = false;

    public SessionsViewModel(HttpClient httpClient)
    {
        _httpClient = httpClient;
        LoadSessionsCommand = new AsyncRelayCommand(LoadSessionsAsync);
    }

    public IAsyncRelayCommand LoadSessionsCommand { get; }

    private async Task LoadSessionsAsync()
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
                Sessions.Clear();
                
                // Extract all sessions from all speakers and combine with speaker info
                var allSessions = new List<SessionWithSpeaker>();
                
                foreach (var speaker in speakersData)
                {
                    foreach (var session in speaker.Sessions)
                    {
                        var sessionWithSpeaker = new SessionWithSpeaker
                        {
                            Title = session.Title,
                            Abstract = session.Abstract,
                            Room = session.Room,
                            StartsAt = session.StartsAt,
                            EndsAt = session.EndsAt,
                            SpeakerName = speaker.Name,
                            SpeakerCompany = speaker.Company,
                            SpeakerImageUrl = speaker.ImageUrl
                        };
                        
                        allSessions.Add(sessionWithSpeaker);
                    }
                }
                
                // Sort sessions by start time
                var sortedSessions = allSessions
                    .OrderBy(s => s.StartsAt)
                    .ThenBy(s => s.Room);
                
                foreach (var session in sortedSessions)
                {
                    Sessions.Add(session);
                }
            }
        }
        catch (Exception ex)
        {
            HasError = true;
            ErrorMessage = $"Failed to load sessions: {ex.Message}";
        }
        finally
        {
            IsLoading = false;
        }
    }
}