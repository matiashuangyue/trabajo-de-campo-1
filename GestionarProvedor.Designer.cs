namespace trabajo_de_campo_1
{
    partial class GestionarProvedor
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
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBack.Location = new System.Drawing.Point(807, 323);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(240, 47);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Volver A Pantalla Principal";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GestionarProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trabajo_de_campo_1.Properties.Resources.clouds_bubble_pop_art_y8iuv5agjzzczq9v;
            this.ClientSize = new System.Drawing.Size(1200, 480);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Headline R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionarProvedor";
            this.Text = "GestionarProvedor";
            this.Load += new System.EventHandler(this.GestionarProvedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
    }
}