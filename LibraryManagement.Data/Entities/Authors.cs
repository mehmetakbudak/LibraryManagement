namespace LibraryManagement.Data.Entities
{
    public class Authors : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Deleted { get; set; }
    }
}
