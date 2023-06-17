using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SALES.Types
{
    public class BookType
    {
        public List<string> Books 
        { 
            get => new List<string>
            {
                "book",
                "pdf"
            }; 
        }
    }
}
