using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator  : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.CarId).GreaterThan(0).WithMessage("Id sıfırdan büyük olamlı");

            RuleFor(c => c.CarImagesId).NotEmpty();
            RuleFor(c => c.CarImagesId).GreaterThan(0);

            RuleFor(c => c.ImagePath).NotEmpty();
            RuleFor(c => c.Date).NotEmpty();


         
        }
    
    }
}
