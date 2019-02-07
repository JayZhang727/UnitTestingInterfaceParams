using System.Collections.Generic;

namespace ClassUnderTesting
{
    public interface IWorkInterface
    {
        string DoWork(IEnumerable<IParamInterface> para);
    }
}
