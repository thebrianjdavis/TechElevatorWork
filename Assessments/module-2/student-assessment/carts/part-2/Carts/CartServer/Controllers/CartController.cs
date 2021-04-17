using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carts;

namespace CartServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartDao cartDAO;

        CartController(ICartDao cartDao)
        {
            cartDAO = cartDao;
        }

        [HttpGet("carts")]
        public ActionResult<IList<Cart>> GetCarts()
        {
            IList<Cart> carts = cartDAO.GetAllCarts();
            return carts;
        }
    }
}
