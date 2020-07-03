using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LesJacksonTaskMasterEF.Model;

namespace LesJacksonTaskMasterEF
{
	public partial class Form1 : Form
	{
		private readonly TaskMasterDbContext _taskMasterDbContext;

		public Form1()
		{
			InitializeComponent();

			_taskMasterDbContext = new TaskMasterDbContext(); // connexion à la bdd

			List<Status> statuses = new TaskMasterDbContext().Statuses.ToList(); // récupère tous les status

			// ajoute les status à la combobox
			foreach (Status statuse in statuses)
				comboBoxStatus.Items.Add(statuse);

			RefreshData();
		}

		private void RefreshData()
		{
			BindingSource bindingSource = new BindingSource();

			var query = from task in _taskMasterDbContext.Tasks
				orderby task.DueDate
				select new {task.Id, TaskName = task.Name, StatusName = task.Status.Name, task.DueDate};

			bindingSource.DataSource = query.ToList();

			dataGridView1.DataSource = bindingSource;
			dataGridView1.Refresh();
		}

		private void buttonCreate_Click(object sender, System.EventArgs e)
		{
			if (comboBoxStatus.SelectedItem != null && textBoxTask.Text != string.Empty)
			{
				// crée la tâche
				Task newTask = new Task()
				{
					Name = textBoxTask.Text,
					// vu qu'on ajoute l'objet Status et qu'il affiche sa méthode ToString
					StatusId = (comboBoxStatus.SelectedItem as Status).Id,
					DueDate = dateTimePicker1.Value
				};

				_taskMasterDbContext.Tasks.Add(newTask); // l'ajout au context

				_taskMasterDbContext.SaveChanges(); // sauve l'état courant des objets (la nouvelle tâche)

				RefreshData();
			}
			else
			{
				MessageBox.Show(@"Enter data !");
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			Task task = _taskMasterDbContext.Tasks.Find((int) dataGridView1.SelectedCells[0].Value);

			_taskMasterDbContext.Tasks.Remove(task);

			_taskMasterDbContext.SaveChanges();

			RefreshData();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (buttonUpdate.Text == "Update")
			{
				textBoxTask.Text = dataGridView1.SelectedCells[1].Value.ToString();

				dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[3].Value;

				foreach (Status status in comboBoxStatus.Items)
					if (status.Name == dataGridView1.SelectedCells[2].Value.ToString())
						comboBoxStatus.SelectedItem = status;

				buttonUpdate.Text = "Save";
			}
			else if(buttonUpdate.Text == "Save")
			{
				Task task = _taskMasterDbContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);

				task.Name = textBoxTask.Text;
				task.StatusId = (comboBoxStatus.SelectedItem as Status).Id;
				task.DueDate = dateTimePicker1.Value;

				_taskMasterDbContext.SaveChanges();

				RefreshData();

				buttonUpdate.Text = "Update";
				textBoxTask.Text = string.Empty;
				dateTimePicker1.Value = DateTime.Now;
				comboBoxStatus.Text = "Please select...";
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			buttonUpdate.Text = "Update";
			textBoxTask.Text = string.Empty;
			dateTimePicker1.Value = DateTime.Now;
			comboBoxStatus.Text = "Please select...";
		}
	}
}
