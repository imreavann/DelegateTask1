#region Task 1

namespace Program
{
    public delegate void Func(string str);
    
    class MyClass
    {
        public void Space(string str)
        {
            char[] arrStr = str.ToCharArray();

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];

                if (i < str.Length - 1)                     //chara cevirib _ elave edirik
                {
                    result += "_";
                }
            }

            Console.WriteLine(result);
        }

        public void Reverse(string str) 
        {
            char[] arrStr = str.ToCharArray();

            Array.Reverse(arrStr);
                                                                  //chara cevirib reverse edirik
            string result = new string(arrStr);
            Console.WriteLine(result);
        }

        class Run
        {
            public void RunFunc(Func runDell, string argument)
            {
                runDell(argument);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                MyClass myClass = new MyClass();
                Run run = new Run();

                Console.Write("Input: ");
                string str = Console.ReadLine();

                Func funcDell = new Func(myClass.Space);
                funcDell += myClass.Reverse;

                run.RunFunc(funcDell, str);
            }
        }
    }
}

#endregion Task 1
