using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Data.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Deleted { get; set; }
    }
}
