using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet.Dal.Entities
{
    [Table("accounts")]
    public class AccountEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("balance")]
        public double Balance { get; set; }

        public IEnumerable<AccountServiceEntity>? AccountServices { get; set; }
    }
}
