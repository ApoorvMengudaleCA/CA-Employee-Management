using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CA_Employee_Management.Dtos;
using CA_Employee_Management.Models;

namespace CA_Employee_Management.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //domain to dto
            Mapper.CreateMap<Employee, EmployeeDto>();


            //dto to domain
            Mapper.CreateMap<EmployeeDto, Employee>();

        }
    }
}