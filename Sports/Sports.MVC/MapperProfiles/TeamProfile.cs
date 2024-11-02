using AutoMapper;
using Sports.MVC.Context.Entities.Concrete;
using Sports.MVC.Models.Concrete;

namespace Sports.MVC.MapperProfiles
{
	public class TeamProfile : Profile
	{
		public TeamProfile()
		{
			CreateMap<Team, TeamViewModel>()
			.ForMember(dest => dest.TeamName, opt => opt.MapFrom(src => src.TeamName));

			CreateMap<TeamViewModel, Team>()
				.ForMember(dest => dest.TeamName, opt => opt.MapFrom(src => src.TeamName))
				// Diğer ICollection özelliklerini boş geç
				.ForMember(dest => dest.Games, opt => opt.Ignore())
				.ForMember(dest => dest.PlayerTeam, opt => opt.Ignore())
				.ForMember(dest => dest.BranchTeam, opt => opt.Ignore())
				.ForMember(dest => dest.HomeMatches, opt => opt.Ignore())
				.ForMember(dest => dest.AwayMatches, opt => opt.Ignore())
				.ForMember(dest => dest.GameStatistices, opt => opt.Ignore());
		}
	}
}
