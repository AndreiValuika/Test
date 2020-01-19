﻿using BulbaCourses.Podcasts.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbaCourses.Podcasts.Logic.Interfaces
{
    public interface IUserService : IBaseService<UserLogic>
    {
        Result Add(UserLogic user);

        bool Exists(string name);

        Result<IEnumerable<UserLogic>> Search(string Name);
    }
}
