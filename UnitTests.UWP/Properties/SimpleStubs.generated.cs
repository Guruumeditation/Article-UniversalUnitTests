using System;
using System.Runtime.CompilerServices;
using Etg.SimpleStubs;
using System.Collections.Generic;

namespace MyPCL
{
    [CompilerGenerated]
    public class StubIService : IService
    {
        private readonly StubContainer<StubIService> _stubs = new StubContainer<StubIService>();

        global::System.Collections.Generic.IList<string> global::MyPCL.IService.GetData(int number)
        {
            return _stubs.GetMethodStub<GetData_Int32_Delegate>("GetData").Invoke(number);
        }

        public delegate global::System.Collections.Generic.IList<string> GetData_Int32_Delegate(int number);

        public StubIService GetData(GetData_Int32_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}