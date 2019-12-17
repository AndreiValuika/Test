﻿using BulbaCourses.DiscountAggregator.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbaCourses.DiscountAggregator.Logic.Services
{
    public interface ICourseBookmarkServices
    {
        IEnumerable<CourseBookmark> GetAll();
        CourseBookmark Add(CourseBookmark courseBookmark);
        IEnumerable<CourseBookmark> Delete(string id);
    }
}
