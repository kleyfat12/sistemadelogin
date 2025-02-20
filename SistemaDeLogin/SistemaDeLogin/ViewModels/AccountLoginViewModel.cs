﻿using System.ComponentModel.DataAnnotations;

namespace SistemaDeLogin.ViewModels
{
    public class AccountLoginViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
