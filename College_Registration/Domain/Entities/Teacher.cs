namespace College_Registration.Domain.Entities
{
    public class Teacher
    {
        public int Id { get; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
