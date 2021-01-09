using FluentValidation;
using HotelRegist.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRegist.Entities.ValidationRules.FluentValidation
{
    public class HotelValidator:AbstractValidator<Hotel>
    {
        public HotelValidator()
        {
            RuleFor(b => b.Capasity).NotEmpty().GreaterThan(0).WithMessage("Kapasite sıfırdan küçük olamaz.");
            RuleFor(b => b.HotelName).NotEmpty().Length(100).WithMessage("Otel adı boş olamaz.");
        }
    }
}
