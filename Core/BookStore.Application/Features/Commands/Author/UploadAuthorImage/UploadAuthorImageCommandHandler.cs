using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Abstractions.Storage;
using BookStore.Application.Repositories.AuthorImageFileRepository;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Author.UploadAuthorImage
{
    public class UploadAuthorImageCommandHandler : BaseHandler<IAuthorReadRepository, IAuthorImageFileWriteRepository>, IRequestHandler<UploadAuthorImageCommandRequest, UploadAuthorImageCommandResponse>
    {
        readonly IStorageService _storageService;
        public UploadAuthorImageCommandHandler(IAuthorReadRepository readRepository, IAuthorImageFileWriteRepository writeRepository, IStorageService storageService) : base(readRepository, writeRepository)
        {
            _storageService = storageService;
        }

        public async Task<UploadAuthorImageCommandResponse> Handle(UploadAuthorImageCommandRequest request, CancellationToken cancellationToken)
        {
            List<(string fileName, string pathOrContainerName)> result = await _storageService.UploadAsync("photo-images", request.Files);


            Domain.Entities.Author author = await _readRepository.GetByIdAsync(request.Id);


            await _writeRepository.AddRangeAsync(result.Select(r => new Domain.Entities.AuthorImageFile
            {
                Name = r.fileName,
                Path = r.pathOrContainerName,
                Storage = _storageService.StorageName,
                Authors = new List<Domain.Entities.Author>() { author }
            }).ToList());

            await _writeRepository.SaveAsync();

            return new();
        }
    }
}