using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internet.DAL.Entities
{
    [Table("account_tariff_link")]
    public class AccountTariffEntity
    {
        [Column("id"), Key]
        public int Id { get; set; }

        [Column("account_id")]
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public AccountEntity Account { get; set; }

        [Column("tariff_id")]
        public int TariffId { get; set; }

        [ForeignKey("TariffId")]
        public TariffEntity Tariff { get; set; }

        [Column("next_tariff_id")]
        public int NextTariffId { get; set; }

        [ForeignKey("NextTariffId")]
        public TariffEntity NextTariff { get; set; }
    }
}
