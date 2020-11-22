using Hff.Challenge.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Dtos.Concrete.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
