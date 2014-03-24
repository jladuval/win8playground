using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace win8playground.Models
{
    public class CatModel : INotifyPropertyChanged
    {

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
 
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged( 
                [CallerMemberName] string caller = "" )
        {
            if ( PropertyChanged != null )
            {
                PropertyChanged( this, 
                   new PropertyChangedEventArgs( caller ) );
            }
        }
 

        public string Image { get; set; }
    }
}
