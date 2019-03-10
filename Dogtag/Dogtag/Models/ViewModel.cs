using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogtag.Models
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            //TEST CODE
            var tags = new List<TagGroupModel>();
            var group1 = new TagGroupModel() { Name = "Group 1" };
            group1.Tags.Add(new TagModel() { Name = "Tag A" });
            group1.Tags.Add(new TagModel() { Name = "Tag B" });
            group1.Tags.Add(new TagModel() { Name = "Tag C" });
            tags.Add(group1);

            var group2 = new TagGroupModel() { Name = "Group 2" };
            group2.Tags.Add(new TagModel() { Name = "Tag D" });
            group2.Tags.Add(new TagModel() { Name = "Tag E" });
            group2.Tags.Add(new TagModel() { Name = "Tag F" });
            tags.Add(group2);

            Tags = tags;
        }

        public List<TagGroupModel> Tags { get; private set; }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifiyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
