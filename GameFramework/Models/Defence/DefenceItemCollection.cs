using GameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Models.Defence
{
    public class ItemCollection : IDefenceItem
    {
        private List<IDefenceItem> items;

        public int ReduceHitPoint { get; set; }
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removeable { get; set; }

        public ItemCollection()
        {
            items = new List<IDefenceItem>();
        }
        public void AddItem(IDefenceItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IDefenceItem item)
        {
            items.Remove(item);
        }
        public IDefenceItem? GetItemByName(string name)
        {
            return items.FirstOrDefault(i => i.Name == name);
        }
        public List<IDefenceItem> GetAllItems()
        {
            return new List<IDefenceItem>(items);
        }
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(ReduceHitPoint)}={ReduceHitPoint.ToString()}, {nameof(Lootable)}={Lootable.ToString()}, {nameof(Removeable)}={Removeable.ToString()}}}";
        }
    }
}
