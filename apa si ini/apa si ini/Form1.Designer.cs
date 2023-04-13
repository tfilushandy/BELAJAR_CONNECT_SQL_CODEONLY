namespace apa_si_ini
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
            this.dgv_pemain = new System.Windows.Forms.DataGridView();
            this.lbltext = new System.Windows.Forms.Label();
            this.combobox_nationality = new System.Windows.Forms.ComboBox();
            this.comboboxteam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pemain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pemain
            // 
            this.dgv_pemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pemain.Location = new System.Drawing.Point(13, 140);
            this.dgv_pemain.Name = "dgv_pemain";
            this.dgv_pemain.Size = new System.Drawing.Size(775, 256);
            this.dgv_pemain.TabIndex = 0;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(12, 66);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(35, 13);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "label1";
            // 
            // combobox_nationality
            // 
            this.combobox_nationality.FormattingEnabled = true;
            this.combobox_nationality.Location = new System.Drawing.Point(13, 32);
            this.combobox_nationality.Name = "combobox_nationality";
            this.combobox_nationality.Size = new System.Drawing.Size(121, 21);
            this.combobox_nationality.TabIndex = 2;
            this.combobox_nationality.SelectedValueChanged += new System.EventHandler(this.combobox_nationality_SelectedValueChanged);
            // 
            // comboboxteam
            // 
            this.comboboxteam.FormattingEnabled = true;
            this.comboboxteam.Location = new System.Drawing.Point(627, 32);
            this.comboboxteam.Name = "comboboxteam";
            this.comboboxteam.Size = new System.Drawing.Size(161, 21);
            this.comboboxteam.TabIndex = 3;
            this.comboboxteam.SelectedValueChanged += new System.EventHandler(this.comboboxteam_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboboxteam);
            this.Controls.Add(this.combobox_nationality);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.dgv_pemain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pemain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pemain;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.ComboBox combobox_nationality;
        private System.Windows.Forms.ComboBox comboboxteam;
    }
}

