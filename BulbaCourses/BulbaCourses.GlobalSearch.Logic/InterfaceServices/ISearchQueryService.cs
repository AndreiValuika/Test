﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulbaCourses.GlobalSearch.Data.Models;
using BulbaCourses.GlobalSearch.Logic.DTO;
using BulbaCourses.GlobalSearch.Logic.Models;

namespace BulbaCourses.GlobalSearch.Logic.InterfaceServices
{
    public interface ISearchQueryService
    {
        IEnumerable<SearchQueryDTO> GetAll();
        Task<IEnumerable<SearchQueryDTO>> GetAllAsync();
        SearchQueryDTO GetById(string id);
        Task<SearchQueryDTO> GetByIdAsync(string id);
        SearchQueryDTO Add(SearchQueryDTO query);
        void RemoveById(string id);
        void RemoveAll();
        Task<bool> AnyAsync(string id);
    }
}
