using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipchatApiV2.Responses
{
    public class HipchatGetAllMembersResponse
    {
        public List<HipchatUser> Items { get; set; }
        public int StartIndex { get; set; }
        public int MaxResults { get; set; }
        public HipchatLink Links { get; set; }
    }
}
