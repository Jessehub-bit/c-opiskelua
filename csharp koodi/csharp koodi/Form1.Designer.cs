namespace csharp_koodi
{
    partial class form1
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
            this.nappi1 = new System.Windows.Forms.Button();
            this.tekstitahan = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tekstilaatikko = new System.Windows.Forms.TextBox();
            this.viesti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nappi1
            // 
            this.nappi1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nappi1.Location = new System.Drawing.Point(314, 309);
            this.nappi1.Name = "nappi1";
            this.nappi1.Size = new System.Drawing.Size(134, 48);
            this.nappi1.TabIndex = 0;
            this.nappi1.Text = "paina";
            this.nappi1.UseVisualStyleBackColor = false;
            this.nappi1.Click += new System.EventHandler(this.nappi1_Click);
            // 
            // tekstitahan
            // 
            this.tekstitahan.AutoSize = true;
            this.tekstitahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekstitahan.Location = new System.Drawing.Point(237, 101);
            this.tekstitahan.Name = "tekstitahan";
            this.tekstitahan.Size = new System.Drawing.Size(121, 20);
            this.tekstitahan.TabIndex = 1;
            this.tekstitahan.Text = "anna etunimesi:";
            this.tekstitahan.Visible = false;
            // 
            // tekstilaatikko
            // 
            this.tekstilaatikko.Location = new System.Drawing.Point(372, 101);
            this.tekstilaatikko.Name = "tekstilaatikko";
            this.tekstilaatikko.Size = new System.Drawing.Size(113, 20);
            this.tekstilaatikko.TabIndex = 2;
            // 
            // viesti
            // 
            this.viesti.AutoSize = true;
            this.viesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viesti.Location = new System.Drawing.Point(210, 162);
            this.viesti.Name = "viesti";
            this.viesti.Size = new System.Drawing.Size(148, 20);
            this.viesti.TabIndex = 3;
            this.viesti.Text = "tähän tulee vastaus";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 457);
            this.Controls.Add(this.viesti);
            this.Controls.Add(this.tekstilaatikko);
            this.Controls.Add(this.tekstitahan);
            this.Controls.Add(this.nappi1);
            this.Name = "form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.xxx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nappi1;
        private System.Windows.Forms.Label tekstitahan;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tekstilaatikko;
        private System.Windows.Forms.Label viesti;
    }
}

