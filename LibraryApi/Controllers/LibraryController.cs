using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Web.Http.Cors;
using Domain.Entities;
using Domain.Interface;


namespace LibraryApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ILibrarydata _librarydata;

        
        public LibraryController(ILibrarydata librarydata)
        {
            _librarydata = librarydata;
        }
        [HttpGet]
        [Route("Users")]
         public IEnumerable<Users> GetUsers()
        {
            return _librarydata.Users.GetAll();

        }
        [HttpGet]
        [Route("Users/{id}")]
        public IActionResult GetUsersByID([FromQuery] int id)
        {
            var users = _librarydata.Users.GetUsers(id);
            return Ok(users);

        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUsers(Users users)
        {
           _librarydata.Users.Add(users);
            _librarydata.Complete();
            return Ok(users);         
        
        }
        [HttpPut]
        [Route("EditUser")]
        public IActionResult EditUsers(Users users)
        {
             _librarydata.Users.Update(users);
            _librarydata.Complete();
            return Ok(users);

        }
        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(Users users)
        {
            _librarydata.Users.Remove(users);
            _librarydata.Complete();
            return Ok(users);

        }

        [HttpGet]
        [Route("Books")]
        public IEnumerable<Books> GetBooks()
        {
            return _librarydata.Books.GetAll();

        }
        [HttpGet]
        [Route("Books/{id}")]
        public IActionResult GetBookByID([FromQuery] int id)
        {
            var books = _librarydata.Books.GetById(id);
            return Ok(books);

        }
        [HttpPost]
        [Route("AddBooks")]
        public IActionResult AddBooks(Books books)
        {
            _librarydata.Books.Add(books);
            _librarydata.Complete();
            return Ok(books);

        }
        [HttpPut]
        [Route("EditBooks")]
        public IActionResult EditBooks(Books books)
        {
            _librarydata.Books.Update(books);
            _librarydata.Complete();
            return Ok(books);

        }
        [HttpGet]
        [Route("UserBooks")]
        public IEnumerable<UserBooks> GetUserBooks()
        {
            return _librarydata.UserBooks.GetAll();

        }
        [HttpGet]
        [Route("UserBooks/{id}")]
        public IActionResult GetUserBooksByID([FromQuery] int id)
        {
            var userbooks = _librarydata.UserBooks.GetById(id);
            return Ok(userbooks);

        }
        [HttpPost]
        [Route("AddUserBooks")]
        public IActionResult AddUserBooks(UserBooks userbooks)
        {
            _librarydata.UserBooks.Add(userbooks);
            _librarydata.Complete();
            return Ok(userbooks);

        }
        [HttpPut]
        [Route("EditUserBooks")]
        public IActionResult EditUserBooks(UserBooks userbooks)
        {
            _librarydata.UserBooks.Update(userbooks);
            _librarydata.Complete();
            return Ok(userbooks);

        }
        [HttpDelete]
        [Route("DeleteUserBooks")]
        public IActionResult DeleteUserBooks(UserBooks userbooks)
        {
            _librarydata.UserBooks.Remove(userbooks);
            _librarydata.Complete();
            return Ok(userbooks);

        }
    }
}
