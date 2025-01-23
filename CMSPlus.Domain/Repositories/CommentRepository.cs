using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Persistance;
using Microsoft.EntityFrameworkCore;

namespace CMSPlus.Domain.Repositories;

public class CommentReposiotory : Repository<CommentEntity>, ICommentRepository
{
    public CommentReposiotory(ApplicationDbContext context) : base(context)
    {
    }
}