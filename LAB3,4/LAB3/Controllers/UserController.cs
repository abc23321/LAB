using LAB3.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB3.Controllers
{
    public class UserController : Controller
    {
        private static List<User> userList = new List<User>();
        public IActionResult Index()
        {
            return View(userList);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    userList.Add(user);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(user);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var user = userList.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var existingUser = userList.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (existingUser == null) return NotFound();

            existingUser.Username = updatedUser.Username;
            existingUser.Password = updatedUser.Password;
            existingUser.Phone = updatedUser.Phone;
            existingUser.Email = updatedUser.Email;

            return RedirectToAction("Index");
        }
    }
}
