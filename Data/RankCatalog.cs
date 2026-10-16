using MCB2B.Models;

namespace MCB2B.Data;

public static class RankCatalog
{
    public static readonly IReadOnlyList<RankProduct> Ranks = new List<RankProduct>
    {
        new RankProduct
        {
            Id = "scout",
            Name = "Scout",
            Tier = 1,
            Price = 4.99m,
            PrefixTag = "[SCOUT]",
            ShortDescription = "Essential perks and quality-of-life commands for budding adventurers.",
            Perks = new List<string>
            {
                "Green [SCOUT] in-game chat badge",
                "2x Home Waypoints (/sethome)",
                "Access to /hat and /workbench utilities",
                "Priority Server Login Queue"
            },
            IsFeatured = false,
            IsPopular = false,
            AccentColorHex = "#10B981",
            BorderClass = "border-emerald-500/40 hover:border-emerald-400",
            BadgeBgClass = "bg-emerald-500/10 border-emerald-500/30",
            BadgeTextClass = "text-emerald-400",
            GlowClass = "shadow-[0_0_20px_rgba(16,185,129,0.15)]",
            ButtonClass = "bg-emerald-600 hover:bg-emerald-500 text-white",
            HomeLimit = "2 Homes",
            CoinMultiplier = "1.0x (Standard)",
            PriorityQueue = true,
            FlyAccess = false,
            KeepExpOnDeath = false,
            CustomNick = false,
            PrivateWorld = false,
            VaultChests = "1 Chest"
        },
        new RankProduct
        {
            Id = "knight",
            Name = "Knight",
            Tier = 2,
            Price = 9.99m,
            PrefixTag = "[KNIGHT]",
            ShortDescription = "Stalwart combat and storage bonuses designed for regular survivalists.",
            Perks = new List<string>
            {
                "Blue [KNIGHT] in-game chat badge",
                "5x Home Waypoints (/sethome)",
                "Keep 100% Experience upon death",
                "3 Personal End-Chest Vaults (/vault)",
                "1.25x Server Economy Coin Booster"
            },
            IsFeatured = false,
            IsPopular = false,
            AccentColorHex = "#3B82F6",
            BorderClass = "border-blue-500/40 hover:border-blue-400",
            BadgeBgClass = "bg-blue-500/10 border-blue-500/30",
            BadgeTextClass = "text-blue-400",
            GlowClass = "shadow-[0_0_20px_rgba(59,130,246,0.15)]",
            ButtonClass = "bg-blue-600 hover:bg-blue-500 text-white",
            HomeLimit = "5 Homes",
            CoinMultiplier = "1.25x",
            PriorityQueue = true,
            FlyAccess = false,
            KeepExpOnDeath = true,
            CustomNick = false,
            PrivateWorld = false,
            VaultChests = "3 Chests"
        },
        new RankProduct
        {
            Id = "vanguard",
            Name = "Vanguard",
            Tier = 3,
            Price = 19.99m,
            PrefixTag = "[VANGUARD]",
            ShortDescription = "Elite status with hub flight, particle cosmetics, and lobby priority.",
            Perks = new List<string>
            {
                "Purple [VANGUARD] in-game chat badge",
                "10x Home Waypoints (/sethome)",
                "Full /fly access in Hubs & Personal Island",
                "Particle Trail Selector (8 animated trails)",
                "1.5x Server Economy Coin Booster",
                "Ability to join full lobby instances"
            },
            IsFeatured = true,
            IsPopular = false,
            AccentColorHex = "#8B5CF6",
            BorderClass = "border-purple-500/50 hover:border-purple-400",
            BadgeBgClass = "bg-purple-500/10 border-purple-500/30",
            BadgeTextClass = "text-purple-400",
            GlowClass = "shadow-[0_0_25px_rgba(139,92,246,0.2)]",
            ButtonClass = "bg-purple-600 hover:bg-purple-500 text-white",
            HomeLimit = "10 Homes",
            CoinMultiplier = "1.5x",
            PriorityQueue = true,
            FlyAccess = true,
            KeepExpOnDeath = true,
            CustomNick = false,
            PrivateWorld = false,
            VaultChests = "5 Chests"
        },
        new RankProduct
        {
            Id = "overlord",
            Name = "Overlord",
            Tier = 4,
            Price = 34.99m,
            PrefixTag = "[OVERLORD]",
            ShortDescription = "Dominant prestige with join broadcasts and expansive utility unlocks.",
            Perks = new List<string>
            {
                "Golden [OVERLORD] in-game chat badge",
                "20x Home Waypoints (/sethome)",
                "Custom Realm Join Broadcast announcement",
                "2.0x Server Economy Coin Booster",
                "All Cosmetic Hats, Pets & Disguise Morphs",
                "Pristine White chat message formatting"
            },
            IsFeatured = false,
            IsPopular = false,
            AccentColorHex = "#F59E0B",
            BorderClass = "border-amber-500/50 hover:border-amber-400",
            BadgeBgClass = "bg-amber-500/10 border-amber-500/30",
            BadgeTextClass = "text-amber-400",
            GlowClass = "shadow-[0_0_25px_rgba(245,158,11,0.2)]",
            ButtonClass = "bg-amber-500 hover:bg-amber-400 text-gray-950 font-bold",
            HomeLimit = "20 Homes",
            CoinMultiplier = "2.0x",
            PriorityQueue = true,
            FlyAccess = true,
            KeepExpOnDeath = true,
            CustomNick = false,
            PrivateWorld = false,
            VaultChests = "10 Chests"
        },
        new RankProduct
        {
            Id = "mythic",
            Name = "Mythic",
            Tier = 5,
            Price = 54.99m,
            PrefixTag = "[MYTHIC]",
            ShortDescription = "Mythological power with unlimited waypoints and private realm access.",
            Perks = new List<string>
            {
                "Crimson [MYTHIC] animated chat badge",
                "Unlimited Home Waypoints (/sethome)",
                "Private Creative Realm instance access",
                "3.0x Server Economy Coin Booster",
                "Color and format code permissions for signs & chat",
                "Exclusive Alpha Server test invites"
            },
            IsFeatured = false,
            IsPopular = false,
            AccentColorHex = "#EF4444",
            BorderClass = "border-red-500/50 hover:border-red-400",
            BadgeBgClass = "bg-red-500/10 border-red-500/30",
            BadgeTextClass = "text-red-400",
            GlowClass = "shadow-[0_0_30px_rgba(239,68,68,0.25)]",
            ButtonClass = "bg-red-600 hover:bg-red-500 text-white font-bold",
            HomeLimit = "Unlimited",
            CoinMultiplier = "3.0x",
            PriorityQueue = true,
            FlyAccess = true,
            KeepExpOnDeath = true,
            CustomNick = true,
            PrivateWorld = true,
            VaultChests = "20 Chests"
        },
        new RankProduct
        {
            Id = "celestial",
            Name = "Celestial",
            Tier = 6,
            Price = 89.99m,
            PrefixTag = "[CELESTIAL]",
            ShortDescription = "The supreme patron rank granting maximum boundary expansion and custom nicknames.",
            Perks = new List<string>
            {
                "Prismatic Cyan [CELESTIAL] luminous chat badge",
                "Max Island Boundary Expansion (250x250 blocks)",
                "Full Custom Nickname permission (/nick)",
                "Personal Weather & Day/Night Time toggle",
                "All future Beta gameplay feature access",
                "Exclusive Celestial VIP Discord Role & Channel"
            },
            IsFeatured = true,
            IsPopular = true,
            AccentColorHex = "#06B6D4",
            BorderClass = "border-cyan-400 hover:border-cyan-300 ring-1 ring-cyan-500/30",
            BadgeBgClass = "bg-cyan-500/15 border-cyan-400/40",
            BadgeTextClass = "text-cyan-300 font-bold",
            GlowClass = "shadow-[0_0_35px_rgba(6,182,212,0.3)]",
            ButtonClass = "bg-gradient-to-r from-cyan-500 to-blue-500 hover:from-cyan-400 hover:to-blue-400 text-gray-950 font-bold",
            HomeLimit = "Unlimited",
            CoinMultiplier = "4.0x",
            PriorityQueue = true,
            FlyAccess = true,
            KeepExpOnDeath = true,
            CustomNick = true,
            PrivateWorld = true,
            VaultChests = "Unlimited"
        }
    };

    public static RankProduct? GetById(string id)
    {
        return Ranks.FirstOrDefault(r => string.Equals(r.Id, id, StringComparison.OrdinalIgnoreCase));
    }
}
