namespace sommaStack
{
    partial class frmSommaStack
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
            this.btnSomma = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTotale = new System.Windows.Forms.Label();
            this.lstStack = new System.Windows.Forms.ListView();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(12, 40);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(75, 23);
            this.btnSomma.TabIndex = 0;
            this.btnSomma.Text = "SOMMA";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(261, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Location = new System.Drawing.Point(9, 422);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(60, 16);
            this.lblTotale.TabIndex = 3;
            this.lblTotale.Text = "TOTALE";
            // 
            // lstStack
            // 
            this.lstStack.FullRowSelect = true;
            this.lstStack.GridLines = true;
            this.lstStack.HideSelection = false;
            this.lstStack.LabelWrap = false;
            this.lstStack.Location = new System.Drawing.Point(279, 12);
            this.lstStack.Name = "lstStack";
            this.lstStack.Size = new System.Drawing.Size(267, 426);
            this.lstStack.TabIndex = 4;
            this.lstStack.UseCompatibleStateImageBehavior = false;
            this.lstStack.View = System.Windows.Forms.View.List;
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(180, 40);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(93, 23);
            this.btnIndietro.TabIndex = 5;
            this.btnIndietro.Text = "INDIETRO";
            this.btnIndietro.UseVisualStyleBackColor = true;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // frmSommaStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.lstStack);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnSomma);
            this.Name = "frmSommaStack";
            this.Text = "SOMMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.ListView lstStack;
        private System.Windows.Forms.Button btnIndietro;
    }
}

