using Tyuiu.KhrapkoDD.Sprint4.Task6.V22.Lib;

namespace Tyuiu.KhrapkoDD.Sprint4.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] things = { "Ñíåã", "Äîæäü", "Òóìàí", "Ãðàä", "Âåòåð", "Òó÷à", "Çàñóõà" };
            string[] res = ds.Calculate(things);
            string[] wait = { "Ñíåã", "Ãðàä", "Òó÷à" };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}