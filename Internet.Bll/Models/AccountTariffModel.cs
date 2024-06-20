namespace Internet.Bll.Models
{
    public class AccountTariffModel
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        public int TariffId { get; set; }

        public int NextTariffId { get; set; }
    }
}
