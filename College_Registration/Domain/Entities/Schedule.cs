namespace College_Registration.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; }
        public DateTime ClassBegin { get; set; }
        public DateTime ClassEnd { get; set; }
        public string ClassDay { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public virtual IList<Teacher> Teachers { get; set; } = new List<Teacher>();

        public Schedule()
        {
            
        }
        public Schedule(DateTime classBegin,DateTime classEnd, string classDay,int subjectId, int sectionId)
        {
            ClassBegin = classBegin;
            ClassEnd = classEnd;
            ClassDay=classDay;
            SubjectId = subjectId;
            SectionId = sectionId;
        }
    }
}
