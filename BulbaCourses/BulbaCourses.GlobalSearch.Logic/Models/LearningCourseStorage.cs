﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BulbaCourses.GlobalSearch.Logic.Models
{
    public static class LearningCourseStorage
    {
        public static List<LearningCourse> _courses = new List<LearningCourse>()
        {
            new LearningCourse()
            {
                Id = Guid.NewGuid().ToString(),
                Items = new List<LearningCourseItem>()
                {
                    new Video()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Introduction: PartOne",
                        Description = "In this video we will introduct the .NET platform features. ",
                        Duration = "3 hours"
                    },
                    new Video()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Introduction: PartTwo",
                        Description = "In this video we will introduct the .NET platform features. ",
                        Duration = "3 hours"
                    },
                },
                Name = "C# Basics",
                Category = "Video",
                Cost = 20.0,
                Complexity = "Easy",
                Language = "En",
                Description = "C# basics video course for beginners",
                AuthorId = 1,
            },
            new LearningCourse()
            {
                Id = Guid.NewGuid().ToString(),
                Items = new List<LearningCourseItem>()
                {
                    new Text()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Main Part: PartOne",
                        Description = "In this video we will introduct another .NET platform features. ",
                        MinutesRead = 20,
                    },
                    new Text()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Main Part: PartTwo",
                        Description = "In this video we will introduct another .NET platform features. ",
                        MinutesRead = 65,
                    },
                },
                Name = "C# Advanced",
                Category = "Text",
                Cost = 20.0,
                Complexity = "Medium",
                Language = "En",
                Description = "C# advanced tutorial",
                AuthorId = 2,
            },
            new LearningCourse()
            {
                Id = Guid.NewGuid().ToString(),
                Items = new List<LearningCourseItem>()
                {
                    new Podcast()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Microservices: introduction",
                        Description = "Backend architecture",
                        Duration = "6 hours"
                    },
                    new Podcast()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Micro frontends: Beginning",
                        Description = "Frontend architecture ",
                        Duration = "3 hours"
                    },
                    new Podcast()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Discussion",
                        Description = "Pros and cons",
                        Duration = "2 hours"
                    },
                },
                Name = "Microservices",
                Category = "Podcast",
                Cost = 20.0,
                Complexity = "Medium",
                Language = "En",
                Description = "Discuss microservices",
                AuthorId = 2,
            },
        };
        /// <summary>
        /// Get all courses from the storage
        /// </summary>
        /// <returns>Readonly collection of courses</returns>
        public static IEnumerable<LearningCourse> GetAllCourses()
        {
            return _courses.AsReadOnly();
        }

        /// <summary>
        /// Get specific course from the storage by id
        /// </summary>
        /// <param name="id">Guid of specific course</param>
        /// <returns>Specific course</returns>
        public static LearningCourse GetById(string id)
        {
            return _courses.SingleOrDefault(c => c.Id.Equals(id,
                StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Get courses from the storage by category
        /// </summary>
        /// <param name="category">Category</param>
        /// <returns>Readonly collection of courses</returns>
        public static IEnumerable<LearningCourse> GetByCategory(string category)
        {
            return _courses.AsReadOnly().Where(course => course.Category.Contains(category));
        }

        /// <summary>
        /// Get courses from the storage by author
        /// </summary>
        /// <param name="id">Author id</param>
        /// <returns>Readonly collection of courses</returns>
        public static IEnumerable<LearningCourse> GetByAuthorId(int id)
        {
            return _courses.AsReadOnly().Where(course => course.AuthorId == id);
        }

        /// <summary>
        /// Get learning items of specific course
        /// </summary>
        /// <param name="id">Guid of specific course</param>
        /// <returns>Readonly collection of learning items</returns>
        public static IEnumerable<LearningCourseItem> GetLearningItemsByCourseId(string id)
        {
            return _courses.AsReadOnly().SingleOrDefault(c => c.Id.Equals(id,
                StringComparison.OrdinalIgnoreCase)).Items;
        }

        /// <summary>
        /// Get courses from the storage by complexity
        /// </summary>
        /// <param name="complexity">Complexity level</param>
        /// <returns>Readonly collection of courses</returns>
        public static IEnumerable<LearningCourse> GetCourseByComplexity(string complexity)
        {
            return _courses.AsReadOnly().Where(course => course.Complexity.Contains(complexity));
        }

        /// <summary>
        /// Get courses from the storage by language
        /// </summary>
        /// <param name="lang">Language</param>
        /// <returns>Readonly collection of courses</returns>
        public static IEnumerable<LearningCourse> GetCourseByLanguage(string lang)
        {
            return _courses.AsReadOnly().Where(course => course.Language.Contains(lang));
        }

        /// <summary>
        /// Get courses from the storage by search query
        /// </summary>
        /// <param name="query">Search query</param>
        /// <returns>Readonly collection of courses</returns>
        public static IEnumerable<LearningCourse> GetCourseByQuery(string query)
        {
            return _courses.AsReadOnly().Where(course => course.Description.ToLower().Contains(query.ToLower()));
        }
    }
}