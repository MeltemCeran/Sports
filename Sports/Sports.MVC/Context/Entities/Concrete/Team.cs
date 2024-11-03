using Sports.MVC.Context.Entities.Abstract;
using System.Text.RegularExpressions;

namespace Sports.MVC.Context.Entities.Concrete
{
    public class Team : BaseEntity
    {
        public string TeamName { get; set; }
        public DateOnly FoundedYear { get; set; }
        public string City { get; set; }
        public virtual ICollection<BranchTeam> BranchTeam { get; set; } = new List<BranchTeam>();
        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; } = new List<PlayerTeam>();
        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
        public virtual ICollection<Game> HomeMatches { get; set; } = new List<Game>();
        public virtual ICollection<Game> AwayMatches { get; set; } = new List<Game>();
        public virtual ICollection<GameInfo> GameInfos { get; set; } = new List<GameInfo>();
        
    }
}
