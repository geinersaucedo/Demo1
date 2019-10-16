using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace WebApiNetCoreEnterpriseLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        Database _localDbDefaul;

        public WeatherForecastController()
        {
  
            DatabaseProviderFactory providerFactoryDefault = new DatabaseProviderFactory();
            _localDbDefaul = providerFactoryDefault.Create("DefaultConnection");
        }
        public object getUsuarioSistema()
        {

            object[] Parameters = new object[] { };
            IRowMapper<Usuario> EntidadFileMapper = MapBuilder<Usuario>
                .MapNoProperties()
                .MapByName(prop => prop.CodRol)
                .MapByName(prop => prop.CodFuncion)
                .MapByName(prop => prop.DescripRol)
                 .Build();

            var listEntidad = _localDbDefaul.ExecuteSprocAccessor("TEST_SELECT", EntidadFileMapper, Parameters);
            return listEntidad.ToList();
        }


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


    }
}
