namespace CMSPlus.Domain.Entities
{
    public class CommentEntity : BaseEntity
    {
        public string Text { get; set; }

        public int TopicId { get; set; }
        public TopicEntity Topic { get; set; }
    }
}
