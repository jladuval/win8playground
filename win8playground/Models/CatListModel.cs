using System.Collections.ObjectModel;

namespace win8playground.Models
{
    public class CatListModel
    {
        public string Title { get; set; }

        public ObservableCollection<CatModel> Cats
        {
            get
            {
                return new ObservableCollection<CatModel>
                {
                    new CatModel
                    {
                        Name = "Gerald",
                        Image = "Assets/1.jpg",
                        Recipe = "Cook with butter"
                    },
                    new CatModel
                    {
                        Name = "Gerald",
                        Image = "Assets/1.jpg",
                        Recipe = "Cook with butter"
                    },
                    new CatModel
                    {
                        Name = "Gerald",
                        Image = "Assets/1.jpg",
                        Recipe = "Cook with butter"
                    },new CatModel
                    {
                        Name = "Gerald",
                        Image = "Assets/1.jpg",
                        Recipe = "Cook with butter"
                    }
                    ,new CatModel
                    {
                        Name = "Gerald",
                        Image = "Assets/1.jpg",
                        Recipe = "Cook with butter"
                    },
                };
            }
        }
    }
}
