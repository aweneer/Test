using System;

namespace TestApp
{
    public class Test
    {
        public void Tester()
        {

            Console.WriteLine("Yoyy");

            Console.WriteLine("P");

            Console.WriteLine("notreally");

            new Test();

            Console.WriteLine("this is from my branch dude");
        }
		
		public int GetZero()
		{
			var x = 1;
			return (x-x);
		}
		
		public string OffBranch()
		{
			var ob = "offBranch";
			return ob;
		}
		
		public string A()
		{
			return "A";
		}
    }
}