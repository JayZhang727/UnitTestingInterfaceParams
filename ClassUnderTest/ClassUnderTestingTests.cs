using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ClassUnderTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUnderTesting.UnitTests
{
    [TestClass]
    public class ClassUnderTestingTests
    {
        private Mock<IWorkInterface> mockClient;

        [TestMethod()]
        public void DoWorkTest()
        {
            mockClient = new Mock<IWorkInterface>(MockBehavior.Strict);
            var target = new ClassUnderTest(mockClient.Object);

            mockClient
                .Setup(ec => ec.DoWork(
                    It.Is<List<IParamInterface>>(el => el[0] is ParamClass<ParamClassA> && ((ParamClass<ParamClassA>)el[0]).ParamData.ParamClassAVar == 123)
                ))
                .Returns("123");

            mockClient
                .Setup(ec => ec.DoWork(
                    It.Is<List<IParamInterface>>(el => el[0] is ParamClass<ParamClassB> && ((ParamClass<ParamClassB>)el[0]).ParamData.ParamClassBVar == "not 123")
                ))
                .Returns("not 123");

            //act
            target.MethodUnderTest();


            //assert
            mockClient.VerifyAll();
        }



    }
}
