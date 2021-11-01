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
    public class GeoTarGetsController : ControllerBase
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

        public GeoTarGetsController()
        {
            _dbConnection = new MySqlConnection(_connectionString);
        }

        [HttpPost]
        public IActionResult Post([FromBody] RequestGeotargets RequestGeotargets)
        {

            string storeName = "get_geotargets_by_name";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("targetName", RequestGeotargets.targetName);
            var entities = _dbConnection.Query<ReponseGeotargets>(storeName, param: dynamicParameters, commandType: CommandType.StoredProcedure);
            return Ok(entities);
        }

    }
}
