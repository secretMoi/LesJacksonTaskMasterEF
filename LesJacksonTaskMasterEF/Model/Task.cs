using System;

namespace LesJacksonTaskMasterEF.Model
{
	public class Task
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime? DueDate { get; set; }


		public int StatusId { get; set; } // foreign key
		public Status Status { get; set; } // contenu de status lié à l'objet
	}
}
