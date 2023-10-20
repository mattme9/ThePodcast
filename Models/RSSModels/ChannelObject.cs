namespace Models
{
    public class Channel
    {
        public int Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Item> Item {  get; set; } 
    }

    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }

    }
}