namespace Internet.API.ViewModels
{
    public class AccountViewModel
    {
        public int Id { get; set; }

        public double Balance { get; set; }

        public IEnumerable<AccountServiceViewModel>? AccountServices { get; set; }
    }
}
