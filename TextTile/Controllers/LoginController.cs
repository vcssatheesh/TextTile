using DBClass.DAO;
using Microsoft.AspNetCore.Mvc;

namespace TextTile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public ILogin _Login;
        public LoginController(ILogin Login)
        {
            _Login = Login;
        }

        [HttpPost, Route("LoginUser")]
        public async Task<bool> LoginUser(EntityObject.Entity.Users ObjLogin)
        {
            return await _Login.DoLogin(ObjLogin.UserName, ObjLogin.Password);
        }
    }
}
