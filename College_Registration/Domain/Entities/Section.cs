namespace College_Registration.Domain.Entities
{
    public class Section
    {
    
        public int Id { get; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int CollegeId { get; set; }
        public College College { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public virtual IList<Schedule> Schedules { get; set; } = new List<Schedule>();
        public virtual IList<Student> Students { get; set; } = new List<Student>();
        public Section()
        {
            
        }
        public Section(string name, int collegeId, int courseId, int capacity)
        {
            Name = name;
            CollegeId = collegeId;
            CourseId = courseId;
            Capacity = capacity;
        }

        

    }
}
