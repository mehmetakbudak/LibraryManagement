namespace LibraryManagement.Data.Entities
{
    public class Persons : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Deleted { get; set; }
    }
}
