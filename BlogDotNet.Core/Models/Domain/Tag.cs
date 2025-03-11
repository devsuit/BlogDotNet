namespace BlogDotNet.Core.Models.Domain
{
    public class Tag
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Tag() { }
        public Tag(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
