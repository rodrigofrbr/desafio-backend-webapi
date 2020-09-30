using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext (DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }
        public DbSet<WebAPI.Models.Tarefa> Tarefa { get; set; }

        //Sobrescrevendo o metodo SaveChangesAsync()...
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SalvarProcesso();

            //Após a execução do método ele termina a ação planejada...
            return base.SaveChangesAsync(cancellationToken);
        }

        //Criação do método... 
        private void SalvarProcesso()
        {
            //Setar a variável dataAgora que contém a data local, através do atributo .Now do objeto DateTime
            var dataAgora = DateTime.Now;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is Entity))
            {
                var entity = item.Entity as Entity;
                //Quando o model Entity for criado os valores de DataCriar e DataUpdate deverão ser atualizados pelo valor de dataAgora
                entity.DataCriar = dataAgora;
                entity.DataUpdate = dataAgora;
            }

            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified && e.Entity is Entity))
            {
                var entity = item.Entity as Entity;
                //Quando o model Entity for atualizado, somente o valor de DataUpdate deve ser atualizado pelo valor de dataAgora			
                entity.DataUpdate = dataAgora;
                //Impede que ao ser modificado, o valor de DataCriar seja alterado
                item.Property(nameof(entity.DataCriar)).IsModified = false;
            }
        }

    }
}
