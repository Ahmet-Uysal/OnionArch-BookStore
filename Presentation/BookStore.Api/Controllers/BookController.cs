using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Features.Commands.Book.CreateBook;
using BookStore.Application.Features.Commands.Book.RemoveBook;
using BookStore.Application.Features.Commands.Book.SwitchBookActiveState;
using BookStore.Application.Features.Commands.Book.UpdateBook;
using BookStore.Application.Features.Queries.Book.GetAllBooks;
using BookStore.Application.Features.Queries.Book.GetAllBooksWithAllProperties;
using BookStore.Application.Features.Queries.Book.GetAllBooksWithAuthors;
using BookStore.Application.Features.Queries.Book.GetAllBooksWithCategories;
using BookStore.Application.Features.Queries.Book.GetBookById;
using BookStore.Application.Features.Queries.Book.GetBookByIdWithAllProperties;
using BookStore.Application.Features.Queries.Book.GetBookByIdWithAuthors;
using BookStore.Application.Features.Queries.Book.GetBookByIdWithCategories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator) => _mediator = mediator;
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateBookCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> SwitchBookActiveState([FromBody] SwitchBookActiveStateCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> RemoveBook([FromBody] RemoveBookCommandRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBooks([FromBody] GetAllBooksQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBooksWithCategories([FromBody] GetAllBooksWithCategoriesQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllBooksWithAuthors([FromBody] GetAllBooksWithAuthorsQueryRequest entity) => Ok(await _mediator.Send(entity));
        [Route("[action]")]
        public async Task<IActionResult> GetAllBooksWithAllProperties([FromBody] GetAllBooksWithAllPropertiesQueryRequest entity) => Ok(await _mediator.Send(entity));

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetBookById([FromBody] GetBookByIdQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetBookByIdWithCategories([FromBody] GetBookByIdWithCategoriesQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetBookByIdWithAuthors([FromBody] GetBookByIdWithAuthorsQueryRequest entity) => Ok(await _mediator.Send(entity));
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetBookByIdWithAllProperties([FromBody] GetBookByIdWithAllPropertiesQueryRequest entity) => Ok(await _mediator.Send(entity));

    }
}