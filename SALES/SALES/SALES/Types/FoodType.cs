using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALES.Types
{
    public class FoodType
    {
        public List<string> Foods
        {
            get => new List<string>
            {
                "jar",
                "tin",
                "carton",
                "can",
                "slice",
                "bar",
                "box"
            };
        }
    }
}
