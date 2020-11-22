using Hff.Challenge.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Trademark { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
