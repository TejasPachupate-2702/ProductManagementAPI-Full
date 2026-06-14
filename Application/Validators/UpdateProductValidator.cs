using System;
using System.Collections.Generic;
using System.Text;
using Application.DTOs;
using FluentValidation;

namespace Application.Validators;

public class UpdateProductValidator
: AbstractValidator<UpdateProductDto>
{
    public UpdateProductValidator()
    {
        RuleFor(x => x.ProductName)
            .NotEmpty()
            .MaximumLength(255);
    }
}