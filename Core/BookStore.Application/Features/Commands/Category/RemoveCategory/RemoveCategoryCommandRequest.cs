using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookStore.Application.Features.Commands.Category.RemoveCategory
{
    public class RemoveCategoryCommandRequest : BaseRequest, IRequest<RemoveCategoryCommandResponse>
    {
        public Guid Id { get; set; }
    }
}