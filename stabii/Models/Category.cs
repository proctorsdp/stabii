using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stabii.Models
{
    public class Category
    {

        public Category()
        {
            this.Games = new HashSet<Game>();
        }

        // Primary Key
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        // Navigation Property
        public virtual ICollection<Game> Games { get; set; }
    }
}
