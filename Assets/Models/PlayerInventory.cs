using System.Collections.Generic;

namespace Models
{
    public class PlayerInventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void RemoveItem(string item)
        {
            items.Remove(item);
        }

        public List<string> GetItems()
        {
            return new List<string>(items);
        }
    }
}