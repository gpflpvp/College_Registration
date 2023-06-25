namespace College_Registration.Domain.Entities
{
    public class Student
    {
        public int Id { get; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
        public Student()
        {
            
        }
        public Student(int accountId, int sectionId)
        {
            AccountId = accountId;
            SectionId = sectionId;
        }
    }
}
