using Hff.Challenge.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Entities.Concrete
{
   public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
