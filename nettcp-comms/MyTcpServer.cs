using System.Reflection;

namespace nettcp_comms
{
    public class MyTcpServer : IServer
    {
        private Helper _helper;

        public MyTcpServer(Helper helper)
        {
            _helper = helper;
        }

        public TestModel FetchTestInstanceById(int id)
        {
            return _helper.CreateTestModel(id);
        }

        public string Test()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            return $"Server: {assemblyName.Name} - v:{assemblyName.Version}";
        }
    }
}
