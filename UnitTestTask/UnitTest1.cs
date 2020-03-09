using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDepartament()
        {
            var controller = new DepartamentController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var result = controller.Get();


            Departament departament; 

            Assert.IsTrue(result.TryGetContentValue<Departament>(out departament));



        }
    }
}
