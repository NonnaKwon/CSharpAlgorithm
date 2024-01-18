namespace _07_1._Hash_Table_A__과제
{
    internal class Program
    {
        public class CheatKey
        {
            private Dictionary<string, Action> cheatDic;

            public CheatKey()
            {
                cheatDic = new Dictionary<string, Action>();
                cheatDic.Add("Gold", ShowMeTheMoney);
                cheatDic.Add("Win", ThereIsNoCowLevel);
            }

            public void Run(string cheatKey)
            {
                if(cheatDic.ContainsKey(cheatKey))
                    cheatDic[cheatKey].Invoke();
                else
                    Console.WriteLine("존재하지 않는 치트키");
            }

            public void ShowMeTheMoney()
            {
                Console.WriteLine("골드를 늘려주는 치트키 발동!");
            }

            public void ThereIsNoCowLevel()
            {
                Console.WriteLine("바로 승리합니다 치트키 발동!");
            }
        }

        static void Main(string[] args)
        {
            CheatKey ck = new CheatKey();
            while (true)
            {
                Console.Write("치트키 입력해라 : ");
                ck.Run(Console.ReadLine());
            }
        }

    }
}
