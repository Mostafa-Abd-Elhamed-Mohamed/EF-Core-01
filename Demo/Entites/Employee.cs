using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entites
{

    // EF Core Support 4 Ways To Mapping Class In Database [Table - Function - View ]

    // 1. By Convention Way ---> [Default Behaviour]
    // 2. Data Annotation [Set Of Attributes Used For Data Validation]

    // POCO Class
    // Plain OLD CLR Object
    //Entity



    // Table
    //internal class Employee
    //{


    //    public int Id { get; set; }  // public Numberic property 'Id' | 'EmployeeId'  ---> PK  Identity (1,1)
    //    public string Name { get; set; }  //  Reference Type : nvarchar(max) - Required
    //    public int? Age { get; set; }  // int  Nullable Value Type : int(Age) - Optional

    //    public double Salary { get; set; }  // float : Value Type - Required
    //    public string? Address { get; set; }  // Nullable Reference Type - Optional

    //    public DateTime DateOfCreation { get; set; }   // datetime2


    //}


    // 2. Data Annotation


    //[Table("Hamada" , Schema = "dbo")]
   class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; }


        [Required]
        [Column("EmpName" , TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50 , MinimumLength =10)]
        public string Name { get; set; }


        [Range(20, 40)]
        public int? Age { get; set; }


        [Column(TypeName ="money")]  
        public double Salary { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]

        public string PhoneNumber { get; set; }

        [NotMapped]
        public double TotalSalary { get; set; }



    }








}
