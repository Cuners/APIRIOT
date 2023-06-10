using APIRIOT.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace APIRIOT.ViewModels
{
    /// <summary>
    /// Логика взаимодействия для ProfileWindows.xaml
    /// </summary>
    public partial class ProfileWindows : Window
    {
        ControllerProfile controllerProfile;
        public ProfileWindows()
        {
            controllerProfile = new ControllerProfile();
            InitializeComponent();
            
            this.DataContext = controllerProfile.GetContext();
        }
       
    }
}
