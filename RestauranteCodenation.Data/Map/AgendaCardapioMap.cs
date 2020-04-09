using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteCodenation.Domain.Modelo;

namespace RestauranteCodenation.Data.Map
{
    public class AgendaCardapioMap : IEntityTypeConfiguration<AgendaCardapio>
    {
        public void Configure(EntityTypeBuilder<AgendaCardapio> builder)
        {
            builder.ToTable(nameof(AgendaCardapio));

            builder.HasKey(t => new { t.IdAgenda, t.IdCardapio });

            builder.HasOne(i => i.Agenda)
                .WithMany(pi => pi.AgendaCardapio)
                .HasForeignKey(i => i.IdAgenda);

            builder.HasOne(p => p.Cardapio)
                .WithMany(pi => pi.AgendaCardapio)
                .HasForeignKey(p => p.IdCardapio);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
