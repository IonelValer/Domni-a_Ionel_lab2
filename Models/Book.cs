using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Domnița_Ionel_lab2.Models;

namespace Domnita_Ionel_Valer_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<Domnița_Ionel_lab2.Models.Order> Orders { get; set; }
        public ICollection<PublishedBook> PublishedBooks { get; set; }
        public class PublishedBook
        {
            public int PublisherID { get; set; }
            public int BookID { get; set; }
            public Publisher Publisher { get; set; }
            public Book Book { get; set; }
        }
    }
}


