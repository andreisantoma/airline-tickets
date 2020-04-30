namespace AirlineTickets.Views
{
    partial class RegularUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularUserForm));
            this.listBox_Flights = new System.Windows.Forms.ListBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Flights
            // 
            this.listBox_Flights.FormattingEnabled = true;
            this.listBox_Flights.HorizontalScrollbar = true;
            this.listBox_Flights.Location = new System.Drawing.Point(12, 51);
            this.listBox_Flights.Name = "listBox_Flights";
            this.listBox_Flights.Size = new System.Drawing.Size(364, 225);
            this.listBox_Flights.Sorted = true;
            this.listBox_Flights.TabIndex = 0;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Search.Location = new System.Drawing.Point(12, 15);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(268, 20);
            this.textBox_Search.TabIndex = 1;
            this.textBox_Search.Text = "Input source, destination or duration of flight...";
            this.textBox_Search.Enter += new System.EventHandler(this.textBox_Search_Enter);
            this.textBox_Search.Leave += new System.EventHandler(this.textBox_Search_Leave);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(288, 13);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(88, 23);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // RegularUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 288);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.listBox_Flights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegularUserForm";
            this.Text = "Browse flights";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Flights;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
    }
}