namespace Agenda
{
    partial class AgendaSemanal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaSemanal));
            this.btnSeg = new System.Windows.Forms.Button();
            this.btnTer = new System.Windows.Forms.Button();
            this.btnQuart = new System.Windows.Forms.Button();
            this.btnQuint = new System.Windows.Forms.Button();
            this.btnSab = new System.Windows.Forms.Button();
            this.btnSex = new System.Windows.Forms.Button();
            this.btnDom = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeg
            // 
            this.btnSeg.BackColor = System.Drawing.Color.White;
            this.btnSeg.Location = new System.Drawing.Point(16, 77);
            this.btnSeg.Name = "btnSeg";
            this.btnSeg.Size = new System.Drawing.Size(110, 23);
            this.btnSeg.TabIndex = 0;
            this.btnSeg.Text = "Segunda-feira";
            this.btnSeg.UseVisualStyleBackColor = false;
            this.btnSeg.Click += new System.EventHandler(this.btnSeg_Click);
            // 
            // btnTer
            // 
            this.btnTer.BackColor = System.Drawing.Color.White;
            this.btnTer.Location = new System.Drawing.Point(132, 77);
            this.btnTer.Name = "btnTer";
            this.btnTer.Size = new System.Drawing.Size(110, 23);
            this.btnTer.TabIndex = 1;
            this.btnTer.Text = "Terça-feira";
            this.btnTer.UseVisualStyleBackColor = false;
            this.btnTer.Click += new System.EventHandler(this.btnTer_Click);
            // 
            // btnQuart
            // 
            this.btnQuart.BackColor = System.Drawing.Color.White;
            this.btnQuart.Location = new System.Drawing.Point(248, 77);
            this.btnQuart.Name = "btnQuart";
            this.btnQuart.Size = new System.Drawing.Size(110, 23);
            this.btnQuart.TabIndex = 2;
            this.btnQuart.Text = "Quarta-feira";
            this.btnQuart.UseVisualStyleBackColor = false;
            this.btnQuart.Click += new System.EventHandler(this.btnQuart_Click);
            // 
            // btnQuint
            // 
            this.btnQuint.BackColor = System.Drawing.Color.White;
            this.btnQuint.Location = new System.Drawing.Point(364, 77);
            this.btnQuint.Name = "btnQuint";
            this.btnQuint.Size = new System.Drawing.Size(110, 23);
            this.btnQuint.TabIndex = 3;
            this.btnQuint.Text = "Quinta-feira";
            this.btnQuint.UseVisualStyleBackColor = false;
            this.btnQuint.Click += new System.EventHandler(this.btnQuint_Click);
            // 
            // btnSab
            // 
            this.btnSab.BackColor = System.Drawing.Color.White;
            this.btnSab.Location = new System.Drawing.Point(596, 77);
            this.btnSab.Name = "btnSab";
            this.btnSab.Size = new System.Drawing.Size(110, 23);
            this.btnSab.TabIndex = 4;
            this.btnSab.Text = "Sábado";
            this.btnSab.UseVisualStyleBackColor = false;
            this.btnSab.Click += new System.EventHandler(this.btnSab_Click);
            // 
            // btnSex
            // 
            this.btnSex.BackColor = System.Drawing.Color.White;
            this.btnSex.Location = new System.Drawing.Point(480, 77);
            this.btnSex.Name = "btnSex";
            this.btnSex.Size = new System.Drawing.Size(110, 23);
            this.btnSex.TabIndex = 5;
            this.btnSex.Text = "Sexta-feira";
            this.btnSex.UseVisualStyleBackColor = false;
            this.btnSex.Click += new System.EventHandler(this.btnSex_Click);
            // 
            // btnDom
            // 
            this.btnDom.BackColor = System.Drawing.Color.White;
            this.btnDom.Location = new System.Drawing.Point(712, 77);
            this.btnDom.Name = "btnDom";
            this.btnDom.Size = new System.Drawing.Size(110, 23);
            this.btnDom.TabIndex = 6;
            this.btnDom.Text = "Domingo";
            this.btnDom.UseVisualStyleBackColor = false;
            this.btnDom.Click += new System.EventHandler(this.btnDom_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(788, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(34, 30);
            this.btnSair.TabIndex = 7;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.Location = new System.Drawing.Point(77, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dias da Semana";
            // 
            // AgendaSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agenda.Properties.Resources.agenda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(833, 548);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDom);
            this.Controls.Add(this.btnSex);
            this.Controls.Add(this.btnSab);
            this.Controls.Add(this.btnQuint);
            this.Controls.Add(this.btnQuart);
            this.Controls.Add(this.btnTer);
            this.Controls.Add(this.btnSeg);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgendaSemanal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeg;
        private System.Windows.Forms.Button btnTer;
        private System.Windows.Forms.Button btnQuart;
        private System.Windows.Forms.Button btnQuint;
        private System.Windows.Forms.Button btnSab;
        private System.Windows.Forms.Button btnSex;
        private System.Windows.Forms.Button btnDom;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
    }
}