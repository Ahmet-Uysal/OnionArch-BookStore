using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookStore.Application.Features.Commands.Category.SubscribeCategory
{
    public class SubscribeCategoryCommandRequest : BaseRequest, IRequest<SubscribeCategoryCommandResponse>
    {
        public Guid ParentId { get; set; }
    }
}