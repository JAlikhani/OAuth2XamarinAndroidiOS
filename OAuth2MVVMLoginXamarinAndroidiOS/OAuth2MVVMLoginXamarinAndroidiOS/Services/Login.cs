using OAuth2MVVMLoginXamarinAndroidiOS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth2XamarinAndroidiOS.Services
{
    public class Login : ILogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        TaskCompleted ILogin.CredentialsValidation(string userName, string password)
        {
            TaskCompleted taskCompleted = new TaskCompleted();
            taskCompleted.Flag = true;
            taskCompleted.Message = "Successfully Done";
            return taskCompleted;
        }

    }
}
