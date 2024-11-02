using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sports.MVC.Context;
using Sports.MVC.Context.Entities.Concrete;
using Sports.MVC.Models.Concrete;

namespace Sports.MVC.Controllers
{
    public class BranchController : Controller
    {
        private readonly SportsDbContext _context;
        private IMapper _mapper;

        public BranchController(SportsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<Branch> branches = _context.Branches.Where(b=>b.IsDeleted== false).ToList();
            List<BranchViewModel> model = _mapper.Map<List<BranchViewModel>>(branches);
            return View(model);
        }
    }
}
