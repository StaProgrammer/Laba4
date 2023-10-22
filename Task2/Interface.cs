public interface IConnectable
{
    void Connect(Computer computer);
    void Disconnect(Computer computer);
    void TransmitData(Computer source, Computer destination, string data);
}
