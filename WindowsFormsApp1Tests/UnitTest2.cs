using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace WindowsFormsApp1Tests
{
    /// <summary>
    /// Сводное описание для UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        public UnitTest2()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1Safina()
        {
            var form = new Registration();

            string regPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}";
            string regEmail = @"\A[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\z";

            var falseResPassword = form.CheckTextIsMatch("fngdfngkj", regPassword);
            var trueResPassword = form.CheckTextIsMatch("1q2w3e4R5T!", regPassword);

            var falseResEmail = form.CheckTextIsMatch("fngdfngkj", regEmail);
            var trueResEmail = form.CheckTextIsMatch("gold@ya.ru", regEmail);


            Assert.IsFalse(falseResPassword);
            Assert.IsTrue(trueResPassword);

            Assert.IsFalse(falseResEmail);
            Assert.IsTrue(trueResEmail);
        }

        //[TestMethod]
        //public void TestMethod2Safina()
        //{
        //    var form = new Users(); 

        //   var falseResPassword = form.CheckSelect("sd", "sd");
        //   var trueResPassword = form.CheckSelect(null, "");

        //    Assert.IsNotNull(falseResPassword);
        //    Assert.IsNull(trueResPassword);

        //    //Assert.is
        //}
    }
}
