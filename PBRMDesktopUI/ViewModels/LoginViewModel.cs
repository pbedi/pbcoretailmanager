using Caliburn.Micro;
using PBRMDesktopUI.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PBRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private IAPIHelper _apiHelper;
        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public string UserName {
            get { return _userName; }
            set 
            { 
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLoginBtn);
            }
        }

        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLoginBtn);
            }
        }

        public bool CanLoginBtn
        {
            get {
                bool output = false;
                if (!string.IsNullOrEmpty(UserName) && UserName.Length > 0 &&
                    !string.IsNullOrEmpty(Password) && Password.Length > 0)
                {
                    output = true;
                }

                return output;
            }
            
        }

        public async Task LoginBtn()
        {
            try
            {
                var result = await _apiHelper.Authenticate(UserName, Password);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
