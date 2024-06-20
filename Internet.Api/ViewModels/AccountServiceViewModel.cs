namespace Internet.Api.ViewModels
{
    public class AccountServiceViewModel
    {
        public int AccountId { get; set; }

        public AccountViewModel? Account { get; set; }

        public int ServiceId { get; set; }

        public ServiceViewModel? Service { get; set; }

        public bool IsDeleted { get; set; }
    }
}
