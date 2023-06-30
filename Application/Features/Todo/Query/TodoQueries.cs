
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
    public class TodoQueries : IRequest<Response<List<TodoModel>>>
    {

    }
}
