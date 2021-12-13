namespace Support.Domain.Factories.Tickets
{
    using Common.Domain;
    using Models.Tickets;

    public interface ITicketFactory : IFactory<Ticket>
    {
        ITicketFactory WithUser(string userId);

        ITicketFactory WithTitle(string title);

        ITicketFactory WithDescription(string description);
    }
}
