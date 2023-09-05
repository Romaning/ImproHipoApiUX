using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Application.Models.Responses.ListaRapidaWebPageMain
{
    public /*abstract*/ class ProdViewModel
    {
        //public int ProdId { get; set; }

        //public int Codigo { get; set; }

        //public string? CodigoComercial { get; set; }

        //public string? CodigoMigracion { get; set; }

        public string? DescripcionCompleta { get; set; }

        public string? DescripcionCorta { get; set; }

        //public int TypeProdId { get; set; }

        //public DateTime? FechaAlta { get; set; }

        //public DateTime? FechaBaja { get; set; }

        //public int? StockMinimo { get; set; }

        //public decimal? EmpaqueMinimo { get; set; }

        //public decimal? MargenBeneficio { get; set; }

        //public decimal? MargenBeneficioPorcentual { get; set; }

        //public string? NombreGenerico { get; set; }

        //public string? NombreFabrica { get; set; }

        //public string? CodigoFabrica { get; set; }

        //public string? CodigoBarra { get; set; }

        //public string? Unidad { get; set; }

        //public decimal? Peso { get; set; }

        //public string? UnidadPeso { get; set; }

        //public decimal? PrecioBase { get; set; }

        //public int Estado { get; set; }

        //public int Oculto { get; set; }

        //public int Fraccionable { get; set; }

        //public int Liquidacion { get; set; }

        //public DateTime? FechaCambio { get; set; }

        //public decimal? Costo { get; set; }

        //public decimal? CostoUfv { get; set; }

        //public int? MarkId { get; set; }

        //public int? CategoryId { get; set; }

        //public decimal? VolumenEmbalaje { get; set; }

        //public decimal? VolumenSinEmbalaje { get; set; }

        //public decimal? VolumenExtra { get; set; }

        //public string? UnidadExtra { get; set; }

        //public decimal? CantidadPallet { get; set; }

        //public string? UnidadPallet { get; set; }

        //public decimal? VolumenPallet { get; set; }

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

        //[NotMapped]
        //[JsonIgnore]
        //public virtual TypeProdViewModel TypeProd { get; set; } = null!;
        //[JsonIgnore]
        //public virtual ClassProdViewModel ClassProd { get; set; } = null!;
        public string Clase { get; set; }
        public string Tipo { get; set; }

        //INFORMACION RAPIDA PARA PRODUCTO, la primera marca que encuentre de la lista
        public string Marca { get; set; }
        //INFORMACION RAPIDA PARA PRODUCTO, la primera marca que encuentre de la lista
        public string Modelo { get; set; }

        public string Industria { get; set; } = "No definido";
        //public string? DescripcionCorta { get; set; } = null;
        //ADICIONADO PARA LA BASE DE DATOS
        //public char? Database { get; set; } = char.MinValue;

        //[JsonIgnore]
        //public virtual ICollection<ShortProductDescViewModel> ShortProdDescs { get; set; } = new List<ShortProductDescViewModel>();

        //INFROMATIVO 
        public string Garantia { get; set; } = "3 Meses";
        public bool EnOferta { get; set; } = false;
        public decimal PorcentajeDescuento { get; set; } = 0; //se mostrara
        public bool MasVendido { get; set; } = false;

        //ADICIONADO
        [JsonIgnore]
        public virtual ICollection<AtributoViewModel> Atributos { get; set; } = new List<AtributoViewModel>();

        [JsonIgnore]
        public virtual ICollection<ColoresProdViewModel> Colores { get; set; } = new List<ColoresProdViewModel>();

        [JsonIgnore]
        public virtual ICollection<ArchivosImagenViewModel> Imagenes { get; set; } = new List<ArchivosImagenViewModel>();
        //$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
        //INFORMATIVO
        [JsonIgnore]
        public virtual ICollection<PriceViewModel> ProdsEspecYPrecios { get; set; } = new List<PriceViewModel>();

        ////INFORMATIVO
        [JsonIgnore]
        public virtual ICollection<MarkViewModel> Marcas { get; set; } = new List<MarkViewModel>();

        ////INFORMATIVO
        [JsonIgnore]
        public virtual ICollection<CategoryViewModel> Modelos { get; set; } = new List<CategoryViewModel>();

        ////INFORMATIVO
        //[JsonIgnore]
        public virtual ICollection<IndustryViewModel?> Industrias { get; set; } = null!;

        //ADICIONADO
        //[JsonIgnore]
        //public virtual ICollection<ResumenAttribsViewModel> ResumenAttribsViewModels { get; set; } = new List<ResumenAttribsViewModel>();
    }
}
