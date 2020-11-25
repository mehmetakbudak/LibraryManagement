namespace LibraryManagement.Data.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
