using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public bool isDeleted = false;

        public bool isMain = false;

        public Category Parent { get; set; }

        public List<Category> subCategory { get; set; }
    }
}
