using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth2XamarinAndroidiOS.Services
{
    public interface ITaskCompleted
    {
        bool Flag { get; set; }
        string Message { get; set; }
    }
}
