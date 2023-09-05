using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class CostoImportacion
{
    public int CostoImportacionId { get; set; }

    public string? Concepto { get; set; }

    public int? EmpresaImportacionId { get; set; }

    public int? TipoDocImportacionId { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Retencion { get; set; }

    public decimal? Total { get; set; }

    public string? NroDocumentoConcepto { get; set; }

    public int? RequerimientoPedidoId { get; set; }

    public int? ConceptoCostoId { get; set; }

    public int MonedaId { get; set; }

    public virtual ConceptoCosto? ConceptoCosto { get; set; }

    public virtual EmpresaImportacion? EmpresaImportacion { get; set; }

    public virtual RequerimientoPedido? RequerimientoPedido { get; set; }

    public virtual TipoDocImportacion? TipoDocImportacion { get; set; }
}
