using Newtonsoft.Json;

namespace TellMeWhatToDo.DTOs
{
    internal class Activity
    {
        public string activity { get; set; }
        public double accessibility { get; }
        public string type { get; set; }
        public long participants { get; set; }
        public double price { get; }
        public string link { get; }
        public long key { get; }
    }
}
