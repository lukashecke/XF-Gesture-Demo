using System.Windows.Input;
using Xamarin.Forms;

namespace TouchManipulation.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string touchLog = "Hier werden alle Berührungsgesten geloggt:";

        public ICommand ClearLogCommand {private set; get; }

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

        public MainPageViewModel() {
            ClearLogCommand = new Command(
                execute: () =>
                {
                    this.TouchLog = "Hier werden alle Berührungsgesten geloggt:";
                },
                canExecute: () =>
                {
                    returen true;
                }
            );
        }
    }
}
