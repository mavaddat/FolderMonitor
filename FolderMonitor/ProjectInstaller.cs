﻿using System.ComponentModel;
using System.Configuration.Install;


namespace FolderMonitor
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
