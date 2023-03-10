using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apkakonsoli_final;

namespace mstesty_final
{
    [TestClass]
    public class TestWizyta
    {
        [TestMethod]
        public void TestKonstruktora()
        {
            Wizyta wizyta = new Wizyta();
            Assert.IsNotNull(wizyta);
        }
        [TestMethod]
        public void TestDataException1()
        {
            Pacjent pacjent = new();
            Lekarz lekarz = new();
            Wizyta wizyta = new();
            Assert.ThrowsException<apkakonsoli_final.DataException>(() => wizyta = new("05/30/2023", lekarz, pacjent, new TimeSpan(9, 0, 0)));    
        }
    }
}