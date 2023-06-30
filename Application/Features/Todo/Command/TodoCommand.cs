
using MediatR;
using Shared.DTOs;
using Shared.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Todo.Command
{


    public class CreateTodoCommand : IRequest<Response<long>>
    {
        public TodoModel Model { get; set; }
    }

    public class ModifyTodoCommand : IRequest<Response<long>>
    {
        public TodoModel Model { get; set; }
    }

    public class DeleteTodoCommand : IRequest<Response<long>>
    {
        public long Id { get; set; }
    }

    

}
