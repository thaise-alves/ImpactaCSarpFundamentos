﻿namespace CSharpFundamentos.Capitulo03.Troco
{
    partial class TrocoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocoForm));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.valorPagotextBox = new System.Windows.Forms.TextBox();
            this.trocotextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moedasimageList = new System.Windows.Forms.ImageList(this.components);
            this.moedaslistView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.calcularButton);
            this.groupBox1.Controls.Add(this.trocotextBox);
            this.groupBox1.Controls.Add(this.valorPagotextBox);
            this.groupBox1.Controls.Add(this.valorCompraTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da &Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor &pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Troco";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.Location = new System.Drawing.Point(97, 13);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(144, 20);
            this.valorCompraTextBox.TabIndex = 1;
            // 
            // valorPagotextBox
            // 
            this.valorPagotextBox.Location = new System.Drawing.Point(97, 48);
            this.valorPagotextBox.Name = "valorPagotextBox";
            this.valorPagotextBox.Size = new System.Drawing.Size(144, 20);
            this.valorPagotextBox.TabIndex = 3;
            // 
            // trocotextBox
            // 
            this.trocotextBox.Location = new System.Drawing.Point(97, 83);
            this.trocotextBox.Name = "trocotextBox";
            this.trocotextBox.ReadOnly = true;
            this.trocotextBox.Size = new System.Drawing.Size(144, 20);
            this.trocotextBox.TabIndex = 5;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(97, 124);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(140, 22);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "C&alcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.moedaslistView);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Troco";
            // 
            // moedasimageList
            // 
            this.moedasimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moedasimageList.ImageStream")));
            this.moedasimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.moedasimageList.Images.SetKeyName(0, "1.png");
            this.moedasimageList.Images.SetKeyName(1, "5.png");
            this.moedasimageList.Images.SetKeyName(2, "10.png");
            this.moedasimageList.Images.SetKeyName(3, "25.png");
            this.moedasimageList.Images.SetKeyName(4, "50.png");
            this.moedasimageList.Images.SetKeyName(5, "100.png");
            // 
            // moedaslistView
            // 
            this.moedaslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moedaslistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.moedaslistView.LargeImageList = this.moedasimageList;
            this.moedaslistView.Location = new System.Drawing.Point(3, 16);
            this.moedaslistView.Name = "moedaslistView";
            this.moedaslistView.Size = new System.Drawing.Size(585, 422);
            this.moedaslistView.TabIndex = 2;
            this.moedaslistView.UseCompatibleStateImageBehavior = false;
            // 
            // TrocoForm
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrocoForm";
            this.Text = "Troco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox trocotextBox;
        private System.Windows.Forms.TextBox valorPagotextBox;
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView moedaslistView;
        private System.Windows.Forms.ImageList moedasimageList;
    }
}

