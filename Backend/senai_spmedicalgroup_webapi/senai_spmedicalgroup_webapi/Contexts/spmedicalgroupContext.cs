using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai_spmedicalgroup_webapi.Domains;

#nullable disable

namespace senai_spmedicalgroup_webapi.Contexts
{
    public partial class spmedicalgroupContext : DbContext
    {
        public spmedicalgroupContext()
        {
        }

        public spmedicalgroupContext(DbContextOptions<spmedicalgroupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clinica> Clinicas { get; set; }
        public virtual DbSet<Consultum> Consulta { get; set; }
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Situacao> Situacaos { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = LAPTOP-OPGDO1EG; Initial Catalog = senai_spmed_group; user Id=sa; pwd = @nota1000;");
            }
        }

       // https://docs.microsoft.com/pt-br/ef/core/managing-schemas/scaffolding

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Clinica>(entity =>
            {
                entity.HasKey(e => e.IdClinica)
                    .HasName("PK__clinica__C73A6055DB2320C1");

                entity.ToTable("clinica");

                entity.Property(e => e.IdClinica).HasColumnName("idClinica");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razaoSocial");
            });

            modelBuilder.Entity<Consultum>(entity =>
            {
                entity.HasKey(e => e.Idconsulta)
                    .HasName("PK__consulta__8CFD7966F1DB8B3D");

                entity.ToTable("consulta");

                entity.Property(e => e.Idconsulta).HasColumnName("idconsulta");

                entity.Property(e => e.DataConsulta)
                    .HasColumnType("date")
                    .HasColumnName("dataConsulta");

                entity.Property(e => e.Idmedico).HasColumnName("idmedico");

                entity.Property(e => e.Idpaciente).HasColumnName("idpaciente");

                entity.Property(e => e.Idsituacao).HasColumnName("idsituacao");

                entity.Property(e => e.Medico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("medico");

                entity.Property(e => e.Prontuario)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("prontuario");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("situacao");

                entity.HasOne(d => d.IdmedicoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.Idmedico)
                    .HasConstraintName("FK__consulta__idmedi__4AB81AF0");

                entity.HasOne(d => d.IdpacienteNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.Idpaciente)
                    .HasConstraintName("FK__consulta__idpaci__4BAC3F29");

                entity.HasOne(d => d.IdsituacaoNavigation)
                    .WithMany(p => p.Consulta)
                    .HasForeignKey(d => d.Idsituacao)
                    .HasConstraintName("FK__consulta__idsitu__4CA06362");
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidade)
                    .HasName("PK__especial__4096980512EC022D");

                entity.ToTable("especialidade");

                entity.Property(e => e.IdEspecialidade).HasColumnName("idEspecialidade");

                entity.Property(e => e.NomeEspecialidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeEspecialidade");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasKey(e => e.IdMedico)
                    .HasName("PK__medico__4E03DEBABDDAA4A7");

                entity.ToTable("medico");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.Crm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRM");

                entity.Property(e => e.IdEspecialidade).HasColumnName("idEspecialidade");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Idclinica).HasColumnName("idclinica");

                entity.HasOne(d => d.IdEspecialidadeNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdEspecialidade)
                    .HasConstraintName("FK__medico__idEspeci__440B1D61");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__medico__idUsuari__4316F928");

                entity.HasOne(d => d.IdclinicaNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.Idclinica)
                    .HasConstraintName("FK__medico__idclinic__44FF419A");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente)
                    .HasName("PK__paciente__F48A08F2A809A0E0");

                entity.ToTable("paciente");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Endereço)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idade).HasColumnName("idade");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Rg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RG");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("FK__paciente__idusua__47DBAE45");
            });

            modelBuilder.Entity<Situacao>(entity =>
            {
                entity.HasKey(e => e.Idsituacao)
                    .HasName("PK__situacao__EA864BB576AA2338");

                entity.ToTable("situacao");

                entity.Property(e => e.Idsituacao).HasColumnName("idsituacao");

                entity.Property(e => e.Situacao1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("situacao");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__tipoUsua__03006BFF1194BDB3");

                entity.ToTable("tipoUsuario");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A66172FECB");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Senha, "UQ__Usuario__7ABB97310353EFC3")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Usuario__A9D1053421ABA06C")
                    .IsUnique();

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuario__idTipoU__403A8C7D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
