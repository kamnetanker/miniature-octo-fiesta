using System; 
namespace formula_proj{
	public class App{
		public static void Main(string[] argv){
			Console.WriteLine("Hello, World!");
			Console.WriteLine("Function Result: "+F(0.23d).ToString());
		}
	
		public static double F(double x){
			return SqX(x)+cosX(x)*ExpoX(x);
		}
		public static double SqX(double x){
			return x*x;
		}
		public static double cosX(double x){
			return Math.Cos(x);
		}
		public static double ExpoX(double x){
			return Math.Exp(-2*x);
		}
	}
} 
