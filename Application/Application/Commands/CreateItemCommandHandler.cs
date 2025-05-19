public class CreateItemCommandHandler : ICommandHandler<CreateItemCommand, string>
{
    public Task<string> Handle(CreateItemCommand command, CancellationToken cancellationToken)
    {
        return Task.FromResult($"Item '{command.Name}' created!");
    }
}
