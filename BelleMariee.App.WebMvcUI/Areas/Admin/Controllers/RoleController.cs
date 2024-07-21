using Microsoft.AspNetCore.Mvc;
using BelleMariee.App.Entity.Services;
using BelleMariee.App.Entity.ViewModels;
using Microsoft.EntityFrameworkCore;
using BelleMariee.App.DataAccess.Contexts;

namespace BelleMariee.App.WebMvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly BelleDbContext _context;

        public RoleController(IAccountService accountService, BelleDbContext context )
        {
            _accountService = accountService;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var roles = await _accountService.GetAllRoles();
            return View(roles);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleViewModel model)
        {
            string msg = await _accountService.CreateRoleAsync(model);
            if (msg == "OK")
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", msg);
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var model = await _accountService.GetAllUsersWithRole(id);  //serice katmanından geriye UsersInOrOutViewModel dönüyor.
            return View(model);
        }

        [HttpPost]
		public async Task<IActionResult> Edit(EditRoleViewModel model)
		{
            string msg = await _accountService.EditRoleListAsync(model);
            if (msg != "OK")
            {
                ModelState.AddModelError("", msg);
                return View(model);
            }

			return RedirectToAction("Edit", "Role", new {id = model.RoleId, area="Admin"});
		}
        public async Task<IActionResult> Delete(int id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Role", new { area = "Admin" });
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Role", new { area = "Admin" });
        }
    }
}