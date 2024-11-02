using Sports.MVC.Context.Entities.Abstract;
using System.Text.RegularExpressions;

namespace Sports.MVC.Context.Entities.Concrete
{
    public class Team : BaseEntity
    {
        public string TeamName { get; set; }
        public DateOnly FoundedYear { get; set; }
        public string City { get; set; }
        public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();
        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
        public virtual ICollection<Game> HomeMatches { get; set; } = new List<Game>();
        public virtual ICollection<Game> AwayMatches { get; set; } = new List<Game>();
        public virtual ICollection<GameStatistic> GameStatistices { get; set; } = new List<GameStatistic>();



    }
}
