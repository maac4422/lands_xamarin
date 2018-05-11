﻿namespace Lands.ViewModels
{
    using System;
    public class MainViewModel
    {
        #region
        public LoginViewModel Login
        {
            get;
            set;
        }
        public LandsViewModel Lands
        {
            get;
            set;
        }
        public LandViewModel Land
        {
            get;
            set;
        }
        #endregion


        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance(){
            if(instance == null){
                return new MainViewModel();
            }else{
                return instance;
            }
        }
        #endregion
    }
}
