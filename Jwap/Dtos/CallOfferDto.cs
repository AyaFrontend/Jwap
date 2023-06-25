using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwap.API.Dtos
{
    public class CallOfferDto
    {
        public string CallerId { set; get; }
        public bool StartCall { set; get; }
        public bool CallState { set; get; }
        public string CalleeId { set; get; }
        public string CallType{ set; get; }
        public string PeerId { set; get; }
    }
}
