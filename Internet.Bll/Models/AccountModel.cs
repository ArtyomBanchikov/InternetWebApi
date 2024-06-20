namespace Internet.BLL.Models
{
    public class AccountModel
    {
        public int Id { get; set; }

        public double Balance { get; set; }

        public IEnumerable<AccountServiceModel>? AccountServices { get; set; }
    }
}
