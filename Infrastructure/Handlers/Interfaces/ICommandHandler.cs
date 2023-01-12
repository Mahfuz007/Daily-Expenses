namespace Infrastructure.Handlers.Interfaces
{
    public interface ICommandHandler
    {
        public Task<TResponse> HandleAsync<TCommand, TResponse>(TCommand command);
    }
}
