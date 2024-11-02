using AutoMapper;
using Sports.MVC.Context.Entities.Concrete;
using Sports.MVC.Models.Concrete;

namespace Sports.MVC.MapperProfiles
{
	public class BranchProfile : Profile
	{
		public BranchProfile()
		{
			CreateMap<Branch, BranchViewModel>()
			.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

			CreateMap<BranchViewModel, Branch>()
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
				// Diğer ICollection özelliklerini boş geç
				.ForMember(dest => dest.Players, opt => opt.Ignore())
				.ForMember(dest => dest.Games, opt => opt.Ignore())
				.ForMember(dest => dest.BranchTeam, opt => opt.Ignore())
				.ForMember(dest => dest.GameStatistics, opt => opt.Ignore());
		}
	}
}
