using Tyuiu.ErmakovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ErmakovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassegeValid()
        {
            //
            var name = "Александр";
            var res = DataService.GetMassege(name);

            // Assert  AreEqual
            Assert.AreEqual("Приветик, Александр", res);

        }
    }
}