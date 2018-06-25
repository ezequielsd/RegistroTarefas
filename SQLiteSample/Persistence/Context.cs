using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ListaTarefas
{
	public class Context : DbContext
	{
        public DbSet<TipoTarefa> TipoTarefas { get; set; }

        public DbSet<Tarefa> Tarefas { get; set; }

        public DbSet<NotaTarefa> NotaTarefas { get; set; }

        public DbSet<Favorito> Favoritos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// Chinook Database does not pluralize table names
			modelBuilder.Conventions
				.Remove<PluralizingTableNameConvention>();

		}

	}
}
