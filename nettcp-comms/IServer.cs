using System.ServiceModel;

namespace nettcp_comms
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
