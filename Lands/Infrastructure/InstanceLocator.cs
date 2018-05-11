namespace Lands.Infrastructure
{
    using ViewModels;
    public class InstanceLocator
    {
        #region
        public MainViewModel Main {get;set;}
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
