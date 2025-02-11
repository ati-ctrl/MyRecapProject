﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class CarImageValidator : AbstractValidator<CarImage>
	{
		public CarImageValidator()
		{
			RuleFor(c => c.CarId).NotNull();
			RuleFor(c => c.CarImageId).NotNull();

		}
	}
}
