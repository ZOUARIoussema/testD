using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Activity
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public String Photo { get; set; }
        public KinderGarten KinderGarten { get; set; }


    }
}
