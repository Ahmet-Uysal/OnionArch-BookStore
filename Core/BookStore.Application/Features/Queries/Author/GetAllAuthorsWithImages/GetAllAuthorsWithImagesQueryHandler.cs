using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Features.Queries.Author.GetAllAuthorsWithImages
{
    public class GetAllAuthorsWithImagesQueryHandler : BaseReadHandler<IAuthorReadRepository>, IRequestHandler<GetAllAuthorsWithImagesQueryRequest, GetAllAuthorsWithImagesQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAllAuthorsWithImagesQueryHandler(IAuthorReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAllAuthorsWithImagesQueryResponse> Handle(GetAllAuthorsWithImagesQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAllAuthorsWithImagesQueryResponse
            {
                Data = _mapper.Map<List<GetAllAuthorsWithImagesDto>>(await _readRepository.GetAll().Include(x => x.AuthorImageFiles).ToListAsync())
            };
        }
    }
}