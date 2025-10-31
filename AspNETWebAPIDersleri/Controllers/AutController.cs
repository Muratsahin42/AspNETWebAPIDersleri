using AspNETWebAPIDersleri.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AspNETWebAPIDersleri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutController : ControllerBase
    {
        [HttpPost()]
        public ResponseModel Login(LoginModel loginModel)
        {
            if (loginModel.Username == "Murat" && loginModel.Password == "123")
            {
                return new ResponseModel()
                {
                    Message = "Giriş işlemi  başarılı",
                    Code = "200",
                    Data = null
                };
            }

            return new ResponseModel()
            {
                Message = "Giriş işlemi  başarısız",
                Code = "401",
                Data = null
            };
        }
    }
}
