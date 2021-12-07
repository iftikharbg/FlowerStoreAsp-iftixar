using FlowerStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.ViewModel
{
    public class HomeViewModel
    {
        public Slider slider { get; set; }

        public Valentine valentine { get; set; }

        public List<ListItem> listItem { get; set; }
    }
}
