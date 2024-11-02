namespace Sports.MVC.Models.Abstract
{
    public abstract class BaseViewModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime? Deleted { get; set; }

    }
}
