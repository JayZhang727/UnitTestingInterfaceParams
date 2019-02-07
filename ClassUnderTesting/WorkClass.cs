using System.Collections.Generic;
using System.Linq;

namespace ClassUnderTesting
{
    public class WorkClass : IWorkInterface
    {
        public WorkClass()
        {

        }

        public string DoWork(IEnumerable<IParamInterface> para)
        {
            var result = string.Empty;
            var implementation = para.ToList()[0].GetParamData();

            switch (implementation)
            {
                case ParamClassA data:
                    result = result + "ParamA var: " + data.ParamClassAVar.ToString() + ", ";
                    break;
                case ParamClassB data:
                    result = result + "ParamB var: " + data.ParamClassBVar + ", ";
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
