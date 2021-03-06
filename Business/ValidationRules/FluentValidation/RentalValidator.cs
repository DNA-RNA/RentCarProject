using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentalId).NotEmpty();
            RuleFor(r => r.RentalId).GreaterThan(0);

            RuleFor(r => r.RentDate).NotEmpty();
            
            RuleFor(r => r.CustomerId).NotEmpty();

        }
    }
}
