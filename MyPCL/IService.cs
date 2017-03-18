using System.Collections.Generic;

namespace MyPCL
{
    public interface IService
    {
        IList<string> GetData(int number);
    }
}
