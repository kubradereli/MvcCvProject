//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCvProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TblEgitimlerim
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alan� bo� ge�emezsiniz.")]
        public string Baslik { get; set; }

        public string AltBaslik1 { get; set; }

        public string AltBaslik2 { get; set; }

        [StringLength(10, ErrorMessage ="L�tfen en fazla 10 karakterlik veri giri�i yap�n�z.")]
        public string GNO { get; set; }

        public string Tarih { get; set; }
    }
}
