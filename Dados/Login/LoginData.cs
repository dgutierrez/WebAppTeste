using Dados.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Login
{
    public class LoginData : ILoginData
    {
        IConfiguration _configuration;
        public LoginData(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string TestaConexao()
        {
            return _configuration.GetConnectionString("Login");
        }
    }
}
