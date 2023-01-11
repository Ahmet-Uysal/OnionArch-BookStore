using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application.Abstractions.Storage;
using BookStore.Application.Repositories.AuthorImageFileRepository;
using BookStore.Application.Repositories.AuthorRepository;
using MediatR;

namespace BookStore.Application.Features.Commands.Author.RemoveAuthorImageFile
{
    public class RemoveAuthorImageFileCommandHandler : BaseHandler<IAuthorReadRepository, IAuthorImageFileWriteRepository>, IRequestHandler<RemoveAuthorImageFileCommandRequest, RemoveAuthorImageFileCommandResponse>
    {
        readonly IStorageService _storageService;
        public RemoveAuthorImageFileCommandHandler(IAuthorReadRepository readRepository, IAuthorImageFileWriteRepository writeRepository, IStorageService storageService) : base(readRepository, writeRepository)
        {
            _storageService = storageService;
        }

        public async Task<RemoveAuthorImageFileCommandResponse> Handle(RemoveAuthorImageFileCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Author author = await _readRepository.GetByIdAsync(request.Id, navigationPropertyPath: x => x.AuthorImageFiles);
            var file = author.AuthorImageFiles?.SingleOrDefault(x => x.Id == request.FileId);
            if (file != null)
                await _storageService.DeleteAsync("photo-images", file.Name);





            await _writeRepository.RemoveAsync(file.Id);
            await _writeRepository.SaveAsync();

            return new();
        }
    }

}