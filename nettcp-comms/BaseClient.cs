using System.ServiceModel;

namespace MyTcpServer
{
    public class MyTcpClient : ClientBase<IServer>, IServer
    {
        public MyTcpClient(NetTcpBinding binding, EndpointAddress endpoint) : base(binding, endpoint)
        {
        }

        public TestModel FetchTestInstanceById(int id)
        {
            return Channel.FetchTestInstanceById(id);
        }

        public string Test()
        {
            return Channel.Test();
        }
    }
}
