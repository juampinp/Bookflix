using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Bookflix.Models;
using Bookflix.Data;


namespace Bookflix.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class BajarCategoriaModel : PageModel
    {
        private readonly SignInManager<BookflixUser> _signInManager;
        private readonly UserManager<BookflixUser> _userManager;
        private readonly ILogger<BajarCategoriaModel> _logger;

        public BajarCategoriaModel(SignInManager<BookflixUser> signInManager, UserManager<BookflixUser> userManager, ILogger<BajarCategoriaModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
            _userManager = userManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"No se pudo cargar al usuario con ID '{_userManager.GetUserId(User)}'.");
            }

            await user.ChangeRole(_userManager, "Normal", "Premium");
            await _signInManager.RefreshSignInAsync(user);

            using (var db = new BookflixDbContext())
            {
                if(db.Perfiles.Where(p => p.Usuario.Id == user.Id).Count() > 2)
                {
                    return RedirectToAction("AdministrarPerfil", "Perfil");
                }
            }

            return RedirectToAction("Index", "Perfil");
        }
    }
}
