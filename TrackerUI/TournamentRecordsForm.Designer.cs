//namespace WindowsFormsApp1
//{
//    partial class TournamentRecordsForm
//    {
//        / <summary>
//        / Required designer variable.
//        / </summary>
//        private System.ComponentModel.IContainer components = null;

//        / <summary>
//        / Clean up any resources being used.
//        / </summary>
//        / <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        / <summary>
//        / Required method for Designer support - do not modify
//        / the contents of this method with the code editor.
//        / </summary>
//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.button1 = new System.Windows.Forms.Button();
//            this.button2 = new System.Windows.Forms.Button();
//            this.headerLabel = new System.Windows.Forms.Label();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();

//            panel1


//            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
//            this.panel1.Controls.Add(this.button1);
//            this.panel1.Controls.Add(this.button2);
//            this.panel1.Controls.Add(this.headerLabel);
//            this.panel1.ForeColor = System.Drawing.Color.White;
//            this.panel1.Location = new System.Drawing.Point(0, -2);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(550, 93);
//            this.panel1.TabIndex = 28;

//            button1


//            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
//            this.button1.FlatAppearance.BorderSize = 0;
//            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.button1.Image = global::TrackerUI.Properties.Resources.minimize1;
//            this.button1.Location = new System.Drawing.Point(419, 15);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(67, 63);
//            this.button1.TabIndex = 17;
//            this.button1.UseVisualStyleBackColor = true;

//            button2


//            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
//            this.button2.FlatAppearance.BorderSize = 0;
//            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.button2.Image = global::TrackerUI.Properties.Resources.close1;
//            this.button2.Location = new System.Drawing.Point(479, 15);
//            this.button2.Name = "button2";
//            this.button2.Size = new System.Drawing.Size(67, 63);
//            this.button2.TabIndex = 16;
//            this.button2.UseVisualStyleBackColor = true;

//            headerLabel


//            this.headerLabel.AutoSize = true;
//            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.headerLabel.ForeColor = System.Drawing.Color.White;
//            this.headerLabel.Location = new System.Drawing.Point(12, 15);
//            this.headerLabel.Name = "headerLabel";
//            this.headerLabel.Size = new System.Drawing.Size(339, 50);
//            this.headerLabel.TabIndex = 12;
//            this.headerLabel.Text = "Tournament Records";

//            dataGridView1


//            this.dataGridView1.AllowUserToAddRows = false;
//            this.dataGridView1.AllowUserToDeleteRows = false;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.Column1,
//            this.Column2,
//            this.Column3,
//            this.Column4});
//            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
//            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
//            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
//            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
//            this.dataGridView1.Location = new System.Drawing.Point(3, 90);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.ReadOnly = true;
//            this.dataGridView1.RowTemplate.Height = 25;
//            this.dataGridView1.Size = new System.Drawing.Size(543, 469);
//            this.dataGridView1.TabIndex = 29;

//            Column1


//            this.Column1.HeaderText = "Team Name";
//            this.Column1.Name = "Column1";
//            this.Column1.ReadOnly = true;
//            this.Column1.Width = 150;

//            Column2


//            this.Column2.HeaderText = "Team Ranking";
//            this.Column2.Name = "Column2";
//            this.Column2.ReadOnly = true;
//            this.Column2.Width = 150;

//            Column3


//            this.Column3.HeaderText = "Wins";
//            this.Column3.Name = "Column3";
//            this.Column3.ReadOnly = true;

//            Column4


//            this.Column4.HeaderText = "Loss";
//            this.Column4.Name = "Column4";
//            this.Column4.ReadOnly = true;

//            TournamentRecordsForm


//            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.AutoSize = true;
//            this.ClientSize = new System.Drawing.Size(549, 536);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.panel1);
//            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.ForeColor = System.Drawing.Color.SteelBlue;
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.Name = "TournamentRecordsForm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Result Table";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.Button button2;
//        private System.Windows.Forms.Label headerLabel;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
//    }
//}

