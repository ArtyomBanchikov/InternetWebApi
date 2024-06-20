using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet.Dal.Entities
{
    [Table("service_links")]
    public class AccountServiceEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("account_id")]
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public AccountEntity? Account { get; set; }

        [Column("service_id")]
        public int ServiceId { get; set; }

        [ForeignKey("ServiceId")]
        public ServiceEntity? Service { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
