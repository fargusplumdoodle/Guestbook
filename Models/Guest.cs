using System;
using System.ComponentModel.DataAnnotations;

namespace GuestBook.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime SignedDate { get; set; }
    }
}
