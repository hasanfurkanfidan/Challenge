using Hff.Challenge.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Dtos.Concrete.AppUserDtos
{
    public class AppUserLoginDto : IDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
