namespace Common.Infrastructure.Events
{
    using Common.Domain.Events;

    internal interface IEventPublisher
    {
        Task Publish(IDomainEvent domainEvent);

        Task Publish<TDomainEvent>(TDomainEvent domainEvent, Type domainEventType);
    }
}
