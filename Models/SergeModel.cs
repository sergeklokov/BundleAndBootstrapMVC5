using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapDemo.Models
{
    public class SergeModel
    {
        public int BigID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string SelectedCountry { get; set; }
        public List<string> Country { get; set; }
    }
}