using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobitelShop.Data;
using MobitelShop.Models;
using MobitelShop.ViewModels;

namespace MobitelShop.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]

    public class RacunController:ControllerBase
    {
        private readonly MojDbContext _dbContext;

        public RacunController(MojDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
