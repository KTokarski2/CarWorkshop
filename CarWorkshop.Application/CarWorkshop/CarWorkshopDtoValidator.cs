using CarWorkshop.Domain.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Routing;

namespace CarWorkshop.Application.CarWorkshop;

public class CarWorkshopDtoValidator : AbstractValidator<CarWorkshopDto>
{
    public CarWorkshopDtoValidator(ICarWorkshopRepository repository)
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Field is required")
            .MinimumLength(2).WithMessage("Length must be more then 2 characters")
            .MaximumLength(20).WithMessage("Lenght must be less then 20 characters")
            .Custom((value, context) =>
            {
                var existingCarWorkshop = repository.GetByName(value).Result;
                if (existingCarWorkshop != null)
                {
                    context.AddFailure($"{value} is not unique for car workshop");
                }
            });

        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Field is required");

        RuleFor(c => c.PhoneNumber)
            .MinimumLength(8).WithMessage("Lenght must be more then 8 characters")
            .MaximumLength(12).WithMessage("Lenght must be less then 12 characters");
    }
}