using AutoMapper;
using Domain.Tables;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<TodoWork, TodoModel>();
            CreateMap<TodoModel, TodoWork>();
        }
    }
}
