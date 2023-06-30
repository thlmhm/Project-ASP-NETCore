
using Application.Interfaces;
using AutoMapper;
using MediatR;
using Shared.DTOs;
using Shared.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Todo.Query
{
    public class TodoQueriesHandler : IRequestHandler<TodoQueries, Response<List<TodoModel>>>
    {
        private readonly IMapper _mapper;
        private readonly ITodoResponsitoryAsync _todoResponsitoryAsync;

        public TodoQueriesHandler(IMapper mapper, ITodoResponsitoryAsync todoResponsitoryAsync)
        {
            this._mapper = mapper;
            this._todoResponsitoryAsync = todoResponsitoryAsync;
        }

        public async Task<Response<List<TodoModel>>> Handle(TodoQueries req, CancellationToken cancellationToken)
        {
            var TodoList = await this._todoResponsitoryAsync.GetAllAsync();
            var models = TodoList.Select(x => _mapper.Map<TodoModel>(x)).ToList();
            return new Response<List<TodoModel>>(true, "Lấy dữ liệu thành công") { Data = models };
        }
    }
}
