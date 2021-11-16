using OO.HandsOn.ContentContext.SharedContext;
using System;

namespace OO.HandsOn.ContentContext.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}