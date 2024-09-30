using Tyuiu.ErmakovAA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.ErmakovAA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayVaid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        public void CheckSubtractionArrayVaid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        public void CheckMultArrayVaid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}