namespace TouchManipulation.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string touchLog = "Hier werden alle Berührungsgesten geloggt.";

        public string TouchLog
        {
            get
            {
                return this.touchLog;
            }
            set
            {
                this.touchLog = value;
                this.OnPropertyChanged();
            }
        }
    }
}
