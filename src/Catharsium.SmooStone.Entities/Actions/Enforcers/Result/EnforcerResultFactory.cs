namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Result
{
    public class EnforcerResultFactory : IEnforcerResultFactory
    {
        public IEnforcerResult Succes(string message)
        {
            return new EnforcerResult
            {
                State = EnforcerResultState.Success,
                Message = message
            };
        }


        public IEnforcerResult Failure(string message)
        {
            return new EnforcerResult
            {
                State = EnforcerResultState.Failure,
                Message = message
            };
        }
    }
}