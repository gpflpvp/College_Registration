namespace College_Registration.Domain.Entities
{
    public class Subject
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Unit { get; set; }
        public virtual IList<Schedule> Schedules { get; set; } = new List<Schedule>();
        public Subject()
        {
            
        }
        public Subject(string name,int unit)
        {
            Name = name;
            Unit = unit;
        }
    }
}
