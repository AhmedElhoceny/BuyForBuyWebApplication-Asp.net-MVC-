﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElMarket.ViewModels
{
    public class SignUpUserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string password { get; set; }
        public string ConfirmPassWord { get; set; }
    }
}