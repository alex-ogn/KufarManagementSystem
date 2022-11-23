using KufarManagementSystem.Data;
using KufarManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KufarManagementSystem.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;
        //private readonly RoleManager<IdentityRole> roleManager;

        public ApplicationUserController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
   //SignInManager<ApplicationUser> signInManager,
   //RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            this.userManager = userManager;
           // this.roleManager = roleManager;
        }

        // GET: ApplicationUserController1cs
        //public async Task<ActionResult> IndexAsync()
        //{
        //    return View(await _context.ApplicationUsers.ToListAsync());
        //}

        public async Task<IActionResult> IndexAsync(string search, string searchBy)
        {
            //return View(await _context.Employee.ToListAsync());
            if (search != null)
            {
                if (searchBy == "Phone")
                {
                    return View(await _context.ApplicationUsers.Where(x => x.PhoneNumber.StartsWith(search) || search == null)
                        .ToListAsync());
                }
                else
                {
                    return View(await _context.ApplicationUsers.Where(x => (x.FirstName + " " + x.LastName).StartsWith(search) || search == null)
                        .ToListAsync());
                }
            }
            return View(await _context.ApplicationUsers.ToListAsync());
        }

        // GET: ApplicationUserController1cs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationUserController1cs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationUserController1cs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationUserController1cs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationUserController1cs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationUserController1cs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationUserController1cs/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
