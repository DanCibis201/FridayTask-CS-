using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayTask
{
     public class Heroes
     {
          public int heroID { get; set; }
          public string heroName { get; set; }
          public string heroFaction { get; set; }

          public Heroes(int heroID, string heroName, string heroFaction)
          {
               this.heroID = heroID;
               this.heroName = heroName;
               this.heroFaction = heroFaction;
          }

          
     }    
}
