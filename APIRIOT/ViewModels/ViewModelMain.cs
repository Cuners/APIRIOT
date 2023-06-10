using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using APIRIOT.ViewModels.Base;
using APIRIOT.Controller;
using APIRIOT.Utils;
using System.ComponentModel;
using System.Windows;

namespace APIRIOT.ViewModels
{
    public class ViewModelMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }

        }
        public string _Region;
        public string _Name;
        public string Region
        {
            get { return _Region; }
            set { _Region = value; Constants.Region = value; NotifyPropertyChanged("Region"); }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; NotifyPropertyChanged("Name"); }
        }
        public RelayCommand _OpenProfile;

        public RelayCommand OpenProfile
        {
            get
            {
                return _OpenProfile ?? (_OpenProfile = new RelayCommand(obj =>
                {
                    if(string.IsNullOrEmpty(Region) || string.IsNullOrEmpty(Name))
                    {
                        return;
                    }
                    ControllerMain controller= new ControllerMain();
                    if (controller.GetSummoner(Name))
                    {
                        ProfileWindows profileWindow= new ProfileWindows();
                        MainWindows mainWindow= new MainWindows();
                        profileWindow.Show();
                        mainWindow.Close();
                    }
                    else
                    {
                        var result = MessageBox.Show("Никто не найден");
         
                    }
                }));
            }
        }

    }
}
