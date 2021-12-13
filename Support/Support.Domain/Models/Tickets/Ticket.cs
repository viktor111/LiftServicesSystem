namespace Support.Domain.Models.Tickets
{
    using Common.Domain;
    using Common.Domain.Models;
    using Exceptions;

    using static ModelConstants.Ticket;

    public class Ticket : Entity<int>, IAggregateRoot
    {
        internal Ticket(string userId, string title, string description)
        {
            this.Validate(userId, title, description);

            this.UserId = userId;
            this.Title = title;
            this.Description = description;
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public string UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsClosed { get; set; }

        public bool IsSolved { get; set; }

        public Ticket UpdateTitle(string title)
        {
            this.ValidateTitle(title);
            this.Title = title;
            this.UpdatedAt = DateTime.Now;
            return this;
        }

        public Ticket UpdateDescription(string description)
        {
            this.ValidateDescription(description);
            this.Title = Title;
            this.UpdatedAt = DateTime.Now;
            return this;
        }

        public Ticket ChangeIsClosed()
        {
            this.IsClosed = !this.IsClosed;
            this.UpdatedAt = DateTime.Now;
            return this;
        }

        public Ticket ChangeIsSolved()
        {
            this.IsSolved = !this.IsSolved;
            this.UpdatedAt = DateTime.Now;
            return this;
        }

        private void Validate(string userId, string title, string description)
        {
            this.ValidateUserId(userId);
            this.ValidateTitle(title);
            this.ValidateDescription(description);
        }

        private void ValidateUserId(string userId)
        {
            Guard.AgainstEmptyString<InvalidTicketException>(
                userId,
                nameof(this.UserId));
        }

        private void ValidateTitle(string title)
        {
            Guard.AgainstEmptyString<InvalidTicketException>(
                title,
                nameof(this.Title));

            Guard.ForStringLength<InvalidTicketException>(
                title,
                MinTitleLength,
                MaxTitleLength,
                nameof(this.Title));
        }

        private void ValidateDescription(string description)
        {
            Guard.AgainstEmptyString<InvalidTicketException>(
                description,
                nameof(this.Description));

            Guard.ForStringLength<InvalidTicketException>(
                description,
                MinDescriptionLength,
                MaxDescriptionLength,
                nameof(this.Description));
        }
    }
}
