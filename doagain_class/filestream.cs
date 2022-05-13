using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doagain_class
{
    public class filestream
    {
     
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class  { get; set; }  
        public decimal Grade { get; set; }


        public static List<filestream> GetFilestreams()
        {
            return new List<filestream>
            {
                new filestream {Name = "Jumoke", Age = 26, Class = "Year 4", Grade = 4 },
                new filestream {Name = "Moyosore", Age = 24, Class = "Year 3", Grade = 5 },
                new filestream {Name = "Jimmy", Age = 24, Class = "Year 5", Grade = 7 },
                new filestream {Name = "Damilare", Age = 22, Class = "Year 5", Grade = 6 },
                new filestream {Name = "Ebuka", Age = 25, Class = "Year 4", Grade = 4 },
                new filestream {Name = "Olabisi", Age = 21, Class = "Year 3", Grade = 6 },

            };
        }



    }
}
