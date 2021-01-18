using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUtilities
{
    public class Rating
    {
        public double? Average { get; set; }
    }  

    public class Show
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public List<string> Genres { get; set; }
        public Rating Rating { get; set; }
        public string Summary { get; set; }     

    }

    public class Root : Show
    {
        public double Score { get; set; }
        public Show Show { get; set; }

        public override string ToString()
        {
            return Show.Name;
        }

    }


}
