using Infrastructure.Handlers.Interfaces;

namespace Infrastructure.Handlers.Implementation
{
    public class CommandHandler : ICommandHandler
    {
        public Task<TResponse> HandleAsync<TCommand, TResponse>(TCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
