using System;
using System.Collections.Generic;
using Domain.Entities.Improcons;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DbContexts;

public partial class ApplicationDbImproContext : DbContext
{
    public ApplicationDbImproContext()
    {
    }

    public ApplicationDbImproContext(DbContextOptions<ApplicationDbImproContext> options)
        : base(options)
    {
        this.ChangeTracker.LazyLoadingEnabled = false;
    }

    public virtual DbSet<Access> Accesses { get; set; }

    public virtual DbSet<AccessClasificatorValue> AccessClasificatorValues { get; set; }

    public virtual DbSet<Activo> Activos { get; set; }

    public virtual DbSet<AddressIp> AddressIps { get; set; }

    public virtual DbSet<Afp> Afps { get; set; }

    public virtual DbSet<Ajuste> Ajustes { get; set; }

    public virtual DbSet<AjusteDetalle> AjusteDetalles { get; set; }

    public virtual DbSet<Almacen> Almacens { get; set; }

    public virtual DbSet<AlmacenActivo> AlmacenActivos { get; set; }

    public virtual DbSet<AlmacenAf> AlmacenAfs { get; set; }

    public virtual DbSet<AlmacenProducto> AlmacenProductos { get; set; }

    public virtual DbSet<AltaActivo> AltaActivos { get; set; }

    public virtual DbSet<AltaDetalle> AltaDetalles { get; set; }

    public virtual DbSet<AltaDetalleActivo> AltaDetalleActivos { get; set; }

    public virtual DbSet<Altum> Alta { get; set; }

    public virtual DbSet<Anticipo> Anticipos { get; set; }

    public virtual DbSet<ArchivosProducto> ArchivosProductos { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AreaAux> AreaAuxes { get; set; }

    public virtual DbSet<Armador> Armadors { get; set; }

    public virtual DbSet<AsignaPuntoVentum> AsignaPuntoVenta { get; set; }

    public virtual DbSet<AsignacionVehiculoChofer> AsignacionVehiculoChofers { get; set; }

    public virtual DbSet<AsistenciaLog> AsistenciaLogs { get; set; }

    public virtual DbSet<Asistencium> Asistencia { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<Baja> Bajas { get; set; }

    public virtual DbSet<BajaActivo> BajaActivos { get; set; }

    public virtual DbSet<BajaDetalle> BajaDetalles { get; set; }

    public virtual DbSet<BajaDetalleActivo> BajaDetalleActivos { get; set; }

    public virtual DbSet<BancoProveedor> BancoProveedors { get; set; }

    public virtual DbSet<BeneficiarioProveedor> BeneficiarioProveedors { get; set; }

    public virtual DbSet<Biometrico> Biometricos { get; set; }

    public virtual DbSet<BloqueoInventario> BloqueoInventarios { get; set; }

    public virtual DbSet<CanalDistribucion> CanalDistribucions { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Categorizacion> Categorizacions { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<ClaseActivo> ClaseActivos { get; set; }

    public virtual DbSet<ClaseCliente> ClaseClientes { get; set; }

    public virtual DbSet<ClaseDocumento> ClaseDocumentos { get; set; }

    public virtual DbSet<ClaseDocumentoActivo> ClaseDocumentoActivos { get; set; }

    public virtual DbSet<ClasificacionActivo> ClasificacionActivos { get; set; }

    public virtual DbSet<Clasificator> Clasificators { get; set; }

    public virtual DbSet<ClasificatorModule> ClasificatorModules { get; set; }

    public virtual DbSet<ClasificatorValue> ClasificatorValues { get; set; }

    public virtual DbSet<ClassProd> ClassProds { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteProyecto> ClienteProyectos { get; set; }

    public virtual DbSet<Cobranza> Cobranzas { get; set; }

    public virtual DbSet<CobranzaItem> CobranzaItems { get; set; }

    public virtual DbSet<Colore> Colores { get; set; }

    public virtual DbSet<Comision> Comisions { get; set; }

    public virtual DbSet<ComisionExcel> ComisionExcels { get; set; }

    public virtual DbSet<ComprobanteActivo> ComprobanteActivos { get; set; }

    public virtual DbSet<CompromisoProd> CompromisoProds { get; set; }

    public virtual DbSet<CompromisoUnidad> CompromisoUnidads { get; set; }

    public virtual DbSet<CompromisoVenta> CompromisoVentas { get; set; }

    public virtual DbSet<ConceptoCosto> ConceptoCostos { get; set; }

    public virtual DbSet<Conductor> Conductors { get; set; }

    public virtual DbSet<ContactoNacional> ContactoNacionals { get; set; }

    public virtual DbSet<ContactoProveedor> ContactoProveedors { get; set; }

    public virtual DbSet<CorreoCliente> CorreoClientes { get; set; }

    public virtual DbSet<CostoImportacion> CostoImportacions { get; set; }

    public virtual DbSet<Cotizacion> Cotizacions { get; set; }

    public virtual DbSet<CotizacionItem> CotizacionItems { get; set; }

    public virtual DbSet<CotizacionProyecto> CotizacionProyectos { get; set; }

    public virtual DbSet<CreditoCliente> CreditoClientes { get; set; }

    public virtual DbSet<CreditoDebito> CreditoDebitos { get; set; }

    public virtual DbSet<CreditoDebitoDetalle> CreditoDebitoDetalles { get; set; }

    public virtual DbSet<DefaultAttrib> DefaultAttribs { get; set; }

    public virtual DbSet<DefaultDomain> DefaultDomains { get; set; }

    public virtual DbSet<DefaultValue> DefaultValues { get; set; }

    public virtual DbSet<DeprecActActivo> DeprecActActivos { get; set; }

    public virtual DbSet<DeprecActDetalleActivo> DeprecActDetalleActivos { get; set; }

    public virtual DbSet<DescuentoComercial> DescuentoComercials { get; set; }

    public virtual DbSet<Despachante> Despachantes { get; set; }

    public virtual DbSet<DespachanteActivo> DespachanteActivos { get; set; }

    public virtual DbSet<DetalleActivo> DetalleActivos { get; set; }

    public virtual DbSet<DetalleProveedorProducto> DetalleProveedorProductos { get; set; }

    public virtual DbSet<DetalleSolicitudVendedor> DetalleSolicitudVendedors { get; set; }

    public virtual DbSet<Devolucion> Devolucions { get; set; }

    public virtual DbSet<DireccionCliente> DireccionClientes { get; set; }

    public virtual DbSet<DireccionEntrega> DireccionEntregas { get; set; }

    public virtual DbSet<DireccionNacional> DireccionNacionals { get; set; }

    public virtual DbSet<DireccionProveedor> DireccionProveedors { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<DocumentoActivo> DocumentoActivos { get; set; }

    public virtual DbSet<DocumentoRrhh> DocumentoRrhhs { get; set; }

    public virtual DbSet<Egreso> Egresos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<EmpleadoAux> EmpleadoAuxes { get; set; }

    public virtual DbSet<EmpleadoBiometrico> EmpleadoBiometricos { get; set; }

    public virtual DbSet<EmpleadoLog> EmpleadoLogs { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EmpresaImportacion> EmpresaImportacions { get; set; }

    public virtual DbSet<Entrega> Entregas { get; set; }

    public virtual DbSet<EntregaObservacion> EntregaObservacions { get; set; }

    public virtual DbSet<EscalaAntiguedad> EscalaAntiguedads { get; set; }

    public virtual DbSet<EscalaDescuento> EscalaDescuentos { get; set; }

    public virtual DbSet<EscalaVacacion> EscalaVacacions { get; set; }

    public virtual DbSet<EstadoMovimiento> EstadoMovimientos { get; set; }

    public virtual DbSet<EstadoMovimientoOperacion> EstadoMovimientoOperacions { get; set; }

    public virtual DbSet<EstadoProducto> EstadoProductos { get; set; }

    public virtual DbSet<EstadoSolicitudTraspaso> EstadoSolicitudTraspasos { get; set; }

    public virtual DbSet<EstructuraPersonal> EstructuraPersonals { get; set; }

    public virtual DbSet<EstructuraPersonalAux> EstructuraPersonalAuxes { get; set; }

    public virtual DbSet<EstructuraPersonalLog> EstructuraPersonalLogs { get; set; }

    public virtual DbSet<Fabrica> Fabricas { get; set; }

    public virtual DbSet<FabricaTrader> FabricaTraders { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaComision> FacturaComisions { get; set; }

    public virtual DbSet<FaltasLog> FaltasLogs { get; set; }

    public virtual DbSet<FechaEspecial> FechaEspecials { get; set; }

    public virtual DbSet<Garante> Garantes { get; set; }

    public virtual DbSet<Gestion> Gestions { get; set; }

    public virtual DbSet<HabilitaCobranza> HabilitaCobranzas { get; set; }

    public virtual DbSet<HabilitadorPlanilla> HabilitadorPlanillas { get; set; }

    public virtual DbSet<HistoricoDistribuidore> HistoricoDistribuidores { get; set; }

    public virtual DbSet<HistoricoFacturaComision> HistoricoFacturaComisions { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<IncrementoVacacion> IncrementoVacacions { get; set; }

    public virtual DbSet<Industry> Industries { get; set; }

    public virtual DbSet<Ingreso> Ingresos { get; set; }

    public virtual DbSet<IngresoDetalle> IngresoDetalles { get; set; }

    public virtual DbSet<IngresoInicialDetalle> IngresoInicialDetalles { get; set; }

    public virtual DbSet<ItemsArmador> ItemsArmadors { get; set; }

    public virtual DbSet<ItemsProducto> ItemsProductos { get; set; }

    public virtual DbSet<Justificativo> Justificativos { get; set; }

    public virtual DbSet<JustificativoDetalle> JustificativoDetalles { get; set; }

    public virtual DbSet<LogTransaccion> LogTransaccions { get; set; }

    public virtual DbSet<Mark> Marks { get; set; }

    public virtual DbSet<MatrizMigracion> MatrizMigracions { get; set; }

    public virtual DbSet<MetaUnidad> MetaUnidads { get; set; }

    public virtual DbSet<MetaVendedor> MetaVendedors { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<ModuleOperation> ModuleOperations { get; set; }

    public virtual DbSet<Monedum> Moneda { get; set; }

    public virtual DbSet<Movimiento> Movimientos { get; set; }

    public virtual DbSet<MovimientoActivo> MovimientoActivos { get; set; }

    public virtual DbSet<MovimientoDetalle> MovimientoDetalles { get; set; }

    public virtual DbSet<MovimientoDetalleActivo> MovimientoDetalleActivos { get; set; }

    public virtual DbSet<Nacional> Nacionals { get; set; }

    public virtual DbSet<NivelAcademico> NivelAcademicos { get; set; }

    public virtual DbSet<NoConformidad> NoConformidads { get; set; }

    public virtual DbSet<NotaComision> NotaComisions { get; set; }

    public virtual DbSet<NotaDc> NotaDcs { get; set; }

    public virtual DbSet<NotasCreditoDebito> NotasCreditoDebitos { get; set; }

    public virtual DbSet<NumeroDocumento> NumeroDocumentos { get; set; }

    public virtual DbSet<NumeroDocumentoActivo> NumeroDocumentoActivos { get; set; }

    public virtual DbSet<PackProducto> PackProductos { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<Parcial> Parcials { get; set; }

    public virtual DbSet<ParcialDetalle> ParcialDetalles { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PedidoCobranza> PedidoCobranzas { get; set; }

    public virtual DbSet<PedidoItem> PedidoItems { get; set; }

    public virtual DbSet<PedidoLocal> PedidoLocals { get; set; }

    public virtual DbSet<PedidoLocalDetalle> PedidoLocalDetalles { get; set; }

    public virtual DbSet<PedidoProveedor> PedidoProveedors { get; set; }

    public virtual DbSet<PedidoProveedorItem> PedidoProveedorItems { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Planilla> Planillas { get; set; }

    public virtual DbSet<PlanillaAuxiliar> PlanillaAuxiliars { get; set; }

    public virtual DbSet<PlanillaDetalle> PlanillaDetalles { get; set; }

    public virtual DbSet<PlanillaImpositiva> PlanillaImpositivas { get; set; }

    public virtual DbSet<PreGuardadoProducto> PreGuardadoProductos { get; set; }

    public virtual DbSet<PrecioClientePreferencial> PrecioClientePreferencials { get; set; }

    public virtual DbSet<PrecioDiferenciado> PrecioDiferenciados { get; set; }

    public virtual DbSet<PrecioDiferenciadoCliente> PrecioDiferenciadoClientes { get; set; }

    public virtual DbSet<PrecioMarcaCliente> PrecioMarcaClientes { get; set; }

    public virtual DbSet<Prepedido> Prepedidos { get; set; }

    public virtual DbSet<PrepedidoItem> PrepedidoItems { get; set; }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<PrestamoDetalle> PrestamoDetalles { get; set; }

    public virtual DbSet<Prod> Prods { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Profesion> Profesions { get; set; }

    public virtual DbSet<ProfesionOficio> ProfesionOficios { get; set; }

    public virtual DbSet<Proforma> Proformas { get; set; }

    public virtual DbSet<ProformaItem> ProformaItems { get; set; }

    public virtual DbSet<ProformaProveedor> ProformaProveedors { get; set; }

    public virtual DbSet<ProformaProveedorDetalle> ProformaProveedorDetalles { get; set; }

    public virtual DbSet<ProformaProveedorItem> ProformaProveedorItems { get; set; }

    public virtual DbSet<Prospecto> Prospectos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<ProveedorFabrica> ProveedorFabricas { get; set; }

    public virtual DbSet<ProveedorNacional> ProveedorNacionals { get; set; }

    public virtual DbSet<ProveedorProdRel> ProveedorProdRels { get; set; }

    public virtual DbSet<ProveedorProducto> ProveedorProductos { get; set; }

    public virtual DbSet<ProveedorProductoProd> ProveedorProductoProds { get; set; }

    public virtual DbSet<ProveedorTrader> ProveedorTraders { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    public virtual DbSet<ProyectoDetallePedido> ProyectoDetallePedidos { get; set; }

    public virtual DbSet<PuntoVentum> PuntoVenta { get; set; }

    public virtual DbSet<RegistroBaja> RegistroBajas { get; set; }

    public virtual DbSet<RegistroBiometrico> RegistroBiometricos { get; set; }

    public virtual DbSet<RegistroCambioLista> RegistroCambioListas { get; set; }

    public virtual DbSet<RegistroCambioProducto> RegistroCambioProductos { get; set; }

    public virtual DbSet<RegistroCliente> RegistroClientes { get; set; }

    public virtual DbSet<RegistroMetaCliente> RegistroMetaClientes { get; set; }

    public virtual DbSet<Relacionador> Relacionadors { get; set; }

    public virtual DbSet<RequerimientoPedido> RequerimientoPedidos { get; set; }

    public virtual DbSet<RequerimientoPedidoItem> RequerimientoPedidoItems { get; set; }

    public virtual DbSet<RequerimientoPedidoItemsComplemento> RequerimientoPedidoItemsComplementos { get; set; }

    public virtual DbSet<RolModule> RolModules { get; set; }

    public virtual DbSet<RubroComercial> RubroComercials { get; set; }

    public virtual DbSet<Sancion> Sancions { get; set; }

    public virtual DbSet<SancionDetalle> SancionDetalles { get; set; }

    public virtual DbSet<SeguroSocial> SeguroSocials { get; set; }

    public virtual DbSet<Solicitante> Solicitantes { get; set; }

    public virtual DbSet<SolicitanteActivo> SolicitanteActivos { get; set; }

    public virtual DbSet<SolicitudTraspaso> SolicitudTraspasos { get; set; }

    public virtual DbSet<SolicitudTraspasoActivo> SolicitudTraspasoActivos { get; set; }

    public virtual DbSet<SolicitudVendedor> SolicitudVendedors { get; set; }

    public virtual DbSet<SubSystem> SubSystems { get; set; }

    public virtual DbSet<Talonario> Talonarios { get; set; }

    public virtual DbSet<TecnicoCliente> TecnicoClientes { get; set; }

    public virtual DbSet<TipoActivo> TipoActivos { get; set; }

    public virtual DbSet<TipoAlmacen> TipoAlmacens { get; set; }

    public virtual DbSet<TipoArchivoProducto> TipoArchivoProductos { get; set; }

    public virtual DbSet<TipoBancoProveedor> TipoBancoProveedors { get; set; }

    public virtual DbSet<TipoCargo> TipoCargos { get; set; }

    public virtual DbSet<TipoCliente> TipoClientes { get; set; }

    public virtual DbSet<TipoComprobanteActivo> TipoComprobanteActivos { get; set; }

    public virtual DbSet<TipoConceptoCosto> TipoConceptoCostos { get; set; }

    public virtual DbSet<TipoDetalleActivo> TipoDetalleActivos { get; set; }

    public virtual DbSet<TipoDireccion> TipoDireccions { get; set; }

    public virtual DbSet<TipoDocImportacion> TipoDocImportacions { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoDocumentoActivo> TipoDocumentoActivos { get; set; }

    public virtual DbSet<TipoEmpresa> TipoEmpresas { get; set; }

    public virtual DbSet<TipoEmpresaImportacion> TipoEmpresaImportacions { get; set; }

    public virtual DbSet<TipoFechaEspecial> TipoFechaEspecials { get; set; }

    public virtual DbSet<TipoMovimiento> TipoMovimientos { get; set; }

    public virtual DbSet<TipoMovimientoActivo> TipoMovimientoActivos { get; set; }

    public virtual DbSet<TipoMovimientoPersonal> TipoMovimientoPersonals { get; set; }

    public virtual DbSet<TipoMovimientoVacacion> TipoMovimientoVacacions { get; set; }

    public virtual DbSet<TipoPermiso> TipoPermisos { get; set; }

    public virtual DbSet<TipoPlanilla> TipoPlanillas { get; set; }

    public virtual DbSet<TipoProveedor> TipoProveedors { get; set; }

    public virtual DbSet<TipoRelacionador> TipoRelacionadors { get; set; }

    public virtual DbSet<TipoSolicitudVendedor> TipoSolicitudVendedors { get; set; }

    public virtual DbSet<TmpIp01> TmpIp01s { get; set; }

    public virtual DbSet<Trader> Traders { get; set; }

    public virtual DbSet<TraduccionIdentificacion> TraduccionIdentificacions { get; set; }

    public virtual DbSet<Transporte> Transportes { get; set; }

    public virtual DbSet<TraspasoActivo> TraspasoActivos { get; set; }

    public virtual DbSet<TraspasoActivoDet> TraspasoActivoDets { get; set; }

    public virtual DbSet<TraspasoNegociacion> TraspasoNegociacions { get; set; }

    public virtual DbSet<TraspasoNegociacionActivo> TraspasoNegociacionActivos { get; set; }

    public virtual DbSet<TraspasoProducto> TraspasoProductos { get; set; }

    public virtual DbSet<TraspasoProductoDet> TraspasoProductoDets { get; set; }

    public virtual DbSet<TypeProd> TypeProds { get; set; }

    public virtual DbSet<Ufv> Ufvs { get; set; }

    public virtual DbSet<UfvAnual> UfvAnuals { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<UnidadComision> UnidadComisions { get; set; }

    public virtual DbSet<UnidadProducto> UnidadProductos { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<UnitUser> UnitUsers { get; set; }

    public virtual DbSet<UsoProducto> UsoProductos { get; set; }

    public virtual DbSet<VDefattrib> VDefattribs { get; set; }

    public virtual DbSet<VProducto> VProductos { get; set; }

    public virtual DbSet<VProductoDisponible> VProductoDisponibles { get; set; }

    public virtual DbSet<VReporteDisponibilidad> VReporteDisponibilidads { get; set; }

    public virtual DbSet<VSeguridad> VSeguridads { get; set; }

    public virtual DbSet<VSeguridad2> VSeguridad2s { get; set; }

    public virtual DbSet<Vacacion> Vacacions { get; set; }

    public virtual DbSet<VacacionDetalle> VacacionDetalles { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<VerProd> VerProds { get; set; }

    public virtual DbSet<VerSeguridad> VerSeguridads { get; set; }

    public virtual DbSet<VerVproductoDisponible> VerVproductoDisponibles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Access>(entity =>
        {
            entity.HasKey(e => e.AccessId).HasName("PK_dbo.Access");

            entity.ToTable("Access");

            entity.HasIndex(e => e.ApplicationRoleId, "IX_ApplicationRoleId");

            entity.HasIndex(e => e.ApplicationUserId, "IX_ApplicationUserId");

            entity.Property(e => e.ApplicationRoleId).HasMaxLength(128);
            entity.Property(e => e.ApplicationUserId).HasMaxLength(128);

            entity.HasOne(d => d.ApplicationRole).WithMany(p => p.Accesses)
                .HasForeignKey(d => d.ApplicationRoleId)
                .HasConstraintName("FK_dbo.Access_dbo.AspNetRoles_ApplicationRoleId");

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.Accesses)
                .HasForeignKey(d => d.ApplicationUserId)
                .HasConstraintName("FK_dbo.Access_dbo.AspNetUsers_ApplicationUserId");
        });

        modelBuilder.Entity<AccessClasificatorValue>(entity =>
        {
            entity.HasKey(e => e.AccessClasificatorValueId).HasName("PK_dbo.AccessClasificatorValue");

            entity.ToTable("AccessClasificatorValue");

            entity.HasIndex(e => e.AccessId, "IX_AccessId");

            entity.HasIndex(e => e.ClasificatorValueId, "IX_ClasificatorValueId");

            entity.HasOne(d => d.Access).WithMany(p => p.AccessClasificatorValues)
                .HasForeignKey(d => d.AccessId)
                .HasConstraintName("FK_dbo.AccessClasificatorValue_dbo.Access_AccessId");

            entity.HasOne(d => d.ClasificatorValue).WithMany(p => p.AccessClasificatorValues)
                .HasForeignKey(d => d.ClasificatorValueId)
                .HasConstraintName("FK_dbo.AccessClasificatorValue_dbo.ClasificatorValue_ClasificatorValueId");
        });

        modelBuilder.Entity<Activo>(entity =>
        {
            entity.HasKey(e => e.ActivoId).HasName("PK_dbo.Activo");

            entity.ToTable("Activo");

            entity.HasIndex(e => e.AreaId, "IX_AreaId");

            entity.HasIndex(e => e.ClasificacionActivoId, "IX_ClasificacionActivoId");

            entity.HasIndex(e => e.ComprobanteActivoId, "IX_ComprobanteActivoId");

            entity.HasIndex(e => e.EmpresaId, "IX_EmpresaId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasIndex(e => e.TipoActivoId, "IX_TipoActivoId");

            entity.HasIndex(e => e.TipoDetalleActivoId, "IX_TipoDetalleActivoId");

            entity.HasIndex(e => e.UnidadProductoId, "IX_UnidadProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaIncorporacion).HasColumnType("datetime");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Area).WithMany(p => p.Activos)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_dbo.Activo_dbo.Area_AreaId");

            entity.HasOne(d => d.ClasificacionActivo).WithMany(p => p.Activos)
                .HasForeignKey(d => d.ClasificacionActivoId)
                .HasConstraintName("FK_dbo.Activo_dbo.ClasificacionActivo_ClasificacionActivoId");

            entity.HasOne(d => d.ComprobanteActivo).WithMany(p => p.Activos)
                .HasForeignKey(d => d.ComprobanteActivoId)
                .HasConstraintName("FK_dbo.Activo_dbo.ComprobanteActivo_ComprobanteActivoId");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Activos)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK_dbo.Activo_dbo.Empresa_EmpresaId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Activos)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_dbo.Activo_dbo.Proveedor_ProveedorId");

            entity.HasOne(d => d.TipoActivo).WithMany(p => p.Activos)
                .HasForeignKey(d => d.TipoActivoId)
                .HasConstraintName("FK_dbo.Activo_dbo.TipoActivo_TipoActivoId");

            entity.HasOne(d => d.UnidadProducto).WithMany(p => p.Activos)
                .HasForeignKey(d => d.UnidadProductoId)
                .HasConstraintName("FK_dbo.Activo_dbo.UnidadProducto_UnidadProductoId");
        });

        modelBuilder.Entity<AddressIp>(entity =>
        {
            entity.HasKey(e => e.AddressIpId).HasName("PK_dbo.AddressIP");

            entity.ToTable("AddressIP");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.AddressIps)
                .HasForeignKey(d => d.UnidadId)
                .HasConstraintName("FK_dbo.AddressIP_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<Afp>(entity =>
        {
            entity.HasKey(e => e.AfpId).HasName("PK_dbo.Afp");

            entity.ToTable("Afp");
        });

        modelBuilder.Entity<Ajuste>(entity =>
        {
            entity.HasKey(e => e.AjusteId).HasName("PK_dbo.Ajuste");

            entity.ToTable("Ajuste");

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.DocumentoId, "IX_DocumentoId");

            entity.HasIndex(e => e.MonedaId, "IX_MonedaId");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.TotalA).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.TotalB).HasColumnType("decimal(12, 4)");

            entity.HasOne(d => d.Almacen).WithMany(p => p.Ajustes)
                .HasForeignKey(d => d.AlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Ajuste_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.Documento).WithMany(p => p.Ajustes)
                .HasForeignKey(d => d.DocumentoId)
                .HasConstraintName("FK_dbo.Ajuste_dbo.Documento_DocumentoId");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Ajustes)
                .HasForeignKey(d => d.MonedaId)
                .HasConstraintName("FK_dbo.Ajuste_dbo.Moneda_MonedaId");
        });

        modelBuilder.Entity<AjusteDetalle>(entity =>
        {
            entity.HasKey(e => e.AjusteDetalleId).HasName("PK_dbo.AjusteDetalle");

            entity.ToTable("AjusteDetalle");

            entity.HasIndex(e => e.AjusteId, "IX_AjusteId");

            entity.HasIndex(e => e.AlmacenProductoId, "IX_AlmacenProductoId");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.CostoIngreso).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.NuevoCosto).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.Obs)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Tajuste).HasColumnName("TAjuste");
            entity.Property(e => e.TipoAjuste)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Ajuste).WithMany(p => p.AjusteDetalles)
                .HasForeignKey(d => d.AjusteId)
                .HasConstraintName("FK_dbo.AjusteDetalle_dbo.Ajuste_AjusteId");

            entity.HasOne(d => d.AlmacenProducto).WithMany(p => p.AjusteDetalles)
                .HasForeignKey(d => d.AlmacenProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.AjusteDetalle_dbo.AlmacenProducto_AlmacenProductoId");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.AjusteDetalles)
                .HasForeignKey(d => d.EstadoProductoId)
                .HasConstraintName("FK_dbo.AjusteDetalle_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.AjusteDetalles)
                .HasForeignKey(d => d.UsoProductoId)
                .HasConstraintName("FK_dbo.AjusteDetalle_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<Almacen>(entity =>
        {
            entity.HasKey(e => e.AlmacenId).HasName("PK_dbo.Almacen");

            entity.ToTable("Almacen");

            entity.HasIndex(e => e.TipoAlmacenId, "IX_TipoAlmacenId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.Property(e => e.Nombre)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.NombreCorto)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoAlmacen).WithMany(p => p.Almacens)
                .HasForeignKey(d => d.TipoAlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Almacen_dbo.TipoAlmacen_TipoAlmacenId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.Almacens)
                .HasForeignKey(d => d.UnidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Almacen_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<AlmacenActivo>(entity =>
        {
            entity.HasKey(e => e.AlmacenActivoId).HasName("PK_dbo.AlmacenActivo");

            entity.ToTable("AlmacenActivo");

            entity.HasIndex(e => e.ActivoId, "IX_ActivoId");

            entity.HasIndex(e => e.AlmacenAfid, "IX_AlmacenAFId");

            entity.Property(e => e.AlmacenAfid).HasColumnName("AlmacenAFId");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");

            entity.HasOne(d => d.Activo).WithMany(p => p.AlmacenActivos)
                .HasForeignKey(d => d.ActivoId)
                .HasConstraintName("FK_dbo.AlmacenActivo_dbo.Activo_ActivoId");

            entity.HasOne(d => d.AlmacenAf).WithMany(p => p.AlmacenActivos)
                .HasForeignKey(d => d.AlmacenAfid)
                .HasConstraintName("FK_dbo.AlmacenActivo_dbo.AlmacenAF_AlmacenAFId");
        });

        modelBuilder.Entity<AlmacenAf>(entity =>
        {
            entity.HasKey(e => e.AlmacenAfid).HasName("PK_dbo.AlmacenAF");

            entity.ToTable("AlmacenAF");

            entity.Property(e => e.AlmacenAfid).HasColumnName("AlmacenAFId");
        });

        modelBuilder.Entity<AlmacenProducto>(entity =>
        {
            entity.HasKey(e => e.AlmacenProductoId).HasName("PK_dbo.AlmacenProducto");

            entity.ToTable("AlmacenProducto", tb => tb.HasTrigger("trIUDAlmacenProducto"));

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.MonedaId, "IX_MonedaId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");

            entity.HasOne(d => d.Almacen).WithMany(p => p.AlmacenProductos)
                .HasForeignKey(d => d.AlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.AlmacenProducto_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.AlmacenProductos)
                .HasForeignKey(d => d.EstadoProductoId)
                .HasConstraintName("FK_dbo.AlmacenProducto_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.Moneda).WithMany(p => p.AlmacenProductos)
                .HasForeignKey(d => d.MonedaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.AlmacenProducto_dbo.Moneda_MonedaId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.AlmacenProductos)
                .HasForeignKey(d => d.UsoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.AlmacenProducto_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<AltaActivo>(entity =>
        {
            entity.HasKey(e => e.AltaActivoId).HasName("PK_dbo.AltaActivo");

            entity.ToTable("AltaActivo");

            entity.HasIndex(e => e.DocumentoActivoId, "IX_DocumentoActivoId");

            entity.Property(e => e.AlmacenAfid).HasColumnName("AlmacenAFId");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.DocumentoActivo).WithMany(p => p.AltaActivos)
                .HasForeignKey(d => d.DocumentoActivoId)
                .HasConstraintName("FK_dbo.AltaActivo_dbo.DocumentoActivo_DocumentoActivoId");
        });

        modelBuilder.Entity<AltaDetalle>(entity =>
        {
            entity.HasKey(e => e.AltaDetalleId).HasName("PK_dbo.AltaDetalle");

            entity.ToTable("AltaDetalle");

            entity.HasIndex(e => e.AltaId, "IX_AltaId");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.CostoIngreso).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.Obs)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.Alta).WithMany(p => p.AltaDetalles)
                .HasForeignKey(d => d.AltaId)
                .HasConstraintName("FK_dbo.AltaDetalle_dbo.Alta_AltaId");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.AltaDetalles)
                .HasForeignKey(d => d.EstadoProductoId)
                .HasConstraintName("FK_dbo.AltaDetalle_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.AltaDetalles)
                .HasForeignKey(d => d.UsoProductoId)
                .HasConstraintName("FK_dbo.AltaDetalle_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<AltaDetalleActivo>(entity =>
        {
            entity.HasKey(e => e.AltaDetalleActivoId).HasName("PK_dbo.AltaDetalleActivo");

            entity.ToTable("AltaDetalleActivo");

            entity.HasIndex(e => e.AltaActivoId, "IX_AltaActivoId");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoIngreso).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AltaActivo).WithMany(p => p.AltaDetalleActivos)
                .HasForeignKey(d => d.AltaActivoId)
                .HasConstraintName("FK_dbo.AltaDetalleActivo_dbo.AltaActivo_AltaActivoId");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.AltaDetalleActivos)
                .HasForeignKey(d => d.EstadoProductoId)
                .HasConstraintName("FK_dbo.AltaDetalleActivo_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.AltaDetalleActivos)
                .HasForeignKey(d => d.UsoProductoId)
                .HasConstraintName("FK_dbo.AltaDetalleActivo_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<Altum>(entity =>
        {
            entity.HasKey(e => e.AltaId).HasName("PK_dbo.Alta");

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.DocumentoId, "IX_DocumentoId");

            entity.HasIndex(e => e.MonedaId, "IX_MonedaId");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.TipoAlta)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.HasOne(d => d.Almacen).WithMany(p => p.Alta)
                .HasForeignKey(d => d.AlmacenId)
                .HasConstraintName("FK_dbo.Alta_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.Documento).WithMany(p => p.Alta)
                .HasForeignKey(d => d.DocumentoId)
                .HasConstraintName("FK_dbo.Alta_dbo.Documento_DocumentoId");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Alta)
                .HasForeignKey(d => d.MonedaId)
                .HasConstraintName("FK_dbo.Alta_dbo.Moneda_MonedaId");
        });

        modelBuilder.Entity<Anticipo>(entity =>
        {
            entity.HasKey(e => e.AnticipoId).HasName("PK_dbo.Anticipo");

            entity.ToTable("Anticipo");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.Property(e => e.DocumentoRrhhid).HasColumnName("DocumentoRRHHId");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Anticipos)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_dbo.Anticipo_dbo.Empleado_EmpleadoId");
        });

        modelBuilder.Entity<ArchivosProducto>(entity =>
        {
            entity.HasKey(e => e.ArchivosProductoId).HasName("PK_dbo.ArchivosProducto");

            entity.ToTable("ArchivosProducto");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.HasIndex(e => e.TipoArchivoProductoId, "IX_TipoArchivoProductoId");

            entity.Property(e => e.FecModifImg)
                .HasDefaultValueSql("('1900-01-01T00:00:00.000')")
                .HasColumnType("datetime");
            entity.Property(e => e.FecModifImgVol)
                .HasDefaultValueSql("('1900-01-01T00:00:00.000')")
                .HasColumnType("datetime");
            entity.Property(e => e.FecModifTec)
                .HasDefaultValueSql("('1900-01-01T00:00:00.000')")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Prod).WithMany(p => p.ArchivosProductos)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.ArchivosProducto_dbo.Prod_ProdId");

            entity.HasOne(d => d.TipoArchivoProducto).WithMany(p => p.ArchivosProductos)
                .HasForeignKey(d => d.TipoArchivoProductoId)
                .HasConstraintName("FK_dbo.ArchivosProducto_dbo.TipoArchivoProducto_TipoArchivoProductoId");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.AreaId).HasName("PK_dbo.Area");

            entity.ToTable("Area");
        });

        modelBuilder.Entity<AreaAux>(entity =>
        {
            entity.HasKey(e => e.AreaAuxId).HasName("PK_dbo.AreaAux");

            entity.ToTable("AreaAux");
        });

        modelBuilder.Entity<Armador>(entity =>
        {
            entity.HasKey(e => e.ArmadorId).HasName("PK_dbo.Armador");

            entity.ToTable("Armador");
        });

        modelBuilder.Entity<AsignaPuntoVentum>(entity =>
        {
            entity.HasKey(e => e.AsignaPuntoVentaId).HasName("PK_dbo.AsignaPuntoVenta");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<AsignacionVehiculoChofer>(entity =>
        {
            entity.HasKey(e => e.AsignacionVehiculoChoferId).HasName("PK_dbo.AsignacionVehiculoChofer");

            entity.ToTable("AsignacionVehiculoChofer");

            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<AsistenciaLog>(entity =>
        {
            entity.HasKey(e => e.AsistenciaLogId).HasName("PK_dbo.AsistenciaLog");

            entity.ToTable("AsistenciaLog");

            entity.Property(e => e.Accion)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaLog).HasColumnType("datetime");
        });

        modelBuilder.Entity<Asistencium>(entity =>
        {
            entity.HasKey(e => e.AsistenciaId).HasName("PK_dbo.Asistencia");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tgr_asistenciaLog_deletes");
                    tb.HasTrigger("tgr_asistenciaLog_inserts");
                    tb.HasTrigger("tgr_asistenciaLog_updates");
                });

            entity.HasIndex(e => e.EmpleadoBiometricoId, "IX_EmpleadoBiometricoId");

            entity.HasIndex(e => e.HorarioId, "IX_HorarioId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.EmpleadoBiometrico).WithMany(p => p.Asistencia)
                .HasForeignKey(d => d.EmpleadoBiometricoId)
                .HasConstraintName("FK_dbo.Asistencia_dbo.EmpleadoBiometrico_EmpleadoBiometricoId");

            entity.HasOne(d => d.Horario).WithMany(p => p.Asistencia)
                .HasForeignKey(d => d.HorarioId)
                .HasConstraintName("FK_dbo.Asistencia_dbo.Horario_HorarioId");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e.Validity).HasColumnType("datetime");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<Baja>(entity =>
        {
            entity.HasKey(e => e.BajaId).HasName("PK_dbo.Baja");

            entity.ToTable("Baja");

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.DocumentoId, "IX_DocumentoId");

            entity.HasIndex(e => e.MonedaId, "IX_MonedaId");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.Almacen).WithMany(p => p.Bajas)
                .HasForeignKey(d => d.AlmacenId)
                .HasConstraintName("FK_dbo.Baja_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.Documento).WithMany(p => p.Bajas)
                .HasForeignKey(d => d.DocumentoId)
                .HasConstraintName("FK_dbo.Baja_dbo.Documento_DocumentoId");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Bajas)
                .HasForeignKey(d => d.MonedaId)
                .HasConstraintName("FK_dbo.Baja_dbo.Moneda_MonedaId");
        });

        modelBuilder.Entity<BajaActivo>(entity =>
        {
            entity.HasKey(e => e.BajaActivoId).HasName("PK_dbo.BajaActivo");

            entity.ToTable("BajaActivo");

            entity.HasIndex(e => e.DocumentoActivoId, "IX_DocumentoActivoId");

            entity.Property(e => e.AlmacenAfid).HasColumnName("AlmacenAFId");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.DocumentoActivo).WithMany(p => p.BajaActivos)
                .HasForeignKey(d => d.DocumentoActivoId)
                .HasConstraintName("FK_dbo.BajaActivo_dbo.DocumentoActivo_DocumentoActivoId");
        });

        modelBuilder.Entity<BajaDetalle>(entity =>
        {
            entity.HasKey(e => e.BajaDetalleId).HasName("PK_dbo.BajaDetalle");

            entity.ToTable("BajaDetalle");

            entity.HasIndex(e => e.AlmacenProductoId, "IX_AlmacenProductoId");

            entity.HasIndex(e => e.BajaId, "IX_BajaId");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.Obs)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.AlmacenProducto).WithMany(p => p.BajaDetalles)
                .HasForeignKey(d => d.AlmacenProductoId)
                .HasConstraintName("FK_dbo.BajaDetalle_dbo.AlmacenProducto_AlmacenProductoId");

            entity.HasOne(d => d.Baja).WithMany(p => p.BajaDetalles)
                .HasForeignKey(d => d.BajaId)
                .HasConstraintName("FK_dbo.BajaDetalle_dbo.Baja_BajaId");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.BajaDetalles)
                .HasForeignKey(d => d.EstadoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.BajaDetalle_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.BajaDetalles)
                .HasForeignKey(d => d.UsoProductoId)
                .HasConstraintName("FK_dbo.BajaDetalle_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<BajaDetalleActivo>(entity =>
        {
            entity.HasKey(e => e.BajaDetalleActivoId).HasName("PK_dbo.BajaDetalleActivo");

            entity.ToTable("BajaDetalleActivo");

            entity.HasIndex(e => e.BajaActivoId, "IX_BajaActivoId");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.BajaActivo).WithMany(p => p.BajaDetalleActivos)
                .HasForeignKey(d => d.BajaActivoId)
                .HasConstraintName("FK_dbo.BajaDetalleActivo_dbo.BajaActivo_BajaActivoId");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.BajaDetalleActivos)
                .HasForeignKey(d => d.EstadoProductoId)
                .HasConstraintName("FK_dbo.BajaDetalleActivo_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.BajaDetalleActivos)
                .HasForeignKey(d => d.UsoProductoId)
                .HasConstraintName("FK_dbo.BajaDetalleActivo_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<BancoProveedor>(entity =>
        {
            entity.HasKey(e => e.BancoProveedorId).HasName("PK_dbo.BancoProveedor");

            entity.ToTable("BancoProveedor");

            entity.HasIndex(e => e.FabricaId, "IX_FabricaId");

            entity.HasIndex(e => e.TipoBancoProveedorId, "IX_TipoBancoProveedorId");

            entity.HasIndex(e => e.TraderId, "IX_TraderId");

            entity.HasOne(d => d.Fabrica).WithMany(p => p.BancoProveedors)
                .HasForeignKey(d => d.FabricaId)
                .HasConstraintName("FK_dbo.BancoProveedor_dbo.Fabrica_FabricaId");

            entity.HasOne(d => d.TipoBancoProveedor).WithMany(p => p.BancoProveedors)
                .HasForeignKey(d => d.TipoBancoProveedorId)
                .HasConstraintName("FK_dbo.BancoProveedor_dbo.TipoBancoProveedor_TipoBancoProveedorId");

            entity.HasOne(d => d.Trader).WithMany(p => p.BancoProveedors)
                .HasForeignKey(d => d.TraderId)
                .HasConstraintName("FK_dbo.BancoProveedor_dbo.Trader_TraderId");
        });

        modelBuilder.Entity<BeneficiarioProveedor>(entity =>
        {
            entity.HasKey(e => e.BeneficiarioProveedorId).HasName("PK_dbo.BeneficiarioProveedor");

            entity.ToTable("BeneficiarioProveedor");
        });

        modelBuilder.Entity<Biometrico>(entity =>
        {
            entity.HasKey(e => e.BiometricoId).HasName("PK_dbo.Biometrico");

            entity.ToTable("Biometrico");
        });

        modelBuilder.Entity<BloqueoInventario>(entity =>
        {
            entity.HasKey(e => e.BloqueoInventarioId).HasName("PK_dbo.BloqueoInventario");

            entity.ToTable("BloqueoInventario");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<CanalDistribucion>(entity =>
        {
            entity.HasKey(e => e.CanalDistribucionId).HasName("PK_dbo.CanalDistribucion");

            entity.ToTable("CanalDistribucion");
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.CargoId).HasName("PK_dbo.Cargo");

            entity.ToTable("Cargo");
        });

        modelBuilder.Entity<Categorizacion>(entity =>
        {
            entity.HasKey(e => e.CategorizacionId).HasName("PK_dbo.Categorizacion");

            entity.ToTable("Categorizacion");

            entity.HasIndex(e => e.ClienteId, "IX_ClienteId");

            entity.HasIndex(e => e.TipoClienteId, "IX_TipoClienteId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Categorizacions)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_dbo.Categorizacion_dbo.Cliente_ClienteId");

            entity.HasOne(d => d.TipoCliente).WithMany(p => p.Categorizacions)
                .HasForeignKey(d => d.TipoClienteId)
                .HasConstraintName("FK_dbo.Categorizacion_dbo.TipoCliente_TipoClienteId");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK_dbo.Category");

            entity.ToTable("Category");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.CiudadId).HasName("PK_dbo.Ciudad");

            entity.ToTable("Ciudad");
        });

        modelBuilder.Entity<ClaseActivo>(entity =>
        {
            entity.HasKey(e => e.ClaseActivoId).HasName("PK_dbo.ClaseActivo");

            entity.ToTable("ClaseActivo");

            entity.Property(e => e.AnioVidaUtil).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Coeficiente).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ClaseCliente>(entity =>
        {
            entity.HasKey(e => e.ClaseClienteId).HasName("PK_dbo.ClaseCliente");

            entity.ToTable("ClaseCliente");
        });

        modelBuilder.Entity<ClaseDocumento>(entity =>
        {
            entity.HasKey(e => e.ClaseDocumentoId).HasName("PK_dbo.ClaseDocumento");

            entity.ToTable("ClaseDocumento");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaseDocumentoActivo>(entity =>
        {
            entity.HasKey(e => e.ClaseDocumentoActivoId).HasName("PK_dbo.ClaseDocumentoActivo");

            entity.ToTable("ClaseDocumentoActivo");
        });

        modelBuilder.Entity<ClasificacionActivo>(entity =>
        {
            entity.HasKey(e => e.ClasificacionActivoId).HasName("PK_dbo.ClasificacionActivo");

            entity.ToTable("ClasificacionActivo");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<Clasificator>(entity =>
        {
            entity.HasKey(e => e.ClasificatorId).HasName("PK_dbo.Clasificator");

            entity.ToTable("Clasificator");
        });

        modelBuilder.Entity<ClasificatorModule>(entity =>
        {
            entity.HasKey(e => e.ClasificatorModuleId).HasName("PK_dbo.ClasificatorModule");

            entity.ToTable("ClasificatorModule");

            entity.HasIndex(e => e.ClasificatorId, "IX_ClasificatorId");

            entity.HasIndex(e => e.ModuleId, "IX_ModuleId");

            entity.HasOne(d => d.Clasificator).WithMany(p => p.ClasificatorModules)
                .HasForeignKey(d => d.ClasificatorId)
                .HasConstraintName("FK_dbo.ClasificatorModule_dbo.Clasificator_ClasificatorId");

            entity.HasOne(d => d.Module).WithMany(p => p.ClasificatorModules)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_dbo.ClasificatorModule_dbo.Module_ModuleId");
        });

        modelBuilder.Entity<ClasificatorValue>(entity =>
        {
            entity.HasKey(e => e.ClasificatorValueId).HasName("PK_dbo.ClasificatorValue");

            entity.ToTable("ClasificatorValue");

            entity.HasIndex(e => e.ClasificatorId, "IX_ClasificatorId");

            entity.HasOne(d => d.Clasificator).WithMany(p => p.ClasificatorValues)
                .HasForeignKey(d => d.ClasificatorId)
                .HasConstraintName("FK_dbo.ClasificatorValue_dbo.Clasificator_ClasificatorId");
        });

        modelBuilder.Entity<ClassProd>(entity =>
        {
            entity.HasKey(e => e.ClassProdId).HasName("PK_dbo.ClassProd");

            entity.ToTable("ClassProd");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK_dbo.Cliente");

            entity.ToTable("Cliente");

            entity.HasIndex(e => e.ProfesionOficioId, "IX_ProfesionOficioId");

            entity.HasIndex(e => e.ProspectoId, "IX_ProspectoId");

            entity.HasIndex(e => e.RubroComercialId, "IX_RubroComercialId");

            entity.HasIndex(e => e.TecnicoClienteId, "IX_TecnicoClienteId");

            entity.HasIndex(e => e.TipoClienteId, "IX_TipoClienteId");

            entity.Property(e => e.Meta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NitCi).HasColumnName("NitCI");
            entity.Property(e => e.TelefonoDomicilioFijo).HasColumnName("TelefonoDomicilioFIjo");
            entity.Property(e => e.VolumenMaximo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VolumenMinimo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ProfesionOficio).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.ProfesionOficioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Cliente_dbo.ProfesionOficio_ProfesionOficioId");

            entity.HasOne(d => d.Prospecto).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.ProspectoId)
                .HasConstraintName("FK_dbo.Cliente_dbo.Prospecto_ProspectoId");

            entity.HasOne(d => d.RubroComercial).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.RubroComercialId)
                .HasConstraintName("FK_dbo.Cliente_dbo.RubroComercial_RubroComercialId");

            entity.HasOne(d => d.TecnicoCliente).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.TecnicoClienteId)
                .HasConstraintName("FK_dbo.Cliente_dbo.TecnicoCliente_TecnicoClienteId");

            entity.HasOne(d => d.TipoCliente).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.TipoClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Cliente_dbo.TipoCliente_TipoClienteId");
        });

        modelBuilder.Entity<ClienteProyecto>(entity =>
        {
            entity.HasKey(e => e.ClienteProyectoId).HasName("PK_dbo.ClienteProyecto");

            entity.ToTable("ClienteProyecto");

            entity.HasIndex(e => e.ClienteId, "IX_ClienteId");

            entity.HasIndex(e => e.ProyectoId, "IX_ProyectoId");

            entity.HasOne(d => d.Cliente).WithMany(p => p.ClienteProyectos)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_dbo.ClienteProyecto_dbo.Cliente_ClienteId");

            entity.HasOne(d => d.Proyecto).WithMany(p => p.ClienteProyectos)
                .HasForeignKey(d => d.ProyectoId)
                .HasConstraintName("FK_dbo.ClienteProyecto_dbo.Proyecto_ProyectoId");
        });

        modelBuilder.Entity<Cobranza>(entity =>
        {
            entity.HasKey(e => e.CobranzaId).HasName("PK_dbo.Cobranza");

            entity.ToTable("Cobranza");

            entity.HasIndex(e => e.NumeroPedido, "IX_Cobranza");

            entity.Property(e => e.CambioBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CambioPago).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CambioSus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CambioSusBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteSus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoCobImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoDeudor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoFavor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPago).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValUtil).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VarBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VarSus).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CobranzaItem>(entity =>
        {
            entity.HasKey(e => e.CobranzaItemsId).HasName("PK_dbo.CobranzaItems");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPend).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Colore>(entity =>
        {
            entity.HasKey(e => e.ColoresId).HasName("PK_dbo.Colores");
        });

        modelBuilder.Entity<Comision>(entity =>
        {
            entity.HasKey(e => e.ComisionId).HasName("PK_dbo.Comision");

            entity.ToTable("Comision");

            entity.Property(e => e.BaseCalculo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bono).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MesAnterior).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MesAnteriorDos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MesAnteriorTres).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalComision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VentaCompleta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VentaPendiente).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ComisionExcel>(entity =>
        {
            entity.HasKey(e => e.ComisionExcelId).HasName("PK_dbo.ComisionExcel");

            entity.ToTable("ComisionExcel");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NombreArchivo).HasColumnName("Nombre_Archivo");
        });

        modelBuilder.Entity<ComprobanteActivo>(entity =>
        {
            entity.HasKey(e => e.ComprobanteActivoId).HasName("PK_dbo.ComprobanteActivo");

            entity.ToTable("ComprobanteActivo");

            entity.HasIndex(e => e.MonedaId, "IX_MonedaId");

            entity.HasIndex(e => e.TipoComprobanteActivoId, "IX_TipoComprobanteActivoId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ufv)
                .HasColumnType("decimal(14, 5)")
                .HasColumnName("UFV");

            entity.HasOne(d => d.Moneda).WithMany(p => p.ComprobanteActivos)
                .HasForeignKey(d => d.MonedaId)
                .HasConstraintName("FK_dbo.ComprobanteActivo_dbo.Moneda_MonedaId");

            entity.HasOne(d => d.TipoComprobanteActivo).WithMany(p => p.ComprobanteActivos)
                .HasForeignKey(d => d.TipoComprobanteActivoId)
                .HasConstraintName("FK_dbo.ComprobanteActivo_dbo.TipoComprobanteActivo_TipoComprobanteActivoId");
        });

        modelBuilder.Entity<CompromisoProd>(entity =>
        {
            entity.HasKey(e => e.CompromisoProdId).HasName("PK_dbo.CompromisoProd");

            entity.ToTable("CompromisoProd");

            entity.HasIndex(e => e.CompromisoUnidadId, "IX_CompromisoUnidadId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.CompromisoUnidad).WithMany(p => p.CompromisoProds)
                .HasForeignKey(d => d.CompromisoUnidadId)
                .HasConstraintName("FK_dbo.CompromisoProd_dbo.CompromisoUnidad_CompromisoUnidadId");
        });

        modelBuilder.Entity<CompromisoUnidad>(entity =>
        {
            entity.HasKey(e => e.CompromisoUnidadId).HasName("PK_dbo.CompromisoUnidad");

            entity.ToTable("CompromisoUnidad");

            entity.HasIndex(e => e.CompromisoVentasId, "IX_CompromisoVentasId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.CompromisoVentas).WithMany(p => p.CompromisoUnidads)
                .HasForeignKey(d => d.CompromisoVentasId)
                .HasConstraintName("FK_dbo.CompromisoUnidad_dbo.CompromisoVentas_CompromisoVentasId");
        });

        modelBuilder.Entity<CompromisoVenta>(entity =>
        {
            entity.HasKey(e => e.CompromisoVentasId).HasName("PK_dbo.CompromisoVentas");

            entity.Property(e => e.FechaAprobacion).HasColumnType("datetime");
            entity.Property(e => e.FechaReporteFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaReporteInicial).HasColumnType("datetime");
            entity.Property(e => e.FechaVentaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaVentaInicial).HasColumnType("datetime");
        });

        modelBuilder.Entity<ConceptoCosto>(entity =>
        {
            entity.HasKey(e => e.ConceptoCostoId).HasName("PK_dbo.ConceptoCosto");

            entity.ToTable("ConceptoCosto");

            entity.HasIndex(e => e.TipoConceptoCostoId, "IX_TipoConceptoCostoId");

            entity.HasOne(d => d.TipoConceptoCosto).WithMany(p => p.ConceptoCostos)
                .HasForeignKey(d => d.TipoConceptoCostoId)
                .HasConstraintName("FK_dbo.ConceptoCosto_dbo.TipoConceptoCosto_TipoConceptoCostoId");
        });

        modelBuilder.Entity<Conductor>(entity =>
        {
            entity.HasKey(e => e.ConductorId).HasName("PK_dbo.Conductor");

            entity.ToTable("Conductor");

            entity.HasIndex(e => e.TransporteId, "IX_TransporteId");

            entity.Property(e => e.Ci)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.Transporte).WithMany(p => p.Conductors)
                .HasForeignKey(d => d.TransporteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Conductor_dbo.Transporte_TransporteId");
        });

        modelBuilder.Entity<ContactoNacional>(entity =>
        {
            entity.HasKey(e => e.ContactoNacionalId).HasName("PK_dbo.ContactoNacional");

            entity.ToTable("ContactoNacional");

            entity.HasIndex(e => e.NacionalId, "IX_NacionalId");

            entity.HasOne(d => d.Nacional).WithMany(p => p.ContactoNacionals)
                .HasForeignKey(d => d.NacionalId)
                .HasConstraintName("FK_dbo.ContactoNacional_dbo.Nacional_NacionalId");
        });

        modelBuilder.Entity<ContactoProveedor>(entity =>
        {
            entity.HasKey(e => e.ContactoProveedorId).HasName("PK_dbo.ContactoProveedor");

            entity.ToTable("ContactoProveedor");

            entity.HasIndex(e => e.FabricaId, "IX_FabricaId");

            entity.HasIndex(e => e.TraderId, "IX_TraderId");

            entity.HasOne(d => d.Fabrica).WithMany(p => p.ContactoProveedors)
                .HasForeignKey(d => d.FabricaId)
                .HasConstraintName("FK_dbo.ContactoProveedor_dbo.Fabrica_FabricaId");

            entity.HasOne(d => d.Trader).WithMany(p => p.ContactoProveedors)
                .HasForeignKey(d => d.TraderId)
                .HasConstraintName("FK_dbo.ContactoProveedor_dbo.Trader_TraderId");
        });

        modelBuilder.Entity<CorreoCliente>(entity =>
        {
            entity.HasKey(e => e.CorreoClienteId).HasName("PK_dbo.CorreoCliente");

            entity.ToTable("CorreoCliente");
        });

        modelBuilder.Entity<CostoImportacion>(entity =>
        {
            entity.HasKey(e => e.CostoImportacionId).HasName("PK_dbo.CostoImportacion");

            entity.ToTable("CostoImportacion");

            entity.HasIndex(e => e.ConceptoCostoId, "IX_ConceptoCostoId");

            entity.HasIndex(e => e.EmpresaImportacionId, "IX_EmpresaImportacionId");

            entity.HasIndex(e => e.RequerimientoPedidoId, "IX_RequerimientoPedidoId");

            entity.HasIndex(e => e.TipoDocImportacionId, "IX_TipoDocImportacionId");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Iva).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Retencion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ConceptoCosto).WithMany(p => p.CostoImportacions)
                .HasForeignKey(d => d.ConceptoCostoId)
                .HasConstraintName("FK_dbo.CostoImportacion_dbo.ConceptoCosto_ConceptoCostoId");

            entity.HasOne(d => d.EmpresaImportacion).WithMany(p => p.CostoImportacions)
                .HasForeignKey(d => d.EmpresaImportacionId)
                .HasConstraintName("FK_dbo.CostoImportacion_dbo.EmpresaImportacion_EmpresaImportacionId");

            entity.HasOne(d => d.RequerimientoPedido).WithMany(p => p.CostoImportacions)
                .HasForeignKey(d => d.RequerimientoPedidoId)
                .HasConstraintName("FK_dbo.CostoImportacion_dbo.RequerimientoPedido_RequerimientoPedidoId");

            entity.HasOne(d => d.TipoDocImportacion).WithMany(p => p.CostoImportacions)
                .HasForeignKey(d => d.TipoDocImportacionId)
                .HasConstraintName("FK_dbo.CostoImportacion_dbo.TipoDocImportacion_TipoDocImportacionId");
        });

        modelBuilder.Entity<Cotizacion>(entity =>
        {
            entity.HasKey(e => e.CotizacionId).HasName("PK_dbo.Cotizacion");

            entity.ToTable("Cotizacion");

            entity.HasIndex(e => e.Codigo, "IX_Cotizacion");

            entity.Property(e => e.DescuentoFraccion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoValor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiferenciaTc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DiferenciaTC");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.PrecioOferta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Validez).HasColumnType("datetime");
        });

        modelBuilder.Entity<CotizacionItem>(entity =>
        {
            entity.HasKey(e => e.CotizacionItemsId).HasName("PK_dbo.CotizacionItems");

            entity.HasIndex(e => e.CotizacionId, "IX_CotizacionItems_01");

            entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUfv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CostoUFV");
            entity.Property(e => e.FraccionDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeReglas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCotizacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioNominal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreferenteDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Use).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorDescuento).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CotizacionProyecto>(entity =>
        {
            entity.HasKey(e => e.CotizacionProyectoId).HasName("PK_dbo.CotizacionProyecto");

            entity.ToTable("CotizacionProyecto");

            entity.HasIndex(e => e.CotizacionId, "IX_CotizacionId");

            entity.HasIndex(e => e.ProyectoId, "IX_ProyectoId");

            entity.HasOne(d => d.Cotizacion).WithMany(p => p.CotizacionProyectos)
                .HasForeignKey(d => d.CotizacionId)
                .HasConstraintName("FK_dbo.CotizacionProyecto_dbo.Cotizacion_CotizacionId");

            entity.HasOne(d => d.Proyecto).WithMany(p => p.CotizacionProyectos)
                .HasForeignKey(d => d.ProyectoId)
                .HasConstraintName("FK_dbo.CotizacionProyecto_dbo.Proyecto_ProyectoId");
        });

        modelBuilder.Entity<CreditoCliente>(entity =>
        {
            entity.HasKey(e => e.CreditoClienteId).HasName("PK_dbo.CreditoCliente");

            entity.ToTable("CreditoCliente");

            entity.HasIndex(e => e.ClienteId, "IX_ClienteId");

            entity.Property(e => e.DisponibleCredito).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaGracia).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.LimiteCredito).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VolumenCredito).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.CreditoClientes)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_dbo.CreditoCliente_dbo.Cliente_ClienteId");
        });

        modelBuilder.Entity<CreditoDebito>(entity =>
        {
            entity.HasKey(e => e.CreditoDebitoId).HasName("PK_dbo.CreditoDebito");

            entity.ToTable("CreditoDebito");

            entity.Property(e => e.DescuentoFraccion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoValor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.PrecioOferta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Validez).HasColumnType("datetime");
        });

        modelBuilder.Entity<CreditoDebitoDetalle>(entity =>
        {
            entity.HasKey(e => e.CreditoDebitoDetalleId).HasName("PK_dbo.CreditoDebitoDetalle");

            entity.ToTable("CreditoDebitoDetalle");

            entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUfv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CostoUFV");
            entity.Property(e => e.FraccionDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeReglas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCotizacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioNominal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreferenteDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Use).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<DefaultAttrib>(entity =>
        {
            entity.HasKey(e => e.DefaultAttribId).HasName("PK_dbo.DefaultAttrib");

            entity.ToTable("DefaultAttrib");

            entity.HasIndex(e => e.DefaultDomainId, "IX_DefaultDomainId");

            entity.HasOne(d => d.DefaultDomainNavigation).WithMany(p => p.DefaultAttribs)
                .HasForeignKey(d => d.DefaultDomainId)
                .HasConstraintName("FK_dbo.DefaultAttrib_dbo.DefaultDomain_DefaultDomainId");
        });

        modelBuilder.Entity<DefaultDomain>(entity =>
        {
            entity.HasKey(e => e.DefaultDomainId).HasName("PK_dbo.DefaultDomain");

            entity.ToTable("DefaultDomain");
        });

        modelBuilder.Entity<DefaultValue>(entity =>
        {
            entity.HasKey(e => e.DefaultValueId).HasName("PK_dbo.DefaultValue");

            entity.ToTable("DefaultValue");

            entity.HasIndex(e => e.DefaultAttribId, "IX_DefaultAttribId");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.HasOne(d => d.DefaultAttrib).WithMany(p => p.DefaultValues)
                .HasForeignKey(d => d.DefaultAttribId)
                .HasConstraintName("FK_dbo.DefaultValue_dbo.DefaultAttrib_DefaultAttribId");

            entity.HasOne(d => d.Prod).WithMany(p => p.DefaultValues)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.DefaultValue_dbo.Prod_ProdId");
        });

        modelBuilder.Entity<DeprecActActivo>(entity =>
        {
            entity.HasKey(e => e.DeprecActActivoId).HasName("PK_dbo.DeprecActActivo");

            entity.ToTable("DeprecActActivo");

            entity.HasIndex(e => e.MonedaId, "IX_MonedaId");

            entity.Property(e => e.FechaAnterior).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.Ufvfinal)
                .HasColumnType("decimal(14, 5)")
                .HasColumnName("UFVFinal");
            entity.Property(e => e.Ufvinicial)
                .HasColumnType("decimal(14, 5)")
                .HasColumnName("UFVInicial");

            entity.HasOne(d => d.Moneda).WithMany(p => p.DeprecActActivos)
                .HasForeignKey(d => d.MonedaId)
                .HasConstraintName("FK_dbo.DeprecActActivo_dbo.Moneda_MonedaId");
        });

        modelBuilder.Entity<DeprecActDetalleActivo>(entity =>
        {
            entity.HasKey(e => e.DeprecActDetalleActivoId).HasName("PK_dbo.DeprecActDetalleActivo");

            entity.ToTable("DeprecActDetalleActivo");

            entity.HasIndex(e => e.ActivoId, "IX_ActivoId");

            entity.HasIndex(e => e.DeprecActActivoId, "IX_DeprecActActivoId");

            entity.Property(e => e.Coeficiente).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.DepreciacionAcum).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.DepreciacionAcumActualizado).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.DepreciacionAcumTotal).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.DepreciacionPeriodo).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.MesesVidaUtil).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MesesVidaUtilRestante).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ufvfinal)
                .HasColumnType("decimal(14, 5)")
                .HasColumnName("UFVFinal");
            entity.Property(e => e.Ufvinicial)
                .HasColumnType("decimal(14, 5)")
                .HasColumnName("UFVInicial");
            entity.Property(e => e.UnidadActualizacion).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.UnidadActualizacionDeprec).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.ValorActualizado).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.ValorNeto).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.ValorNetoActual).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.ValorOriginal).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.VarianteDperiodo)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("VarianteDPeriodo");

            entity.HasOne(d => d.Activo).WithMany(p => p.DeprecActDetalleActivos)
                .HasForeignKey(d => d.ActivoId)
                .HasConstraintName("FK_dbo.DeprecActDetalleActivo_dbo.Activo_ActivoId");

            entity.HasOne(d => d.DeprecActActivo).WithMany(p => p.DeprecActDetalleActivos)
                .HasForeignKey(d => d.DeprecActActivoId)
                .HasConstraintName("FK_dbo.DeprecActDetalleActivo_dbo.DeprecActActivo_DeprecActActivoId");
        });

        modelBuilder.Entity<DescuentoComercial>(entity =>
        {
            entity.HasKey(e => e.DescuentoComercialId).HasName("PK_dbo.DescuentoComercial");

            entity.ToTable("DescuentoComercial");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinal).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
        });

        modelBuilder.Entity<Despachante>(entity =>
        {
            entity.HasKey(e => e.DespachanteId).HasName("PK_dbo.Despachante");

            entity.ToTable("Despachante", tb => tb.HasTrigger("trIUDDespachante"));

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.SolicitanteId, "IX_SolicitanteId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.Property(e => e.ConformidadD).HasColumnType("datetime");
            entity.Property(e => e.ConformidadS).HasColumnType("datetime");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaCambioEstado).HasColumnType("datetime");
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Almacen).WithMany(p => p.Despachantes)
                .HasForeignKey(d => d.AlmacenId)
                .HasConstraintName("FK_dbo.Despachante_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.Solicitante).WithMany(p => p.Despachantes)
                .HasForeignKey(d => d.SolicitanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Despachante_dbo.Solicitante_SolicitanteId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.Despachantes)
                .HasForeignKey(d => d.UnidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Despachante_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<DespachanteActivo>(entity =>
        {
            entity.HasKey(e => e.DespachanteActivoId).HasName("PK_dbo.DespachanteActivo");

            entity.ToTable("DespachanteActivo");

            entity.HasIndex(e => e.SolicitanteActivoId, "IX_SolicitanteActivoId");

            entity.Property(e => e.AlmacenAfid).HasColumnName("AlmacenAFId");
            entity.Property(e => e.ConformidadD).HasColumnType("datetime");
            entity.Property(e => e.ConformidadS).HasColumnType("datetime");
            entity.Property(e => e.FechaCambioEstado).HasColumnType("datetime");

            entity.HasOne(d => d.SolicitanteActivo).WithMany(p => p.DespachanteActivos)
                .HasForeignKey(d => d.SolicitanteActivoId)
                .HasConstraintName("FK_dbo.DespachanteActivo_dbo.SolicitanteActivo_SolicitanteActivoId");
        });

        modelBuilder.Entity<DetalleActivo>(entity =>
        {
            entity.HasKey(e => e.DetalleActivoId).HasName("PK_dbo.DetalleActivo");

            entity.ToTable("DetalleActivo");

            entity.HasIndex(e => e.ActivoId, "IX_ActivoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Activo).WithMany(p => p.DetalleActivos)
                .HasForeignKey(d => d.ActivoId)
                .HasConstraintName("FK_dbo.DetalleActivo_dbo.Activo_ActivoId");
        });

        modelBuilder.Entity<DetalleProveedorProducto>(entity =>
        {
            entity.HasKey(e => e.DetalleProveedorProductoId).HasName("PK_dbo.DetalleProveedorProducto");

            entity.ToTable("DetalleProveedorProducto");

            entity.HasIndex(e => e.ProveedorProductoId, "IX_ProveedorProductoId");
        });

        modelBuilder.Entity<DetalleSolicitudVendedor>(entity =>
        {
            entity.HasKey(e => e.DetalleSolicitudVendedorId).HasName("PK_dbo.DetalleSolicitudVendedor");

            entity.ToTable("DetalleSolicitudVendedor");

            entity.HasIndex(e => e.SolicitudVendedorId, "IX_SolicitudVendedorId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.SolicitudVendedor).WithMany(p => p.DetalleSolicitudVendedors)
                .HasForeignKey(d => d.SolicitudVendedorId)
                .HasConstraintName("FK_dbo.DetalleSolicitudVendedor_dbo.SolicitudVendedor_SolicitudVendedorId");
        });

        modelBuilder.Entity<Devolucion>(entity =>
        {
            entity.HasKey(e => e.DevolucionId).HasName("PK_dbo.Devolucion");

            entity.ToTable("Devolucion");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<DireccionCliente>(entity =>
        {
            entity.HasKey(e => e.DireccionClienteId).HasName("PK_dbo.DireccionCliente");

            entity.ToTable("DireccionCliente");
        });

        modelBuilder.Entity<DireccionEntrega>(entity =>
        {
            entity.HasKey(e => e.DireccionEntregaId).HasName("PK_dbo.DireccionEntrega");

            entity.ToTable("DireccionEntrega");

            entity.HasIndex(e => e.ClienteId, "IX_ClienteId");

            entity.HasOne(d => d.Cliente).WithMany(p => p.DireccionEntregas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_dbo.DireccionEntrega_dbo.Cliente_ClienteId");
        });

        modelBuilder.Entity<DireccionNacional>(entity =>
        {
            entity.HasKey(e => e.DireccionNacionalId).HasName("PK_dbo.DireccionNacional");

            entity.ToTable("DireccionNacional");

            entity.HasIndex(e => e.CiudadId, "IX_CiudadId");

            entity.HasIndex(e => e.NacionalId, "IX_NacionalId");

            entity.HasIndex(e => e.ProvinciaId, "IX_ProvinciaId");

            entity.HasIndex(e => e.TipoDireccionId, "IX_TipoDireccionId");

            entity.HasOne(d => d.Ciudad).WithMany(p => p.DireccionNacionals)
                .HasForeignKey(d => d.CiudadId)
                .HasConstraintName("FK_dbo.DireccionNacional_dbo.Ciudad_CiudadId");

            entity.HasOne(d => d.Nacional).WithMany(p => p.DireccionNacionals)
                .HasForeignKey(d => d.NacionalId)
                .HasConstraintName("FK_dbo.DireccionNacional_dbo.Nacional_NacionalId");

            entity.HasOne(d => d.Provincia).WithMany(p => p.DireccionNacionals)
                .HasForeignKey(d => d.ProvinciaId)
                .HasConstraintName("FK_dbo.DireccionNacional_dbo.Provincia_ProvinciaId");

            entity.HasOne(d => d.TipoDireccion).WithMany(p => p.DireccionNacionals)
                .HasForeignKey(d => d.TipoDireccionId)
                .HasConstraintName("FK_dbo.DireccionNacional_dbo.TipoDireccion_TipoDireccionId");
        });

        modelBuilder.Entity<DireccionProveedor>(entity =>
        {
            entity.HasKey(e => e.DireccionProveedorId).HasName("PK_dbo.DireccionProveedor");

            entity.ToTable("DireccionProveedor");

            entity.HasIndex(e => e.CiudadId, "IX_CiudadId");

            entity.HasIndex(e => e.FabricaId, "IX_FabricaId");

            entity.HasIndex(e => e.ProvinciaId, "IX_ProvinciaId");

            entity.HasIndex(e => e.TipoDireccionId, "IX_TipoDireccionId");

            entity.HasIndex(e => e.TraderId, "IX_TraderId");

            entity.HasOne(d => d.Ciudad).WithMany(p => p.DireccionProveedors)
                .HasForeignKey(d => d.CiudadId)
                .HasConstraintName("FK_dbo.DireccionProveedor_dbo.Ciudad_CiudadId");

            entity.HasOne(d => d.Fabrica).WithMany(p => p.DireccionProveedors)
                .HasForeignKey(d => d.FabricaId)
                .HasConstraintName("FK_dbo.DireccionProveedor_dbo.Fabrica_FabricaId");

            entity.HasOne(d => d.Provincia).WithMany(p => p.DireccionProveedors)
                .HasForeignKey(d => d.ProvinciaId)
                .HasConstraintName("FK_dbo.DireccionProveedor_dbo.Provincia_ProvinciaId");

            entity.HasOne(d => d.TipoDireccion).WithMany(p => p.DireccionProveedors)
                .HasForeignKey(d => d.TipoDireccionId)
                .HasConstraintName("FK_dbo.DireccionProveedor_dbo.TipoDireccion_TipoDireccionId");

            entity.HasOne(d => d.Trader).WithMany(p => p.DireccionProveedors)
                .HasForeignKey(d => d.TraderId)
                .HasConstraintName("FK_dbo.DireccionProveedor_dbo.Trader_TraderId");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.DocumentoId).HasName("PK_dbo.Documento");

            entity.ToTable("Documento");

            entity.HasIndex(e => e.TipoDocumentoId, "IX_TipoDocumentoId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.Property(e => e.Cerrado).HasColumnType("datetime");
            entity.Property(e => e.Estado).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.TipoDocumentoId)
                .HasConstraintName("FK_dbo.Documento_dbo.TipoDocumento_TipoDocumentoId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.UnidadId)
                .HasConstraintName("FK_dbo.Documento_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<DocumentoActivo>(entity =>
        {
            entity.HasKey(e => e.DocumentoActivoId).HasName("PK_dbo.DocumentoActivo");

            entity.ToTable("DocumentoActivo");

            entity.HasIndex(e => e.TipoDocumentoActivoId, "IX_TipoDocumentoActivoId");

            entity.Property(e => e.Cerrado).HasColumnType("datetime");
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.TipoDocumentoActivo).WithMany(p => p.DocumentoActivos)
                .HasForeignKey(d => d.TipoDocumentoActivoId)
                .HasConstraintName("FK_dbo.DocumentoActivo_dbo.TipoDocumentoActivo_TipoDocumentoActivoId");
        });

        modelBuilder.Entity<DocumentoRrhh>(entity =>
        {
            entity.HasKey(e => e.DocumentoRrhhid).HasName("PK_dbo.DocumentoRRHH");

            entity.ToTable("DocumentoRRHH");

            entity.Property(e => e.DocumentoRrhhid).HasColumnName("DocumentoRRHHId");
            entity.Property(e => e.Cerrado).HasColumnType("datetime");
            entity.Property(e => e.Estado).IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.DocumentoRrhhs)
                .HasForeignKey(d => d.TipoDocumentoId)
                .HasConstraintName("FK_dbo.DocumentoRRHH_dbo.TipoDocumento_TipoDocumentoId");
        });

        modelBuilder.Entity<Egreso>(entity =>
        {
            entity.HasKey(e => e.EgresoId).HasName("PK_dbo.Egreso");

            entity.ToTable("Egreso");

            entity.Property(e => e.CambioBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CambioSus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CambioSusBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteSus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoDeudor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoFavor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValUtil).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VarBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VarSus).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK_dbo.Empleado");

            entity.ToTable("Empleado", tb => tb.HasTrigger("TR_EmpleadoModificado"));

            entity.HasIndex(e => e.AfpId, "IX_AfpId");

            entity.HasIndex(e => e.NivelAcademicoId, "IX_NivelAcademicoId");

            entity.HasIndex(e => e.ProfesionId, "IX_ProfesionId");

            entity.HasIndex(e => e.SeguroSocialId, "IX_SeguroSocialId");

            entity.Property(e => e.Ci).HasColumnName("CI");
            entity.Property(e => e.Dias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

            entity.HasOne(d => d.Afp).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.AfpId)
                .HasConstraintName("FK_dbo.Empleado_dbo.Afp_AfpId");

            entity.HasOne(d => d.NivelAcademico).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.NivelAcademicoId)
                .HasConstraintName("FK_dbo.Empleado_dbo.NivelAcademico_NivelAcademicoId");

            entity.HasOne(d => d.Profesion).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.ProfesionId)
                .HasConstraintName("FK_dbo.Empleado_dbo.Profesion_ProfesionId");

            entity.HasOne(d => d.SeguroSocial).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.SeguroSocialId)
                .HasConstraintName("FK_dbo.Empleado_dbo.SeguroSocial_SeguroSocialId");
        });

        modelBuilder.Entity<EmpleadoAux>(entity =>
        {
            entity.HasKey(e => e.EmpleadoAuxId).HasName("PK_dbo.EmpleadoAux");

            entity.ToTable("EmpleadoAux");

            entity.Property(e => e.Ci).HasColumnName("CI");
            entity.Property(e => e.Dias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
        });

        modelBuilder.Entity<EmpleadoBiometrico>(entity =>
        {
            entity.HasKey(e => e.EmpleadoBiometricoId).HasName("PK_dbo.EmpleadoBiometrico");

            entity.ToTable("EmpleadoBiometrico");

            entity.HasIndex(e => e.BiometricoId, "IX_BiometricoId");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Biometrico).WithMany(p => p.EmpleadoBiometricos)
                .HasForeignKey(d => d.BiometricoId)
                .HasConstraintName("FK_dbo.EmpleadoBiometrico_dbo.Biometrico_BiometricoId");

            entity.HasOne(d => d.Empleado).WithMany(p => p.EmpleadoBiometricos)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_dbo.EmpleadoBiometrico_dbo.Empleado_EmpleadoId");
        });

        modelBuilder.Entity<EmpleadoLog>(entity =>
        {
            entity.HasKey(e => e.EmpleadoLogId).HasName("PK_dbo.EmpleadoLog");

            entity.ToTable("EmpleadoLog");

            entity.Property(e => e.Cinew).HasColumnName("CINew");
            entity.Property(e => e.Ciold).HasColumnName("CIOld");
            entity.Property(e => e.DiasNew).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiasOld).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaIngresoNew).HasColumnType("datetime");
            entity.Property(e => e.FechaIngresoOld).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimientoNew).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimientoOld).HasColumnType("datetime");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.EmpresaId).HasName("PK_dbo.Empresa");

            entity.ToTable("Empresa");

            entity.HasIndex(e => e.TipoEmpresaId, "IX_TipoEmpresaId");

            entity.HasOne(d => d.TipoEmpresa).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.TipoEmpresaId)
                .HasConstraintName("FK_dbo.Empresa_dbo.TipoEmpresa_TipoEmpresaId");
        });

        modelBuilder.Entity<EmpresaImportacion>(entity =>
        {
            entity.HasKey(e => e.EmpresaImportacionId).HasName("PK_dbo.EmpresaImportacion");

            entity.ToTable("EmpresaImportacion");

            entity.HasIndex(e => e.TipoEmpresaImportacionId, "IX_TipoEmpresaImportacionId");

            entity.HasOne(d => d.TipoEmpresaImportacion).WithMany(p => p.EmpresaImportacions)
                .HasForeignKey(d => d.TipoEmpresaImportacionId)
                .HasConstraintName("FK_dbo.EmpresaImportacion_dbo.TipoEmpresaImportacion_TipoEmpresaImportacionId");
        });

        modelBuilder.Entity<Entrega>(entity =>
        {
            entity.HasKey(e => e.EntregaId).HasName("PK_dbo.Entrega");

            entity.ToTable("Entrega");

            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
        });

        modelBuilder.Entity<EntregaObservacion>(entity =>
        {
            entity.HasKey(e => e.EntregaObservacionId).HasName("PK_dbo.EntregaObservacion");

            entity.ToTable("EntregaObservacion");

            entity.Property(e => e.FechaObservacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<EscalaAntiguedad>(entity =>
        {
            entity.HasKey(e => e.EscalaAntiguedadId).HasName("PK_dbo.EscalaAntiguedad");

            entity.ToTable("EscalaAntiguedad");
        });

        modelBuilder.Entity<EscalaDescuento>(entity =>
        {
            entity.HasKey(e => e.EscalaDescuentosId).HasName("PK_dbo.EscalaDescuentos");

            entity.Property(e => e.Dias).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<EscalaVacacion>(entity =>
        {
            entity.HasKey(e => e.EscalaVacacionId).HasName("PK_dbo.EscalaVacacion");

            entity.ToTable("EscalaVacacion");
        });

        modelBuilder.Entity<EstadoMovimiento>(entity =>
        {
            entity.HasKey(e => e.EstadoMovimientoId).HasName("PK_dbo.EstadoMovimiento");

            entity.ToTable("EstadoMovimiento");

            entity.Property(e => e.DescripcionEstadoMov).HasMaxLength(255);
            entity.Property(e => e.EstadoMovimientoChar).HasMaxLength(2);
            entity.Property(e => e.RelatoEstadoMov).HasMaxLength(255);
        });

        modelBuilder.Entity<EstadoMovimientoOperacion>(entity =>
        {
            entity.HasKey(e => e.EstadoMovimientoOperacionId).HasName("PK_dbo.EstadoMovimientoOperacion");

            entity.ToTable("EstadoMovimientoOperacion");

            entity.Property(e => e.DescripcionEstadoMovOp).HasMaxLength(255);
            entity.Property(e => e.EstadoMovimientoOperacionChar).HasMaxLength(2);
            entity.Property(e => e.RelatoEstadoMovOp).HasMaxLength(255);
        });

        modelBuilder.Entity<EstadoProducto>(entity =>
        {
            entity.HasKey(e => e.EstadoProductoId).HasName("PK_dbo.EstadoProducto");

            entity.ToTable("EstadoProducto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoSolicitudTraspaso>(entity =>
        {
            entity.HasKey(e => e.EstadoSolicitudTraspasoId).HasName("PK_dbo.EstadoSolicitudTraspaso");

            entity.ToTable("EstadoSolicitudTraspaso");

            entity.Property(e => e.DescripcionEstadoSoli).HasMaxLength(255);
            entity.Property(e => e.EstadoSolicitudChar).HasMaxLength(2);
            entity.Property(e => e.RelatoEstadoSoli).HasMaxLength(255);
        });

        modelBuilder.Entity<EstructuraPersonal>(entity =>
        {
            entity.HasKey(e => e.EstructuraPersonalId).HasName("PK_dbo.EstructuraPersonal");

            entity.ToTable("EstructuraPersonal", tb => tb.HasTrigger("TR_EstructuraModificado"));

            entity.HasIndex(e => e.AreaId, "IX_AreaId");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.HasIndex(e => e.EmpresaId, "IX_EmpresaId");

            entity.HasIndex(e => e.TipoCargoId, "IX_TipoCargoId");

            entity.HasIndex(e => e.TipoMovimientoPersonalId, "IX_TipoMovimientoPersonalId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.Property(e => e.CodigoSinempleado).HasColumnName("CodigoSINEmpleado");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.HaberBasico).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Area).WithMany(p => p.EstructuraPersonals)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_dbo.EstructuraPersonal_dbo.Area_AreaId");

            entity.HasOne(d => d.Empleado).WithMany(p => p.EstructuraPersonals)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_dbo.EstructuraPersonal_dbo.Empleado_EmpleadoId");

            entity.HasOne(d => d.Empresa).WithMany(p => p.EstructuraPersonals)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK_dbo.EstructuraPersonal_dbo.Empresa_EmpresaId");

            entity.HasOne(d => d.TipoCargo).WithMany(p => p.EstructuraPersonals)
                .HasForeignKey(d => d.TipoCargoId)
                .HasConstraintName("FK_dbo.EstructuraPersonal_dbo.TipoCargo_TipoCargoId");

            entity.HasOne(d => d.TipoMovimientoPersonal).WithMany(p => p.EstructuraPersonals)
                .HasForeignKey(d => d.TipoMovimientoPersonalId)
                .HasConstraintName("FK_dbo.EstructuraPersonal_dbo.TipoMovimientoPersonal_TipoMovimientoPersonalId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.EstructuraPersonals)
                .HasForeignKey(d => d.UnidadId)
                .HasConstraintName("FK_dbo.EstructuraPersonal_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<EstructuraPersonalAux>(entity =>
        {
            entity.HasKey(e => e.EstructuraPersonalAuxId).HasName("PK_dbo.EstructuraPersonalAux");

            entity.ToTable("EstructuraPersonalAux");

            entity.Property(e => e.CodigoSinempleado).HasColumnName("CodigoSINEmpleado");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaProceso).HasColumnType("datetime");
            entity.Property(e => e.HaberBasico).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<EstructuraPersonalLog>(entity =>
        {
            entity.HasKey(e => e.EstructuraPersonalLogId).HasName("PK_dbo.EstructuraPersonalLog");

            entity.ToTable("EstructuraPersonalLog");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaFinNew).HasColumnType("datetime");
            entity.Property(e => e.FechaFinOld).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioNew).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioOld).HasColumnType("datetime");
            entity.Property(e => e.HaberBasicoNew).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.HaberBasicoOld).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Fabrica>(entity =>
        {
            entity.HasKey(e => e.FabricaId).HasName("PK_dbo.Fabrica");

            entity.ToTable("Fabrica");
        });

        modelBuilder.Entity<FabricaTrader>(entity =>
        {
            entity.HasKey(e => e.FabricaTraderId).HasName("PK_dbo.FabricaTrader");

            entity.ToTable("FabricaTrader");

            entity.HasIndex(e => e.FabricaId, "IX_FabricaId");

            entity.HasIndex(e => e.TraderId, "IX_TraderId");

            entity.HasOne(d => d.Fabrica).WithMany(p => p.FabricaTraders)
                .HasForeignKey(d => d.FabricaId)
                .HasConstraintName("FK_dbo.FabricaTrader_dbo.Fabrica_FabricaId");

            entity.HasOne(d => d.Trader).WithMany(p => p.FabricaTraders)
                .HasForeignKey(d => d.TraderId)
                .HasConstraintName("FK_dbo.FabricaTrader_dbo.Trader_TraderId");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK_dbo.Factura");

            entity.ToTable("Factura");

            entity.HasIndex(e => e.DocumentoAutorizacionId, "IX_Factura");

            entity.Property(e => e.CodControl).HasColumnName("Cod_Control");
            entity.Property(e => e.Cuf).HasColumnName("cuf");
            entity.Property(e => e.FechaEmision)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Emision");
            entity.Property(e => e.FechaSiat)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_siat");
            entity.Property(e => e.Leyenda).HasDefaultValueSql("('')");
            entity.Property(e => e.NroFactura).HasColumnName("Nro_Factura");
        });

        modelBuilder.Entity<FacturaComision>(entity =>
        {
            entity.HasKey(e => e.FacturaComisionId).HasName("PK_dbo.FacturaComision");

            entity.ToTable("FacturaComision");

            entity.Property(e => e.CobranzaUsd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CobranzaUSD");
            entity.Property(e => e.DescuentUsd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DescuentUSD");
            entity.Property(e => e.DescuentoPorcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FacturaUsd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FacturaUSD");
            entity.Property(e => e.NroFactura).HasColumnName("Nro_Factura");
        });

        modelBuilder.Entity<FaltasLog>(entity =>
        {
            entity.HasKey(e => e.FaltasLogId).HasName("PK_dbo.FaltasLog");

            entity.ToTable("FaltasLog");

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaLog).HasColumnType("datetime");
        });

        modelBuilder.Entity<FechaEspecial>(entity =>
        {
            entity.HasKey(e => e.FechaEspecialId).HasName("PK_dbo.FechaEspecial");

            entity.ToTable("FechaEspecial");

            entity.HasIndex(e => e.TipoFechaEspecialId, "IX_TipoFechaEspecialId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.HoraIngreso).HasPrecision(0);
            entity.Property(e => e.HoraSalida).HasPrecision(0);

            entity.HasOne(d => d.TipoFechaEspecial).WithMany(p => p.FechaEspecials)
                .HasForeignKey(d => d.TipoFechaEspecialId)
                .HasConstraintName("FK_dbo.FechaEspecial_dbo.TipoFechaEspecial_TipoFechaEspecialId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.FechaEspecials)
                .HasForeignKey(d => d.UnidadId)
                .HasConstraintName("FK_dbo.FechaEspecial_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<Garante>(entity =>
        {
            entity.HasKey(e => e.GaranteId).HasName("PK_dbo.Garante");

            entity.ToTable("Garante");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.Property(e => e.Ci).HasColumnName("CI");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Garantes)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_dbo.Garante_dbo.Empleado_EmpleadoId");
        });

        modelBuilder.Entity<Gestion>(entity =>
        {
            entity.HasKey(e => e.GestionId).HasName("PK_dbo.Gestion");

            entity.ToTable("Gestion");

            entity.Property(e => e.MinimoNacional).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<HabilitaCobranza>(entity =>
        {
            entity.HasKey(e => e.HabilitaCobranzaId).HasName("PK_dbo.HabilitaCobranza");

            entity.ToTable("HabilitaCobranza");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<HabilitadorPlanilla>(entity =>
        {
            entity.HasKey(e => e.HabilitadorPlanillaId).HasName("PK_dbo.HabilitadorPlanilla");

            entity.ToTable("HabilitadorPlanilla");

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaIni).HasColumnType("datetime");
        });

        modelBuilder.Entity<HistoricoDistribuidore>(entity =>
        {
            entity.HasKey(e => e.HistoricoDistribuidoresId).HasName("PK_dbo.HistoricoDistribuidores");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.TotalCobranzas).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<HistoricoFacturaComision>(entity =>
        {
            entity.HasKey(e => e.HistoricoFacturaComisionId).HasName("PK_dbo.HistoricoFacturaComision");

            entity.ToTable("HistoricoFacturaComision");

            entity.Property(e => e.FechaEmision).HasColumnType("datetime");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.HorarioId).HasName("PK_dbo.Horario");

            entity.ToTable("Horario");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.HoraIngreso1).HasPrecision(0);
            entity.Property(e => e.HoraIngreso2).HasPrecision(0);
            entity.Property(e => e.HoraIngreso3).HasPrecision(0);
            entity.Property(e => e.HoraSalida1).HasPrecision(0);
            entity.Property(e => e.HoraSalida2).HasPrecision(0);
            entity.Property(e => e.HoraSalida3).HasPrecision(0);

            entity.HasOne(d => d.Empleado).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_dbo.Horario_dbo.Empleado_EmpleadoId");
        });

        modelBuilder.Entity<IncrementoVacacion>(entity =>
        {
            entity.HasKey(e => e.IncrementoId);

            entity.ToTable("IncrementoVacacion");

            entity.Property(e => e.Dias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Empleado).WithMany(p => p.IncrementoVacacions)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_IncrementoVacacion_Empleado");
        });

        modelBuilder.Entity<Industry>(entity =>
        {
            entity.HasKey(e => e.IndustryId).HasName("PK_dbo.Industry");

            entity.ToTable("Industry");
        });

        modelBuilder.Entity<Ingreso>(entity =>
        {
            entity.HasKey(e => e.IngresoId).HasName("PK_dbo.Ingreso");

            entity.ToTable("Ingreso");

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasIndex(e => e.RequerimientoPedidoId, "IX_RequerimientoPedidoId");

            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.Almacen).WithMany(p => p.Ingresos)
                .HasForeignKey(d => d.AlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Ingreso_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Ingresos)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Ingreso_dbo.Proveedor_ProveedorId");

            entity.HasOne(d => d.RequerimientoPedido).WithMany(p => p.Ingresos)
                .HasForeignKey(d => d.RequerimientoPedidoId)
                .HasConstraintName("FK_dbo.Ingreso_dbo.RequerimientoPedido_RequerimientoPedidoId");
        });

        modelBuilder.Entity<IngresoDetalle>(entity =>
        {
            entity.HasKey(e => e.IngresoDetalleId).HasName("PK_dbo.IngresoDetalle");

            entity.ToTable("IngresoDetalle");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.IngresoId, "IX_IngresoId");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.IngresoDetalleId).HasColumnName("IngresoDetalleID");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.CostoIngreso).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.PrecioLista).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.IngresoDetalles)
                .HasForeignKey(d => d.EstadoProductoId)
                .HasConstraintName("FK_dbo.IngresoDetalle_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.Ingreso).WithMany(p => p.IngresoDetalles)
                .HasForeignKey(d => d.IngresoId)
                .HasConstraintName("FK_dbo.IngresoDetalle_dbo.Ingreso_IngresoId");

            entity.HasOne(d => d.Prod).WithMany(p => p.IngresoDetalles)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.IngresoDetalle_dbo.Prod_ProdId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.IngresoDetalles)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_dbo.IngresoDetalle_dbo.Proveedor_ProveedorId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.IngresoDetalles)
                .HasForeignKey(d => d.UsoProductoId)
                .HasConstraintName("FK_dbo.IngresoDetalle_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<IngresoInicialDetalle>(entity =>
        {
            entity.HasKey(e => e.IngresoInicialDetalleId).HasName("PK_dbo.IngresoInicialDetalle");

            entity.ToTable("IngresoInicialDetalle");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.PrecioLista).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.IngresoInicialDetalles)
                .HasForeignKey(d => d.EstadoProductoId)
                .HasConstraintName("FK_dbo.IngresoInicialDetalle_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.Prod).WithMany(p => p.IngresoInicialDetalles)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.IngresoInicialDetalle_dbo.Prod_ProdId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.IngresoInicialDetalles)
                .HasForeignKey(d => d.UsoProductoId)
                .HasConstraintName("FK_dbo.IngresoInicialDetalle_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<ItemsArmador>(entity =>
        {
            entity.HasKey(e => e.ItemsArmadorId).HasName("PK_dbo.ItemsArmador");

            entity.ToTable("ItemsArmador");

            entity.HasIndex(e => e.ArmadorId, "IX_ArmadorId");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.HasOne(d => d.Armador).WithMany(p => p.ItemsArmadors)
                .HasForeignKey(d => d.ArmadorId)
                .HasConstraintName("FK_dbo.ItemsArmador_dbo.Armador_ArmadorId");

            entity.HasOne(d => d.Prod).WithMany(p => p.ItemsArmadors)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.ItemsArmador_dbo.Prod_ProdId");
        });

        modelBuilder.Entity<ItemsProducto>(entity =>
        {
            entity.HasKey(e => e.ItemsProductoId).HasName("PK_dbo.ItemsProducto");

            entity.ToTable("ItemsProducto");

            entity.HasIndex(e => e.PackProductoId, "IX_PackProductoId");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.HasOne(d => d.PackProducto).WithMany(p => p.ItemsProductos)
                .HasForeignKey(d => d.PackProductoId)
                .HasConstraintName("FK_dbo.ItemsProducto_dbo.PackProducto_PackProductoId");

            entity.HasOne(d => d.Prod).WithMany(p => p.ItemsProductos)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.ItemsProducto_dbo.Prod_ProdId");
        });

        modelBuilder.Entity<Justificativo>(entity =>
        {
            entity.HasKey(e => e.JustificativoId).HasName("PK_dbo.Justificativo");

            entity.ToTable("Justificativo");

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
        });

        modelBuilder.Entity<JustificativoDetalle>(entity =>
        {
            entity.HasKey(e => e.JustificativoDetalleId).HasName("PK_dbo.JustificativoDetalle");

            entity.ToTable("JustificativoDetalle");

            entity.HasIndex(e => e.JustificativoId, "IX_JustificativoId");

            entity.HasOne(d => d.Justificativo).WithMany(p => p.JustificativoDetalles)
                .HasForeignKey(d => d.JustificativoId)
                .HasConstraintName("FK_dbo.JustificativoDetalle_dbo.Justificativo_JustificativoId");
        });

        modelBuilder.Entity<LogTransaccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LogTransaccion");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Campo)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Dato).IsUnicode(false);
            entity.Property(e => e.Evento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.LogTransaccionId).ValueGeneratedOnAdd();
            entity.Property(e => e.Pk)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PK");
            entity.Property(e => e.Tabla)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Terminal)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e.Usuario)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ValorNuevo)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ValorOriginal)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Mark>(entity =>
        {
            entity.HasKey(e => e.MarkId).HasName("PK_dbo.Mark");

            entity.ToTable("Mark");
        });

        modelBuilder.Entity<MatrizMigracion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MatrizMigracion");

            entity.Property(e => e.MatrizMigracionId).ValueGeneratedOnAdd();
            entity.Property(e => e.TipoDato)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MetaUnidad>(entity =>
        {
            entity.HasKey(e => e.MetaUnidadId).HasName("PK_dbo.MetaUnidad");

            entity.ToTable("MetaUnidad");

            entity.Property(e => e.Meta).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MetaVendedor>(entity =>
        {
            entity.HasKey(e => e.MetaVendedorId).HasName("PK_dbo.MetaVendedor");

            entity.ToTable("MetaVendedor");

            entity.Property(e => e.BonoAux).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ci).HasColumnName("CI");
            entity.Property(e => e.Meta).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK_dbo.Module");

            entity.ToTable("Module");

            entity.HasIndex(e => e.SubSystemId, "IX_SubSystemId");

            entity.Property(e => e.Identificador)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.SubSystem).WithMany(p => p.Modules)
                .HasForeignKey(d => d.SubSystemId)
                .HasConstraintName("FK_dbo.Module_dbo.SubSystem_SubSystemId");
        });

        modelBuilder.Entity<ModuleOperation>(entity =>
        {
            entity.HasKey(e => e.ModuleOperationId).HasName("PK_dbo.ModuleOperation");

            entity.ToTable("ModuleOperation");

            entity.HasIndex(e => e.AccessId, "IX_AccessId");

            entity.HasOne(d => d.Access).WithMany(p => p.ModuleOperations)
                .HasForeignKey(d => d.AccessId)
                .HasConstraintName("FK_dbo.ModuleOperation_dbo.Access_AccessId");
        });

        modelBuilder.Entity<Monedum>(entity =>
        {
            entity.HasKey(e => e.MonedaId).HasName("PK_dbo.Moneda");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Movimiento>(entity =>
        {
            entity.HasKey(e => e.MovimientoId).HasName("PK_dbo.Movimiento");

            entity.ToTable("Movimiento", tb => tb.HasTrigger("trIUDMovimiento"));

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.DocumentoAutorizacionId, "IX_DocumentoAutorizacionId");

            entity.HasIndex(e => e.DocumentoId, "IX_DocumentoId");

            entity.HasIndex(e => e.MonedaId, "IX_MonedaId");

            entity.HasIndex(e => e.RelacionMovimientoId, "IX_RelacionMovimientoId");

            entity.HasIndex(e => e.TipoMovimientoId, "IX_TipoMovimientoId");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCambioManual).HasColumnType("datetime");
            entity.Property(e => e.FechaPendiente).HasColumnType("datetime");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2048)
                .IsUnicode(false);
            entity.Property(e => e.Operacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RazonAnulacion).HasMaxLength(300);

            entity.HasOne(d => d.Almacen).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.AlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Movimiento_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.DocumentoAutorizacion).WithMany(p => p.MovimientoDocumentoAutorizacions)
                .HasForeignKey(d => d.DocumentoAutorizacionId)
                .HasConstraintName("FK_dbo.Movimiento_dbo.Documento_DocumentoAutorizacionId");

            entity.HasOne(d => d.Documento).WithMany(p => p.MovimientoDocumentos)
                .HasForeignKey(d => d.DocumentoId)
                .HasConstraintName("FK_dbo.Movimiento_dbo.Documento_DocumentoId");

            entity.HasOne(d => d.Moneda).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.MonedaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Movimiento_dbo.Moneda_MonedaId");

            entity.HasOne(d => d.RelacionMovimiento).WithMany(p => p.InverseRelacionMovimiento)
                .HasForeignKey(d => d.RelacionMovimientoId)
                .HasConstraintName("FK_dbo.Movimiento_dbo.Movimiento_RelacionMovimientoId");

            entity.HasOne(d => d.TipoMovimiento).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.TipoMovimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Movimiento_dbo.TipoMovimiento_TipoMovimientoId");
        });

        modelBuilder.Entity<MovimientoActivo>(entity =>
        {
            entity.HasKey(e => e.MovimientoActivoId).HasName("PK_dbo.MovimientoActivo");

            entity.ToTable("MovimientoActivo");

            entity.HasIndex(e => e.DocumentoActivoId, "IX_DocumentoActivoId");

            entity.HasIndex(e => e.TipoMovimientoActivoId, "IX_TipoMovimientoActivoId");

            entity.Property(e => e.AlmacenAfid).HasColumnName("AlmacenAFId");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCambioManual).HasColumnType("datetime");
            entity.Property(e => e.FechaPendiente).HasColumnType("datetime");

            entity.HasOne(d => d.DocumentoActivo).WithMany(p => p.MovimientoActivos)
                .HasForeignKey(d => d.DocumentoActivoId)
                .HasConstraintName("FK_dbo.MovimientoActivo_dbo.DocumentoActivo_DocumentoActivoId");

            entity.HasOne(d => d.TipoMovimientoActivo).WithMany(p => p.MovimientoActivos)
                .HasForeignKey(d => d.TipoMovimientoActivoId)
                .HasConstraintName("FK_dbo.MovimientoActivo_dbo.TipoMovimientoActivo_TipoMovimientoActivoId");
        });

        modelBuilder.Entity<MovimientoDetalle>(entity =>
        {
            entity.HasKey(e => e.MovimientoDetalleId).HasName("PK_dbo.MovimientoDetalle");

            entity.ToTable("MovimientoDetalle", tb => tb.HasTrigger("trIUDMovimientoDetalle"));

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId").HasFillFactor(100);

            entity.HasIndex(e => e.MovimientoId, "IX_MovimientoId").HasFillFactor(100);

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId").HasFillFactor(100);

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.CostoAnterior).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.CostoIngreso).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.Obs)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.MovimientoDetalles)
                .HasForeignKey(d => d.EstadoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.MovimientoDetalle_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.Movimiento).WithMany(p => p.MovimientoDetalles)
                .HasForeignKey(d => d.MovimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.MovimientoDetalle_dbo.Movimiento_MovimientoId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.MovimientoDetalles)
                .HasForeignKey(d => d.UsoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.MovimientoDetalle_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<MovimientoDetalleActivo>(entity =>
        {
            entity.HasKey(e => e.MovimientoDetalleActivoId).HasName("PK_dbo.MovimientoDetalleActivo");

            entity.ToTable("MovimientoDetalleActivo");

            entity.HasIndex(e => e.MovimientoActivoId, "IX_MovimientoActivoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoAnterior).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoIngreso).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MovimientoActivo).WithMany(p => p.MovimientoDetalleActivos)
                .HasForeignKey(d => d.MovimientoActivoId)
                .HasConstraintName("FK_dbo.MovimientoDetalleActivo_dbo.MovimientoActivo_MovimientoActivoId");
        });

        modelBuilder.Entity<Nacional>(entity =>
        {
            entity.HasKey(e => e.NacionalId).HasName("PK_dbo.Nacional");

            entity.ToTable("Nacional");
        });

        modelBuilder.Entity<NivelAcademico>(entity =>
        {
            entity.HasKey(e => e.NivelAcademicoId).HasName("PK_dbo.NivelAcademico");

            entity.ToTable("NivelAcademico");
        });

        modelBuilder.Entity<NoConformidad>(entity =>
        {
            entity.HasKey(e => e.NoConformidadId).HasName("PK_dbo.NoConformidad");

            entity.ToTable("NoConformidad");

            entity.HasIndex(e => e.MovimientoDetalleId, "IX_MovimientoDetalleId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.Detalle)
                .HasMaxLength(2048)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaResuelto).HasColumnType("datetime");
            entity.Property(e => e.Imagen1).HasColumnType("image");
            entity.Property(e => e.Imagen2).HasColumnType("image");
            entity.Property(e => e.ObsResuelto)
                .HasMaxLength(2048)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NotaComision>(entity =>
        {
            entity.HasKey(e => e.NotaComisionId).HasName("PK_dbo.NotaComision");

            entity.ToTable("NotaComision");
        });

        modelBuilder.Entity<NotaDc>(entity =>
        {
            entity.HasKey(e => e.NotaDcid).HasName("PK_dbo.NotaDC");

            entity.ToTable("NotaDC");

            entity.Property(e => e.NotaDcid).HasColumnName("NotaDCId");
            entity.Property(e => e.CodControl).HasColumnName("Cod_Control");
            entity.Property(e => e.Cuf).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaEmision)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Emision");
            entity.Property(e => e.FechaSiat).HasColumnType("datetime");
            entity.Property(e => e.Leyenda).HasDefaultValueSql("('')");
            entity.Property(e => e.NroNotaDc).HasColumnName("Nro_NotaDC");
        });

        modelBuilder.Entity<NotasCreditoDebito>(entity =>
        {
            entity.HasKey(e => e.NotasCreditoDebitoId).HasName("PK_dbo.NotasCreditoDebito");

            entity.ToTable("NotasCreditoDebito");

            entity.Property(e => e.CodDosificacion).HasColumnName("Cod_Dosificacion");
            entity.Property(e => e.ConfCiudad).HasColumnName("confCiudad");
            entity.Property(e => e.ConfEstadoImpre).HasColumnName("confEstadoImpre");
            entity.Property(e => e.ConfLeyenda1).HasColumnName("confLeyenda1");
            entity.Property(e => e.ConfLeyenda2).HasColumnName("confLeyenda2");
            entity.Property(e => e.ConfNitEmisor).HasColumnName("confNitEmisor");
            entity.Property(e => e.ConfRubro1).HasColumnName("confRubro1");
            entity.Property(e => e.ConfRubro2).HasColumnName("confRubro2");
            entity.Property(e => e.ConfRubro3).HasColumnName("confRubro3");
            entity.Property(e => e.ConfSucursalCiudad).HasColumnName("confSucursalCiudad");
            entity.Property(e => e.ConfSucursalDir1).HasColumnName("confSucursalDir1");
            entity.Property(e => e.ConfSucursalDir2).HasColumnName("confSucursalDir2");
            entity.Property(e => e.ConfSucursalNro).HasColumnName("confSucursalNro");
            entity.Property(e => e.FechaActivacion).HasColumnType("datetime");
            entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDesactivacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinUso).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioUso).HasColumnType("datetime");
            entity.Property(e => e.FechaLimite)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Limite");
            entity.Property(e => e.NroAutorizacion).HasColumnName("Nro_Autorizacion");
            entity.Property(e => e.NroFin).HasColumnName("Nro_Fin");
            entity.Property(e => e.NroInicio).HasColumnName("Nro_Inicio");
            entity.Property(e => e.NroTramite).HasColumnName("Nro_Tramite");
        });

        modelBuilder.Entity<NumeroDocumento>(entity =>
        {
            entity.HasKey(e => e.NumeroDocumentoId).HasName("PK_dbo.NumeroDocumento");

            entity.ToTable("NumeroDocumento");

            entity.HasIndex(e => e.TipoDocumentoId, "IX_TipoDocumentoId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.NumeroDocumentos)
                .HasForeignKey(d => d.TipoDocumentoId)
                .HasConstraintName("FK_dbo.NumeroDocumento_dbo.TipoDocumento_TipoDocumentoId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.NumeroDocumentos)
                .HasForeignKey(d => d.UnidadId)
                .HasConstraintName("FK_dbo.NumeroDocumento_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<NumeroDocumentoActivo>(entity =>
        {
            entity.HasKey(e => e.NumeroDocumentoActivoId).HasName("PK_dbo.NumeroDocumentoActivo");

            entity.ToTable("NumeroDocumentoActivo");

            entity.HasIndex(e => e.TipoDocumentoActivoId, "IX_TipoDocumentoActivoId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.HasOne(d => d.TipoDocumentoActivo).WithMany(p => p.NumeroDocumentoActivos)
                .HasForeignKey(d => d.TipoDocumentoActivoId)
                .HasConstraintName("FK_dbo.NumeroDocumentoActivo_dbo.TipoDocumentoActivo_TipoDocumentoActivoId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.NumeroDocumentoActivos)
                .HasForeignKey(d => d.UnidadId)
                .HasConstraintName("FK_dbo.NumeroDocumentoActivo_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<PackProducto>(entity =>
        {
            entity.HasKey(e => e.PackProductoId).HasName("PK_dbo.PackProducto");

            entity.ToTable("PackProducto");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.PaisId).HasName("PK_dbo.Pais");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasKey(e => e.ParametroId).HasName("PK_dbo.Parametro");

            entity.ToTable("Parametro");

            entity.Property(e => e.FinGest).HasColumnType("datetime");
            entity.Property(e => e.InicioGest).HasColumnType("datetime");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Parcial>(entity =>
        {
            entity.HasKey(e => e.ParcialId).HasName("PK_dbo.Parcial");

            entity.ToTable("Parcial");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaConfirma).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.Observaciones).HasMaxLength(2048);
            entity.Property(e => e.Operacion).HasMaxLength(1);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPend).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ParcialDetalle>(entity =>
        {
            entity.HasKey(e => e.ParcialDetalleId).HasName("PK_dbo.ParcialDetalle");

            entity.ToTable("ParcialDetalle");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCotiza).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.PedidoId).HasName("PK_dbo.Pedido");

            entity.ToTable("Pedido");

            entity.Property(e => e.DescuentoFraccion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoValor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.PrecioOferta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Validez).HasColumnType("datetime");
        });

        modelBuilder.Entity<PedidoCobranza>(entity =>
        {
            entity.HasKey(e => e.PedidoCobranzaId).HasName("PK_dbo.PedidoCobranza");

            entity.ToTable("PedidoCobranza");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.SaldoCobranza).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PedidoItem>(entity =>
        {
            entity.HasKey(e => e.PedidoItemsId).HasName("PK_dbo.PedidoItems");

            entity.HasIndex(e => e.PedidoId, "IX_PedidoId");

            entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUfv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CostoUFV");
            entity.Property(e => e.FraccionDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeReglas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCotizacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioNominal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreferenteDescuento).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Pedido).WithMany(p => p.PedidoItems)
                .HasForeignKey(d => d.PedidoId)
                .HasConstraintName("FK_dbo.PedidoItems_dbo.Pedido_PedidoId");
        });

        modelBuilder.Entity<PedidoLocal>(entity =>
        {
            entity.HasKey(e => e.PedidoLocalId).HasName("PK_dbo.PedidoLocal");

            entity.ToTable("PedidoLocal");

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.Almacen).WithMany(p => p.PedidoLocals)
                .HasForeignKey(d => d.AlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.PedidoLocal_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.PedidoLocals)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.PedidoLocal_dbo.Proveedor_ProveedorId");
        });

        modelBuilder.Entity<PedidoLocalDetalle>(entity =>
        {
            entity.HasKey(e => e.PedidoLocalDetalleId).HasName("PK_dbo.PedidoLocalDetalle");

            entity.ToTable("PedidoLocalDetalle");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.PedidoLocalId, "IX_PedidoLocalId");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.CostoIngreso).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.PrecioLista).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.PedidoLocalDetalles)
                .HasForeignKey(d => d.EstadoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.PedidoLocalDetalle_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.PedidoLocal).WithMany(p => p.PedidoLocalDetalles)
                .HasForeignKey(d => d.PedidoLocalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.PedidoLocalDetalle_dbo.PedidoLocal_PedidoLocalId");

            entity.HasOne(d => d.Prod).WithMany(p => p.PedidoLocalDetalles)
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.PedidoLocalDetalle_dbo.Prod_ProdId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.PedidoLocalDetalles)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.PedidoLocalDetalle_dbo.Proveedor_ProveedorId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.PedidoLocalDetalles)
                .HasForeignKey(d => d.UsoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.PedidoLocalDetalle_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<PedidoProveedor>(entity =>
        {
            entity.HasKey(e => e.PedidoProveedorId).HasName("PK_dbo.PedidoProveedor");

            entity.ToTable("PedidoProveedor");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<PedidoProveedorItem>(entity =>
        {
            entity.HasKey(e => e.PedidoProveedorItemsId).HasName("PK_dbo.PedidoProveedorItems");

            entity.HasIndex(e => e.PedidoProveedorId, "IX_PedidoProveedorId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Uso).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.PedidoProveedor).WithMany(p => p.PedidoProveedorItems)
                .HasForeignKey(d => d.PedidoProveedorId)
                .HasConstraintName("FK_dbo.PedidoProveedorItems_dbo.PedidoProveedor_PedidoProveedorId");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.PermisoId).HasName("PK_dbo.Permiso");

            entity.ToTable("Permiso");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.HasIndex(e => e.TipoPermisoId, "IX_TipoPermisoId");

            entity.Property(e => e.DocumentoRrhhid).HasColumnName("DocumentoRRHHId");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_dbo.Permiso_dbo.Empleado_EmpleadoId");

            entity.HasOne(d => d.TipoPermiso).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.TipoPermisoId)
                .HasConstraintName("FK_dbo.Permiso_dbo.TipoPermiso_TipoPermisoId");
        });

        modelBuilder.Entity<Planilla>(entity =>
        {
            entity.HasKey(e => e.PlanillaId).HasName("PK_dbo.Planilla");

            entity.ToTable("Planilla");

            entity.HasIndex(e => e.TipoPlanillaId, "IX_TipoPlanillaId");

            entity.HasIndex(e => e.UfvId, "IX_UfvId");

            entity.Property(e => e.AfpPatronal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Afp_Patronal");
            entity.Property(e => e.AfpPlanilla)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Afp_Planilla");
            entity.Property(e => e.FonviPatronal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Fonvi_Patronal");
            entity.Property(e => e.SeguroPatronal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Seguro_Patronal");
            entity.Property(e => e.SolidarioPatronal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Solidario_Patronal");
            entity.Property(e => e.UfvF).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.UfvI).HasColumnType("decimal(18, 5)");

            entity.HasOne(d => d.TipoPlanilla).WithMany(p => p.Planillas)
                .HasForeignKey(d => d.TipoPlanillaId)
                .HasConstraintName("FK_dbo.Planilla_dbo.TipoPlanilla_TipoPlanillaId");

            entity.HasOne(d => d.Ufv).WithMany(p => p.Planillas)
                .HasForeignKey(d => d.UfvId)
                .HasConstraintName("FK_dbo.Planilla_dbo.Ufv_UfvId");
        });

        modelBuilder.Entity<PlanillaAuxiliar>(entity =>
        {
            entity.HasKey(e => e.PlanillaAuxiliarId).HasName("PK_dbo.PlanillaAuxiliar");

            entity.ToTable("PlanillaAuxiliar");

            entity.Property(e => e.Afp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtrosBonos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeAfp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rciva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RCIva");
            entity.Property(e => e.TotalGanado).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PlanillaDetalle>(entity =>
        {
            entity.HasKey(e => e.PlanillaDetalleId).HasName("PK_dbo.PlanillaDetalle");

            entity.ToTable("PlanillaDetalle");

            entity.HasIndex(e => e.EstructuraPersonalId, "IX_EstructuraPersonalId");

            entity.HasIndex(e => e.PlanillaId, "IX_PlanillaId");

            entity.Property(e => e.Afp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Anticipo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BonoAntiguedad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BonoProduccion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Comision).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoFaltas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoOtros).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoRetrasos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoSancion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HaberBasico).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HaberMensual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LiquidoPagable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoRetrazo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtrosBonos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeAfp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rciva)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RCIva");
            entity.Property(e => e.TotalDescuentos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiasTrabajados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDiasVacacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalFaltas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalGanado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPermisos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalRetrasos).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.EstructuraPersonal).WithMany(p => p.PlanillaDetalles)
                .HasForeignKey(d => d.EstructuraPersonalId)
                .HasConstraintName("FK_dbo.PlanillaDetalle_dbo.EstructuraPersonal_EstructuraPersonalId");

            entity.HasOne(d => d.Planilla).WithMany(p => p.PlanillaDetalles)
                .HasForeignKey(d => d.PlanillaId)
                .HasConstraintName("FK_dbo.PlanillaDetalle_dbo.Planilla_PlanillaId");
        });

        modelBuilder.Entity<PlanillaImpositiva>(entity =>
        {
            entity.HasKey(e => e.PlanillaImpositivaId).HasName("PK_dbo.PlanillaImpositiva");

            entity.ToTable("PlanillaImpositiva");

            entity.Property(e => e.Dependiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Dnimponible)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DNImponible");
            entity.Property(e => e.Dsimpuesto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DSImpuesto");
            entity.Property(e => e.Fisco).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FormularioDiez).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImpuestoRciva).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImpuestoRetenido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Mvalor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MValor");
            entity.Property(e => e.Retroactivo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoAnterior).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoFavDepen).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaldoFavMesSgte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Smnal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sncomputable)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SNComputable");
            entity.Property(e => e.StfavDepen)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("STFavDepen");
            entity.Property(e => e.Sutilizado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SUtilizado");
            entity.Property(e => e.Tganado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TGanado");
        });

        modelBuilder.Entity<PreGuardadoProducto>(entity =>
        {
            entity.HasKey(e => e.PreGuardadoProductoId).HasName("PK_dbo.PreGuardadoProducto");

            entity.ToTable("PreGuardadoProducto");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Prod).WithMany(p => p.PreGuardadoProductos)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.PreGuardadoProducto_dbo.Prod_ProdId");
        });

        modelBuilder.Entity<PrecioClientePreferencial>(entity =>
        {
            entity.HasKey(e => e.PrecioClientePreferencialId).HasName("PK_dbo.PrecioClientePreferencial");

            entity.ToTable("PrecioClientePreferencial");

            entity.HasIndex(e => e.PrecioDiferenciadoId, "IX_PrecioDiferenciadoId");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");

            entity.HasOne(d => d.PrecioDiferenciado).WithMany(p => p.PrecioClientePreferencials)
                .HasForeignKey(d => d.PrecioDiferenciadoId)
                .HasConstraintName("FK_dbo.PrecioClientePreferencial_dbo.PrecioDiferenciado_PrecioDiferenciadoId");
        });

        modelBuilder.Entity<PrecioDiferenciado>(entity =>
        {
            entity.HasKey(e => e.PrecioDiferenciadoId).HasName("PK_dbo.PrecioDiferenciado");

            entity.ToTable("PrecioDiferenciado");

            entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PrecioDiferenciadoCliente>(entity =>
        {
            entity.HasKey(e => e.PrecioDiferenciadoClienteId).HasName("PK_dbo.PrecioDiferenciadoCliente");

            entity.ToTable("PrecioDiferenciadoCliente");

            entity.HasIndex(e => e.PrecioDiferenciadoId, "IX_PrecioDiferenciadoId");

            entity.HasIndex(e => e.TipoClienteId, "IX_TipoClienteId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.PrecioDiferenciado).WithMany(p => p.PrecioDiferenciadoClientes)
                .HasForeignKey(d => d.PrecioDiferenciadoId)
                .HasConstraintName("FK_dbo.PrecioDiferenciadoCliente_dbo.PrecioDiferenciado_PrecioDiferenciadoId");

            entity.HasOne(d => d.TipoCliente).WithMany(p => p.PrecioDiferenciadoClientes)
                .HasForeignKey(d => d.TipoClienteId)
                .HasConstraintName("FK_dbo.PrecioDiferenciadoCliente_dbo.TipoCliente_TipoClienteId");
        });

        modelBuilder.Entity<PrecioMarcaCliente>(entity =>
        {
            entity.HasKey(e => e.PrecioMarcaClienteId).HasName("PK_dbo.PrecioMarcaCliente");

            entity.ToTable("PrecioMarcaCliente");

            entity.HasIndex(e => e.PrecioDiferenciadoId, "IX_PrecioDiferenciadoId");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");

            entity.HasOne(d => d.PrecioDiferenciado).WithMany(p => p.PrecioMarcaClientes)
                .HasForeignKey(d => d.PrecioDiferenciadoId)
                .HasConstraintName("FK_dbo.PrecioMarcaCliente_dbo.PrecioDiferenciado_PrecioDiferenciadoId");
        });

        modelBuilder.Entity<Prepedido>(entity =>
        {
            entity.HasKey(e => e.PrepedidoId).HasName("PK_dbo.Prepedido");

            entity.ToTable("Prepedido");

            entity.Property(e => e.DescuentoFraccion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoValor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.PrecioOferta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Validez).HasColumnType("datetime");
        });

        modelBuilder.Entity<PrepedidoItem>(entity =>
        {
            entity.HasKey(e => e.PrepedidoItemsId).HasName("PK_dbo.PrepedidoItems");

            entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUfv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CostoUFV");
            entity.Property(e => e.FraccionDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeReglas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCotizacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioNominal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreferenteDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Use).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.PrestamoId).HasName("PK_dbo.Prestamo");

            entity.ToTable("Prestamo");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaF).HasColumnType("datetime");
            entity.Property(e => e.FechaI).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_dbo.Prestamo_dbo.Empleado_EmpleadoId");
        });

        modelBuilder.Entity<PrestamoDetalle>(entity =>
        {
            entity.HasKey(e => e.PrestamoDetalleId).HasName("PK_dbo.PrestamoDetalle");

            entity.ToTable("PrestamoDetalle");

            entity.HasIndex(e => e.PrestamoId, "IX_PrestamoId");

            entity.Property(e => e.Debe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.Haber).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Prestamo).WithMany(p => p.PrestamoDetalles)
                .HasForeignKey(d => d.PrestamoId)
                .HasConstraintName("FK_dbo.PrestamoDetalle_dbo.Prestamo_PrestamoId");
        });

        modelBuilder.Entity<Prod>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK_dbo.Prod");

            entity.ToTable("Prod");

            entity.HasIndex(e => e.CategoryId, "IX_CategoryId");

            entity.HasIndex(e => e.IndustryId, "IX_IndustryId");

            entity.HasIndex(e => e.MarkId, "IX_MarkId");

            entity.HasIndex(e => e.TypeProdId, "IX_TypeProdId");

            entity.Property(e => e.CantidadPallet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUfv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CostoUFV");
            entity.Property(e => e.EmpaqueMinimo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCambio).HasColumnType("datetime");
            entity.Property(e => e.MargenBeneficio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MargenBeneficioPorcentual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VolumenEmbalaje).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.VolumenExtra).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.VolumenPallet).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.VolumenSinEmbalaje).HasColumnType("decimal(14, 6)");

            entity.HasOne(d => d.Category).WithMany(p => p.Prods)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_dbo.Prod_dbo.Category_CategoryId");

            entity.HasOne(d => d.Industry).WithMany(p => p.Prods)
                .HasForeignKey(d => d.IndustryId)
                .HasConstraintName("FK_dbo.Prod_dbo.Industry_IndustryId");

            entity.HasOne(d => d.Mark).WithMany(p => p.Prods)
                .HasForeignKey(d => d.MarkId)
                .HasConstraintName("FK_dbo.Prod_dbo.Mark_MarkId");

            entity.HasOne(d => d.TypeProd).WithMany(p => p.Prods)
                .HasForeignKey(d => d.TypeProdId)
                .HasConstraintName("FK_dbo.Prod_dbo.TypeProd_TypeProdId");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK_dbo.Producto");

            entity.ToTable("Producto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(2048)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.Volumen).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<Profesion>(entity =>
        {
            entity.HasKey(e => e.ProfesionId).HasName("PK_dbo.Profesion");

            entity.ToTable("Profesion");
        });

        modelBuilder.Entity<ProfesionOficio>(entity =>
        {
            entity.HasKey(e => e.ProfesionOficioId).HasName("PK_dbo.ProfesionOficio");

            entity.ToTable("ProfesionOficio");
        });

        modelBuilder.Entity<Proforma>(entity =>
        {
            entity.HasKey(e => e.ProformaId).HasName("PK_dbo.Proforma");

            entity.ToTable("Proforma");

            entity.Property(e => e.DescuentoFraccion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoValor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.PrecioOferta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMoneda2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Validez).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProformaItem>(entity =>
        {
            entity.HasKey(e => e.ProformaItemsId).HasName("PK_dbo.ProformaItems");

            entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUfv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CostoUFV");
            entity.Property(e => e.FraccionDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeReglas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioCotizacion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioNominal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PreferenteDescuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Use).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ProformaProveedor>(entity =>
        {
            entity.HasKey(e => e.ProformaProveedorId).HasName("PK_dbo.ProformaProveedor");

            entity.ToTable("ProformaProveedor");

            entity.HasIndex(e => e.CompromisoVentasId, "IX_CompromisoVentasId");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

            entity.HasOne(d => d.CompromisoVentas).WithMany(p => p.ProformaProveedors)
                .HasForeignKey(d => d.CompromisoVentasId)
                .HasConstraintName("FK_dbo.ProformaProveedor_dbo.CompromisoVentas_CompromisoVentasId");
        });

        modelBuilder.Entity<ProformaProveedorDetalle>(entity =>
        {
            entity.HasKey(e => e.ProformaProveedorDetalleId).HasName("PK_dbo.ProformaProveedorDetalle");

            entity.ToTable("ProformaProveedorDetalle");
        });

        modelBuilder.Entity<ProformaProveedorItem>(entity =>
        {
            entity.HasKey(e => e.ProformaProveedorItemsId).HasName("PK_dbo.ProformaProveedorItems");

            entity.HasIndex(e => e.ProformaProveedorId, "IX_ProformaProveedorId");

            entity.Property(e => e.AlmacenProveedor).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cantidad)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CantidadPropuestaFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CantidadPropuestaPedido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompromisoNacional).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalExistencias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UltimaProforma).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UltimoPedido).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Uso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VentasNacional).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ProformaProveedor).WithMany(p => p.ProformaProveedorItems)
                .HasForeignKey(d => d.ProformaProveedorId)
                .HasConstraintName("FK_dbo.ProformaProveedorItems_dbo.ProformaProveedor_ProformaProveedorId");
        });

        modelBuilder.Entity<Prospecto>(entity =>
        {
            entity.HasKey(e => e.ProspectoId).HasName("PK_dbo.Prospecto");

            entity.ToTable("Prospecto");

            entity.Property(e => e.FechaVisita).HasColumnType("datetime");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.ProveedorId).HasName("PK_dbo.Proveedor");

            entity.ToTable("Proveedor");

            entity.HasIndex(e => e.PaisId, "IX_PaisId");

            entity.HasIndex(e => e.TipoProveedorId, "IX_TipoProveedorId");

            entity.HasOne(d => d.Pais).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.PaisId)
                .HasConstraintName("FK_dbo.Proveedor_dbo.Pais_PaisId");

            entity.HasOne(d => d.TipoProveedor).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.TipoProveedorId)
                .HasConstraintName("FK_dbo.Proveedor_dbo.TipoProveedor_TipoProveedorId");
        });

        modelBuilder.Entity<ProveedorFabrica>(entity =>
        {
            entity.HasKey(e => e.ProveedorFabricaId).HasName("PK_dbo.ProveedorFabrica");

            entity.ToTable("ProveedorFabrica");

            entity.HasIndex(e => e.FabricaId, "IX_FabricaId");

            entity.HasIndex(e => e.MarkId, "IX_MarkId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasOne(d => d.Fabrica).WithMany(p => p.ProveedorFabricas)
                .HasForeignKey(d => d.FabricaId)
                .HasConstraintName("FK_dbo.ProveedorFabrica_dbo.Fabrica_FabricaId");

            entity.HasOne(d => d.Mark).WithMany(p => p.ProveedorFabricas)
                .HasForeignKey(d => d.MarkId)
                .HasConstraintName("FK_dbo.ProveedorFabrica_dbo.Mark_MarkId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProveedorFabricas)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_dbo.ProveedorFabrica_dbo.Proveedor_ProveedorId");
        });

        modelBuilder.Entity<ProveedorNacional>(entity =>
        {
            entity.HasKey(e => e.ProveedorNacionalId).HasName("PK_dbo.ProveedorNacional");

            entity.ToTable("ProveedorNacional");

            entity.HasIndex(e => e.MarkId, "IX_MarkId");

            entity.HasIndex(e => e.NacionalId, "IX_NacionalId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasOne(d => d.Mark).WithMany(p => p.ProveedorNacionals)
                .HasForeignKey(d => d.MarkId)
                .HasConstraintName("FK_dbo.ProveedorNacional_dbo.Mark_MarkId");

            entity.HasOne(d => d.Nacional).WithMany(p => p.ProveedorNacionals)
                .HasForeignKey(d => d.NacionalId)
                .HasConstraintName("FK_dbo.ProveedorNacional_dbo.Nacional_NacionalId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProveedorNacionals)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_dbo.ProveedorNacional_dbo.Proveedor_ProveedorId");
        });

        modelBuilder.Entity<ProveedorProdRel>(entity =>
        {
            entity.HasKey(e => e.ProveedorProdRelId).HasName("PK_dbo.ProveedorProdRel");

            entity.ToTable("ProveedorProdRel");

            entity.HasIndex(e => e.ProveedorProductoId, "IX_ProveedorProductoId");
        });

        modelBuilder.Entity<ProveedorProducto>(entity =>
        {
            entity.HasKey(e => e.ProveedorProductoId).HasName("PK_dbo.ProveedorProducto");

            entity.ToTable("ProveedorProducto");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProveedorProductos)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_dbo.ProveedorProducto_dbo.Proveedor_ProveedorId");
        });

        modelBuilder.Entity<ProveedorProductoProd>(entity =>
        {
            entity.HasKey(e => e.ProveedorProductoProdId).HasName("PK_dbo.ProveedorProductoProd");

            entity.ToTable("ProveedorProductoProd");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.HasIndex(e => e.ProveedorProductoId, "IX_ProveedorProductoId");

            entity.HasOne(d => d.Prod).WithMany(p => p.ProveedorProductoProds)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.ProveedorProductoProd_dbo.Prod_ProdId");

            entity.HasOne(d => d.ProveedorProducto).WithMany(p => p.ProveedorProductoProds)
                .HasForeignKey(d => d.ProveedorProductoId)
                .HasConstraintName("FK_dbo.ProveedorProductoProd_dbo.ProveedorProducto_ProveedorProductoId");
        });

        modelBuilder.Entity<ProveedorTrader>(entity =>
        {
            entity.HasKey(e => e.ProveedorTraderId).HasName("PK_dbo.ProveedorTrader");

            entity.ToTable("ProveedorTrader");

            entity.HasIndex(e => e.MarkId, "IX_MarkId");

            entity.HasIndex(e => e.ProveedorId, "IX_ProveedorId");

            entity.HasIndex(e => e.TraderId, "IX_TraderId");

            entity.HasOne(d => d.Mark).WithMany(p => p.ProveedorTraders)
                .HasForeignKey(d => d.MarkId)
                .HasConstraintName("FK_dbo.ProveedorTrader_dbo.Mark_MarkId");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProveedorTraders)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK_dbo.ProveedorTrader_dbo.Proveedor_ProveedorId");

            entity.HasOne(d => d.Trader).WithMany(p => p.ProveedorTraders)
                .HasForeignKey(d => d.TraderId)
                .HasConstraintName("FK_dbo.ProveedorTrader_dbo.Trader_TraderId");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.ProvinciaId).HasName("PK_dbo.Provincia");
        });

        modelBuilder.Entity<Proyecto>(entity =>
        {
            entity.HasKey(e => e.ProyectoId).HasName("PK_dbo.Proyecto");

            entity.ToTable("Proyecto");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
        });

        modelBuilder.Entity<ProyectoDetallePedido>(entity =>
        {
            entity.HasKey(e => e.ProyectoDetallePedidoId).HasName("PK_dbo.ProyectoDetallePedido");

            entity.ToTable("ProyectoDetallePedido");

            entity.HasIndex(e => e.ProyectoId, "IX_ProyectoId");

            entity.Property(e => e.CantFacturado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usado).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Proyecto).WithMany(p => p.ProyectoDetallePedidos)
                .HasForeignKey(d => d.ProyectoId)
                .HasConstraintName("FK_dbo.ProyectoDetallePedido_dbo.Proyecto_ProyectoId");
        });

        modelBuilder.Entity<PuntoVentum>(entity =>
        {
            entity.HasKey(e => e.PuntoVentaId).HasName("PK_dbo.PuntoVenta");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<RegistroBaja>(entity =>
        {
            entity.HasKey(e => e.RegistroBajasId).HasName("PK_dbo.RegistroBajas");

            entity.Property(e => e.Dias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FecBaja)
                .HasColumnType("datetime")
                .HasColumnName("fecBaja");
        });

        modelBuilder.Entity<RegistroBiometrico>(entity =>
        {
            entity.HasKey(e => e.RegistroBiometricoId).HasName("PK_dbo.RegistroBiometrico");

            entity.ToTable("RegistroBiometrico");

            entity.HasIndex(e => e.BiometricoId, "IX_BiometricoId");

            entity.HasOne(d => d.Biometrico).WithMany(p => p.RegistroBiometricos)
                .HasForeignKey(d => d.BiometricoId)
                .HasConstraintName("FK_dbo.RegistroBiometrico_dbo.Biometrico_BiometricoId");
        });

        modelBuilder.Entity<RegistroCambioLista>(entity =>
        {
            entity.HasKey(e => e.RegistroCambioListasId).HasName("PK_dbo.RegistroCambioListas");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PorcentajeActual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajeAnterior).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<RegistroCambioProducto>(entity =>
        {
            entity.HasKey(e => e.RegistroCambioProductosId).HasName("PK_dbo.RegistroCambioProductos");

            entity.HasIndex(e => e.ProdId, "IX_ProdId");

            entity.Property(e => e.Costo).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.FechaCambio).HasColumnType("datetime");
            entity.Property(e => e.PrecioBaseActual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioBaseAnterior).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Prod).WithMany(p => p.RegistroCambioProductos)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_dbo.RegistroCambioProductos_dbo.Prod_ProdId");
        });

        modelBuilder.Entity<RegistroCliente>(entity =>
        {
            entity.HasKey(e => e.RegistroClienteId).HasName("PK_dbo.RegistroCliente");

            entity.ToTable("RegistroCliente");

            entity.HasIndex(e => e.AspNetUsersId, "IX_AspNetUsers_Id");

            entity.HasIndex(e => e.ClienteId, "IX_ClienteId");

            entity.Property(e => e.AspNetUsersId)
                .HasMaxLength(128)
                .HasColumnName("AspNetUsers_Id");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");

            entity.HasOne(d => d.AspNetUsers).WithMany(p => p.RegistroClientes)
                .HasForeignKey(d => d.AspNetUsersId)
                .HasConstraintName("FK_dbo.RegistroCliente_dbo.AspNetUsers_AspNetUsers_Id");

            entity.HasOne(d => d.Cliente).WithMany(p => p.RegistroClientes)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_dbo.RegistroCliente_dbo.Cliente_ClienteId");
        });

        modelBuilder.Entity<RegistroMetaCliente>(entity =>
        {
            entity.HasKey(e => e.RegistroMetaClienteId).HasName("PK_dbo.RegistroMetaCliente");

            entity.ToTable("RegistroMetaCliente");

            entity.HasIndex(e => e.ClienteId, "IX_ClienteId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.MontoActual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoAnterior).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.RegistroMetaClientes)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_dbo.RegistroMetaCliente_dbo.Cliente_ClienteId");
        });

        modelBuilder.Entity<Relacionador>(entity =>
        {
            entity.HasKey(e => e.RelacionadorId).HasName("PK_dbo.Relacionador");

            entity.ToTable("Relacionador");

            entity.HasIndex(e => e.ClienteId, "IX_ClienteId");

            entity.HasIndex(e => e.TipoRelacionadorId, "IX_TipoRelacionadorId");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Relacionadors)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_dbo.Relacionador_dbo.Cliente_ClienteId");

            entity.HasOne(d => d.TipoRelacionador).WithMany(p => p.Relacionadors)
                .HasForeignKey(d => d.TipoRelacionadorId)
                .HasConstraintName("FK_dbo.Relacionador_dbo.TipoRelacionador_TipoRelacionadorId");
        });

        modelBuilder.Entity<RequerimientoPedido>(entity =>
        {
            entity.HasKey(e => e.RequerimientoPedidoId).HasName("PK_dbo.RequerimientoPedido");

            entity.ToTable("RequerimientoPedido");

            entity.HasIndex(e => e.PedidoProveedorId, "IX_PedidoProveedorId");

            entity.Property(e => e.Cambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CambioMoneda).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.Cf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CF");
            entity.Property(e => e.FechaArribo).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaEmbarque).HasColumnType("datetime");
            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
            entity.Property(e => e.FechaInicial).HasColumnType("datetime");
            entity.Property(e => e.PorcentajePvp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PorcentajePVP");
            entity.Property(e => e.Sf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SF");
            entity.Property(e => e.TotalCarguio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDsctoPromocion).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.PedidoProveedor).WithMany(p => p.RequerimientoPedidos)
                .HasForeignKey(d => d.PedidoProveedorId)
                .HasConstraintName("FK_dbo.RequerimientoPedido_dbo.PedidoProveedor_PedidoProveedorId");
        });

        modelBuilder.Entity<RequerimientoPedidoItem>(entity =>
        {
            entity.HasKey(e => e.RequerimientoPedidoItemsId).HasName("PK_dbo.RequerimientoPedidoItems");

            entity.HasIndex(e => e.RequerimientoPedidoId, "IX_RequerimientoPedidoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ComplementoBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoCarguioUsd)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("CostoCarguioUSD");
            entity.Property(e => e.CostoTotalBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoTotalImportacionBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoTotalImportacionUsd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CostoTotalImportacionUSD");
            entity.Property(e => e.CostoTotalUsdEuCny)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("CostoTotalUSD_EU_CNY");
            entity.Property(e => e.CostoUnitarioBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUnitarioUsd)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("CostoUnitarioUSD");
            entity.Property(e => e.CostoUnitarioUsdEuCny)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("CostoUnitarioUSD_EU_CNY");
            entity.Property(e => e.DescuentoIvaBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DescuentoUsd)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("DescuentoUSD");
            entity.Property(e => e.GastosCif)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GastosCIF");
            entity.Property(e => e.GastosEstibajeBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GastosImportacionBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GravamenArancelario).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PorcentajePvp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PorcentajePVP");
            entity.Property(e => e.PrecioLista).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioListaFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioTotalUsd)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("PrecioTotalUSD");
            entity.Property(e => e.PrecioUnitarioUsd)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("PrecioUnitarioUSD");
            entity.Property(e => e.Pvp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PVP");
            entity.Property(e => e.TotalCifbs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalCIFBs");
            entity.Property(e => e.TotalCifusd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalCIFUSD");
            entity.Property(e => e.TotalFobusd)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("TotalFOBUSD");
        });

        modelBuilder.Entity<RequerimientoPedidoItemsComplemento>(entity =>
        {
            entity.HasKey(e => e.RequerimientoPedidoItemsComplementosId).HasName("PK_dbo.RequerimientoPedidoItemsComplementos");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pendiente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioUnitarioUsd).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.TotalBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalUsd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usado).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<RolModule>(entity =>
        {
            entity.HasKey(e => e.RolModuleId).HasName("PK_dbo.RolModule");

            entity.ToTable("RolModule");

            entity.HasIndex(e => e.ApplicationRoleId, "IX_ApplicationRoleId");

            entity.HasIndex(e => e.ModuleId, "IX_ModuleId");

            entity.Property(e => e.ApplicationRoleId).HasMaxLength(128);

            entity.HasOne(d => d.ApplicationRole).WithMany(p => p.RolModules)
                .HasForeignKey(d => d.ApplicationRoleId)
                .HasConstraintName("FK_dbo.RolModule_dbo.AspNetRoles_ApplicationRoleId");

            entity.HasOne(d => d.Module).WithMany(p => p.RolModules)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_dbo.RolModule_dbo.Module_ModuleId");
        });

        modelBuilder.Entity<RubroComercial>(entity =>
        {
            entity.HasKey(e => e.RubroComercialId).HasName("PK_dbo.RubroComercial");

            entity.ToTable("RubroComercial");
        });

        modelBuilder.Entity<Sancion>(entity =>
        {
            entity.HasKey(e => e.SancionId).HasName("PK_dbo.Sancion");

            entity.ToTable("Sancion");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.Property(e => e.Dias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Sancions)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Sancion_dbo.Empleado_EmpleadoId");
        });

        modelBuilder.Entity<SancionDetalle>(entity =>
        {
            entity.HasKey(e => e.SancionDetalleId).HasName("PK_dbo.SancionDetalle");

            entity.ToTable("SancionDetalle");

            entity.HasIndex(e => e.SancionId, "IX_SancionId");

            entity.Property(e => e.Debe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.Haber).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Sancion).WithMany(p => p.SancionDetalles)
                .HasForeignKey(d => d.SancionId)
                .HasConstraintName("FK_dbo.SancionDetalle_dbo.Sancion_SancionId");
        });

        modelBuilder.Entity<SeguroSocial>(entity =>
        {
            entity.HasKey(e => e.SeguroSocialId).HasName("PK_dbo.SeguroSocial");

            entity.ToTable("SeguroSocial");
        });

        modelBuilder.Entity<Solicitante>(entity =>
        {
            entity.HasKey(e => e.SolicitanteId).HasName("PK_dbo.Solicitante");

            entity.ToTable("Solicitante", tb => tb.HasTrigger("trIUDSolicitante"));

            entity.HasIndex(e => e.AlmacenDescargaId, "IX_AlmacenDescargaId");

            entity.HasIndex(e => e.AlmacenId, "IX_AlmacenId");

            entity.HasIndex(e => e.SolicitudTraspasoId, "IX_SolicitudTraspasoId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.Obs)
                .HasMaxLength(2048)
                .IsUnicode(false);

            entity.HasOne(d => d.AlmacenDescarga).WithMany(p => p.SolicitanteAlmacenDescargas)
                .HasForeignKey(d => d.AlmacenDescargaId)
                .HasConstraintName("FK_dbo.Solicitante_dbo.Almacen_AlmacenDescargaId");

            entity.HasOne(d => d.Almacen).WithMany(p => p.SolicitanteAlmacens)
                .HasForeignKey(d => d.AlmacenId)
                .HasConstraintName("FK_dbo.Solicitante_dbo.Almacen_AlmacenId");

            entity.HasOne(d => d.SolicitudTraspaso).WithMany(p => p.Solicitantes)
                .HasForeignKey(d => d.SolicitudTraspasoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Solicitante_dbo.SolicitudTraspaso_SolicitudTraspasoId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.Solicitantes)
                .HasForeignKey(d => d.UnidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Solicitante_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<SolicitanteActivo>(entity =>
        {
            entity.HasKey(e => e.SolicitanteActivoId).HasName("PK_dbo.SolicitanteActivo");

            entity.ToTable("SolicitanteActivo");

            entity.HasIndex(e => e.AlmacenAfid, "IX_AlmacenAFId");

            entity.HasIndex(e => e.SolicitudTraspasoActivoId, "IX_SolicitudTraspasoActivoId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.Property(e => e.AlmacenAfid).HasColumnName("AlmacenAFId");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");

            entity.HasOne(d => d.AlmacenAf).WithMany(p => p.SolicitanteActivos)
                .HasForeignKey(d => d.AlmacenAfid)
                .HasConstraintName("FK_dbo.SolicitanteActivo_dbo.AlmacenAF_AlmacenAFId");

            entity.HasOne(d => d.SolicitudTraspasoActivo).WithMany(p => p.SolicitanteActivos)
                .HasForeignKey(d => d.SolicitudTraspasoActivoId)
                .HasConstraintName("FK_dbo.SolicitanteActivo_dbo.SolicitudTraspasoActivo_SolicitudTraspasoActivoId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.SolicitanteActivos)
                .HasForeignKey(d => d.UnidadId)
                .HasConstraintName("FK_dbo.SolicitanteActivo_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<SolicitudTraspaso>(entity =>
        {
            entity.HasKey(e => e.SolicitudTraspasoId).HasName("PK_dbo.SolicitudTraspaso");

            entity.ToTable("SolicitudTraspaso", tb => tb.HasTrigger("trIUDSolicitudTraspaso"));

            entity.HasIndex(e => e.ConductorId, "IX_ConductorId");

            entity.HasIndex(e => e.DocumentoId, "IX_DocumentoId");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaArrivo).HasColumnType("datetime");
            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Obs)
                .HasMaxLength(2048)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.Conductor).WithMany(p => p.SolicitudTraspasos)
                .HasForeignKey(d => d.ConductorId)
                .HasConstraintName("FK_dbo.SolicitudTraspaso_dbo.Conductor_ConductorId");

            entity.HasOne(d => d.Documento).WithMany(p => p.SolicitudTraspasos)
                .HasForeignKey(d => d.DocumentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.SolicitudTraspaso_dbo.Documento_DocumentoId");
        });

        modelBuilder.Entity<SolicitudTraspasoActivo>(entity =>
        {
            entity.HasKey(e => e.SolicitudTraspasoActivoId).HasName("PK_dbo.SolicitudTraspasoActivo");

            entity.ToTable("SolicitudTraspasoActivo");

            entity.HasIndex(e => e.DocumentoActivoId, "IX_DocumentoActivoId");

            entity.Property(e => e.FechaArrivo).HasColumnType("datetime");
            entity.Property(e => e.FechaEnvio).HasColumnType("datetime");
            entity.Property(e => e.FechaEstado).HasColumnType("datetime");
            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.DocumentoActivo).WithMany(p => p.SolicitudTraspasoActivos)
                .HasForeignKey(d => d.DocumentoActivoId)
                .HasConstraintName("FK_dbo.SolicitudTraspasoActivo_dbo.DocumentoActivo_DocumentoActivoId");
        });

        modelBuilder.Entity<SolicitudVendedor>(entity =>
        {
            entity.HasKey(e => e.SolicitudVendedorId).HasName("PK_dbo.SolicitudVendedor");

            entity.ToTable("SolicitudVendedor");

            entity.HasIndex(e => e.TipoSolicitudVendedorId, "IX_TipoSolicitudVendedorId");

            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaComercializacionFin).HasColumnType("datetime");
            entity.Property(e => e.FechaComercializacionInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaVerificacion).HasColumnType("datetime");

            entity.HasOne(d => d.TipoSolicitudVendedor).WithMany(p => p.SolicitudVendedors)
                .HasForeignKey(d => d.TipoSolicitudVendedorId)
                .HasConstraintName("FK_dbo.SolicitudVendedor_dbo.TipoSolicitudVendedor_TipoSolicitudVendedorId");
        });

        modelBuilder.Entity<SubSystem>(entity =>
        {
            entity.HasKey(e => e.SubSystemId).HasName("PK_dbo.SubSystem");

            entity.ToTable("SubSystem");
        });

        modelBuilder.Entity<Talonario>(entity =>
        {
            entity.HasKey(e => e.TalonarioId).HasName("PK_dbo.Talonario");

            entity.ToTable("Talonario");

            entity.Property(e => e.CodDosificacion).HasColumnName("Cod_Dosificacion");
            entity.Property(e => e.ConfCiudad).HasColumnName("confCiudad");
            entity.Property(e => e.ConfEstadoImpre).HasColumnName("confEstadoImpre");
            entity.Property(e => e.ConfLeyenda1).HasColumnName("confLeyenda1");
            entity.Property(e => e.ConfLeyenda2).HasColumnName("confLeyenda2");
            entity.Property(e => e.ConfNitEmisor).HasColumnName("confNitEmisor");
            entity.Property(e => e.ConfRubro1).HasColumnName("confRubro1");
            entity.Property(e => e.ConfRubro2).HasColumnName("confRubro2");
            entity.Property(e => e.ConfRubro3).HasColumnName("confRubro3");
            entity.Property(e => e.ConfSucursalCiudad).HasColumnName("confSucursalCiudad");
            entity.Property(e => e.ConfSucursalDir1).HasColumnName("confSucursalDir1");
            entity.Property(e => e.ConfSucursalDir2).HasColumnName("confSucursalDir2");
            entity.Property(e => e.ConfSucursalNro).HasColumnName("confSucursalNro");
            entity.Property(e => e.FechaActivacion).HasColumnType("datetime");
            entity.Property(e => e.FechaAnulacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDesactivacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinUso).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioUso).HasColumnType("datetime");
            entity.Property(e => e.FechaLimite)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Limite");
            entity.Property(e => e.NroAutorizacion).HasColumnName("Nro_Autorizacion");
            entity.Property(e => e.NroFin).HasColumnName("Nro_Fin");
            entity.Property(e => e.NroInicio).HasColumnName("Nro_Inicio");
            entity.Property(e => e.NroTramite).HasColumnName("Nro_Tramite");
        });

        modelBuilder.Entity<TecnicoCliente>(entity =>
        {
            entity.HasKey(e => e.TecnicoClienteId).HasName("PK_dbo.TecnicoCliente");

            entity.ToTable("TecnicoCliente");
        });

        modelBuilder.Entity<TipoActivo>(entity =>
        {
            entity.HasKey(e => e.TipoActivoId).HasName("PK_dbo.TipoActivo");

            entity.ToTable("TipoActivo");

            entity.HasIndex(e => e.ClaseActivoId, "IX_ClaseActivoId");

            entity.HasOne(d => d.ClaseActivo).WithMany(p => p.TipoActivos)
                .HasForeignKey(d => d.ClaseActivoId)
                .HasConstraintName("FK_dbo.TipoActivo_dbo.ClaseActivo_ClaseActivoId");
        });

        modelBuilder.Entity<TipoAlmacen>(entity =>
        {
            entity.HasKey(e => e.TipoAlmacenId).HasName("PK_dbo.TipoAlmacen");

            entity.ToTable("TipoAlmacen");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.NombreCorto)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoArchivoProducto>(entity =>
        {
            entity.HasKey(e => e.TipoArchivoProductoId).HasName("PK_dbo.TipoArchivoProducto");

            entity.ToTable("TipoArchivoProducto");
        });

        modelBuilder.Entity<TipoBancoProveedor>(entity =>
        {
            entity.HasKey(e => e.TipoBancoProveedorId).HasName("PK_dbo.TipoBancoProveedor");

            entity.ToTable("TipoBancoProveedor");
        });

        modelBuilder.Entity<TipoCargo>(entity =>
        {
            entity.HasKey(e => e.TipoCargoId).HasName("PK_dbo.TipoCargo");

            entity.ToTable("TipoCargo");

            entity.HasIndex(e => e.CargoId, "IX_CargoId");

            entity.Property(e => e.Sueldo1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Sueldo2).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Cargo).WithMany(p => p.TipoCargos)
                .HasForeignKey(d => d.CargoId)
                .HasConstraintName("FK_dbo.TipoCargo_dbo.Cargo_CargoId");
        });

        modelBuilder.Entity<TipoCliente>(entity =>
        {
            entity.HasKey(e => e.TipoClienteId).HasName("PK_dbo.TipoCliente");

            entity.ToTable("TipoCliente");

            entity.HasIndex(e => e.ClaseClienteId, "IX_ClaseClienteId");

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VolumenMaximo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VolumenMinimo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ClaseCliente).WithMany(p => p.TipoClientes)
                .HasForeignKey(d => d.ClaseClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TipoCliente_dbo.ClaseCliente_ClaseClienteId");
        });

        modelBuilder.Entity<TipoComprobanteActivo>(entity =>
        {
            entity.HasKey(e => e.TipoComprobanteActivoId).HasName("PK_dbo.TipoComprobanteActivo");

            entity.ToTable("TipoComprobanteActivo");
        });

        modelBuilder.Entity<TipoConceptoCosto>(entity =>
        {
            entity.HasKey(e => e.TipoConceptoCostoId).HasName("PK_dbo.TipoConceptoCosto");

            entity.ToTable("TipoConceptoCosto");
        });

        modelBuilder.Entity<TipoDetalleActivo>(entity =>
        {
            entity.HasKey(e => e.TipoDetalleActivoId).HasName("PK_dbo.TipoDetalleActivo");

            entity.ToTable("TipoDetalleActivo");

            entity.HasIndex(e => e.ClaseActivoId, "IX_ClaseActivoId");

            entity.HasOne(d => d.ClaseActivo).WithMany(p => p.TipoDetalleActivos)
                .HasForeignKey(d => d.ClaseActivoId)
                .HasConstraintName("FK_dbo.TipoDetalleActivo_dbo.ClaseActivo_ClaseActivoId");
        });

        modelBuilder.Entity<TipoDireccion>(entity =>
        {
            entity.HasKey(e => e.TipoDireccionId).HasName("PK_dbo.TipoDireccion");

            entity.ToTable("TipoDireccion");
        });

        modelBuilder.Entity<TipoDocImportacion>(entity =>
        {
            entity.HasKey(e => e.TipoDocImportacionId).HasName("PK_dbo.TipoDocImportacion");

            entity.ToTable("TipoDocImportacion");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.TipoDocumentoId).HasName("PK_dbo.TipoDocumento");

            entity.ToTable("TipoDocumento");

            entity.HasIndex(e => e.ClaseDocumentoId, "IX_ClaseDocumentoId");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.HasOne(d => d.ClaseDocumento).WithMany(p => p.TipoDocumentos)
                .HasForeignKey(d => d.ClaseDocumentoId)
                .HasConstraintName("FK_dbo.TipoDocumento_dbo.ClaseDocumento_ClaseDocumentoId");
        });

        modelBuilder.Entity<TipoDocumentoActivo>(entity =>
        {
            entity.HasKey(e => e.TipoDocumentoActivoId).HasName("PK_dbo.TipoDocumentoActivo");

            entity.ToTable("TipoDocumentoActivo");

            entity.HasIndex(e => e.ClaseDocumentoActivoId, "IX_ClaseDocumentoActivoId");

            entity.HasOne(d => d.ClaseDocumentoActivo).WithMany(p => p.TipoDocumentoActivos)
                .HasForeignKey(d => d.ClaseDocumentoActivoId)
                .HasConstraintName("FK_dbo.TipoDocumentoActivo_dbo.ClaseDocumentoActivo_ClaseDocumentoActivoId");
        });

        modelBuilder.Entity<TipoEmpresa>(entity =>
        {
            entity.HasKey(e => e.TipoEmpresaId).HasName("PK_dbo.TipoEmpresa");

            entity.ToTable("TipoEmpresa");
        });

        modelBuilder.Entity<TipoEmpresaImportacion>(entity =>
        {
            entity.HasKey(e => e.TipoEmpresaImportacionId).HasName("PK_dbo.TipoEmpresaImportacion");

            entity.ToTable("TipoEmpresaImportacion");
        });

        modelBuilder.Entity<TipoFechaEspecial>(entity =>
        {
            entity.HasKey(e => e.TipoFechaEspecialId).HasName("PK_dbo.TipoFechaEspecial");

            entity.ToTable("TipoFechaEspecial");
        });

        modelBuilder.Entity<TipoMovimiento>(entity =>
        {
            entity.HasKey(e => e.TipoMovimientoId).HasName("PK_dbo.TipoMovimiento");

            entity.ToTable("TipoMovimiento");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoMovimientoActivo>(entity =>
        {
            entity.HasKey(e => e.TipoMovimientoActivoId).HasName("PK_dbo.TipoMovimientoActivo");

            entity.ToTable("TipoMovimientoActivo");
        });

        modelBuilder.Entity<TipoMovimientoPersonal>(entity =>
        {
            entity.HasKey(e => e.TipoMovimientoPersonalId).HasName("PK_dbo.TipoMovimientoPersonal");

            entity.ToTable("TipoMovimientoPersonal");
        });

        modelBuilder.Entity<TipoMovimientoVacacion>(entity =>
        {
            entity.HasKey(e => e.TipoMovimientoVacacionId).HasName("PK_dbo.TipoMovimientoVacacion");

            entity.ToTable("TipoMovimientoVacacion");
        });

        modelBuilder.Entity<TipoPermiso>(entity =>
        {
            entity.HasKey(e => e.TipoPermisoId).HasName("PK_dbo.TipoPermiso");

            entity.ToTable("TipoPermiso");
        });

        modelBuilder.Entity<TipoPlanilla>(entity =>
        {
            entity.HasKey(e => e.TipoPlanillaId).HasName("PK_dbo.TipoPlanilla");

            entity.ToTable("TipoPlanilla");
        });

        modelBuilder.Entity<TipoProveedor>(entity =>
        {
            entity.HasKey(e => e.TipoProveedorId).HasName("PK_dbo.TipoProveedor");

            entity.ToTable("TipoProveedor");
        });

        modelBuilder.Entity<TipoRelacionador>(entity =>
        {
            entity.HasKey(e => e.TipoRelacionadorId).HasName("PK_dbo.TipoRelacionador");

            entity.ToTable("TipoRelacionador");
        });

        modelBuilder.Entity<TipoSolicitudVendedor>(entity =>
        {
            entity.HasKey(e => e.TipoSolicitudVendedorId).HasName("PK_dbo.TipoSolicitudVendedor");

            entity.ToTable("TipoSolicitudVendedor");
        });

        modelBuilder.Entity<TmpIp01>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_ip01");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Codigo)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("documento");
        });

        modelBuilder.Entity<Trader>(entity =>
        {
            entity.HasKey(e => e.TraderId).HasName("PK_dbo.Trader");

            entity.ToTable("Trader");
        });

        modelBuilder.Entity<TraduccionIdentificacion>(entity =>
        {
            entity.HasKey(e => e.TraduccionIdentificacionId).HasName("PK_dbo.TraduccionIdentificacion");

            entity.ToTable("TraduccionIdentificacion");
        });

        modelBuilder.Entity<Transporte>(entity =>
        {
            entity.HasKey(e => e.TransporteId).HasName("PK_dbo.Transporte");

            entity.ToTable("Transporte");

            entity.Property(e => e.Cubicaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Placa)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TraspasoActivo>(entity =>
        {
            entity.HasKey(e => e.TraspasoActivoId).HasName("PK_dbo.TraspasoActivo");

            entity.ToTable("TraspasoActivo");

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.TraspasoNegociacionActivoId, "IX_TraspasoNegociacionActivoId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.CantidadAprobada).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CantidadSolicitada).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.TraspasoActivos)
                .HasForeignKey(d => d.EstadoProductoId)
                .HasConstraintName("FK_dbo.TraspasoActivo_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.TraspasoNegociacionActivo).WithMany(p => p.TraspasoActivos)
                .HasForeignKey(d => d.TraspasoNegociacionActivoId)
                .HasConstraintName("FK_dbo.TraspasoActivo_dbo.TraspasoNegociacionActivo_TraspasoNegociacionActivoId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.TraspasoActivos)
                .HasForeignKey(d => d.UsoProductoId)
                .HasConstraintName("FK_dbo.TraspasoActivo_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<TraspasoActivoDet>(entity =>
        {
            entity.HasKey(e => e.TraspasoActivoDetId).HasName("PK_dbo.TraspasoActivoDet");

            entity.ToTable("TraspasoActivoDet");

            entity.HasIndex(e => e.AlmacenActivoId, "IX_AlmacenActivoId");

            entity.HasIndex(e => e.TraspasoActivoId, "IX_TraspasoActivoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AlmacenActivo).WithMany(p => p.TraspasoActivoDets)
                .HasForeignKey(d => d.AlmacenActivoId)
                .HasConstraintName("FK_dbo.TraspasoActivoDet_dbo.AlmacenActivo_AlmacenActivoId");

            entity.HasOne(d => d.TraspasoActivo).WithMany(p => p.TraspasoActivoDets)
                .HasForeignKey(d => d.TraspasoActivoId)
                .HasConstraintName("FK_dbo.TraspasoActivoDet_dbo.TraspasoActivo_TraspasoActivoId");
        });

        modelBuilder.Entity<TraspasoNegociacion>(entity =>
        {
            entity.HasKey(e => e.TraspasoNegociacionId).HasName("PK_dbo.TraspasoNegociacion");

            entity.ToTable("TraspasoNegociacion", tb => tb.HasTrigger("trIUDTraspasoNegociacion"));

            entity.HasIndex(e => e.DespachanteId, "IX_DespachanteId");

            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Obs)
                .HasMaxLength(2048)
                .IsUnicode(false);

            entity.HasOne(d => d.Despachante).WithMany(p => p.TraspasoNegociacions)
                .HasForeignKey(d => d.DespachanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TraspasoNegociacion_dbo.Despachante_DespachanteId");
        });

        modelBuilder.Entity<TraspasoNegociacionActivo>(entity =>
        {
            entity.HasKey(e => e.TraspasoNegociacionActivoId).HasName("PK_dbo.TraspasoNegociacionActivo");

            entity.ToTable("TraspasoNegociacionActivo");

            entity.HasIndex(e => e.DespachanteActivoId, "IX_DespachanteActivoId");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.DespachanteActivo).WithMany(p => p.TraspasoNegociacionActivos)
                .HasForeignKey(d => d.DespachanteActivoId)
                .HasConstraintName("FK_dbo.TraspasoNegociacionActivo_dbo.DespachanteActivo_DespachanteActivoId");
        });

        modelBuilder.Entity<TraspasoProducto>(entity =>
        {
            entity.HasKey(e => e.TraspasoProductoId).HasName("PK_dbo.TraspasoProducto");

            entity.ToTable("TraspasoProducto", tb => tb.HasTrigger("trIUDTraspasoProducto"));

            entity.HasIndex(e => e.EstadoProductoId, "IX_EstadoProductoId");

            entity.HasIndex(e => e.TraspasoNegociacionId, "IX_TraspasoNegociacionId");

            entity.HasIndex(e => e.UsoProductoId, "IX_UsoProductoId");

            entity.Property(e => e.CantidadAprobada).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.CantidadSolicitada).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.Obs)
                .HasMaxLength(2048)
                .IsUnicode(false);

            entity.HasOne(d => d.EstadoProducto).WithMany(p => p.TraspasoProductos)
                .HasForeignKey(d => d.EstadoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TraspasoProducto_dbo.EstadoProducto_EstadoProductoId");

            entity.HasOne(d => d.TraspasoNegociacion).WithMany(p => p.TraspasoProductos)
                .HasForeignKey(d => d.TraspasoNegociacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TraspasoProducto_dbo.TraspasoNegociacion_TraspasoNegociacionId");

            entity.HasOne(d => d.UsoProducto).WithMany(p => p.TraspasoProductos)
                .HasForeignKey(d => d.UsoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TraspasoProducto_dbo.UsoProducto_UsoProductoId");
        });

        modelBuilder.Entity<TraspasoProductoDet>(entity =>
        {
            entity.HasKey(e => e.TraspasoProductoDetId).HasName("PK_dbo.TraspasoProductoDet");

            entity.ToTable("TraspasoProductoDet", tb => tb.HasTrigger("trIUDTraspasoProductoDet"));

            entity.HasIndex(e => e.AlmacenProductoId, "IX_AlmacenProductoId");

            entity.HasIndex(e => e.TraspasoProductoId, "IX_TraspasoProductoId");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(12, 5)");

            entity.HasOne(d => d.AlmacenProducto).WithMany(p => p.TraspasoProductoDets)
                .HasForeignKey(d => d.AlmacenProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TraspasoProductoDet_dbo.AlmacenProducto_AlmacenProductoId");

            entity.HasOne(d => d.TraspasoProducto).WithMany(p => p.TraspasoProductoDets)
                .HasForeignKey(d => d.TraspasoProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TraspasoProductoDet_dbo.TraspasoProducto_TraspasoProductoId");
        });

        modelBuilder.Entity<TypeProd>(entity =>
        {
            entity.HasKey(e => e.TypeProdId).HasName("PK_dbo.TypeProd");

            entity.ToTable("TypeProd");

            entity.HasIndex(e => e.ClassProdId, "IX_ClassProdId");

            entity.HasOne(d => d.ClassProd).WithMany(p => p.TypeProds)
                .HasForeignKey(d => d.ClassProdId)
                .HasConstraintName("FK_dbo.TypeProd_dbo.ClassProd_ClassProdId");
        });

        modelBuilder.Entity<Ufv>(entity =>
        {
            entity.HasKey(e => e.UfvId).HasName("PK_dbo.Ufv");

            entity.ToTable("Ufv");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 5)");
        });

        modelBuilder.Entity<UfvAnual>(entity =>
        {
            entity.HasKey(e => e.UfvAnualId).HasName("PK_dbo.UfvAnual");

            entity.ToTable("UfvAnual");

            entity.Property(e => e.Valor).HasColumnType("decimal(14, 5)");
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => e.UnidadId).HasName("PK_dbo.Unidad");

            entity.ToTable("Unidad");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.NombreCorto)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Telefono1)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Telefono2)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UnidadComision>(entity =>
        {
            entity.HasKey(e => e.UnidadComisionId).HasName("PK_dbo.UnidadComision");

            entity.ToTable("UnidadComision");

            entity.Property(e => e.Bono).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BonoAdicional).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ci).HasColumnName("CI");
        });

        modelBuilder.Entity<UnidadProducto>(entity =>
        {
            entity.HasKey(e => e.UnidadProductoId).HasName("PK_dbo.UnidadProducto");

            entity.ToTable("UnidadProducto");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK_dbo.Unit");

            entity.ToTable("Unit");
        });

        modelBuilder.Entity<UnitUser>(entity =>
        {
            entity.HasKey(e => e.UnitUserId).HasName("PK_dbo.UnitUser");

            entity.ToTable("UnitUser");

            entity.HasIndex(e => e.ApplicationUserId, "IX_ApplicationUserId");

            entity.HasIndex(e => e.UnidadId, "IX_UnidadId");

            entity.Property(e => e.ApplicationUserId).HasMaxLength(128);

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.UnitUsers)
                .HasForeignKey(d => d.ApplicationUserId)
                .HasConstraintName("FK_dbo.UnitUser_dbo.AspNetUsers_ApplicationUserId");

            entity.HasOne(d => d.Unidad).WithMany(p => p.UnitUsers)
                .HasForeignKey(d => d.UnidadId)
                .HasConstraintName("FK_dbo.UnitUser_dbo.Unidad_UnidadId");
        });

        modelBuilder.Entity<UsoProducto>(entity =>
        {
            entity.HasKey(e => e.UsoProductoId).HasName("PK_dbo.UsoProducto");

            entity.ToTable("UsoProducto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionCorta)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDefattrib>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_defattribs");

            entity.Property(e => e.Atributos)
                .IsUnicode(false)
                .HasColumnName("ATRIBUTOS");
            entity.Property(e => e.CantidadAgrupada).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VolumenAgrupado).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<VProducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_productos");

            entity.Property(e => e.CantidadAgrupada).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VolumenAgrupado).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<VProductoDisponible>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_producto_disponible");

            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(14, 5)")
                .HasColumnName("cantidad");
            entity.Property(e => e.DescripcionEstadoProducto)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("descripcion_estado_producto");
            entity.Property(e => e.DescripcionUsoProducto)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("descripcion_uso_producto");
            entity.Property(e => e.Disponible)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("disponible");
            entity.Property(e => e.FechaArrivo).HasColumnName("fecha_arrivo");
            entity.Property(e => e.NombreAlmacen)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("nombre_almacen");
            entity.Property(e => e.NombreUnidad)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("nombre_unidad");
        });

        modelBuilder.Entity<VReporteDisponibilidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_reporte_disponibilidad");

            entity.Property(e => e.DescripcionEstadoProducto)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Disponibilidad).HasColumnType("decimal(14, 5)");
            entity.Property(e => e.Entregas).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.NombreAlmacen)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.NombreUnidad)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(12, 5)");
            entity.Property(e => e.Traspasos).HasColumnType("decimal(12, 5)");
        });

        modelBuilder.Entity<VSeguridad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_seguridad");

            entity.Property(e => e.Ambito)
                .IsUnicode(false)
                .HasColumnName("AMBITO");
            entity.Property(e => e.IdUsuario).HasMaxLength(128);
            entity.Property(e => e.NombreUsuario).HasMaxLength(256);
            entity.Property(e => e.Operacion)
                .IsUnicode(false)
                .HasColumnName("OPERACION");
            entity.Property(e => e.Unidad)
                .IsUnicode(false)
                .HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<VSeguridad2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_seguridad2");

            entity.Property(e => e.IdUsuario).HasMaxLength(128);
            entity.Property(e => e.NombreUsuario).HasMaxLength(256);
            entity.Property(e => e.OpcionModulo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Operacion).IsUnicode(false);
        });

        modelBuilder.Entity<Vacacion>(entity =>
        {
            entity.HasKey(e => e.VacacionId).HasName("PK_dbo.Vacacion");

            entity.ToTable("Vacacion");

            entity.HasIndex(e => e.EmpleadoId, "IX_EmpleadoId");

            entity.HasIndex(e => e.TipoMovimientoVacacionId, "IX_TipoMovimientoVacacionId");

            entity.Property(e => e.Dias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocumentoRrhhid).HasColumnName("DocumentoRRHHId");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Vacacions)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK_dbo.Vacacion_dbo.Empleado_EmpleadoId");

            entity.HasOne(d => d.TipoMovimientoVacacion).WithMany(p => p.Vacacions)
                .HasForeignKey(d => d.TipoMovimientoVacacionId)
                .HasConstraintName("FK_dbo.Vacacion_dbo.TipoMovimientoVacacion_TipoMovimientoVacacionId");
        });

        modelBuilder.Entity<VacacionDetalle>(entity =>
        {
            entity.HasKey(e => e.VacacionDetalleId).HasName("PK_dbo.VacacionDetalle");

            entity.ToTable("VacacionDetalle");

            entity.Property(e => e.Dias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.VehiculoId).HasName("PK_dbo.Vehiculo");

            entity.ToTable("Vehiculo");
        });

        modelBuilder.Entity<VerProd>(entity =>
        {
            entity.HasKey(e => e.VerProdsId).HasName("PK_dbo.VerProds");

            entity.Property(e => e.PrecioBase).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VerSeguridad>(entity =>
        {
            entity.HasKey(e => e.VerSeguridadId).HasName("PK_dbo.VerSeguridad");

            entity.ToTable("VerSeguridad");

            entity.Property(e => e.Ambito).HasColumnName("AMBITO");
            entity.Property(e => e.Operacion).HasColumnName("OPERACION");
            entity.Property(e => e.Unidad).HasColumnName("UNIDAD");
        });

        modelBuilder.Entity<VerVproductoDisponible>(entity =>
        {
            entity.HasKey(e => e.VerVproductoDisponibleId).HasName("PK_dbo.VerVProductoDisponible");

            entity.ToTable("VerVProductoDisponible");

            entity.Property(e => e.VerVproductoDisponibleId).HasColumnName("VerVProductoDisponibleId");
            entity.Property(e => e.DescripcionEstadoProducto).HasColumnName("descripcion_estado_producto");
            entity.Property(e => e.DescripcionUsoProducto).HasColumnName("descripcion_uso_producto");
            entity.Property(e => e.Disponible).HasColumnName("disponible");
            entity.Property(e => e.FechaArrivo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_arrivo");
            entity.Property(e => e.NombreAlmacen).HasColumnName("nombre_almacen");
            entity.Property(e => e.NombreUnidad).HasColumnName("nombre_unidad");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
