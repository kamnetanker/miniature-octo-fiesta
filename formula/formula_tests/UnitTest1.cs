using Microsoft.VisualStudio.TestTools.UnitTesting;
using formula_proj;

namespace formula_tests;

[TestClass]
public class FormulaTest
{
    [TestMethod]
    public void Test1ExpoX()
    {
		double expoX = formula_proj.ExpoX(0);
		Assert.AreEqual(expoX, 1);
    }
	public void Test2ExpoX(){
		double expoX = formula_proj.ExpoX(0);
		Assert.AreEqual(expoX, 1);
	}
}