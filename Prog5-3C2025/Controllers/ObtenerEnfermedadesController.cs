using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prog5_3C2025.Data;
using Prog5_3C2025.Models;


namespace MVCNOEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObtenerEnfermedadesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ObtenerEnfermedadesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [Route("ObtenerEnfermedades")]
        [HttpGet]
        public List<Enfermedades> ObtenerEnfermedades(string enfermedad)
        {
            return (from c in this._appDbContext.Enfermedades.Take(10)
                    where c.Enfermedad.StartsWith(enfermedad) || string.IsNullOrEmpty(enfermedad)
                    select c).ToList();
        }
    }
}

