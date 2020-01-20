﻿using BulbaCourses.DiscountAggregator.Logic.Models;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulbaCourses.DiscountAggregator.Logic.Validators
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleSet("AddCourse", () =>
            {
                // TODO add DTO without ID field
                RuleFor(x => x.Id).Must(x => string.IsNullOrEmpty(x)).WithMessage("Id must be null or empty");
            });

            RuleFor(x => x.Price).GreaterThan(0.0);
            RuleFor(x => x.OldPrice).GreaterThan(0.0);
            RuleFor(x => x.Discount).GreaterThan(0);
            RuleFor(x => x.Title).NotEmpty().MinimumLength(5).WithMessage("Title must be not empty");
            RuleFor(x => x.Domain).NotEmpty().NotNull().WithMessage("Domain must be not empty or null");
            RuleFor(x => x.Domain.DomainName).NotEmpty().NotNull().MinimumLength(5).WithMessage("Domain name must be not empty or null");
            RuleFor(x => x.Domain.DomainURL).NotEmpty().NotNull().MinimumLength(5).WithMessage("Domain URL must be not empty or null");
            RuleFor(x => x.Category.Name).NotEmpty().NotNull().MinimumLength(2).WithMessage("Category name must be not empty or null");
            RuleFor(x => x.Category.Title).NotEmpty().NotNull().MinimumLength(2).WithMessage("Category title must be not empty or null");
            RuleFor(x => x.URL).NotEmpty().NotNull().MinimumLength(5).WithMessage("URL must be not empty or null");
   
        }
    }
}