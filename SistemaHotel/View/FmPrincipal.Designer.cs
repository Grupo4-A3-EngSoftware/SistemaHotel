namespace SistemaHotel
{
    partial class FmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtacheckin = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_Listar = new System.Windows.Forms.Button();
            this.btngestaopagamentos = new System.Windows.Forms.Button();
            this.btnHóspedes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtacheckin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.dtacheckin);
            this.panel1.Location = new System.Drawing.Point(182, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 332);
            this.panel1.TabIndex = 0;
            // 
            // dtacheckin
            // 
            this.dtacheckin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtacheckin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtacheckin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtacheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtacheckin.Location = new System.Drawing.Point(4, 12);
            this.dtacheckin.Margin = new System.Windows.Forms.Padding(2);
            this.dtacheckin.Name = "dtacheckin";
            this.dtacheckin.RowHeadersWidth = 62;
            this.dtacheckin.RowTemplate.Height = 28;
            this.dtacheckin.Size = new System.Drawing.Size(671, 299);
            this.dtacheckin.TabIndex = 0;
            this.dtacheckin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtacheckin_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.but_Listar);
            this.panel2.Controls.Add(this.btngestaopagamentos);
            this.panel2.Controls.Add(this.btnHóspedes);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 446);
            this.panel2.TabIndex = 1;
            // 
            // but_Listar
            // 
            this.but_Listar.Location = new System.Drawing.Point(22, 342);
            this.but_Listar.Name = "but_Listar";
            this.but_Listar.Size = new System.Drawing.Size(87, 25);
            this.but_Listar.TabIndex = 3;
            this.but_Listar.Text = "Listar";
            this.but_Listar.UseVisualStyleBackColor = true;
            this.but_Listar.Click += new System.EventHandler(this.but_Listar_Click);
            // 
            // btngestaopagamentos
            // 
            this.btngestaopagamentos.Location = new System.Drawing.Point(22, 85);
            this.btngestaopagamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btngestaopagamentos.Name = "btngestaopagamentos";
            this.btngestaopagamentos.Size = new System.Drawing.Size(87, 38);
            this.btngestaopagamentos.TabIndex = 2;
            this.btngestaopagamentos.Text = "Gestão de Pagamentos";
            this.btngestaopagamentos.UseVisualStyleBackColor = true;
            this.btngestaopagamentos.Click += new System.EventHandler(this.btngestaopagamentos_Click);
            // 
            // btnHóspedes
            // 
            this.btnHóspedes.Location = new System.Drawing.Point(22, 23);
            this.btnHóspedes.Margin = new System.Windows.Forms.Padding(2);
            this.btnHóspedes.Name = "btnHóspedes";
            this.btnHóspedes.Size = new System.Drawing.Size(87, 33);
            this.btnHóspedes.TabIndex = 2;
            this.btnHóspedes.Text = "Hóspedes";
            this.btnHóspedes.UseVisualStyleBackColor = true;
            this.btnHóspedes.Click += new System.EventHandler(this.btnHóspedes_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entradas agendas do dia (Check-in)";
            // 
            // FmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtacheckin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHóspedes;
        private System.Windows.Forms.DataGridView dtacheckin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngestaopagamentos;
        private System.Windows.Forms.Button but_Listar;
    }
}