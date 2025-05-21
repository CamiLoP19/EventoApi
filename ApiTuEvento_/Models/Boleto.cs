﻿using System.ComponentModel.DataAnnotations;

namespace ApiTuEvento_.Models
{
    public class Boleto
    {
        [Key] public int BoletoId { get; set; }
        public string NombreComprador { get; set; }
        public string TipoBoleto { get; set; } //VIP, comun, etc
        public string Descripcion {  get; set; }
        public double Precio { get; set; }
        public bool EstadoVenta {  get; set; } //no vendido, vendido
        public string? CodigoQR { get; set; }
        public string? CodigoAN { get; set; } //codigo alfanumerico irrepetible

        public int EventoId { get; set; }
        public Evento evento { get; set; }
        public int? PersonaId { get; set; } // apunta a Usuario.PersonaId
        public Persona? persona { get; set; }
    }

    public class BoletoDTO
    {
        public int BoletoId { get; set; }
        public string NombreComprador { get; set; }
        public string TipoBoleto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public bool EstadoVenta { get; set; }
        public string? CodigoQR { get; set; }
        public string? CodigoAN { get; set; }
        public int EventoId { get; set; }
        public int? PersonaId { get; set; }

    }

}
