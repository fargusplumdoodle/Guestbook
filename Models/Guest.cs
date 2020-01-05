using System;
using System.ComponentModel.DataAnnotations;

namespace GuestBook.Models
{
    public class Guest
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime SignedDate { get; set; }

    }
}