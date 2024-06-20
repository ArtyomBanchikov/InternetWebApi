namespace Internet.Bll.Models
{
    public class AccountServiceModel
    {
        public int AccountId { get; set; }

        public AccountModel? Account { get; set; }

        public int ServiceId { get; set; }

        public ServiceModel? Service { get; set; }

        public bool IsDeleted { get; set; }
    }
}
