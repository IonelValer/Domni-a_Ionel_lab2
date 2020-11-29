using Domnița_Ionel_lab2.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryModel.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<LibraryModel.Models.Order> Orders { get; set; }
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


