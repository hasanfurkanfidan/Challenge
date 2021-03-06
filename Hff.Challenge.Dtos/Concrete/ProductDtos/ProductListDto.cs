﻿using Hff.Challenge.Dtos.Abstract;
using Hff.Challenge.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Dtos.Concrete.ProductDtos
{
    public class ProductListDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Trademark { get; set; }
        public Category Category { get; set; }

    }
}
