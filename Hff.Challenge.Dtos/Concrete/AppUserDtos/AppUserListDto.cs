using Hff.Challenge.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Dtos.Concrete.AppUserDtos
{
    public class AppUserListDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
