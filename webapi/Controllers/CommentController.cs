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
    public class CommentController : ControllerBase
    {
        Connection conexao = new Connection();

        [HttpGet("{id}")]
        public List<CommentModel> get(int id)
        {
            return conexao.selectComment(id);
        }
    }
}