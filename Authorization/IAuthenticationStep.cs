using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.SinglySharp.Authorization
{
    interface IAuthenticationStep
    {
        bool IsCurrent { get; set; }
        int Order { get; set; }
        string Execute();
    }
}
