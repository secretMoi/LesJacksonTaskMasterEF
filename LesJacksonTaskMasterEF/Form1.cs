using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LesJacksonTaskMasterEF.Model;

namespace LesJacksonTaskMasterEF
{
	public partial class Form1 : Form
	{
		private TaskMasterDbContext _taskMasterDbContext;

		public Form1()
		{
			InitializeComponent();

			_taskMasterDbContext = new TaskMasterDbContext(); // connexion à la bdd

			List<Status> statuses = new TaskMasterDbContext().Statuses.ToList(); // récupère tous les status

			// ajoute les status à la combobox
			foreach (Status statuse in statuses)
				comboBoxStatus.Items.Add(statuse);
		}
	}
}
