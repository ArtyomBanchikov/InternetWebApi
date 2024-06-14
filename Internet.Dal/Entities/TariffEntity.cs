using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet.Dal.Entities
{
    [Table("tariffs")]
    public class TariffEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
