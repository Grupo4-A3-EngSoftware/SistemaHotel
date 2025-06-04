namespace SistemaHotel
{
    partial class FmCadastroHodped
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomehospede = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_hpds = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttListar = new System.Windows.Forms.Button();
            this.butt_del = new System.Windows.Forms.Button();
            this.butt_checkin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_hpds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtnomehospede
            // 
            this.txtnomehospede.Location = new System.Drawing.Point(19, 32);
            this.txtnomehospede.Margin = new System.Windows.Forms.Padding(2);
            this.txtnomehospede.Name = "txtnomehospede";
            this.txtnomehospede.Size = new System.Drawing.Size(305, 20);
            this.txtnomehospede.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(19, 103);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtendereco.Multiline = true;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(305, 20);
            this.txtendereco.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.DGV_hpds);
            this.panel1.Location = new System.Drawing.Point(19, 252);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 127);
            this.panel1.TabIndex = 4;
            // 
            // DGV_hpds
            // 
            this.DGV_hpds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_hpds.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_hpds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_hpds.Location = new System.Drawing.Point(18, 15);
            this.DGV_hpds.Name = "DGV_hpds";
            this.DGV_hpds.RowHeadersWidth = 62;
            this.DGV_hpds.Size = new System.Drawing.Size(789, 96);
            this.DGV_hpds.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hóspedes cadastrados";
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(174, 168);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(77, 32);
            this.btnnovo.TabIndex = 0;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(452, 32);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(235, 20);
            this.txtemail.TabIndex = 3;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(481, 168);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(79, 32);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(452, 103);
            this.maskedTextBoxCPF.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(235, 20);
            this.maskedTextBoxCPF.TabIndex = 4;
            this.maskedTextBoxCPF.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCPF_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF";
            // 
            // buttListar
            // 
            this.buttListar.Location = new System.Drawing.Point(151, 404);
            this.buttListar.Name = "buttListar";
            this.buttListar.Size = new System.Drawing.Size(79, 32);
            this.buttListar.TabIndex = 12;
            this.buttListar.Text = "Listar";
            this.buttListar.UseVisualStyleBackColor = true;
            this.buttListar.Click += new System.EventHandler(this.buttListar_Click);
            // 
            // butt_del
            // 
            this.butt_del.Location = new System.Drawing.Point(326, 406);
            this.butt_del.Name = "butt_del";
            this.butt_del.Size = new System.Drawing.Size(74, 28);
            this.butt_del.TabIndex = 13;
            this.butt_del.Text = "Deletar";
            this.butt_del.UseVisualStyleBackColor = true;
            this.butt_del.Click += new System.EventHandler(this.butt_del_Click);
            // 
            // butt_checkin
            // 
            this.butt_checkin.Location = new System.Drawing.Point(502, 406);
            this.butt_checkin.Name = "butt_checkin";
            this.butt_checkin.Size = new System.Drawing.Size(101, 28);
            this.butt_checkin.TabIndex = 14;
            this.butt_checkin.Text = "Fazer checkin";
            this.butt_checkin.UseVisualStyleBackColor = true;
            this.butt_checkin.Click += new System.EventHandler(this.butt_checkin_Click);
            // 
            // FmCadastroHodped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(866, 460);
            this.Controls.Add(this.butt_checkin);
            this.Controls.Add(this.butt_del);
            this.Controls.Add(this.buttListar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxCPF);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnomehospede);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FmCadastroHodped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Hóspede";
            this.Load += new System.EventHandler(this.FmCadastroHodped_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_hpds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomehospede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.DataGridView DGV_hpds;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttListar;
        private System.Windows.Forms.Button butt_del;
        private System.Windows.Forms.Button butt_checkin;
    }
}