namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Result
{
    public interface IEnforcerResultFactory
    {
        IEnforcerResult Succes(string message);

        IEnforcerResult Failure(string message);
    }
}