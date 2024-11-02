using AutoMapper;
using Sports.MVC.Context.Entities.Concrete;
using Sports.MVC.Models.Concrete;

namespace Sports.MVC.MapperProfiles
{
	public class PlayerProfile : Profile
		{
			public PlayerProfile()
			{
			CreateMap<Player, PlayerViewModel>()
			.ForMember(dest => dest.PlayerName, opt => opt.MapFrom(src => src.PlayerName))
			.ForMember(dest => dest.PlayerSurname, opt => opt.MapFrom(src => src.PlayerSurname))
			.ForMember(dest => dest.PlayerBirthDate, opt => opt.MapFrom(src => src.PlayerBirthDate))
			.ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
			.ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.Branch.Name));

			CreateMap<PlayerViewModel, Player>()
				.ForMember(dest => dest.PlayerName, opt => opt.MapFrom(src => src.PlayerName))
				.ForMember(dest => dest.PlayerSurname, opt => opt.MapFrom(src => src.PlayerSurname))
				.ForMember(dest => dest.PlayerBirthDate, opt => opt.MapFrom(src => src.PlayerBirthDate))
				.ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
				.ForMember(dest => dest.GameStatistics, opt => opt.Ignore())
				.ForMember(dest => dest.PlayerTeam, opt => opt.Ignore());
					
			}
		}
	}

