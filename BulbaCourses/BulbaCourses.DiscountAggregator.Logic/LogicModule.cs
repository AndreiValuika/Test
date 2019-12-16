﻿using BulbaCourses.DiscountAggregator.Logic.Parsers;
using BulbaCourses.DiscountAggregator.Logic.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbaCourses.DiscountAggregator.Logic
{
    public class LogicModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICourseServices>().To<CourseServices>();
            Bind<ICourseITAcademyServices>().To<CourseITAcademyServices>();
            Bind<ICourseUdemyServices>().To<CourseUdemyServices>();
            Bind<ICourseBookmarkServices>().To<CourseBookmarkServices>();
            Bind<IUserAccountServise>().To<UserAccountServeces>();
            Bind<IDomainServices>().To<DomainServices>();
            Bind<ICourseCategoryServices>().To<CourseCategoryServices>();
        }
    }
}
