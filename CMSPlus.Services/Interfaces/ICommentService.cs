using CMSPlus.Domain.Entities;

namespace CMSPlus.Services.Interfaces
{
    public interface ICommentService
    {
        public Task CreateComment(CommentEntity entity);
    }
}
