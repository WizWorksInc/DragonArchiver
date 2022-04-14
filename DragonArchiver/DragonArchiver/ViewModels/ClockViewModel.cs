using System.ComponentModel;

namespace DragonArchiver.ViewModels
{
    public class ClockViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
        }

        public ClockViewModel()
        {
            this.DateTime = DateTime.Now;

            // Update the DateTime property every second.
            Timer timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now), null, 0, 1000);
        }
    }
}