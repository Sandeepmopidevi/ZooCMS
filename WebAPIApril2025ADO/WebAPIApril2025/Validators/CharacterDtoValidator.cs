﻿using FluentValidation;
using WebAPIApril2025.DTOs;

namespace WebAPIApril2025.Validators
{
    public class CharacterDtoValidator : AbstractValidator<CharacterDto>
    {
        public CharacterDtoValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Character name is required.")
                .MaximumLength(50).WithMessage("Character name cannot exceed 50 characters.");

            //Here ID is autogenerated. So, not checking for it. 
            //RuleFor(c => c.ComicId)
            //    .GreaterThan(0).WithMessage("ComicId must be greater than 0.");
        }
    }
}
