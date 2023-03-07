using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMiranda.ArqLimpia.BL.DTOs.UserDTOs
{
    public class CreateUserInputDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
