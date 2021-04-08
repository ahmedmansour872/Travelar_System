namespace Travelar_System
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ll1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ll2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ll3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ll4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ll5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ll6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.Color.Brown;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 279);
            this.dataGridView1.TabIndex = 93;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "fullname";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "phone";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name of tour";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Travels ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Number of individuals";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Individual price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 98;
            this.label2.Text = "num of bookings=";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Black;
            this.l1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.Transparent;
            this.l1.Location = new System.Drawing.Point(194, 300);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(17, 23);
            this.l1.TabIndex = 98;
            this.l1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(609, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 98;
            this.label3.Text = "sum of total price=";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Black;
            this.l3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.Transparent;
            this.l3.Location = new System.Drawing.Point(803, 300);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(17, 23);
            this.l3.TabIndex = 98;
            this.l3.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(12, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 23);
            this.label5.TabIndex = 98;
            this.label5.Text = "num of Tour in Aswan=";
            // 
            // ll1
            // 
            this.ll1.AutoSize = true;
            this.ll1.BackColor = System.Drawing.Color.Black;
            this.ll1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll1.ForeColor = System.Drawing.Color.Transparent;
            this.ll1.Location = new System.Drawing.Point(243, 366);
            this.ll1.Name = "ll1";
            this.ll1.Size = new System.Drawing.Size(17, 23);
            this.ll1.TabIndex = 98;
            this.ll1.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(467, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 23);
            this.label7.TabIndex = 98;
            this.label7.Text = "num of Tour in Luxor=";
            // 
            // ll2
            // 
            this.ll2.AutoSize = true;
            this.ll2.BackColor = System.Drawing.Color.Black;
            this.ll2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll2.ForeColor = System.Drawing.Color.Transparent;
            this.ll2.Location = new System.Drawing.Point(695, 366);
            this.ll2.Name = "ll2";
            this.ll2.Size = new System.Drawing.Size(17, 23);
            this.ll2.TabIndex = 98;
            this.ll2.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(281, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 23);
            this.label9.TabIndex = 98;
            this.label9.Text = "Avg to num of individuals=";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Black;
            this.l2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.Transparent;
            this.l2.Location = new System.Drawing.Point(547, 300);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(17, 23);
            this.l2.TabIndex = 98;
            this.l2.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOrange;
            this.label13.Location = new System.Drawing.Point(12, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(351, 23);
            this.label13.TabIndex = 98;
            this.label13.Text = "num of Cairo Tours from El Gouna=";
            // 
            // ll3
            // 
            this.ll3.AutoSize = true;
            this.ll3.BackColor = System.Drawing.Color.Black;
            this.ll3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll3.ForeColor = System.Drawing.Color.Transparent;
            this.ll3.Location = new System.Drawing.Point(355, 426);
            this.ll3.Name = "ll3";
            this.ll3.Size = new System.Drawing.Size(17, 23);
            this.ll3.TabIndex = 98;
            this.ll3.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkOrange;
            this.label17.Location = new System.Drawing.Point(467, 426);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(292, 23);
            this.label17.TabIndex = 98;
            this.label17.Text = "num of Alexandria Day Tour=";
            // 
            // ll4
            // 
            this.ll4.AutoSize = true;
            this.ll4.BackColor = System.Drawing.Color.Black;
            this.ll4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll4.ForeColor = System.Drawing.Color.Transparent;
            this.ll4.Location = new System.Drawing.Point(754, 426);
            this.ll4.Name = "ll4";
            this.ll4.Size = new System.Drawing.Size(17, 23);
            this.ll4.TabIndex = 98;
            this.ll4.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkOrange;
            this.label19.Location = new System.Drawing.Point(12, 484);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(350, 23);
            this.label19.TabIndex = 98;
            this.label19.Text = "num of Nile Cruise Tour in Sharm= ";
            // 
            // ll5
            // 
            this.ll5.AutoSize = true;
            this.ll5.BackColor = System.Drawing.Color.Black;
            this.ll5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll5.ForeColor = System.Drawing.Color.Transparent;
            this.ll5.Location = new System.Drawing.Point(355, 484);
            this.ll5.Name = "ll5";
            this.ll5.Size = new System.Drawing.Size(17, 23);
            this.ll5.TabIndex = 98;
            this.ll5.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkOrange;
            this.label21.Location = new System.Drawing.Point(467, 484);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(341, 23);
            this.label21.TabIndex = 98;
            this.label21.Text = "num of Giftun Tours in Hurghada=";
            // 
            // ll6
            // 
            this.ll6.AutoSize = true;
            this.ll6.BackColor = System.Drawing.Color.Black;
            this.ll6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll6.ForeColor = System.Drawing.Color.Transparent;
            this.ll6.Location = new System.Drawing.Point(803, 484);
            this.ll6.Name = "ll6";
            this.ll6.Size = new System.Drawing.Size(17, 23);
            this.ll6.TabIndex = 98;
            this.ll6.Text = ":";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Travelar_System.Properties.Resources.leaf_409258_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 516);
            this.Controls.Add(this.ll4);
            this.Controls.Add(this.ll2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ll5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ll3);
            this.Controls.Add(this.ll6);
            this.Controls.Add(this.ll1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show bookings";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ll1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ll2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ll3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label ll4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label ll5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label ll6;
    }
}