using Sports.MVC.Context.Entities.Abstract;

namespace Sports.MVC.Context.Entities.Concrete
{
    public class GameStatistic :BaseEntity
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
        public int? PlayerId { get; set; }
        public Player Player { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public bool IsWin { get; set; }
        public bool IsDraw { get; set; }
        public int Score { get; set; }
        public byte Duration { get; set; }
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public string StatisticType { get; set; }
    }
}
