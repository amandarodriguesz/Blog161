﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class LoginViewModel
    {
            [Display(Name = "User Name")]
            [Required(ErrorMessage = "Please enter your user name.")]
            public string UserName { get; set; }

            [Display(Name = "Password")]
            [Required(ErrorMessage = "Please enter your password.")]
            public string Password { get; set; }

            [Display(Name = "Remember Me")]
            public bool RememberMe { get; set; }
        }
}
