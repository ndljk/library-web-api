using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_web_api.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Nav props, posto je veza n-n potreban je join model
        public List<Book_Author> Book_Authors { get; set; }
    }
}
