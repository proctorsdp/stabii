using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stabii.Models
{
    public class Platform
    {

        public Platform()
        {
            this.Games = new HashSet<Game>();
        }

        // Primary Key
        public int PlatformID { get; set; }

        public string PlatformName { get; set; }

        // Navigation Property
        public virtual ICollection<Game> Games { get; set; }
    }
}
