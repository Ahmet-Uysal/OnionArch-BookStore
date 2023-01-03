using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BookStore.Application.Features.Commands.Category.AddCategory;
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

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddCategoryCommandRequest createProductCommandRequest)
        {
            // await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created, await _mediator.Send(createProductCommandRequest));
        }
        [HttpGet(Name = "GetAllCategories")]
        public async Task<IActionResult> Get()
        {
            // throw new Exception("patladı");
            // await _mediator.Send(createProductCommandRequest);
            return Ok(await _mediator.Send(new GetCategoriesQueryRequest()));
        }
        [HttpGet("[action]")]
        // [Route("[action]")]
        public async Task<IActionResult> GetAllCategoriesWithSub()
        {
            // throw new Exception("patladı");
            // await _mediator.Send(createProductCommandRequest);
            return Ok(await _mediator.Send(new GetCategoriesWithSubQueryRequest()));
        }
    }
}