
namespace ui_insert
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
            this.facturaTxt = new System.Windows.Forms.TextBox();
            this.condTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.montoTxt = new System.Windows.Forms.TextBox();
            this.facturaLbl = new System.Windows.Forms.Label();
            this.condLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.montoLbl = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.stsLbl = new System.Windows.Forms.Label();
            this.stsTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // facturaTxt
            // 
            this.facturaTxt.Location = new System.Drawing.Point(186, 32);
            this.facturaTxt.Name = "facturaTxt";
            this.facturaTxt.Size = new System.Drawing.Size(100, 22);
            this.facturaTxt.TabIndex = 0;
            // 
            // condTxt
            // 
            this.condTxt.Location = new System.Drawing.Point(186, 84);
            this.condTxt.Name = "condTxt";
            this.condTxt.Size = new System.Drawing.Size(100, 22);
            this.condTxt.TabIndex = 2;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(186, 139);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 22);
            this.idTxt.TabIndex = 3;
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(186, 187);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(100, 22);
            this.dateTxt.TabIndex = 4;
            // 
            // montoTxt
            // 
            this.montoTxt.Location = new System.Drawing.Point(186, 240);
            this.montoTxt.Name = "montoTxt";
            this.montoTxt.Size = new System.Drawing.Size(100, 22);
            this.montoTxt.TabIndex = 5;
            // 
            // facturaLbl
            // 
            this.facturaLbl.AutoSize = true;
            this.facturaLbl.Location = new System.Drawing.Point(72, 36);
            this.facturaLbl.Name = "facturaLbl";
            this.facturaLbl.Size = new System.Drawing.Size(56, 17);
            this.facturaLbl.TabIndex = 6;
            this.facturaLbl.Text = "Factura";
            // 
            // condLbl
            // 
            this.condLbl.AutoSize = true;
            this.condLbl.Location = new System.Drawing.Point(72, 87);
            this.condLbl.Name = "condLbl";
            this.condLbl.Size = new System.Drawing.Size(68, 17);
            this.condLbl.TabIndex = 7;
            this.condLbl.Text = "condicion";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(72, 139);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(49, 17);
            this.idLbl.TabIndex = 8;
            this.idLbl.Text = "cliente";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(72, 187);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(43, 17);
            this.dateLbl.TabIndex = 9;
            this.dateLbl.Text = "fecha";
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Location = new System.Drawing.Point(72, 240);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(47, 17);
            this.montoLbl.TabIndex = 10;
            this.montoLbl.Text = "monto";
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(75, 337);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(211, 23);
            this.regBtn.TabIndex = 11;
            this.regBtn.Text = "Registrar";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // stsLbl
            // 
            this.stsLbl.AutoSize = true;
            this.stsLbl.Location = new System.Drawing.Point(72, 278);
            this.stsLbl.Name = "stsLbl";
            this.stsLbl.Size = new System.Drawing.Size(51, 17);
            this.stsLbl.TabIndex = 12;
            this.stsLbl.Text = "estado";
            // 
            // stsTxt
            // 
            this.stsTxt.Location = new System.Drawing.Point(186, 278);
            this.stsTxt.Name = "stsTxt";
            this.stsTxt.Size = new System.Drawing.Size(100, 22);
            this.stsTxt.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.stsTxt);
            this.Controls.Add(this.stsLbl);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.condLbl);
            this.Controls.Add(this.facturaLbl);
            this.Controls.Add(this.montoTxt);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.condTxt);
            this.Controls.Add(this.facturaTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox facturaTxt;
        private System.Windows.Forms.TextBox condTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.TextBox montoTxt;
        private System.Windows.Forms.Label facturaLbl;
        private System.Windows.Forms.Label condLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Label stsLbl;
        private System.Windows.Forms.TextBox stsTxt;
    }
}

