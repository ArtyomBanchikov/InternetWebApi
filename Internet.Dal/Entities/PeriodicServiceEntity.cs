using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet.Dal.Entities
{
    [Table("periodic_services_data")]
    public class PeriodicServiceEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("cost")]
        public double Cost { get; set; }
    }
}
