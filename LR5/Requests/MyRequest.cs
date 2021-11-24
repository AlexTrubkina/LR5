using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LR5.Requests
{
    public class MyRequest
    {
        internal string PrefixTable;
        public MyRequest(HttpRequest request
            )
        {
            foreach (var hdr in request.Headers.ToList())
            {
                switch (hdr.Key)
                {
                    case "prefix_table":
                        this.PrefixTable = hdr.Value.ToArray()[0].Trim();
                        break;
                }
            }
        }
    }
}
