namespace MCB2B.Models;

public class RankProduct
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Tier { get; set; }
    public decimal Price { get; set; }
    public string PrefixTag { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public List<string> Perks { get; set; } = new();
    public bool IsFeatured { get; set; }
    public bool IsPopular { get; set; }
    
    // Visual theme styling classes
    public string AccentColorHex { get; set; } = string.Empty;
    public string BorderClass { get; set; } = string.Empty;
    public string BadgeBgClass { get; set; } = string.Empty;
    public string BadgeTextClass { get; set; } = string.Empty;
    public string GlowClass { get; set; } = string.Empty;
    public string ButtonClass { get; set; } = string.Empty;

    // Comparison attributes
    public string HomeLimit { get; set; } = string.Empty;
    public string CoinMultiplier { get; set; } = string.Empty;
    public bool PriorityQueue { get; set; }
    public bool FlyAccess { get; set; }
    public bool KeepExpOnDeath { get; set; }
    public bool CustomNick { get; set; }
    public bool PrivateWorld { get; set; }
    public string VaultChests { get; set; } = string.Empty;
}
