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
}