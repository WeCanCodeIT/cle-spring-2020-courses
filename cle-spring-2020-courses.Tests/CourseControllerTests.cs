using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using cle_spring_2020_courses.Controllers;
using cle_spring_2020_courses.Models;
using System.Collections.Generic;
using NSubstitute;
using cle_spring_2020_courses.Repositories;

namespace cle_spring_2020_courses.Tests
{
    public class CourseControllerTests
    {
        CourseController controller;
        IRepository<Course> courseRepo;
        
        public CourseControllerTests()
        {
            // controller = new CourseController();
            courseRepo = Substitute.For<IRepository<Course>>();
            controller = new CourseController(courseRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_AllCourses_To_View()
        {
            // Act
            var result = controller.Index();

            // Assert
            Assert.IsAssignableFrom<IEnumerable<Course>>(result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            // Act
            var result = controller.Details(1);

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            // Act
            var result = controller.Details(1);

            // Assert
            Assert.IsType<Course>(result.Model);
        }

    }
}
