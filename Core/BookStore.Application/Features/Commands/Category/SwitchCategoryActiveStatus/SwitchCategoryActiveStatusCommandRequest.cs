using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookStore.Application.Features.Commands.Category.SwitchCategoryActiveStatus
{
    public class SwitchCategoryActiveStatusCommandRequest : BaseRequest, IRequest<SwitchCategoryActiveStatusCommandResponse>
    {
    }
}