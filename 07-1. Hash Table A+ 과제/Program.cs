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
                //cheatDic.TryGetValue(cheatKey, out Action a);
                //왜 이건 예외가 뜨지 
                cheatDic[cheatKey]?.Invoke();
                //a?.Invoke();
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
