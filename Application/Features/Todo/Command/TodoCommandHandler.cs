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

namespace Application.Features.Todo.Command
{
    internal class TodoCommandHandler : IRequestHandler<CreateTodoCommand, Response<long>>,
                                        IRequestHandler<ModifyTodoCommand, Response<long>>,
                                        IRequestHandler<DeleteTodoCommand, Response<long>>
                                     
    {
        private readonly IMapper _mapper;
        private readonly ITodoResponsitoryAsync _todoResponsitoryAsync;

        public TodoCommandHandler(IMapper mapper, ITodoResponsitoryAsync todoRepoAsync)
        {
            this._mapper = mapper;
            this._todoResponsitoryAsync = todoRepoAsync;
        }

        public async Task<Response<long>> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var model = _mapper.Map<Domain.Tables.TodoWork>(request.Model);
                var ret = await this._todoResponsitoryAsync.AddAsync(model);
                return new Response<long>(true, "Lưu dữ liệu thành công") { Data = ret.Id };
            }
            catch (Exception ex)
            {
                return new Response<long>(false, "ServerError") { Data = -1 };
            }
        }

        public async Task<Response<long>> Handle(ModifyTodoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var model = _mapper.Map<Domain.Tables.TodoWork>(request.Model);
                var ret = await this._todoResponsitoryAsync.UpdateAsync(model);
                return new Response<long>(true, "Lưu dữ liệu thành công") { Data = ret.Id };
            }
            catch (Exception ex)
            {
                return new Response<long>(false, "ServerError") { Data = -1 };
            }
        }

 

        public async Task<Response<long>> Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var model = await this._todoResponsitoryAsync.GetByIdAsync(request.Id);
                if (model == null)
                {
                    return new Response<long>(false, "Không tồn tại đối tượng trong database") { Data = -1 };
                }

                var ret = await this._todoResponsitoryAsync.DeleteAsync(model);
                return new Response<long>(true, "Xóa thành công") { Data = ret };
            }
            catch (Exception ex)
            {
                return new Response<long>(false, "ServerError") { Data = -1 };
            }
        }
    }
}
