
namespace Tp_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pump1 = new Tp_1.pump();
            this.ticket1 = new Tp_1.ticket();
            this.choices1 = new Tp_1.choices();
            this.numPad1 = new Tp_1.numPad();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "         EN SERVICE \r\nINSEREZ VOTRE CARTE";
            // 
            // pump1
            // 
            this.pump1.Location = new System.Drawing.Point(186, 39);
            this.pump1.Name = "pump1";
            this.pump1.Size = new System.Drawing.Size(602, 329);
            this.pump1.TabIndex = 4;
            // 
            // ticket1
            // 
            this.ticket1.Location = new System.Drawing.Point(247, 83);
            this.ticket1.Name = "ticket1";
            this.ticket1.Size = new System.Drawing.Size(304, 265);
            this.ticket1.TabIndex = 3;
            this.ticket1.Load += new System.EventHandler(this.ticket1_Load);
            // 
            // choices1
            // 
            this.choices1.Location = new System.Drawing.Point(247, 39);
            this.choices1.Name = "choices1";
            this.choices1.Size = new System.Drawing.Size(321, 334);
            this.choices1.TabIndex = 1;
            this.choices1.Load += new System.EventHandler(this.choices1_Load);
            // 
            // numPad1
            // 
            this.numPad1.Location = new System.Drawing.Point(258, 121);
            this.numPad1.Name = "numPad1";
            this.numPad1.Size = new System.Drawing.Size(276, 218);
            this.numPad1.TabIndex = 2;
            this.numPad1.Load += new System.EventHandler(this.numPad1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pump1);
            this.Controls.Add(this.ticket1);
            this.Controls.Add(this.choices1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPad1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private numPad numPad1;
        private System.Windows.Forms.Label label1;
        private choices choices1;
        private ticket ticket1;
        private pump pump1;
    }
}

