using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Rental_webAPI.Model
{
    public class Book
    {
        public int Id { get; set; }
        
        public string Book_Tittle { get; set; }

        public string Book_Discription { get; set; }
       
        public decimal Price { get; set; }

        public string Author_Name { get; set; }

        public string Email_Id { get; set; }
    }
}
