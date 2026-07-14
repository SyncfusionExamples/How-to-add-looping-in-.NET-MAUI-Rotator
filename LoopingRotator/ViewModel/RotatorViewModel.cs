using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LoopingRotator
{
    public class RotatorViewModel
    {

        public ObservableCollection<RotatorModel> ImageCollection { get; set; }

        public RotatorViewModel()
        {
            ImageCollection = new ObservableCollection<RotatorModel>()
            {
                new RotatorModel("image1.png"),
                new RotatorModel("animal5.png"),
                new RotatorModel("animal3.png")
            };
        }
    }
}
