using System;

namespace Methods
{
 class Program
    {
        static void Main()
        {
            Program Names = new Program();
            string N = Names.Names("saif");
            Console.WriteLine(N);

           Program.evenNumber(50);

           Program sum=new Program();
           int Sum =sum.Add(20, 10);
            Console.WriteLine(Sum);

        }


        public int Add(int FN,int SN)
        {
            return FN + SN;
        }
        public static void evenNumber(int target)
        {
            int start = 0;

            while (start <= target)
            {
                Console.WriteLine("Even numbers  "+ start);
                start=start+2;
            }
        }

        public string  Names(string name)
        {

            return(name);
        }
    }
}
