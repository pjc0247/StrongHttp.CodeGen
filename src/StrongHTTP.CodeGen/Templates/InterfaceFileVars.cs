using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongHTTP.CodeGen.Templates
{
    public partial class InterfaceFileTemplate
    {
        public string @namespace { get; set; }

        public List<Service> services { get; set; }
    }
}
