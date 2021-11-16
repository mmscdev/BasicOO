using OO.HandsOn.ContentContext.Enums;
using System.Collections.Generic;

namespace OO.HandsOn.ContentContext
{
    public class Course : Content 
    {
        
        public Course(string _title, string _url) : base(_title, _url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }

}
