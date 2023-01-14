using System.Net;
using BookStore.Application.Features.Commands.Category.CreateCategory;
using BookStore.Application.Features.Commands.Category.RemoveCategory;
using BookStore.Application.Features.Commands.Category.SubscribeCategory;
using BookStore.Application.Features.Commands.Category.SwitchCategoryActiveStatus;
using BookStore.Application.Features.Commands.Category.UnsubscribeCategory;
using BookStore.Application.Features.Commands.Category.UpdateCategory;
using BookStore.Application.Features.Queries.Category.GetAllCategoriesWithBooks;
using BookStore.Application.Features.Queries.Category.GetCategories;
using BookStore.Application.Features.Queries.Category.GetCategoriesWithSub;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommandRequest createProductCommandRequest) => StatusCode((int)HttpStatusCode.Created, await _mediator.Send(createProductCommandRequest));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllCategories() => Ok(await _mediator.Send(new GetCategoriesQueryRequest()));
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCategoriesWithSub() => Ok(await _mediator.Send(new GetCategoriesWithSubQueryRequest()));
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCategoriesWithBooks() => Ok(await _mediator.Send(new GetAllCategoriesWithBooksQueryRequest()));


        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut("[action]")]
        public async Task<IActionResult> RemoveCategory([FromBody] RemoveCategoryCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut("[action]")]
        public async Task<IActionResult> SwitchCategoryActiveStatus([FromBody] SwitchCategoryActiveStatusCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut("[action]")]
        public async Task<IActionResult> UnsubscribeCategory([FromBody] UnsubscribeCategoryCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut("[action]")]
        public async Task<IActionResult> SubscribeCategory([FromBody] SubscribeCategoryCommandRequest entity) => Ok(await _mediator.Send(entity));
    }
}