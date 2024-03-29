﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToSell.Data.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required ...")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required ...")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-mail is required ...")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required ...")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmedPassword { get; set; }
    }
}