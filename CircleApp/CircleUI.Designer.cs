namespace CircleApp
{
    partial class CircleUI
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
            this.areaButton = new System.Windows.Forms.Button();
            this.perimetreButton = new System.Windows.Forms.Button();
            this.diametreButton = new System.Windows.Forms.Button();
            this.reslutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // areaButton
            // 
            this.areaButton.Location = new System.Drawing.Point(207, 109);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(70, 25);
            this.areaButton.TabIndex = 13;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // perimetreButton
            // 
            this.perimetreButton.Location = new System.Drawing.Point(126, 109);
            this.perimetreButton.Name = "perimetreButton";
            this.perimetreButton.Size = new System.Drawing.Size(70, 25);
            this.perimetreButton.TabIndex = 12;
            this.perimetreButton.Text = "Perimetre";
            this.perimetreButton.UseVisualStyleBackColor = true;
            this.perimetreButton.Click += new System.EventHandler(this.perimetreButton_Click);
            // 
            // diametreButton
            // 
            this.diametreButton.Location = new System.Drawing.Point(45, 109);
            this.diametreButton.Name = "diametreButton";
            this.diametreButton.Size = new System.Drawing.Size(70, 25);
            this.diametreButton.TabIndex = 11;
            this.diametreButton.Text = "Diametre";
            this.diametreButton.UseVisualStyleBackColor = true;
            this.diametreButton.Click += new System.EventHandler(this.diametreButton_Click);
            // 
            // reslutLabel
            // 
            this.reslutLabel.AutoSize = true;
            this.reslutLabel.Location = new System.Drawing.Point(71, 72);
            this.reslutLabel.Name = "reslutLabel";
            this.reslutLabel.Size = new System.Drawing.Size(37, 13);
            this.reslutLabel.TabIndex = 10;
            this.reslutLabel.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Radius";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(138, 69);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(191, 20);
            this.resultTextBox.TabIndex = 8;
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(138, 29);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(191, 20);
            this.radiusTextBox.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(288, 109);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(70, 25);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // CircleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 153);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.perimetreButton);
            this.Controls.Add(this.diametreButton);
            this.Controls.Add(this.reslutLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.radiusTextBox);
            this.Name = "CircleUI";
            this.Text = "CircleUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button perimetreButton;
        private System.Windows.Forms.Button diametreButton;
        private System.Windows.Forms.Label reslutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button clearButton;
    }
}

