

using Tyuiu.ZavyalovKA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZavyalovKA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Константин";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Константин", res);
        }
    }
}
