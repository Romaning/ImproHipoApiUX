using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Hipotina;

public partial class Prod : ProdBase
{
    //public int ProdId { get; set; }

    //public int Codigo { get; set; }

    //public string? CodigoComercial { get; set; }

    //public string? CodigoMigracion { get; set; }

    //public string? DescripcionCompleta { get; set; }

    //public string? DescripcionCorta { get; set; }

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

    //public int Produccion { get; set; }

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

    public string? CodigoHomologadoSin { get; set; }

    public string? CodigoActEcoSin { get; set; }

    public int CodigoUniMedidaSin { get; set; }

    public string? DescUniMedidaSin { get; set; }
    [JsonIgnore]
    public virtual ICollection<AccesoriosCambioProd> AccesoriosCambioProds { get; set; } = new List<AccesoriosCambioProd>();
    [JsonIgnore]
    public virtual ICollection<AccesoriosProd> AccesoriosProds { get; set; } = new List<AccesoriosProd>();
    [JsonIgnore]
    public virtual ICollection<ArchivosProducto> ArchivosProductos { get; set; } = new List<ArchivosProducto>();
    [JsonIgnore]
    public virtual Category? Category { get; set; }
    [JsonIgnore]
    public virtual ICollection<ColorProd> ColorProds { get; set; } = new List<ColorProd>();
    [JsonIgnore]
    public virtual ICollection<DefaultValue> DefaultValues { get; set; } = new List<DefaultValue>();
    [JsonIgnore]
    public virtual ICollection<EquipamientoProd> EquipamientoProds { get; set; } = new List<EquipamientoProd>();
    [JsonIgnore]
    public virtual ICollection<IngresoDetalle> IngresoDetalles { get; set; } = new List<IngresoDetalle>();
    [JsonIgnore]
    public virtual ICollection<IngresoInicialDetalle> IngresoInicialDetalles { get; set; } = new List<IngresoInicialDetalle>();
    [JsonIgnore]
    public virtual ICollection<ItemsArmador> ItemsArmadors { get; set; } = new List<ItemsArmador>();
    [JsonIgnore]
    public virtual ICollection<ItemsProducto> ItemsProductos { get; set; } = new List<ItemsProducto>();
    [JsonIgnore]
    public virtual Mark? Mark { get; set; }
    [JsonIgnore]
    public virtual ICollection<PedidoLocalDetalle> PedidoLocalDetalles { get; set; } = new List<PedidoLocalDetalle>();
    [JsonIgnore]
    public virtual ICollection<Plantilla> Plantillas { get; set; } = new List<Plantilla>();
    [JsonIgnore]
    public virtual ICollection<PosicionFaldon> PosicionFaldons { get; set; } = new List<PosicionFaldon>();
    [JsonIgnore]
    public virtual ICollection<PreGuardadoProducto> PreGuardadoProductos { get; set; } = new List<PreGuardadoProducto>();
    [JsonIgnore]
    public virtual ICollection<ProductoGrafico> ProductoGraficos { get; set; } = new List<ProductoGrafico>();
    [JsonIgnore]
    public virtual ICollection<ProveedorProductoProd> ProveedorProductoProds { get; set; } = new List<ProveedorProductoProd>();
    [JsonIgnore]
    public virtual ICollection<RegistroCambioProducto> RegistroCambioProductos { get; set; } = new List<RegistroCambioProducto>();
    [JsonIgnore]
    public virtual TypeProd TypeProd { get; set; } = null!;

    [JsonIgnore]
    public virtual Industry? Industry { get; set; }
    //ADICIONADO PARA LA BASE DE DATOS
    [NotMapped]
    public char? DatabaseEspecific { get; set; } = 'H';
}
