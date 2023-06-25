namespace College_Registration.Domain.Entities
{
    public class College
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual IList<Section> Sections { get; set; } = new List<Section>();
        public College()
        {
            
        }
        public College(string name, string address)
        {
            Name = name;
            Address = address;
        }
        
    }
}
