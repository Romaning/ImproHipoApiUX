using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common
{
    public /*abstract*/ class ProdBase
    {
        public int ProdId { get; set; }

        public int Codigo { get; set; }

        public string? CodigoComercial { get; set; }

        public string? CodigoMigracion { get; set; }

        public string? DescripcionCompleta { get; set; }

        public string? DescripcionCorta { get; set; }

        public int TypeProdId { get; set; }

        public DateTime? FechaAlta { get; set; }

        public DateTime? FechaBaja { get; set; }

        public int? StockMinimo { get; set; }

        public decimal? EmpaqueMinimo { get; set; }

        public decimal? MargenBeneficio { get; set; }

        public decimal? MargenBeneficioPorcentual { get; set; }

        public string? NombreGenerico { get; set; }

        public string? NombreFabrica { get; set; }

        public string? CodigoFabrica { get; set; }

        public string? CodigoBarra { get; set; }

        public string? Unidad { get; set; }

        public decimal? Peso { get; set; }

        public string? UnidadPeso { get; set; }

        public decimal? PrecioBase { get; set; }

        public int Estado { get; set; }

        public int Oculto { get; set; }

        public int Fraccionable { get; set; }

        public int Liquidacion { get; set; }

        public DateTime? FechaCambio { get; set; }

        public decimal? Costo { get; set; }

        public decimal? CostoUfv { get; set; }

        public int? MarkId { get; set; }

        public int? CategoryId { get; set; }

        public decimal? VolumenEmbalaje { get; set; }

        public decimal? VolumenSinEmbalaje { get; set; }

        public decimal? VolumenExtra { get; set; }

        public string? UnidadExtra { get; set; }

        public decimal? CantidadPallet { get; set; }

        public string? UnidadPallet { get; set; }

        public decimal? VolumenPallet { get; set; }

        public int? IndustryId { get; set; }

        /* MOMENTANEO
        public virtual ICollection<ArchivosProducto> ArchivosProductos { get; set; } = new List<ArchivosProducto>();

        public virtual Category? Category { get; set; }

        public virtual ICollection<DefaultValue> DefaultValues { get; set; } = new List<DefaultValue>();

        public virtual ICollection<IngresoDetalle> IngresoDetalles { get; set; } = new List<IngresoDetalle>();

        public virtual ICollection<IngresoInicialDetalle> IngresoInicialDetalles { get; set; } = new List<IngresoInicialDetalle>();

        public virtual ICollection<ItemsArmador> ItemsArmadors { get; set; } = new List<ItemsArmador>();

        public virtual ICollection<ItemsProducto> ItemsProductos { get; set; } = new List<ItemsProducto>();

        public virtual Mark? Mark { get; set; } //repeat

        public virtual ICollection<PedidoLocalDetalle> PedidoLocalDetalles { get; set; } = new List<PedidoLocalDetalle>();

        public virtual ICollection<PreGuardadoProducto> PreGuardadoProductos { get; set; } = new List<PreGuardadoProducto>();

        public virtual ICollection<ProveedorProductoProd> ProveedorProductoProds { get; set; } = new List<ProveedorProductoProd>();

        public virtual ICollection<RegistroCambioProducto> RegistroCambioProductos { get; set; } = new List<RegistroCambioProducto>();
        */
        [NotMapped]
        //[JsonIgnore]
        public virtual MarkBase? MarkBase { get; set; }

        [NotMapped]
        //[JsonIgnore]
        public virtual IndustryBase? IndustryBase { get; set; }

        [NotMapped]
        //[JsonIgnore]
        public virtual TypeProdBase TypeProdBase { get; set; } = null!;

        [NotMapped]
        //[JsonIgnore]
        public virtual CategoryBase? CategoryBase { get; set; }

        [NotMapped]
        //[JsonIgnore]
        public virtual ICollection<DefaultValueBase> DefaultValueBases { get; set; } = new List<DefaultValueBase>();

        [NotMapped]
        //[JsonIgnore]
        public virtual ICollection<ArchivosProductoBase> ArchivosProductoBases { get; set; } = new List<ArchivosProductoBase>();


        //ADICIONADO PARA LA BASE DE DATOS
        //public char? Database { get; set; } = char.MinValue;
    }
}
