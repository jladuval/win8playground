using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace win8playground.Models
{
    public class CatListModel: INotifyPropertyChanged
    {
        //public ObservableCollection<CatModel> Cats { get; set; }
        private CatModel _cat;

        public CatModel Cat 
        {
            get { return _cat; }
            set
            {
                _cat = value;
                OnPropertyChanged();
            } 
        }

        public string Title
        {
            get { return "Delicious cat recipes"; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
                [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                   new PropertyChangedEventArgs(caller));
            }
        }
 
    }
}
