using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Features.Commands.Author.CreateAuthor;
using BookStore.Application.Features.Commands.Author.RemoveAuthor;
using BookStore.Application.Features.Commands.Author.SwitchAuthorActiveState;
using BookStore.Application.Features.Commands.Author.UpdateAuthor;
using BookStore.Application.Features.Queries.Author.GetAllAuthors;
using BookStore.Application.Features.Queries.Author.GetAllAuthorsById;
using BookStore.Application.Features.Queries.Author.GetAllAuthorsWithAllProperties;
using BookStore.Application.Features.Queries.Author.GetAllAuthorsWithBooks;
using BookStore.Application.Features.Queries.Author.GetAllAuthorsWithImages;
using BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithAllProperties;
using BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithBooks;
using BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithImages;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator) => _mediator = mediator;
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateAuthor([FromBody] CreateAuthorCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllAuthors([FromBody] GetAllAuthorsQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllAuthorsWithImages([FromBody] GetAllAuthorsWithImagesQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllAuthorsWithBooks([FromBody] GetAllAuthorsWithBooksQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllAuthorsWithAllProperties([FromBody] GetAllAuthorsWithAllPropertiesQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAuthorsById([FromBody] GetAuthorsByIdQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAuthorsByIdWithImages([FromBody] GetAuthorsByIdWithImagesQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAuthorsByIdWithBooks([FromBody] GetAuthorsByIdWithBooksQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAuthorsByIdWithAllProperties([FromBody] GetAuthorsByIdWithAllPropertiesQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateAuthor([FromBody] UpdateAuthorCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> SwitchAuthorActiveState([FromBody] SwitchAuthorActiveStateCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> RemoveAuthor([FromBody] RemoveAuthorCommandRequest entity) => Ok(await _mediator.Send(entity));
    }
}