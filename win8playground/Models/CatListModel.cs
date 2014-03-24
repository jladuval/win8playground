using System.Collections.ObjectModel;

namespace win8playground.Models
{
    public class CatListModel
    {
        //public ObservableCollection<CatModel> Cats { get; set; }
        public CatModel Cat { get; set; }

        public string Title
        {
            get { return "Delicious cat recipes"; }
        }
    }
}
