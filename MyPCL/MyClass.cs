using System.Collections.Generic;

namespace MyPCL
{
    public class MyClass
    {
        private IService _service;

        public int Number { get; set; }

        public MyClass(IService service)
        {
            _service = service;
        }

        public IList<string> GetCities()
        {
            return _service.GetData(Number);
        }
    }
}
