﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORM
{
    public class RepositoryConnector
    {
        public IConfiguration _configuration;

        public RepositoryConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConection()
        {
            return _configuration.GetSection("ConnectionStrings")
                .GetSection("ConnectionStringUdemy").Value;
        }
    }
}
