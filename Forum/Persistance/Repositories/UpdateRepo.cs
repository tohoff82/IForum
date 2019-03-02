﻿using Forum.Domain.Repositories;
using Forum.Models.Account;
using Forum.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Persistance.Repositories
{
    public class UpdateRepo : IUpdateRepo
    {
        private readonly ForumContext forumContext;

        public UpdateRepo(ForumContext context)
        {
            forumContext = context;
        }

        public async Task<IEnumerable<Update>> ToListAsync() => await forumContext.ForumUpdates.ToListAsync();

        public async Task AddUpdateAsync(Update update)
        {
            await forumContext.ForumUpdates.AddAsync(update);
            await forumContext.SaveChangesAsync();
        }
    }
}