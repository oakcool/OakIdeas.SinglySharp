using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.SinglySharp.Authorization
{
    public class SinglyOAuth
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public string CallBackUrl { get; set; }

        public string Token { get; set; }
    }
}
