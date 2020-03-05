using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDapperCrud.Data;
using FluentValidation;

namespace BlazorDapperCrud.Validation
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(city => city.Name).NotEmpty().MaximumLength(50);
            RuleFor(city => city.State).NotEmpty().MaximumLength(50);
        }
    }
}
