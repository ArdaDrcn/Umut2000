namespace Umut2000.Entity.Models
{
    public class UmutUser : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
