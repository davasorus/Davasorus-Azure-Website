using System;

namespace StreamWebPage.Models
{
    public partial class ChannelAnalytics
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? AdBreaksMinutes { get; set; }
        public int? AdTimeSecondsPerHour { get; set; }
        public int? AverageViewers { get; set; }
        public int? ChatMessages { get; set; }
        public int? Chatters { get; set; }
        public int? ClipViews { get; set; }
        public int? ClipsCreated { get; set; }
        public int? Follows { get; set; }
        public int? HostsAndRaidsViewers { get; set; }
        public int? LiveViews { get; set; }
        public int? MaxViewers { get; set; }
        public int? MinutesWatched { get; set; }
        public int? MinutesStreamed { get; set; }
        public int? UniqueViewers { get; set; }
        public int? SubRevenue { get; set; }
        public int? PrimeRevenue { get; set; }
        public int? GiftedSubsRevenue { get; set; }
        public int? BitsRevenue { get; set; }
        public int? AdRevenue { get; set; }
        public int? GameSalesRevenue { get; set; }
        public int? ExtensionsRevenue { get; set; }
        public int? BountiesRevenue { get; set; }
        public int? PrimeSubs { get; set; }
        public int? TotalPaidSubs { get; set; }
        public int? Tier1Subs { get; set; }
        public int? TotalGiftedSubs { get; set; }
        public int? GiftedTier1Subs { get; set; }
    }
}