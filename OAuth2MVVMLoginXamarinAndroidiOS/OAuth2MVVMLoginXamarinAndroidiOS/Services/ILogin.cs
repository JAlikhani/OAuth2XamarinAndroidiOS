using OAuth2MVVMLoginXamarinAndroidiOS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth2XamarinAndroidiOS.Services
{
    public interface ILogin
    {
        string Username { get; set; }
        string Password { get; set; }
        TaskCompleted CredentialsValidation(string userName, string password);
    }
}
