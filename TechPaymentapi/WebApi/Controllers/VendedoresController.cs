using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TechPaymentapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedoresController : Controller
    {
        private readonly IVendedoresService _service;

        public VendedoresController(IVendedoresService service)
        {
            _service = service;
        }
    }
}
