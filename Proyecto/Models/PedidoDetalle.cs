using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class PedidoDetalle
    {
        [Key]
        [Required]
        public int PedidoDetalleId { get; set; }
        [Required]
        public int PedidoId { get; set; }
        [Required]
        public int ProductoId { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Descuento { get; set; }
        [Required]
        public decimal SubTotalLinea { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}