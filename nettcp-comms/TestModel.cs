using System.Collections.Generic;

namespace MyTcpServer
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public Dictionary<string, string> InternalDictionary { get; set; }
    }
}
