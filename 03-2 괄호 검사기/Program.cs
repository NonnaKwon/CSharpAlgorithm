namespace _03_2_괄호_검사기
{
    internal class Program
    {
        static bool IsOk(string text)
        {
            Stack<char> stack = new Stack<char> ();
            foreach(char c in text)
            {
                if (c == ']')
                {
                    if (stack.Peek() != '[')
                        return false;
                    stack.Pop();
                }
                else if (c == '}')
                {
                    if (stack.Peek() != '{')
                        return false;
                    stack.Pop();
                }
                else if (c == ')')
                {
                    if (stack.Peek() != '(')
                        return false;
                    stack.Pop();
                }
                else
                    stack.Push(c);
            }

            return stack.Count == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsOk("()"));
            Console.WriteLine(IsOk("(()"));
            Console.WriteLine(IsOk("[)"));
            Console.WriteLine(IsOk("[[(){}]]"));
        }
    }
}
