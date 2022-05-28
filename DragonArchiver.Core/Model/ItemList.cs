using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArchiver.Core.Model
{
    public class ItemList : ObservableCollection<Item>
    {
        public ItemList() : base()
        {
            Add(new Item());
            Add(new Item());
            Add(new Item());
            Add(new Item());
        }
    }
}
