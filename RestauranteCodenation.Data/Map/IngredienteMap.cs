using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteCodenation.Domain.Modelo;

namespace RestauranteCodenation.Data.Map
{
    public class IngredienteMap : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {            
            builder.ToTable(nameof(Ingrediente));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(x => x.Descricao)
                   .HasColumnType("varchar(500)");
        }
    }
}
