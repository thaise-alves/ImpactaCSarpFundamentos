namespace Oficina.WindowsForms
{
    partial class VeiculoForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.anoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MarcacomboBox = new System.Windows.Forms.ComboBox();
            this.ModelocomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CombustivelcomboBox = new System.Windows.Forms.ComboBox();
            this.CambiocomboBox = new System.Windows.Forms.ComboBox();
            this.Gravarbutton = new System.Windows.Forms.Button();
            this.Limparbutton = new System.Windows.Forms.Button();
            this.observacaogroupBox = new System.Windows.Forms.GroupBox();
            this.observacaotextBox = new System.Windows.Forms.TextBox();
            this.CorcomboBox = new System.Windows.Forms.ComboBox();
            this.veiculoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.observacaogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano";
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Location = new System.Drawing.Point(80, 8);
            this.placaMaskedTextBox.Mask = ">LLL<-0000";
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.placaMaskedTextBox.TabIndex = 1;
            this.placaMaskedTextBox.Tag = "*PLACA";
            this.placaMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // anoTextBox
            // 
            this.anoTextBox.Location = new System.Drawing.Point(80, 175);
            this.anoTextBox.Mask = "00000";
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(121, 20);
            this.anoTextBox.TabIndex = 7;
            this.anoTextBox.Tag = "*ANO";
            this.anoTextBox.ValidatingType = typeof(int);
            // 
            // MarcacomboBox
            // 
            this.MarcacomboBox.FormattingEnabled = true;
            this.MarcacomboBox.Location = new System.Drawing.Point(80, 62);
            this.MarcacomboBox.Name = "MarcacomboBox";
            this.MarcacomboBox.Size = new System.Drawing.Size(121, 21);
            this.MarcacomboBox.TabIndex = 3;
            this.MarcacomboBox.Tag = "*";
            this.MarcacomboBox.SelectedIndexChanged += new System.EventHandler(this.MarcacomboBox_SelectedIndexChanged);
            // 
            // ModelocomboBox
            // 
            this.ModelocomboBox.FormattingEnabled = true;
            this.ModelocomboBox.Location = new System.Drawing.Point(80, 127);
            this.ModelocomboBox.Name = "ModelocomboBox";
            this.ModelocomboBox.Size = new System.Drawing.Size(121, 21);
            this.ModelocomboBox.TabIndex = 5;
            this.ModelocomboBox.Tag = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cor";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Combustivel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Câmbio";
            // 
            // CombustivelcomboBox
            // 
            this.CombustivelcomboBox.FormattingEnabled = true;
            this.CombustivelcomboBox.Location = new System.Drawing.Point(358, 63);
            this.CombustivelcomboBox.Name = "CombustivelcomboBox";
            this.CombustivelcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CombustivelcomboBox.TabIndex = 11;
            this.CombustivelcomboBox.Tag = "*";
            // 
            // CambiocomboBox
            // 
            this.CambiocomboBox.FormattingEnabled = true;
            this.CambiocomboBox.Location = new System.Drawing.Point(358, 128);
            this.CambiocomboBox.Name = "CambiocomboBox";
            this.CambiocomboBox.Size = new System.Drawing.Size(121, 21);
            this.CambiocomboBox.TabIndex = 13;
            this.CambiocomboBox.Tag = "*";
            // 
            // Gravarbutton
            // 
            this.Gravarbutton.Location = new System.Drawing.Point(556, 8);
            this.Gravarbutton.Name = "Gravarbutton";
            this.Gravarbutton.Size = new System.Drawing.Size(75, 23);
            this.Gravarbutton.TabIndex = 15;
            this.Gravarbutton.Text = "Gravar";
            this.Gravarbutton.UseVisualStyleBackColor = true;
            this.Gravarbutton.Click += new System.EventHandler(this.Gravarbutton_Click);
            // 
            // Limparbutton
            // 
            this.Limparbutton.Location = new System.Drawing.Point(556, 37);
            this.Limparbutton.Name = "Limparbutton";
            this.Limparbutton.Size = new System.Drawing.Size(75, 23);
            this.Limparbutton.TabIndex = 16;
            this.Limparbutton.Text = "Limpar";
            this.Limparbutton.UseVisualStyleBackColor = true;
            this.Limparbutton.Click += new System.EventHandler(this.Limparbutton_Click);
            // 
            // observacaogroupBox
            // 
            this.observacaogroupBox.Controls.Add(this.observacaotextBox);
            this.observacaogroupBox.Location = new System.Drawing.Point(15, 228);
            this.observacaogroupBox.Name = "observacaogroupBox";
            this.observacaogroupBox.Size = new System.Drawing.Size(655, 127);
            this.observacaogroupBox.TabIndex = 14;
            this.observacaogroupBox.TabStop = false;
            this.observacaogroupBox.Text = "Observação(300)";
            // 
            // observacaotextBox
            // 
            this.observacaotextBox.Location = new System.Drawing.Point(6, 19);
            this.observacaotextBox.Multiline = true;
            this.observacaotextBox.Name = "observacaotextBox";
            this.observacaotextBox.Size = new System.Drawing.Size(633, 103);
            this.observacaotextBox.TabIndex = 0;
            // 
            // CorcomboBox
            // 
            this.CorcomboBox.FormattingEnabled = true;
            this.CorcomboBox.Location = new System.Drawing.Point(358, 9);
            this.CorcomboBox.Name = "CorcomboBox";
            this.CorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CorcomboBox.TabIndex = 9;
            this.CorcomboBox.Tag = "*";
            // 
            // veiculoerrorProvider
            // 
            this.veiculoerrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.veiculoerrorProvider.ContainerControl = this;
            // 
            // VeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 367);
            this.Controls.Add(this.observacaogroupBox);
            this.Controls.Add(this.Limparbutton);
            this.Controls.Add(this.Gravarbutton);
            this.Controls.Add(this.CambiocomboBox);
            this.Controls.Add(this.ModelocomboBox);
            this.Controls.Add(this.CorcomboBox);
            this.Controls.Add(this.CombustivelcomboBox);
            this.Controls.Add(this.MarcacomboBox);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VeiculoForm";
            this.Text = "Cadastro de Veiculo";
            this.observacaogroupBox.ResumeLayout(false);
            this.observacaogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox anoTextBox;
        private System.Windows.Forms.ComboBox MarcacomboBox;
        private System.Windows.Forms.ComboBox ModelocomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CombustivelcomboBox;
        private System.Windows.Forms.ComboBox CambiocomboBox;
        private System.Windows.Forms.Button Gravarbutton;
        private System.Windows.Forms.Button Limparbutton;
        private System.Windows.Forms.GroupBox observacaogroupBox;
        private System.Windows.Forms.TextBox observacaotextBox;
        private System.Windows.Forms.ComboBox CorcomboBox;
        private System.Windows.Forms.ErrorProvider veiculoerrorProvider;
    }
}

