using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.SinglySharp.Authorization
{
    public class AuthorizeStep : IAuthenticationStep
    {
        public bool IsCurrent
        {
            get; set; }

        public int Order
        {
            get; set; }

        public string Execute()
        {

            return "";
        }
    }
}
