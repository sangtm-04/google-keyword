using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_Google_Key_Words.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguageController : ControllerBase
    {
        protected string _tableName = "test";
        protected string _connectionString = "" +
               "Host=localhost; " +
               "Port=3306;" +
               "User Id= root; " +
               "Password=123456;" +
               "Database= test;" +
                "convert zero datetime=True";
        protected IDbConnection _dbConnection;

        public LanguageController()
        {
            _dbConnection = new MySqlConnection(_connectionString);
        }

        [HttpGet]
        public IActionResult Get()
        {
            string storeName = "get_all_language";
            var entity = _dbConnection.Query<ReponseLanguage>(storeName, commandType: CommandType.StoredProcedure);
            return Ok(entity);
        }

    }
}
