namespace Internet.Bll.Models
{
    public class ServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public PeriodicServiceModel PeriodicService { get; set; }
    }
}
