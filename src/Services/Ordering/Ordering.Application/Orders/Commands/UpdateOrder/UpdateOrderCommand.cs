namespace Ordering.Application.Orders.Commands.UpdateOrder
{
    public record UpdateOrderCommand(OrderDto orderDto)
        : ICommand<UpdateOrderResult>;

    public record UpdateOrderResult(bool IsSuccess);

    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(x => x.orderDto.Id).NotEmpty().WithMessage("Id is required");
            RuleFor(x => x.orderDto.OrderName).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.orderDto.CustomerId).NotNull().WithMessage("CustomerId is required");
        }
    }
}
