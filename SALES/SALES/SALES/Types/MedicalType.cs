using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALES.Types
{
    public class MedicalType
    {
        public List<string> Medicals
        {
            get => new List<string>
            {
                "packet",
                "pill",
                "capsule",
                "tablet",
                "drop",
                "drug",
                "medicine"
            };
        }
    }
}
