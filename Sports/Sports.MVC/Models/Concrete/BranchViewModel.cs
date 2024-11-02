using Sports.MVC.Context.Entities.Concrete;
using Sports.MVC.Models.Abstract;

namespace Sports.MVC.Models.Concrete
{
    public class BranchViewModel : BaseViewModel
    {
        public string Name { get; set; }
  //      public virtual ICollection<Player> Players { get; set; }
  //      public virtual ICollection<Game> Games { get; set; }
		//public virtual ICollection<BranchTeam> BranchTeam { get; set; } = new List<BranchTeam>();
		//public virtual ICollection<GameStatistic> GameStatistics { get; set; } = new List<GameStatistic>();
    }
}
