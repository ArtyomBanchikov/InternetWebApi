using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet.DAL.Entities
{
    [Table("users")]
    public class ClientEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("full_name")]
        public string Name { get; set; }

        [Column("basic_account")]
        public int AccountId { get; set; }
    }
}
