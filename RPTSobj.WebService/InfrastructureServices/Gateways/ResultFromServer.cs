using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPTSobj.WebService.InfrastructureServices.Gateways
{
    public class Cells
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string MetroStation { get; set; }
        public string MetroLine { get; set; }
        public string WebSite { get; set; }
    }

    public class ResultFromServer
    {
        public int Number { get; set; }
        public Cells Cells { get; set; }
    }
}
