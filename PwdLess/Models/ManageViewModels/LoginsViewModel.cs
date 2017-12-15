﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PwdLess.Models.ManageViewModels
{
    public class LoginsViewModel
    {
        public IList<UserLoginInfo> Logins { get; set; }
        
        [EmailAddress]
        public string EmailFromExternalProvider { get; set; }
    }
}