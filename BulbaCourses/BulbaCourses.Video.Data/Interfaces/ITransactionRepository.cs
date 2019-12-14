﻿using BulbaCourses.Video.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbaCourses.Video.Data.Interfaces
{
    public interface ITransactionRepository
    {
        TransactionDb GetById(string transactionlId);
        IEnumerable<TransactionDb> GetAll();
        void Add(TransactionDb transaction);
        void Update(TransactionDb transaction);
        void Remove(TransactionDb transaction);
    }
}