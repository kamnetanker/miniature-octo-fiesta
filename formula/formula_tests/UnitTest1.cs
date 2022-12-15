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
}