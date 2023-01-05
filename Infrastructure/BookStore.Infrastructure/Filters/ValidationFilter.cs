using BookStore.Application.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace BookStore.Infrastructure.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                // var errors = context.ModelState
                //         .Where(x => x.Value.Errors.Any())
                //         .ToDictionary(e => e.Key, e => e.Value.Errors.Select(e => e.ErrorMessage))
                //         .ToArray();
                List<string> errors = new();
                context.ModelState
                        .Where(x => x.Value.Errors.Any()).ToList().ForEach(x => errors.AddRange(x.Value.Errors.Select(x => x.ErrorMessage).ToList()));

                context.Result = new BadRequestObjectResult(new ApiResponse<object>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = String.Join(" | ", errors)
                });
                return;
            }
            await next();
        }
    }
}