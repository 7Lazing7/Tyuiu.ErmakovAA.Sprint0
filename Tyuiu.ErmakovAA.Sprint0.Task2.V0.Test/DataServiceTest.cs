using Tyuiu.ErmakovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ErmakovAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassegeValid()
        {
            //область создания метода тестирования, методов из библиотеки 
            var name = "Александр";
            var res = DataService.GetMassege(name);

            //вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Приветик, Александр", res);

        }
    }
}