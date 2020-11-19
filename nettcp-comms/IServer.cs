using System.ServiceModel;

namespace MyTcpServer
{
    [ServiceContract]
    public interface IServer
    {
        [OperationContract]
        string Test();

        [OperationContract]
        TestModel FetchTestInstanceById(int id);
    }
}
