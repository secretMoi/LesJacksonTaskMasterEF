namespace LesJacksonTaskMasterEF
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxTask = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelTask = new System.Windows.Forms.Label();
			this.labelStatus = new System.Windows.Forms.Label();
			this.labelDueDate = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 163);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(576, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.labelDueDate);
			this.groupBox1.Controls.Add(this.labelStatus);
			this.groupBox1.Controls.Add(this.labelTask);
			this.groupBox1.Controls.Add(this.buttonCancel);
			this.groupBox1.Controls.Add(this.buttonDelete);
			this.groupBox1.Controls.Add(this.buttonUpdate);
			this.groupBox1.Controls.Add(this.buttonCreate);
			this.groupBox1.Controls.Add(this.comboBoxStatus);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.textBoxTask);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 145);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Task";
			// 
			// textBoxTask
			// 
			this.textBoxTask.Location = new System.Drawing.Point(71, 19);
			this.textBoxTask.Name = "textBoxTask";
			this.textBoxTask.Size = new System.Drawing.Size(174, 20);
			this.textBoxTask.TabIndex = 0;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(459, 19);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Location = new System.Drawing.Point(71, 45);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
			this.comboBoxStatus.TabIndex = 2;
			this.comboBoxStatus.Text = "Please Select...";
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(198, 43);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonCreate.TabIndex = 3;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(279, 43);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(360, 43);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 5;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(279, 72);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelTask
			// 
			this.labelTask.AutoSize = true;
			this.labelTask.Location = new System.Drawing.Point(6, 25);
			this.labelTask.Name = "labelTask";
			this.labelTask.Size = new System.Drawing.Size(34, 13);
			this.labelTask.TabIndex = 7;
			this.labelTask.Text = "Task:";
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(6, 53);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(40, 13);
			this.labelStatus.TabIndex = 8;
			this.labelStatus.Text = "Status:";
			// 
			// labelDueDate
			// 
			this.labelDueDate.AutoSize = true;
			this.labelDueDate.Location = new System.Drawing.Point(397, 22);
			this.labelDueDate.Name = "labelDueDate";
			this.labelDueDate.Size = new System.Drawing.Size(56, 13);
			this.labelDueDate.TabIndex = 9;
			this.labelDueDate.Text = "Due Date:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 325);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.MaximumSize = new System.Drawing.Size(616, 364);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TaskMaster";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelDueDate;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label labelTask;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBoxTask;
	}
}

