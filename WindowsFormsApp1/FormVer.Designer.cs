namespace WindowsFormsApp1
{
    partial class FormVer
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
            this.LBresultado = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBresultado
            // 
            this.LBresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBresultado.FormattingEnabled = true;
            this.LBresultado.ItemHeight = 24;
            this.LBresultado.Location = new System.Drawing.Point(177, 201);
            this.LBresultado.Name = "LBresultado";
            this.LBresultado.Size = new System.Drawing.Size(158, 100);
            this.LBresultado.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(445, 254);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 47);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.LBresultado);
            this.Name = "FormVer";
            this.Text = "FormVer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OK;
        public System.Windows.Forms.ListBox LBresultado;
    }
}