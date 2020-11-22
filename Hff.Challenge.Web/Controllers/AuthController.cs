using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Hff.Challenge.Business.Abstract;
using Hff.Challenge.Dtos.Concrete.AppUserDtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Hff.Challenge.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAppUserService _appUserService;
        public AuthController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult SignIn()
        {
            return View(new AppUserLoginDto());
        }
        [HttpPost]
        public async Task<IActionResult>  SignIn(AppUserLoginDto appUserLoginDto)
        {

            if (ModelState.IsValid)
            {
                if (await _appUserService.CheckUser(appUserLoginDto.Email, appUserLoginDto.Password))
                {
                    await CookieConfiguration(appUserLoginDto.Email, appUserLoginDto.Password, appUserLoginDto.RememberMe);
                    //giriş başarılı
                    return RedirectToAction("Index", "Home", new { @area = "Admin" });
                }
                //giriş başarısız
                ModelState.AddModelError("", "Kullanıcı adı yada parola hatalı.");
            }
            return View(appUserLoginDto);
           
        }

        private async  Task CookieConfiguration(string email, string password, bool rememberMe)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,email),
                new Claim(ClaimTypes.Role,"Admin")

            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                IsPersistent = rememberMe
            };
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
        }
    }
}
