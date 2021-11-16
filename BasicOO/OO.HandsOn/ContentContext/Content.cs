using OO.HandsOn.ContentContext.SharedContext;
using System;

namespace OO.HandsOn.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string _title,string _url)
        {
            Id = Guid.NewGuid();
            Title = _title;
            Url = _url;
        }
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Url { get; private set; }
    }
}
