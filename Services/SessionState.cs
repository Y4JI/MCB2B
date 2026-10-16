using MCB2B.Models;

namespace MCB2B.Services;

/// <summary>
/// Scoped session state holding the currently authenticated user in the Blazor circuit.
/// Persists across normal page navigation within the circuit; reset upon browser refresh.
/// </summary>
public class SessionState
{
    public UserAccount? CurrentUser { get; private set; }

    public bool IsLoggedIn => CurrentUser != null;

    public event Action? OnChange;

    public void Login(UserAccount user)
    {
        CurrentUser = user;
        NotifyStateChanged();
    }

    public void Logout()
    {
        CurrentUser = null;
        NotifyStateChanged();
    }

    public void UpdateProfile(string newUsername, string newEmail)
    {
        if (CurrentUser != null)
        {
            CurrentUser.Username = newUsername;
            CurrentUser.Email = newEmail;
            NotifyStateChanged();
        }
    }

    public void AddRank(string rankId)
    {
        if (CurrentUser != null && !CurrentUser.OwnedRanks.Contains(rankId, StringComparer.OrdinalIgnoreCase))
        {
            CurrentUser.OwnedRanks.Add(rankId);
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
