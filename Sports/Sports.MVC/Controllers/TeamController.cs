using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sports.MVC.Context;
using Sports.MVC.Context.Entities.Concrete;
using Sports.MVC.Models.Concrete;

namespace Sports.MVC.Controllers
{
	public class TeamController : Controller
	{
		private readonly SportsDbContext _context;
		private IMapper _mapper;

		public TeamController(SportsDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			List<Team> teams = _context.Teams.Where(t=>t.IsDeleted == false).ToList();
			List<TeamViewModel> model = _mapper.Map<List<TeamViewModel>>(teams);
			return View(model);
		}
	}
}
