using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stabii.Models
{
    public class Game
    {

        public Game()
        {
            this.Categories = new HashSet<Category>();
            this.Platforms = new HashSet<Platform>();
            this.Referrers = new HashSet<Referrer>();
        }

        // Primary Key
        public int GameID { get; set; }

        public string GameName { get; set; }

        // Foreign Key
        // TODO add status enum
        
        // Navigation Property
        public virtual ICollection<Category> Categories { get; set; }

        // Navigation Property
        public virtual ICollection<Platform> Platforms { get; set; }

        // Navigation Property
        public virtual ICollection<Referrer> Referrers { get; set; }
    }
}
