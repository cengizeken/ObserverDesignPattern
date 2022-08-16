
namespace Aselsan.RadarDonanimTest.ObserverDesignPattern
{
    partial class AnaForm
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
            this.btnOlcumeBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOlcumeBasla
            // 
            this.btnOlcumeBasla.Location = new System.Drawing.Point(615, 348);
            this.btnOlcumeBasla.Name = "btnOlcumeBasla";
            this.btnOlcumeBasla.Size = new System.Drawing.Size(137, 28);
            this.btnOlcumeBasla.TabIndex = 0;
            this.btnOlcumeBasla.Text = "Ölçüme Başla";
            this.btnOlcumeBasla.UseVisualStyleBackColor = true;
            this.btnOlcumeBasla.Click += new System.EventHandler(this.btnOlcumeBasla_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOlcumeBasla);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOlcumeBasla;
    }
}

