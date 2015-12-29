namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Request
{
    public class RequestFactory<T> : IRequestFactory<T> where T : IRequest, new()
    {
        public T Create()
        {
            return new T();
        }
    }
}