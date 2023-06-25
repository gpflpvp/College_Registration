namespace College_Registration.Domain.Entities
{
    public class Account
    {
        
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        
        public int SectionId { get; set; }
        public virtual IList<Student> Students { get; set; } = new List<Student>();
        public virtual IList<Teacher> Teachers { get; set; } = new List<Teacher>();
        public Account()
        {
            
        }
        public Account(string firstName, string lastName, bool gender,string email, string password,string type)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Email = email;
            Password= password;
            Type = type;
        }

    }
}
