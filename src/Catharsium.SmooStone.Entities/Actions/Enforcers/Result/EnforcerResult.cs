namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Result
{
    public class EnforcerResult : IEnforcerResult
    {
        public EnforcerResultState State { get; set; }

        public string Message { get; set; }
    }
}