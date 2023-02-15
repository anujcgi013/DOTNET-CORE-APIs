namespace ApiCorrelation.Configuation.Interface;

public interface ICorrelationIdGenerator
{
    string Get();
    void Set(string correlationId);
}
