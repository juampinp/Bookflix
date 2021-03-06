using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Bookflix.Models;

namespace Bookflix.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<BookflixUser> _userManager;

        public ResetPasswordModel(UserManager<BookflixUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Debe ingresar un correo correcto.")]
            [EmailAddress(ErrorMessage = "Debe ingesar un correo válido.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Debe ingesar una contraseña.")]
            [StringLength(100, ErrorMessage = "La {0} debe tener al menos {2} caracteres y {1} como máximo.", MinimumLength = 8)]
            [DataType(DataType.Password, ErrorMessage = "La contraseña debe contener al menos un caracter en mayúscula")]
            [Display(Name = "Nueva contraseña")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirme la nueva contraseña")]
            [Compare("Password", ErrorMessage = "Las contraseñas no son iguales.")]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }

        public IActionResult OnGet(string code = null)
        {
            if (code == null)
            {
                return BadRequest("A code must be supplied for password reset.");
            }
            else
            {
                Input = new InputModel
                {
                    Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code))
                };
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                return RedirectToPage("./ResetPasswordConfirmation");
            }

            foreach (var error in result.Errors)
            {
                if (error.Code.Equals("InvalidToken"))
                {
                    ModelState.AddModelError("Correo", "El email es inválido.");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }
    }
}
