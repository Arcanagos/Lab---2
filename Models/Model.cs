using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Model
    {
        [Display(Name = "Imie")]
        public string Name { get; set; }
        [Display(Name = "Liczba dni od dnia urodzenia")]
        public string Days { get; set; }
        [Display(Name = "Liczba dni od dnia urodzenia")]
        public string BirthDate { get; set; }
        [Display(Name = "Rok przestępny?")]
        public bool Leap { get; set; }
    }
}
