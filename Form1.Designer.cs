namespace arayuz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            otobusidTb = new TextBox();
            firmaidTb = new TextBox();
            kapasiteTb = new TextBox();
            modelTb = new TextBox();
            buttonekle = new Button();
            buttonguncelle = new Button();
            buttonsil = new Button();
            buttonara = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // otobusidTb
            // 
            otobusidTb.Location = new Point(219, 51);
            otobusidTb.Name = "otobusidTb";
            otobusidTb.Size = new Size(125, 27);
            otobusidTb.TabIndex = 0;
            otobusidTb.Text = "otobus_id";
            // 
            // firmaidTb
            // 
            firmaidTb.Location = new Point(219, 84);
            firmaidTb.Name = "firmaidTb";
            firmaidTb.Size = new Size(125, 27);
            firmaidTb.TabIndex = 1;
            firmaidTb.Text = "firma_id";
            // 
            // kapasiteTb
            // 
            kapasiteTb.Location = new Point(219, 117);
            kapasiteTb.Name = "kapasiteTb";
            kapasiteTb.Size = new Size(125, 27);
            kapasiteTb.TabIndex = 2;
            kapasiteTb.Text = "kapasite";
            // 
            // modelTb
            // 
            modelTb.Location = new Point(219, 150);
            modelTb.Name = "modelTb";
            modelTb.Size = new Size(125, 27);
            modelTb.TabIndex = 3;
            modelTb.Text = "model";
            // 
            // buttonekle
            // 
            buttonekle.Location = new Point(548, 45);
            buttonekle.Name = "buttonekle";
            buttonekle.Size = new Size(94, 29);
            buttonekle.TabIndex = 6;
            buttonekle.Text = "ekle";
            buttonekle.UseVisualStyleBackColor = true;
            buttonekle.Click += buttonekle_Click;
            // 
            // buttonguncelle
            // 
            buttonguncelle.Location = new Point(548, 96);
            buttonguncelle.Name = "buttonguncelle";
            buttonguncelle.Size = new Size(94, 29);
            buttonguncelle.TabIndex = 7;
            buttonguncelle.Text = "guncelle";
            buttonguncelle.UseVisualStyleBackColor = true;
            buttonguncelle.Click += buttonguncelle_Click;
            // 
            // buttonsil
            // 
            buttonsil.Location = new Point(548, 147);
            buttonsil.Name = "buttonsil";
            buttonsil.Size = new Size(94, 29);
            buttonsil.TabIndex = 8;
            buttonsil.Text = "sil";
            buttonsil.UseVisualStyleBackColor = true;
            buttonsil.Click += buttonsil_Click;
            // 
            // buttonara
            // 
            buttonara.Location = new Point(548, 193);
            buttonara.Name = "buttonara";
            buttonara.Size = new Size(94, 29);
            buttonara.TabIndex = 9;
            buttonara.Text = "ara";
            buttonara.UseVisualStyleBackColor = true;
            buttonara.Click += buttonara_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 188);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 54);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 11;
            label1.Text = "otobus_id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 87);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 12;
            label2.Text = "firma_id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 120);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 13;
            label3.Text = "kapasite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 157);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 14;
            label4.Text = "model";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 469);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonara);
            Controls.Add(buttonsil);
            Controls.Add(buttonguncelle);
            Controls.Add(buttonekle);
            Controls.Add(modelTb);
            Controls.Add(kapasiteTb);
            Controls.Add(firmaidTb);
            Controls.Add(otobusidTb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox otobusidTb;
        private TextBox firmaidTb;
        private TextBox kapasiteTb;
        private TextBox modelTb;
        private Button buttonekle;
        private Button buttonguncelle;
        private Button buttonsil;
        private Button buttonara;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
