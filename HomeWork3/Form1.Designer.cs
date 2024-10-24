namespace HomeWork3
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.attacker = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.lambda = new System.Windows.Forms.TextBox();
            this.attackerLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.lambdaLabel = new System.Windows.Forms.Label();
            this.simulationStart = new System.Windows.Forms.Button();
            this.graphBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // attacker
            // 
            this.attacker.Location = new System.Drawing.Point(30, 43);
            this.attacker.Name = "attacker";
            this.attacker.Size = new System.Drawing.Size(139, 20);
            this.attacker.TabIndex = 2;
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(199, 43);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(139, 20);
            this.server.TabIndex = 3;
            // 
            // lambda
            // 
            this.lambda.Location = new System.Drawing.Point(367, 43);
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(131, 20);
            this.lambda.TabIndex = 4;
            // 
            // attackerLabel
            // 
            this.attackerLabel.AutoSize = true;
            this.attackerLabel.Location = new System.Drawing.Point(27, 27);
            this.attackerLabel.Name = "attackerLabel";
            this.attackerLabel.Size = new System.Drawing.Size(103, 13);
            this.attackerLabel.TabIndex = 6;
            this.attackerLabel.Text = "Number of attackers";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(196, 27);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(93, 13);
            this.serverLabel.TabIndex = 7;
            this.serverLabel.Text = "Number of servers";
            // 
            // lambdaLabel
            // 
            this.lambdaLabel.AutoSize = true;
            this.lambdaLabel.Location = new System.Drawing.Point(364, 27);
            this.lambdaLabel.Name = "lambdaLabel";
            this.lambdaLabel.Size = new System.Drawing.Size(83, 13);
            this.lambdaLabel.TabIndex = 8;
            this.lambdaLabel.Text = "Value of lambda";
            // 
            // simulationStart
            // 
            this.simulationStart.Location = new System.Drawing.Point(885, 40);
            this.simulationStart.Name = "simulationStart";
            this.simulationStart.Size = new System.Drawing.Size(75, 23);
            this.simulationStart.TabIndex = 10;
            this.simulationStart.Text = "Start";
            this.simulationStart.UseVisualStyleBackColor = true;
            this.simulationStart.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // graphBox
            // 
            this.graphBox.Location = new System.Drawing.Point(30, 69);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(930, 421);
            this.graphBox.TabIndex = 11;
            this.graphBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 503);
            this.Controls.Add(this.graphBox);
            this.Controls.Add(this.simulationStart);
            this.Controls.Add(this.lambdaLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.attackerLabel);
            this.Controls.Add(this.lambda);
            this.Controls.Add(this.server);
            this.Controls.Add(this.attacker);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox attacker;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox lambda;
        private System.Windows.Forms.Label attackerLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label lambdaLabel;
        private System.Windows.Forms.Button simulationStart;
        private System.Windows.Forms.PictureBox graphBox;
    }
}

