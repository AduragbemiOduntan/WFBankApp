namespace WFbankApp.Models.Models
{
    public class AuditableBaseEntity
    {
        public int Id { get; set; }
        public DateTime Datecreated { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime DateModified { get; set; }
    }

}

