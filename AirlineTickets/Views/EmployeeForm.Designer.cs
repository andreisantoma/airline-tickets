namespace AirlineTickets.Views
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.dataGridView_Flights = new System.Windows.Forms.DataGridView();
            this.label_Source = new System.Windows.Forms.Label();
            this.label_Destination = new System.Windows.Forms.Label();
            this.label_Duration = new System.Windows.Forms.Label();
            this.textBox_Source = new System.Windows.Forms.TextBox();
            this.textBox_Destination = new System.Windows.Forms.TextBox();
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Flights
            // 
            this.dataGridView_Flights.AllowUserToAddRows = false;
            this.dataGridView_Flights.AllowUserToDeleteRows = false;
            this.dataGridView_Flights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Flights.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Flights.Name = "dataGridView_Flights";
            this.dataGridView_Flights.ReadOnly = true;
            this.dataGridView_Flights.Size = new System.Drawing.Size(641, 205);
            this.dataGridView_Flights.TabIndex = 0;
            this.dataGridView_Flights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Flights_CellClick);
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Location = new System.Drawing.Point(222, 254);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(41, 13);
            this.label_Source.TabIndex = 1;
            this.label_Source.Text = "Source";
            // 
            // label_Destination
            // 
            this.label_Destination.AutoSize = true;
            this.label_Destination.Location = new System.Drawing.Point(203, 290);
            this.label_Destination.Name = "label_Destination";
            this.label_Destination.Size = new System.Drawing.Size(60, 13);
            this.label_Destination.TabIndex = 2;
            this.label_Destination.Text = "Destination";
            // 
            // label_Duration
            // 
            this.label_Duration.AutoSize = true;
            this.label_Duration.Location = new System.Drawing.Point(216, 325);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(47, 13);
            this.label_Duration.TabIndex = 3;
            this.label_Duration.Text = "Duration";
            // 
            // textBox_Source
            // 
            this.textBox_Source.Location = new System.Drawing.Point(282, 251);
            this.textBox_Source.Name = "textBox_Source";
            this.textBox_Source.Size = new System.Drawing.Size(100, 20);
            this.textBox_Source.TabIndex = 4;
            // 
            // textBox_Destination
            // 
            this.textBox_Destination.Location = new System.Drawing.Point(282, 287);
            this.textBox_Destination.Name = "textBox_Destination";
            this.textBox_Destination.Size = new System.Drawing.Size(100, 20);
            this.textBox_Destination.TabIndex = 5;
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(282, 322);
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(100, 20);
            this.textBox_Duration.TabIndex = 6;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(405, 249);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(405, 285);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(405, 320);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 9;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 369);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Duration);
            this.Controls.Add(this.textBox_Destination);
            this.Controls.Add(this.textBox_Source);
            this.Controls.Add(this.label_Duration);
            this.Controls.Add(this.label_Destination);
            this.Controls.Add(this.label_Source);
            this.Controls.Add(this.dataGridView_Flights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.Text = "Manage flights";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Flights;
        private System.Windows.Forms.Label label_Source;
        private System.Windows.Forms.Label label_Destination;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.TextBox textBox_Source;
        private System.Windows.Forms.TextBox textBox_Destination;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
    }
}