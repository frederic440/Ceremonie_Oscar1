using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Crud_Demo_UsingSQLIte.Models
{
    public class InviteModel
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Siege { get; set; }
    }
}