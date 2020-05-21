using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CanalElectronico29.Models
{
    public partial class DBBUSINTEGRACIONContext : DbContext
    {
        public DBBUSINTEGRACIONContext()
        {
        }

        public DBBUSINTEGRACIONContext(DbContextOptions<DBBUSINTEGRACIONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AfectacionMonetariaCuentas> AfectacionMonetariaCuentas { get; set; }
        public virtual DbSet<Tposcompensacabecera> Tposcompensacabecera { get; set; }
        public virtual DbSet<Tposcompensadetalle> Tposcompensadetalle { get; set; }
        public virtual DbSet<Tposconvenio> Tposconvenio { get; set; }
        public virtual DbSet<Tposestado> Tposestado { get; set; }
        public virtual DbSet<Tposmovimientosdenarius> Tposmovimientosdenarius { get; set; }
        public virtual DbSet<TransaccionLog> TransaccionLog { get; set; }
        public virtual DbSet<Tswterminalespos> Tswterminalespos { get; set; }
        public virtual DbSet<Tusuario> Tusuario { get; set; }
        public virtual DbSet<Tusuariohistorico> Tusuariohistorico { get; set; }
        public virtual DbSet<Vposcompensacabecera> Vposcompensacabecera { get; set; }
        public virtual DbSet<Vposconvenio> Vposconvenio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SVCCPWNPRDMGR01,10449;Database=DBBUSINTEGRACION;Trusted_Connection=True;Integrated Security=false;User Id=usr_bus;Password=rcAKDB22*;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AfectacionMonetariaCuentas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AfectacionMonetariaCuentas", "historico");

                entity.Property(e => e.Efectivo).HasColumnType("money");

                entity.Property(e => e.EstadoCuenta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHistorico)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaProceso)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.MontoMn).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.MontoTotal).HasColumnType("money");

                entity.Property(e => e.NumeroCuenta)
                    .HasColumnName("numeroCuenta")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PorEfectivizar).HasColumnType("money");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasColumnName("referencia")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia2)
                    .HasColumnName("referencia2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoContable).HasColumnType("money");

                entity.Property(e => e.SaldoDisponible).HasColumnType("money");

                entity.Property(e => e.SufijoCuenta)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLog)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tposcompensacabecera>(entity =>
            {
                entity.ToTable("TPOSCOMPENSACABECERA", "CANAL29OCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cestado)
                    .IsRequired()
                    .HasColumnName("CESTADO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Convenio).HasColumnName("CONVENIO");

                entity.Property(e => e.Cusuarioautorizacion)
                    .HasColumnName("CUSUARIOAUTORIZACION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fautorizacion)
                    .HasColumnName("FAUTORIZACION")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Fproceso)
                    .HasColumnName("FPROCESO")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Idconvenio).HasColumnName("IDCONVENIO");

                entity.Property(e => e.Retencionfte)
                    .HasColumnName("RETENCIONFTE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Retencioniva)
                    .HasColumnName("RETENCIONIVA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transferencia)
                    .HasColumnName("TRANSFERENCIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdconvenioNavigation)
                    .WithMany(p => p.Tposcompensacabecera)
                    .HasForeignKey(d => d.Idconvenio)
                    .HasConstraintName("FK_TPOSCOMPENSACABECERA_TPOSCONVENIO");
            });

            modelBuilder.Entity<Tposcompensadetalle>(entity =>
            {
                entity.ToTable("TPOSCOMPENSADETALLE", "CANAL29OCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Archivo)
                    .HasColumnName("ARCHIVO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ccuenta)
                    .HasColumnName("CCUENTA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cerror)
                    .HasColumnName("CERROR")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cestado)
                    .IsRequired()
                    .HasColumnName("CESTADO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Convenio).HasColumnName("CONVENIO");

                entity.Property(e => e.Derror)
                    .HasColumnName("DERROR")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fcarga)
                    .HasColumnName("FCARGA")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Fcompensacion)
                    .HasColumnName("FCOMPENSACION")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Fproceso)
                    .HasColumnName("FPROCESO")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Ftransaccion)
                    .HasColumnName("FTRANSACCION")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Idcompensacabecera).HasColumnName("IDCOMPENSACABECERA");

                entity.Property(e => e.Linea)
                    .HasColumnName("LINEA")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Lote)
                    .HasColumnName("LOTE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mid)
                    .HasColumnName("MID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Numeroaprobacion)
                    .HasColumnName("NUMEROAPROBACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numeromensaje)
                    .HasColumnName("NUMEROMENSAJE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Numerotransaccion)
                    .HasColumnName("NUMEROTRANSACCION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Secuencia)
                    .HasColumnName("SECUENCIA")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Tarjeta)
                    .HasColumnName("TARJETA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Terminal)
                    .HasColumnName("TERMINAL")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Valorcomision)
                    .HasColumnName("VALORCOMISION")
                    .HasColumnType("numeric(15, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valoriva)
                    .HasColumnName("VALORIVA")
                    .HasColumnType("numeric(15, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valorivacomision)
                    .HasColumnName("VALORIVACOMISION")
                    .HasColumnType("numeric(15, 4)");

                entity.Property(e => e.Valorliquidado)
                    .HasColumnName("VALORLIQUIDADO")
                    .HasColumnType("numeric(15, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valorretencionfuente)
                    .HasColumnName("VALORRETENCIONFUENTE")
                    .HasColumnType("numeric(15, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valorretencioniva)
                    .HasColumnName("VALORRETENCIONIVA")
                    .HasColumnType("numeric(15, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valortarifa0)
                    .HasColumnName("VALORTARIFA0")
                    .HasColumnType("numeric(15, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valortarifaiva)
                    .HasColumnName("VALORTARIFAIVA")
                    .HasColumnType("numeric(15, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valortransaccion)
                    .HasColumnName("VALORTRANSACCION")
                    .HasColumnType("numeric(15, 4)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdcompensacabeceraNavigation)
                    .WithMany(p => p.Tposcompensadetalle)
                    .HasForeignKey(d => d.Idcompensacabecera)
                    .HasConstraintName("FK_TPOSCOMPENSADETALLE_TPOSCOMPENSACABECERA");
            });

            modelBuilder.Entity<Tposconvenio>(entity =>
            {
                entity.ToTable("TPOSCONVENIO", "CANAL29OCT");

                entity.HasComment("ID TABLA TSWTERMINALESPOS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Archivoorigen)
                    .IsRequired()
                    .HasColumnName("ARCHIVOORIGEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Archivoretrono)
                    .IsRequired()
                    .HasColumnName("ARCHIVORETRONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comandoarchivo)
                    .IsRequired()
                    .HasColumnName("COMANDOARCHIVO")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("COMANDO PARA GENRACION DE ARCHIVOS");

                entity.Property(e => e.Comandocalculo)
                    .IsRequired()
                    .HasColumnName("COMANDOCALCULO")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("COMANDO DE CALCULO DE COMISIONES POR COMPRAS ");

                entity.Property(e => e.Comandotransaccion)
                    .IsRequired()
                    .HasColumnName("COMANDOTRANSACCION")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("TRANSACCION SCRIPT PARA EJECUTAR TRANSACCION");

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("numeric(5, 2)")
                    .HasComment("VALOR DE COMISIONES");

                entity.Property(e => e.Compensa)
                    .IsRequired()
                    .HasColumnName("COMPENSA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .HasComment("COMPENSACCION FLAG");

                entity.Property(e => e.Convenio)
                    .HasColumnName("CONVENIO")
                    .HasComment("NOMBRE DE CONVENIO");

                entity.Property(e => e.Cuentacredito)
                    .IsRequired()
                    .HasColumnName("CUENTACREDITO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuentacreditobanco)
                    .HasColumnName("CUENTACREDITOBANCO")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Cuentacreditotipo)
                    .HasColumnName("CUENTACREDITOTIPO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cuentadebito)
                    .IsRequired()
                    .HasColumnName("CUENTADEBITO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Existearchivo)
                    .HasColumnName("EXISTEARCHIVO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Identificacion)
                    .HasColumnName("IDENTIFICACION")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("IDENTIFICACION DE LA EMPRESA CONVENIO");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("NOMBRE DE CONVENIO");

                entity.Property(e => e.Notifica)
                    .IsRequired()
                    .HasColumnName("NOTIFICA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')")
                    .HasComment("FLAG DE ENVIO DE NOTIFICACIONES");

                entity.Property(e => e.Notificaparametros)
                    .IsRequired()
                    .HasColumnName("NOTIFICAPARAMETROS")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("PARAMETROS PARA ENVIO DE NOTIFICACIONES");

                entity.Property(e => e.Notificatipo)
                    .IsRequired()
                    .HasColumnName("NOTIFICATIPO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('FTP')")
                    .HasComment("TIPO DE NOTIFICACION SMS O MAIL");

                entity.Property(e => e.Tipoliquidacion)
                    .IsRequired()
                    .HasColumnName("TIPOLIQUIDACION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('LIQ')");

                entity.Property(e => e.Tipopago)
                    .IsRequired()
                    .HasColumnName("TIPOPAGO")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tposestado>(entity =>
            {
                entity.ToTable("TPOSESTADO", "CANAL29OCT");

                entity.HasComment("ID DE ESTADO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnName("CODIGO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("CODIGO DE ESTADO DE PROCESO DE COMPENSACION");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("DESCRIPCION DE ESTADO DE COMPENSACCION");
            });

            modelBuilder.Entity<Tposmovimientosdenarius>(entity =>
            {
                entity.ToTable("TPOSMOVIMIENTOSDENARIUS", "CANAL29OCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cestado)
                    .HasColumnName("CESTADO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Convenio)
                    .HasColumnName("CONVENIO")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Fcompensacion)
                    .HasColumnName("FCOMPENSACION")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Ftransaccion)
                    .HasColumnName("FTRANSACCION")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Mid)
                    .HasColumnName("MID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Numeroaprobacion)
                    .HasColumnName("NUMEROAPROBACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numerotransaccion)
                    .HasColumnName("NUMEROTRANSACCION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valortransaccion)
                    .HasColumnName("VALORTRANSACCION")
                    .HasColumnType("numeric(15, 4)");
            });

            modelBuilder.Entity<TransaccionLog>(entity =>
            {
                entity.HasKey(e => e.IdTransaccionLog)
                    .HasName("PK_TRANSACCIONLOG");

                entity.ToTable("TransaccionLog", "BUS");

                entity.Property(e => e.Aplicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correlacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Mensaje).IsUnicode(false);

                entity.Property(e => e.ServicioWeb)
                    .HasColumnName("ServicioWEB")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tswterminalespos>(entity =>
            {
                entity.ToTable("TSWTERMINALESPOS", "CANAL29OCT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("CIUDAD")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("CIUDAD DE ESTABLECIMIENTO");

                entity.Property(e => e.Codigoalterno)
                    .HasColumnName("CODIGOALTERNO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("CODIGO ALTERNO DE MID");

                entity.Property(e => e.Convenio)
                    .HasColumnName("CONVENIO")
                    .HasComment("CODIGO DEL CONVENIO");

                entity.Property(e => e.Ctacontable)
                    .HasColumnName("CTACONTABLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("NUMERO DE CUENTA CONTABLE A AFECTAR");

                entity.Property(e => e.Direccion)
                    .HasColumnName("DIRECCION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("DIRECCION DEL ESTABLECIMIENTO");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("ESTADO DEL CONVENIO");

                entity.Property(e => e.Idconvenio).HasColumnName("IDCONVENIO");

                entity.Property(e => e.Mid)
                    .IsRequired()
                    .HasColumnName("MID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("CODIGO DE MID DE CONVENIO");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("NOMBRE DE TERMINAL");

                entity.HasOne(d => d.IdconvenioNavigation)
                    .WithMany(p => p.Tswterminalespos)
                    .HasForeignKey(d => d.Idconvenio)
                    .HasConstraintName("FK_TSWTERMINALESPOS_TPOSCONVENIO");
            });

            modelBuilder.Entity<Tusuario>(entity =>
            {
                entity.HasKey(e => e.Idcodigo);

                entity.ToTable("TUSUARIO", "HB");

                entity.HasComment("TABLA DONDE SE ALMACENARA LOS USUARIOS HOMEBANKING LIBELULA Y APP EN DESARROLLO, ESTE ESQUEMA SE CONSUMIRA ATRAVEZ DE WS");

                entity.HasIndex(e => new { e.Usuario, e.Tipo })
                    .HasName("UK_TUSUARIO")
                    .IsUnique();

                entity.HasIndex(e => new { e.Fhasta, e.Usuario, e.Tipo, e.Estado, e.Idcliente, e.Contrasenia })
                    .HasName("IX_TUSUARIO_FHASTAUSUARIOTIPEST");

                entity.Property(e => e.Idcodigo).HasColumnName("IDCODIGO");

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasColumnName("CONTRASENIA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fcaducidadpassword)
                    .HasColumnName("FCADUCIDADPASSWORD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fdesde)
                    .HasColumnName("FDESDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fhasta)
                    .HasColumnName("FHASTA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idcliente).HasColumnName("IDCLIENTE");

                entity.Property(e => e.Intento).HasColumnName("INTENTO");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("TIPO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("USUARIO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tusuariohistorico>(entity =>
            {
                entity.HasKey(e => e.Idcodigohistorico);

                entity.ToTable("TUSUARIOHISTORICO", "HB");

                entity.HasComment("TABLA DONDE SE ALMACENARA REGISTROS HISTORICO DE OPERACIONES REALIZADAS POR USUARIOS Y MENSAJES DE RESPUESTA ENVIADOS POR LOS STOREPROCEDURES");

                entity.Property(e => e.Idcodigohistorico).HasColumnName("IDCODIGOHISTORICO");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fechareal)
                    .HasColumnName("FECHAREAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idcodigo).HasColumnName("IDCODIGO");

                entity.Property(e => e.Respuesta)
                    .HasColumnName("RESPUESTA")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdcodigoNavigation)
                    .WithMany(p => p.Tusuariohistorico)
                    .HasForeignKey(d => d.Idcodigo)
                    .HasConstraintName("FK_TUSUARIO_TUSUARIOHISTO");
            });

            modelBuilder.Entity<Vposcompensacabecera>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VPOSCOMPENSACABECERA", "CANAL29OCT");

                entity.Property(e => e.Cestado)
                    .IsRequired()
                    .HasColumnName("CESTADO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Compensados).HasColumnName("COMPENSADOS");

                entity.Property(e => e.Convenio).HasColumnName("CONVENIO");

                entity.Property(e => e.Cusuarioautorizacion)
                    .HasColumnName("CUSUARIOAUTORIZACION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Error)
                    .HasColumnName("ERROR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fautorizacion)
                    .HasColumnName("FAUTORIZACION")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Fproceso)
                    .HasColumnName("FPROCESO")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rechazados).HasColumnName("RECHAZADOS");

                entity.Property(e => e.Registros).HasColumnName("REGISTROS");

                entity.Property(e => e.Retencionfte)
                    .HasColumnName("RETENCIONFTE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Retencioniva)
                    .HasColumnName("RETENCIONIVA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Totalcomision)
                    .HasColumnName("TOTALCOMISION")
                    .HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Totalivacomision)
                    .HasColumnName("TOTALIVACOMISION")
                    .HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Totalliquidado)
                    .HasColumnName("TOTALLIQUIDADO")
                    .HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Totalretencionfte)
                    .HasColumnName("TOTALRETENCIONFTE")
                    .HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Totalretencioniva)
                    .HasColumnName("TOTALRETENCIONIVA")
                    .HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Totaltransaccion)
                    .HasColumnName("TOTALTRANSACCION")
                    .HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Transferencia)
                    .HasColumnName("TRANSFERENCIA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuarioautorizacion)
                    .IsRequired()
                    .HasColumnName("USUARIOAUTORIZACION")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vposconvenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VPOSCONVENIO", "CANAL29OCT");

                entity.Property(e => e.Archivoorigen)
                    .IsRequired()
                    .HasColumnName("ARCHIVOORIGEN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Archivoretrono)
                    .IsRequired()
                    .HasColumnName("ARCHIVORETRONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comandoarchivo)
                    .IsRequired()
                    .HasColumnName("COMANDOARCHIVO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Comandocalculo)
                    .IsRequired()
                    .HasColumnName("COMANDOCALCULO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Comandotransaccion)
                    .IsRequired()
                    .HasColumnName("COMANDOTRANSACCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Compensa)
                    .IsRequired()
                    .HasColumnName("COMPENSA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Convenio)
                    .HasColumnName("CONVENIO")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Cuentacredito)
                    .IsRequired()
                    .HasColumnName("CUENTACREDITO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cuentacreditobanco)
                    .HasColumnName("CUENTACREDITOBANCO")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Cuentacreditobancobce)
                    .IsRequired()
                    .HasColumnName("CUENTACREDITOBANCOBCE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cuentacreditobanconombre)
                    .IsRequired()
                    .HasColumnName("CUENTACREDITOBANCONOMBRE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cuentacreditotipo)
                    .HasColumnName("CUENTACREDITOTIPO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cuentadebito)
                    .IsRequired()
                    .HasColumnName("CUENTADEBITO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Existearchivo)
                    .HasColumnName("EXISTEARCHIVO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasColumnName("IDENTIFICACION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Notifica)
                    .IsRequired()
                    .HasColumnName("NOTIFICA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Notificaparametros)
                    .IsRequired()
                    .HasColumnName("NOTIFICAPARAMETROS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Notificatipo)
                    .IsRequired()
                    .HasColumnName("NOTIFICATIPO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Tipoliquidacion)
                    .IsRequired()
                    .HasColumnName("TIPOLIQUIDACION")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tipopago)
                    .IsRequired()
                    .HasColumnName("TIPOPAGO")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
