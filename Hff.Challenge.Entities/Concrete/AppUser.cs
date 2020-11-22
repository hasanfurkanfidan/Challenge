using Hff.Challenge.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Entities.Concrete
{
    public class AppUser:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       
    }
}
