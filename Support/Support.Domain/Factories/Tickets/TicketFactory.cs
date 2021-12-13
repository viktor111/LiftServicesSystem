namespace Support.Domain.Factories.Tickets
{
    using Models.Tickets;
    using Exceptions;

    public class TicketFactory : ITicketFactory
    {

        private string userId = default!;
        private string title = default!;
        private string description = default!;

        private bool isUserIdSet = false;
        private bool isTitleSet = false;
        private bool isDescriptionSet = false;

        public ITicketFactory WithUser(string userId)
        {
            this.userId = userId;
            this.isUserIdSet = true;
            return this;
        }

        public ITicketFactory WithTitle(string title)
        {
            this.title = title;
            this.isTitleSet = true;
            return this;
        }

        public ITicketFactory WithDescription(string description)
        {
            this.description = description;
            this.isDescriptionSet = true;
            return this;
        }    

        public Ticket Build()
        {
            if(
                !this.isUserIdSet ||
                !this.isTitleSet || 
                !this.isDescriptionSet)
            {
                throw new InvalidTicketException("UserId, Title and Description must be set!");
            }

            return new Ticket(userId, title, description);
        }
    }
}
