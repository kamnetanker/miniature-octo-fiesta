using Microsoft.VisualStudio.TestTools.UnitTesting;
using formula_proj;

namespace formula_tests;

[TestClass]
public class FormulaTest
{
    [TestMethod]
    public void Test1ExpoX()
    {
		double expoX = App.ExpoX(0);
		Assert.AreEqual(expoX, 1);
    }
	[TestMethod]
	public void Test2ExpoX(){
		double expoX = App.ExpoX(1);
		Assert.AreEqual(expoX, Math.Exp(-2));
	}
	[TestMethod]
	public void Test3ExpoX(){
		double expoX = App.ExpoX(double.MaxValue);
		Assert.AreEqual(expoX, Math.Exp(-2*double.MaxValue));
	}
	[TestMethod]
	public void Test4ExpoX(){
		double expoX = App.ExpoX(-1);
		Assert.AreEqual(expoX, Math.Exp(2));
	}
	[TestMethod]
	public void Test5ExpoX(){
		double expoX = App.ExpoX(0.5d);
		Assert.AreEqual(expoX, Math.Exp(-1));
	}
	[TestMethod]
	public void Test6ExpoX(){
		double expoX = App.ExpoX(-0.5d);
		Assert.AreEqual(expoX, Math.Exp(1));
	}
	[TestMethod]
    public void Test1cosX()
    {
		double cosX = App.cosX(0);
		Assert.AreEqual(cosX, 1);
    }
	[TestMethod]
	public void Test2cosX(){
		double cosX = App.cosX(1);
		Assert.AreEqual(cosX, Math.Cos(1));
	}
	[TestMethod]
	public void Test3cosX(){
		double cosX = App.cosX(double.MaxValue);
		Assert.AreEqual(cosX, Math.Cos(double.MaxValue));
	}
	[TestMethod]
	public void Test4cosX(){
		double cosX = App.cosX(-1);
		Assert.AreEqual(cosX, Math.Cos(-1));
	}
	[TestMethod]
	public void Test5cosX(){
		double cosX = App.cosX(0.5d);
		Assert.AreEqual(cosX, Math.Cos(0.5d));
	}
	[TestMethod]
	public void Test6cosX(){
		double cosX = App.cosX(-0.5d);
		Assert.AreEqual(cosX, Math.Cos(-0.5d));
	}
	[TestMethod]
    public void Test1SqX()
    {
		double SqX = App.SqX(0);
		Assert.AreEqual(SqX, 0);
    }
	[TestMethod]
	public void Test2SqX(){
		double SqX = App.SqX(1);
		Assert.AreEqual(SqX, 1);
	}
	[TestMethod]
	public void Test3SqX(){
		double SqX = App.SqX(double.MaxValue);
		Assert.AreEqual(SqX, Math.Pow(double.MaxValue, 2));
	}
	[TestMethod]
	public void Test4SqX(){
		double SqX = App.SqX(-1);
		Assert.AreEqual(SqX, 1);
	}
	[TestMethod]
	public void Test5SqX(){
		double SqX = App.SqX(0.5d);
		Assert.AreEqual(SqX, 0.25d);
	}
	[TestMethod]
	public void Test6SqX(){
		double SqX = App.SqX(-0.5d);
		Assert.AreEqual(SqX, 0.25d);
	}
	[TestMethod]
    public void Test1F()
    {
		double F = App.F(0);
		Assert.AreEqual(F, 1);
    }
	[TestMethod]
	public void Test2F(){
		double F = App.F(1);
		Assert.AreEqual(F, 1.0731219655980597d);
	}
	[TestMethod]
	public void Test3F(){
		double F = App.F(double.MaxValue);
		Assert.AreEqual(F, double.MaxValue*double.MaxValue);
	}
	[TestMethod]
	public void Test4F(){
		double F = App.F(-1);
		Assert.AreEqual(F, 4.992324048441272d);
	}
	[TestMethod]
	public void Test5F(){
		double F = App.F(0.5d);
		Assert.AreEqual(F, 0.572844582450033d);
	}
	[TestMethod]
	public void Test6F(){
		double F = App.F(-0.5d);
		Assert.AreEqual(F, 2.6355167309591354d);
	}
}