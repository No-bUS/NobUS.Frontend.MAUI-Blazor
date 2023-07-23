using NobUS.Frontend.MAUI_Blazor.Façade;
using NobUS.Frontend.MAUI_Blazor.Repository;

﻿namespace NobUS.Frontend.MAUI_Blazor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}