using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.DBConnection;
namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        Connection conexao = new Connection();

        [HttpGet("{id}")]
        public List<PostModel> Get(int Id)
        {
            return conexao.SelectPost(Id);
        }

    }
}