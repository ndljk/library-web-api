using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_web_api.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Nav properties
        public List<Book> Books { get; set; }
    }
}
