using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSPlus.Domain.Models.CommentModels
{
    public class CommentModel
    {
        public string FullName { get; set; } = null!;
        public string Text { get; set; } = null!;
        public int TopicId { get; set; }
    }
}
