using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Crud_Demo_UsingSQLIte.Models
{
    /// <summary>
    /// BDD local 
    /// </summary>
    public class InviteModel
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Siege { get; set; }

        // Données pour le serveur
        //[Newtonsoft.Json.JsonProperty("ID")]
        //public string ID { get; set; }

        //[Microsoft.WindowsAzure.MobileServices.Version]
        //public string AzureVersion { get; set; }

        //public DateTime DateUtc { get; set; }
        //public bool MadeAtHome { get; set; }

        //[Newtonsoft.Json.JsonIgnore]
        //public string DateDisplay { get { return DateUtc.ToLocalTime().ToString("d"); } }

        //[Newtonsoft.Json.JsonIgnore]
        //public string TimeDisplay { get { return DateUtc.ToLocalTime().ToString("t"); } }
    }
}