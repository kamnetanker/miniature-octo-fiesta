using System; 
namespace formula_proj{
	public class App{
		public static void Main(string[] argv){
			Console.WriteLine("Hello, World!");
			Console.WriteLine("F(0) = "+F(0d).ToString());
			Console.WriteLine("F(1) = "+F(1d).ToString());
			Console.WriteLine("F(-1) = "+F(-1d).ToString());
			Console.WriteLine("F(0.5) = "+F(0.5d).ToString());
			Console.WriteLine("F(-0.5) = "+F(-0.5d).ToString());
			Console.WriteLine("F(double.MaxValue) = "+F(double.MaxValue).ToString());
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
