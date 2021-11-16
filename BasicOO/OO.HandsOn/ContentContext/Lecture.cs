using OO.HandsOn.ContentContext.Enums;
using OO.HandsOn.ContentContext.SharedContext;

namespace OO.HandsOn.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
