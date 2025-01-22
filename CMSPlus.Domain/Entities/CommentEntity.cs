﻿namespace CMSPlus.Domain.Entities
{
    public class CommentEntity : BaseEntity
    {
        public string FullName { get; set; } = null!;
        public string Text { get; set; } = null!;

        public int TopicId { get; set; }
        public TopicEntity Topic { get; set; } = null!;
    }
}
