using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUtilities
{
    
    public class SeasonModel
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"Season {Number}";
        }
    }
}
