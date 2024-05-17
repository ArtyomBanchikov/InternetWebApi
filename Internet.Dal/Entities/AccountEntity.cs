using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Internet.DAL.Entities
{
    [Table("accounts")]
    public class AccountEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("balance")]
        public double Balance { get; set; }
    }
}
