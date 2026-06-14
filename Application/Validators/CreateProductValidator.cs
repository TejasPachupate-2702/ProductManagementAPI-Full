using System;
using System.Collections.Generic;
using System.Text;
using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class CreateProductValidator
: AbstractValidator<CreateProductDto>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.ProductName)
            .NotEmpty()
            .WithMessage("Product name required")
            .MaximumLength(255);
    }
}