using System;
using System.Collections.Generic;
using System.Net;
using RPTSobj.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace RPTSobj.ApplicationServices.Synchronization
{
    public class RPTSobj_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public RPTSobj_inf Cells { get; set; }
    }

    public class RPTSobj_inf
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string MetroStation { get; set; }

        public string MetroLine { get; set; }
        public string WebSite { get; set; }
    }


    public class UseCaseRPTSobj
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/2624/rows?api_key=b830358d40b1d55aa8d34b4f33b5f6c6";

        List<RPTSobj_Cell> rptsobj_cells;

        public List<rptsobj> rptsobjs = new List<rptsobj>();

        public UseCaseRPTSobj()
        {
            
            WebRequest request = WebRequest.Create(remoteUri);
            WebResponse response = request.GetResponse();

            
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string line = stream.ReadToEnd();

            JArray jsonArray = JArray.Parse(line);

            rptsobj_cells = JsonConvert.DeserializeObject<List<RPTSobj_Cell>>(jsonArray.ToString());


            for (int i = 0; i < rptsobj_cells.Count; i++)
            {
                rptsobjs.Add(new rptsobj()
                {
                    Name = rptsobj_cells[i].Cells.Name,
                    Id = rptsobj_cells[i].Number,
                    Address = rptsobj_cells[i].Cells.Address,
                    MetroStation = rptsobj_cells[i].Cells.MetroStation,
                    MetroLine = rptsobj_cells[i].Cells.MetroLine,
                    WebSite = rptsobj_cells[i].Cells.WebSite
                });
            }
        }

    }
}