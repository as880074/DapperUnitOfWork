using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using UnitPattenDemo.Repository.Interface;
using UnitPattenDemo.Repository.Models;

namespace UnitPattenDemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public UsersController(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Test() 
        {
            var user = new Users()
            {
                FirstName = "123",
                LastName ="456"
            };
            unitOfWork.Start();
            unitOfWork.UserRepository.Add(user);
            unitOfWork.UserRepository.Add(user);
            unitOfWork.UserRepository.Add(user);
            unitOfWork.UserRepository.Add(user);
            unitOfWork.UserRepository.TestException();
                unitOfWork.UserRepository.Add(user);
            unitOfWork.UserRepository.Add(user);
            unitOfWork.Complete();
            return Ok();
        }
    }
}
