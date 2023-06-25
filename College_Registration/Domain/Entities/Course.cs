namespace College_Registration.Domain.Entities
{
    public class Course
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IList<Section> Sections { get; set; } = new List<Section>();
        public Course()
        {
            
        }
        public Course(string name, string description)
        {
            Name = name;
            Description = description;
        }

        

    }
}
