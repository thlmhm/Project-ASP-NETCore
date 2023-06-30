﻿
using Application.Features.Todo.Command;
using Application.Features.Todo.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs;

namespace TodoList.API.Controllers
{

    public class TodoListController : BaseApiController
    {
        [HttpGet]

        public async Task<IActionResult> GetProducts()
        {
            return Ok(await Mediator.Send(new TodoQueries()));

        }

        [HttpPost]

        public async Task<IActionResult> CreateTodo([FromBody] TodoModel Model)
        {
            return Ok(await Mediator.Send(new CreateTodoCommand() { Model = Model }));
        }

        [HttpPut]
        public async Task<IActionResult> ModifyTodo([FromBody] TodoModel Model)
        {
            return Ok(await Mediator.Send(new ModifyTodoCommand() { Model = Model }));
        }
      

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            return Ok(await Mediator.Send(new DeleteTodoCommand() { Id = id }));
        }
    }
}
