﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string Username { get; set; }
        public string Password
        {
            get; set;
        }
    }
}
