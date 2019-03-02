﻿using Forum.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Domain.Repositories
{
    public interface IUpdateRepo
    {
        Task AddUpdateAsync(Update update);
        Task<IEnumerable<Update>> ToListAsync();
    }
}