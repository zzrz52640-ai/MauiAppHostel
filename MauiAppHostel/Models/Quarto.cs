using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppHostel.Models
{
    public class Quarto
    {
        public string Descricao { get; set; } // Precisa ser exatamente igual ao XAML e ter { get; set; }
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }
    }
}
