
namespace prevody
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_hex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_bin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hexadecimální:";
            // 
            // textBox_hex
            // 
            this.textBox_hex.Location = new System.Drawing.Point(125, 77);
            this.textBox_hex.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex.Name = "textBox_hex";
            this.textBox_hex.Size = new System.Drawing.Size(132, 22);
            this.textBox_hex.TabIndex = 11;
            this.textBox_hex.TextChanged += new System.EventHandler(this.textBox_hex_TextChanged);
            this.textBox_hex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Binární:";
            // 
            // textBox_bin
            // 
            this.textBox_bin.Location = new System.Drawing.Point(125, 45);
            this.textBox_bin.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_bin.Name = "textBox_bin";
            this.textBox_bin.Size = new System.Drawing.Size(132, 22);
            this.textBox_bin.TabIndex = 10;
            this.textBox_bin.TextChanged += new System.EventHandler(this.textBox_bin_TextChanged);
            this.textBox_bin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_bin_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dekadická:";
            // 
            // textBox_dec
            // 
            this.textBox_dec.Location = new System.Drawing.Point(125, 13);
            this.textBox_dec.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dec.Name = "textBox_dec";
            this.textBox_dec.Size = new System.Drawing.Size(132, 22);
            this.textBox_dec.TabIndex = 8;
            this.textBox_dec.TextChanged += new System.EventHandler(this.textBox_dec_TextChanged_1);
            this.textBox_dec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_dec_KeyPress_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 109);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_hex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_bin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_dec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Převody";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_hex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_bin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dec;
    }
}

