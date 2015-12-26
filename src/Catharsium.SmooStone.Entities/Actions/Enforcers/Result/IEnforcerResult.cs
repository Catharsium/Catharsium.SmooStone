namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Result
{
    public interface IEnforcerResult
    {
        EnforcerResultState State { get; }

        string Message { get; }
    }
}