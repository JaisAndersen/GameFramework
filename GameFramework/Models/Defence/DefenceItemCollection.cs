using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Models.Defence
{
    public class DefenceItemCollection
    {  
        private List<DefenceItem> items;
        public DefenceItemCollection()
        {
            items = new List<DefenceItem>();
        }
        public void AddItem(DefenceItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(DefenceItem item)
        {
            items.Remove(item);
        }
        public DefenceItem? GetItemByName(string name)
        {
            return items.FirstOrDefault(i => i.Name == name);
        }
        public List<DefenceItem> GetAllItems()
        {
            return new List<DefenceItem>(items);
        }
    }
}
