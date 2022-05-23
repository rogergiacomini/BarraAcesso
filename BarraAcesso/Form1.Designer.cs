namespace BarraAcesso
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
            this.btnSkype = new System.Windows.Forms.Button();
            this.btnWhats = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSkype
            // 
            this.btnSkype.Location = new System.Drawing.Point(24, 12);
            this.btnSkype.Name = "btnSkype";
            this.btnSkype.Size = new System.Drawing.Size(51, 41);
            this.btnSkype.TabIndex = 0;
            this.btnSkype.Text = "Skype";
            this.btnSkype.UseVisualStyleBackColor = true;
            this.btnSkype.Click += new System.EventHandler(this.btnSkype_Click);
            // 
            // btnWhats
            // 
            this.btnWhats.Location = new System.Drawing.Point(24, 59);
            this.btnWhats.Name = "btnWhats";
            this.btnWhats.Size = new System.Drawing.Size(51, 41);
            this.btnWhats.TabIndex = 1;
            this.btnWhats.Text = "WhatsApp";
            this.btnWhats.UseVisualStyleBackColor = true;
            this.btnWhats.Click += new System.EventHandler(this.btnWhats_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(76, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(109, 131);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWhats);
            this.Controls.Add(this.btnSkype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Acesso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSkype;
        private System.Windows.Forms.Button btnWhats;
        private System.Windows.Forms.Button button1;
    }
}

