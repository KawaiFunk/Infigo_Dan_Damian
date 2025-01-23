using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModels;
using CMSPlus.Domain.Models.TopicModels;
using CMSPlus.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CMSPlus.Presentation.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly ITopicService _topicService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, ITopicService topicService, IMapper mapper)
        {
            _commentService = commentService;
            _topicService = topicService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CommentModel commentCreateModel)
        {
            if (ModelState.IsValid)
            {
                var commentEntity = _mapper.Map<CommentModel, CommentEntity>(commentCreateModel);
                await _commentService.CreateComment(commentEntity);
                var updatedTopicSystemName = await _topicService.GetById(commentCreateModel.TopicId);
                return RedirectToAction("Details", "Topic", new { systemName = updatedTopicSystemName.SystemName });
            }

            var topicToDisplay = await _topicService.GetBySystemName(commentCreateModel.TopicId.ToString());
            var topicDto = _mapper.Map<TopicEntity, TopicDetailsModel>(topicToDisplay);
            return RedirectToAction("Details", "Topic", topicDto);
        }
    }
}
