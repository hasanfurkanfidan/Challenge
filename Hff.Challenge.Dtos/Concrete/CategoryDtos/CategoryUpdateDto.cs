using Hff.Challenge.Dtos.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.Dtos.Concrete.CategoryDtos
{
   public class CategoryUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
