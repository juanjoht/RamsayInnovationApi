﻿using MediatR;
using StudentApp.Api.DB.Models;
using StudentApp.Api.DB.Repository.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Api.DB.Repository.Command
{
    public class InsertCommand : IRequest<Response>
    {
        public Student Student { get; set; }
        public InsertCommand(Student student)
        {
            Student = student;
        }
    }
}
