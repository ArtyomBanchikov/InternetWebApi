using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet.Dal.Entities
{
    [Table("services_data")]
    public class ServiceEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("service_name")]
        public string Name { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        [ForeignKey("Id")]
        public PeriodicServiceEntity? PeriodicService { get; set; }
    }
}
