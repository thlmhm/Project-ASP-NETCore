using Application.Interfaces;
using Domain.Tables;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class TodoListReponsitoryAsync : GenericReponsitoriesAsync<TodoWork>, ITodoResponsitoryAsync
    {
        private readonly ApplicationDbContext _dbContext;
        public TodoListReponsitoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
