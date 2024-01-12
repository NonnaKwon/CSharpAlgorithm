using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_1._List_A_과제
{
    internal class Inventory
    {
        private List<Item> items;
        private int inventoryCapacity;

        public Inventory()
        {
            items = new List<Item>();
            inventoryCapacity = 10;
        }

        public bool GetItem(Item item)
        {
            if (inventoryCapacity <= items.Count)
            {
                Console.WriteLine("인벤토리가 가득 찼습니다");
                return false;
            }
            items.Add(item);
            return true;
        }



        public bool RemoveItem(Item item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (item.Name == items[i].Name)
                {
                    items.Remove(item);
                    return true;
                }
            }

            return false;
        }

        public bool RemoveItem(int index)
        {
            items.RemoveAt(index);
            return true;
        }

        public void PrintInventory()
        {
            Console.WriteLine("-------------인벤토리-------------");
            Console.WriteLine($"아이템 개수 : {items.Count}/ 가방 용량 : {inventoryCapacity}");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].ToString()}");
            }
        }
    }
}
