﻿namespace Lands.ViewModels
{
    using System;
    using Lands.Models;

    public class LandViewModel : BaseViewModel
    {
        #region Properties
        public Land Land
        {
            get;
            set;
        }
        #endregion


        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;
        }
        #endregion
       
	}
}
