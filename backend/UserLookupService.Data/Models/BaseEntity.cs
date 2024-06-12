namespace KayakMeetupService.Data.Models
{
    public class BaseEntity
    {
        public bool IsDeleted { get; set; } 
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
    }
}
