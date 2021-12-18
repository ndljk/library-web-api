﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_web_api.Data.ViewModels
{
    public class AuthorVM
    {
        public string FullName { get; set; }
    }

    public class AuthorWithBooksVM
    {
        public string FullName { get; set; }
        public List<string> BookTitles { get; set; }
    }
}
