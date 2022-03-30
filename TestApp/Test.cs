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
			System.Console.WriteLine( "A" );
			var A = "A";
			return A;
		}
		
		public bool B()
		{
			return ( this.GetZero() == 0 && this.A().Equals( "A" ) );
		}
		
		public bool isCorrectB()
		{
			return ( B() == true );
		}
    }
}