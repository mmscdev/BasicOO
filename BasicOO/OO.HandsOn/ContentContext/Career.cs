using System.Collections.Generic;

namespace OO.HandsOn.ContentContext
{
    public class Career: Content
    {
        public Career(string _title, string _url):base(_title,_url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
    }
}
