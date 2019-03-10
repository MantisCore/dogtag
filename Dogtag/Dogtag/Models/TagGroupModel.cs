using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogtag.Models
{
    public class TagGroupModel
    {
        public string Name { get; set; }

        public ObservableCollection<TagModel> Tags { get; } = new ObservableCollection<TagModel>();
    }
}
