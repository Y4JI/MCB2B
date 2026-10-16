using System.Collections.Concurrent;
using MCB2B.Models;

namespace MCB2B.Services;

/// <summary>
/// In-memory singleton store for user accounts.
/// Plain in-memory comparison for demonstration purposes only (no hashing or database).
/// Survives page refreshes while the application process is running.
/// </summary>
public class AccountStore
{
    private readonly ConcurrentDictionary<string, UserAccount> _accounts = new(StringComparer.OrdinalIgnoreCase);

    public AccountStore()
    {
        // Pre-seeded demo account as required by project specification
        var demoUser = new UserAccount
        {
            Username = "demo",
            Email = "demo@aetheria.net",
            Password = "demo123",
            CreatedAt = DateTime.UtcNow.AddDays(-7),
            OwnedRanks = new List<string> { "scout" }
        };
        _accounts[demoUser.Username] = demoUser;
    }

    public UserAccount? Authenticate(string usernameOrEmail, string password)
    {
        if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
            return null;

        var account = _accounts.Values.FirstOrDefault(u =>
            (string.Equals(u.Username, usernameOrEmail, StringComparison.OrdinalIgnoreCase) ||
             string.Equals(u.Email, usernameOrEmail, StringComparison.OrdinalIgnoreCase)) &&
            u.Password == password);

        return account;
    }

    public bool Exists(string username, string email)
    {
        return _accounts.Values.Any(u =>
            string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase) ||
            string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase));
    }

    public bool Register(string username, string email, string password, out string? errorMessage, out UserAccount? createdAccount)
    {
        errorMessage = null;
        createdAccount = null;

        if (_accounts.Values.Any(u => string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase)))
        {
            errorMessage = "This username is already taken. Please choose another.";
            return false;
        }

        if (_accounts.Values.Any(u => string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase)))
        {
            errorMessage = "An account with this email address already exists.";
            return false;
        }

        var newAccount = new UserAccount
        {
            Username = username,
            Email = email,
            Password = password,
            CreatedAt = DateTime.UtcNow,
            OwnedRanks = new List<string>()
        };

        if (_accounts.TryAdd(username, newAccount))
        {
            createdAccount = newAccount;
            return true;
        }

        errorMessage = "Failed to create account. Please try again.";
        return false;
    }

    public bool UpdateProfile(string originalUsername, string newUsername, string newEmail, out string? errorMessage)
    {
        errorMessage = null;

        if (!_accounts.TryGetValue(originalUsername, out var account))
        {
            errorMessage = "Account not found.";
            return false;
        }

        // Check if username changed and is already taken
        if (!string.Equals(originalUsername, newUsername, StringComparison.OrdinalIgnoreCase))
        {
            if (_accounts.Values.Any(u => string.Equals(u.Username, newUsername, StringComparison.OrdinalIgnoreCase)))
            {
                errorMessage = "The requested username is already taken.";
                return false;
            }
        }

        // Check if email changed and is already taken
        if (!string.Equals(account.Email, newEmail, StringComparison.OrdinalIgnoreCase))
        {
            if (_accounts.Values.Any(u => !string.Equals(u.Username, originalUsername, StringComparison.OrdinalIgnoreCase) &&
                                          string.Equals(u.Email, newEmail, StringComparison.OrdinalIgnoreCase)))
            {
                errorMessage = "The requested email address is already in use.";
                return false;
            }
        }

        if (!string.Equals(originalUsername, newUsername, StringComparison.OrdinalIgnoreCase))
        {
            _accounts.TryRemove(originalUsername, out _);
            account.Username = newUsername;
            account.Email = newEmail;
            _accounts[newUsername] = account;
        }
        else
        {
            account.Email = newEmail;
        }

        return true;
    }

    public void AddRankToAccount(string username, string rankId)
    {
        if (_accounts.TryGetValue(username, out var account))
        {
            if (!account.OwnedRanks.Contains(rankId, StringComparer.OrdinalIgnoreCase))
            {
                account.OwnedRanks.Add(rankId);
            }
        }
    }
}
