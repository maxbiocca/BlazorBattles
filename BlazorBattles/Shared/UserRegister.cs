using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [StringLength(16,ErrorMessage ="your username is too long (16 max)")]
        public string Username { get; set; }
        public string Bio { get; set; }
        [Required, StringLength(100, MinimumLength =6)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="the passwords do not match")]
        public string ConfirmPassword { get; set; }
        public int StartUnitId { get; set; } = 1;
        [Range(0,1000, ErrorMessage =" please choose a num between 0-1000")]
        public int Bananas { get; set; } = 100;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Range(typeof(bool), "true", "true", ErrorMessage ="only confirmed users can play!")]
        public bool IsConfirmed { get; set; } = true;

    }
}
