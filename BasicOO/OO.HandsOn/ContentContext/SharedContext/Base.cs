using OO.HandsOn.NotificationContext;
using System;

namespace OO.HandsOn.ContentContext.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
