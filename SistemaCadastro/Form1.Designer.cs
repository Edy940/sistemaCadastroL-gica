﻿
namespace SistemaCadastro
{
    partial class Form1
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbEC = new System.Windows.Forms.Label();
            this.lbTelefomne = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.comboEC = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.checkCasa = new System.Windows.Forms.CheckBox();
            this.checkVeiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.Lista = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 30);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(0, 25);
            this.lbNome.TabIndex = 0;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(12, 66);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(176, 25);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data Nascimento";
            // 
            // lbEC
            // 
            this.lbEC.AutoSize = true;
            this.lbEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEC.Location = new System.Drawing.Point(12, 102);
            this.lbEC.Name = "lbEC";
            this.lbEC.Size = new System.Drawing.Size(126, 25);
            this.lbEC.TabIndex = 2;
            this.lbEC.Text = "Estado Civil";
            // 
            // lbTelefomne
            // 
            this.lbTelefomne.AutoSize = true;
            this.lbTelefomne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefomne.Location = new System.Drawing.Point(12, 138);
            this.lbTelefomne.Name = "lbTelefomne";
            this.lbTelefomne.Size = new System.Drawing.Size(96, 25);
            this.lbTelefomne.TabIndex = 3;
            this.lbTelefomne.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(205, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(494, 31);
            this.txtNome.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(205, 61);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(494, 31);
            this.txtData.TabIndex = 5;
            // 
            // comboEC
            // 
            this.comboEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEC.FormattingEnabled = true;
            this.comboEC.Location = new System.Drawing.Point(205, 102);
            this.comboEC.Name = "comboEC";
            this.comboEC.Size = new System.Drawing.Size(370, 33);
            this.comboEC.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(205, 141);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(370, 31);
            this.txtTelefone.TabIndex = 7;
            // 
            // checkCasa
            // 
            this.checkCasa.AutoSize = true;
            this.checkCasa.Location = new System.Drawing.Point(205, 192);
            this.checkCasa.Name = "checkCasa";
            this.checkCasa.Size = new System.Drawing.Size(120, 17);
            this.checkCasa.TabIndex = 8;
            this.checkCasa.Text = "Possui Casa Própria";
            this.checkCasa.UseVisualStyleBackColor = true;
            this.checkCasa.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkVeiculo
            // 
            this.checkVeiculo.AutoSize = true;
            this.checkVeiculo.Location = new System.Drawing.Point(205, 215);
            this.checkVeiculo.Name = "checkVeiculo";
            this.checkVeiculo.Size = new System.Drawing.Size(97, 17);
            this.checkVeiculo.TabIndex = 9;
            this.checkVeiculo.Text = "Possui Veículo";
            this.checkVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioO);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Location = new System.Drawing.Point(205, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 114);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(6, 66);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(51, 17);
            this.radioO.TabIndex = 2;
            this.radioO.Text = "Outro";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(6, 19);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(73, 17);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 25;
            this.Lista.Location = new System.Drawing.Point(36, 358);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(683, 129);
            this.Lista.TabIndex = 11;
            this.Lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lista_MouseDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(36, 267);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 31);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "CadastrarAlterar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(6, 43);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(67, 17);
            this.radioF.TabIndex = 13;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(36, 304);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 31);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(617, 313);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 31);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkVeiculo);
            this.Controls.Add(this.checkCasa);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.comboEC);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbTelefomne);
            this.Controls.Add(this.lbEC);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbNome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbEC;
        private System.Windows.Forms.Label lbTelefomne;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.ComboBox comboEC;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.CheckBox checkCasa;
        private System.Windows.Forms.CheckBox checkVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
    }
}

