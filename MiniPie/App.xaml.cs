﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Navigation;
using MiniPie.Core;
using ILog = Caliburn.Micro.ILog;

namespace MiniPie {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        public AppBootstrapper Bootstrapper { get; set; }
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Bootstrapper = (AppBootstrapper)Resources["bootstrapper"];
            await Bootstrapper.ConfigurationInitialize();
        }
    }
}
