namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Request
{
    public interface IRequestFactory<out T> where T : IRequest, new()
    {
        T Create();
    }
}