using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Application.Dtos.Author;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Queries.Author.GetAuthorsByIdWithImages
{
    public class GetAuthorsByIdWithImagesQueryHandler : BaseReadHandler<IAuthorReadRepository>, IRequestHandler<GetAuthorsByIdWithImagesQueryRequest, GetAuthorsByIdWithImagesQueryResponse>
    {
        readonly IMapper _mapper;
        public GetAuthorsByIdWithImagesQueryHandler(IAuthorReadRepository readRepository, IMapper mapper) : base(readRepository)
        {
            _mapper = mapper;
        }

        public async Task<GetAuthorsByIdWithImagesQueryResponse> Handle(GetAuthorsByIdWithImagesQueryRequest request, CancellationToken cancellationToken)
        {
            return new GetAuthorsByIdWithImagesQueryResponse
            {
                Data = _mapper.Map<GetAuthorsByIdWithImagesDto>(await _readRepository.GetByIdAsync(request.Id, navigationPropertyPath: x => x.AuthorImageFiles))
            };
        }
    }
}