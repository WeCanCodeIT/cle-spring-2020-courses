﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_spring_2020_courses.Models
{
    public class CourseModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }

        public CourseModel()
        {

        }

        public CourseModel(string name, int id, string description)
        {
            Name = name;
            Id = id;
            Description = description;
        }
    }
}
