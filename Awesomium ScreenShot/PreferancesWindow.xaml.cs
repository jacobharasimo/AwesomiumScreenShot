﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Awesomium_ScreenShot.Class;
using Telerik.Windows.Controls;

namespace Awesomium_ScreenShot
{
    /// <summary>
    /// Interaction logic for PreferencesWindow.xaml
    /// </summary>
    public partial class PreferencesWindow : INotifyPropertyChanged
    {
        private Preferences _settings = new Preferences();
        public Preferences Settings
        {
            get { return _settings; }
            set { _settings = value;
            OnPropertyChanged("Settings");}
        }
        public PreferencesWindow()
        {
            InitializeComponent();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void ButtonConfirm_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
