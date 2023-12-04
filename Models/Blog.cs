using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWithDB.Models
{

    //[Table("Blogs",Schema ="vb")]
    [Table("Blogs")]
    public class Blog
    {
        //[Column("Blog_Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 0)]
        public int BlogValue { get; set; }

        [Column(Order =1)]
        [MaxLength(200)]
        public string Url { get; set; }

        [Column(Order =3)]
        [Precision(7,2)]
        public decimal Rating { get; set; }



        [NotMapped]
        public string AlreadyData { get; set; }
    }
}
