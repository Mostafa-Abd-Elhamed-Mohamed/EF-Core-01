using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment.Entites
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public DateTime Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Top_ID { get; set; }

    }
}
