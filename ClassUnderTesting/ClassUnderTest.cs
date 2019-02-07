using System.Collections.Generic;

namespace ClassUnderTesting
{
    public class ClassUnderTest
    {
        public ClassUnderTest(IWorkInterface workInt)
        {
            this.WorkClient = workInt;
        }

        public IWorkInterface WorkClient { get; set; }

        public string MethodUnderTest()
        {
            var result = string.Empty;

            //Class A is an implementation of IParamDataInterface
            var a = new ParamClassA();
            var theParamA = new ParamClass<ParamClassA>(a);
            var listA = new List<IParamInterface>();
            listA.Add(theParamA);

            result = WorkClient.DoWork(listA);

            //Class B is also an implementation of IParamDataInterface
            var b = new ParamClassB();
            var theParamB = new ParamClass<ParamClassB>(b);
            var listB = new List<IParamInterface>();
            listB.Add(theParamB);

            result = result + WorkClient.DoWork(listB);

            return result;
        }

    }
}
