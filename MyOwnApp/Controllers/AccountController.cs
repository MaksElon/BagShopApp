using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyOwnApp.Data.Entities;
using MyOwnApp.Data.Interfaces;
using MyOwnApp.Data.Models;
using MyOwnApp.ViewModels;

namespace MyOwnApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly EFContext _context;
        private readonly IProducers _producers;
        public AccountController(IProducers producers,UserManager<User> userManager, SignInManager<User> signInManager,
        EFContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _producers = producers;
        }
        [HttpGet]
        public IActionResult Register()
        {
            RegisterViewModel obj = new RegisterViewModel();
            obj.GetProducers = _producers.GetProducers.ToList();
            obj.ProducersCount = _producers.GetProducers.Count();
            return View(obj);   
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            UserProfile userProfile = new UserProfile()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                RegisterDate = DateTime.Now,
                CountOfLogins=0,
                Image=""
            };
            User user = new User()
            {
                PhoneNumber = model.Phone,
                Email = model.Email,
                UserName = model.Email,
                UserProfile = userProfile
            };
            var res = await _userManager.CreateAsync(user, model.Password);
            res = _userManager.AddToRoleAsync(user, "User").Result;
            if (res.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in res.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
            }
            
            return View();
        }
    }
}