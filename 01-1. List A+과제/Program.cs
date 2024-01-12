namespace _01_1._List_A_과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            List<Item> shopItems = new List<Item>();
            shopItems.Add(new Item("날개달린 신발"));
            shopItems.Add(new Item("천사 날개"));
            shopItems.Add(new Item("찬규의 물통"));
            shopItems.Add(new Item("경민이의 침낭"));

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 아이템 획득하기");
                Console.WriteLine("2. 아이템 버리기");
                Console.WriteLine("3. 인벤토리 확인하기");
                Console.Write("고르시오 : ");
                int input = int.Parse(Console.ReadLine());


                Console.Clear();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("------------상점------------");
                        for (int i = 0; i < shopItems.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shopItems[i].Name}");
                        }
                        Console.Write("가질 물건의 번호를 고르시오 : ");
                        input = int.Parse(Console.ReadLine());

                        if (0 < input && input <= shopItems.Count)
                        {
                            inventory.GetItem(shopItems[input - 1]);
                            Console.Write("아이템을 얻었습니다. ");
                        }
                        else
                            Console.Write("숫자 잘못 입력하셨습니다. ");
                        break;
                    case 2:
                        inventory.PrintInventory();
                        Console.Write("버릴 물건의 번호를 고르시오 : ");
                        input = int.Parse(Console.ReadLine());
                        inventory.RemoveItem(input - 1);
                        break;
                    case 3:
                        inventory.PrintInventory();
                        break;
                    default:
                        continue;
                }
                Console.Write("계속하려면 아무키나 입력 : ");
                Console.ReadLine();
            }
        }
    }
}
