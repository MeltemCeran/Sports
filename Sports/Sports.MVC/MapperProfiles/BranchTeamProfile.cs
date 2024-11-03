﻿using AutoMapper;
using Sports.MVC.Context.Entities.Concrete;
using Sports.MVC.Models.Concrete;

namespace Sports.MVC.MapperProfiles
{
	public class BranchTeamProfile : Profile
	{
		public BranchTeamProfile()
		{
			CreateMap<BranchTeam, BranchTeamViewModel>()
			.ReverseMap();
		}
	}
}