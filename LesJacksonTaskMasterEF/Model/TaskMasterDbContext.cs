using System.Data.Entity;

namespace LesJacksonTaskMasterEF.Model
{
	public class TaskMasterDbContext : DbContext
	{
		// liste des tables
		public DbSet<Status> Statuses { get; set; }
		public DbSet<Task> Tasks { get; set; }
	}
}
