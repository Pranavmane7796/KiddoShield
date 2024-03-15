namespace Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    public class Doctor
    {
        [Key]
        [Column("did", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Did { get; set; }

        [Column("dfname", TypeName = "nvarchar(255)")]
        [Required]
        public string Dfname { get; set; }

        [Column("dlname", TypeName = "nvarchar(255)")]
        [Required]
        public string Dlname { get; set; }

        [Column("contact", TypeName = "nvarchar(255)")]
        [Required]
        public string Contact { get; set; }

        [Column("specialization", TypeName = "nvarchar(255)")]
        [Required]
        public string Specialization { get; set; }

        [ForeignKey("Hospital")]
        [Required]
        public int Hid { get; set; }
        public Hospital Hospital { get; set; }

        [Column("email", TypeName = "nvarchar(255)")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Column("password", TypeName = "nvarchar(255)")]
        [Required]
        public string Password { get; set; }

        [JsonIgnore] // Assuming you're using Newtonsoft.Json for serialization
        public ICollection<ConsultationAppointment> ConsultationAppointments { get; set; }
    }
