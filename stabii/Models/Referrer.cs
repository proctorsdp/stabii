using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stabii.Models
{
    public class Referrer
    {

        public Referrer()
        {
            this.Games = new HashSet<Game>();
        }

        // Primary Key
        public int ReferrerID { get; set; }

        public string ReferrerName { get; set; }

        // Navigation Property
        public virtual ICollection<Game> Games { get; set; }
    }
}
