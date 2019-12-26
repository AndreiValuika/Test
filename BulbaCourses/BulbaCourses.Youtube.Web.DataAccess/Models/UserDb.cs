﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BulbaCourses.Youtube.Web.DataAccess.Models
{
    public class UserDb
    {
        public int? Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }  //скрыть надо бы..
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string NumberPhone { get; set; } //возможно надо для авторизации, или восстановления пароля
        public string Email { get; set; }
        public string ReserveEmail { get; set; }
        public ICollection<SearchStoryDb> SearchStories { get; set; } //reference
    } 
}