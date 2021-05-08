namespace StrongholdFinder
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
            this.x1input = new System.Windows.Forms.TextBox();
            this.a2input = new System.Windows.Forms.TextBox();
            this.z2input = new System.Windows.Forms.TextBox();
            this.x2input = new System.Windows.Forms.TextBox();
            this.a1input = new System.Windows.Forms.TextBox();
            this.z1input = new System.Windows.Forms.TextBox();
            this.x1label = new System.Windows.Forms.Label();
            this.angle1label = new System.Windows.Forms.Label();
            this.z1label = new System.Windows.Forms.Label();
            this.angle2label = new System.Windows.Forms.Label();
            this.z2label = new System.Windows.Forms.Label();
            this.x2label = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.coordinateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x1input
            // 
            this.x1input.Location = new System.Drawing.Point(89, 74);
            this.x1input.Name = "x1input";
            this.x1input.Size = new System.Drawing.Size(51, 20);
            this.x1input.TabIndex = 0;
            // 
            // a2input
            // 
            this.a2input.Location = new System.Drawing.Point(293, 169);
            this.a2input.Name = "a2input";
            this.a2input.Size = new System.Drawing.Size(51, 20);
            this.a2input.TabIndex = 1;
            // 
            // z2input
            // 
            this.z2input.Location = new System.Drawing.Point(194, 166);
            this.z2input.Name = "z2input";
            this.z2input.Size = new System.Drawing.Size(51, 20);
            this.z2input.TabIndex = 2;
            // 
            // x2input
            // 
            this.x2input.Location = new System.Drawing.Point(89, 166);
            this.x2input.Name = "x2input";
            this.x2input.Size = new System.Drawing.Size(51, 20);
            this.x2input.TabIndex = 3;
            // 
            // a1input
            // 
            this.a1input.Location = new System.Drawing.Point(293, 74);
            this.a1input.Name = "a1input";
            this.a1input.Size = new System.Drawing.Size(51, 20);
            this.a1input.TabIndex = 4;
            // 
            // z1input
            // 
            this.z1input.Location = new System.Drawing.Point(194, 74);
            this.z1input.Name = "z1input";
            this.z1input.Size = new System.Drawing.Size(51, 20);
            this.z1input.TabIndex = 5;
            // 
            // x1label
            // 
            this.x1label.AutoSize = true;
            this.x1label.Location = new System.Drawing.Point(48, 77);
            this.x1label.Name = "x1label";
            this.x1label.Size = new System.Drawing.Size(23, 13);
            this.x1label.TabIndex = 6;
            this.x1label.Text = "X1:";
            // 
            // angle1label
            // 
            this.angle1label.AutoSize = true;
            this.angle1label.Location = new System.Drawing.Point(252, 81);
            this.angle1label.Name = "angle1label";
            this.angle1label.Size = new System.Drawing.Size(36, 13);
            this.angle1label.TabIndex = 7;
            this.angle1label.Text = "angle:";
            // 
            // z1label
            // 
            this.z1label.AutoSize = true;
            this.z1label.Location = new System.Drawing.Point(153, 77);
            this.z1label.Name = "z1label";
            this.z1label.Size = new System.Drawing.Size(23, 13);
            this.z1label.TabIndex = 8;
            this.z1label.Text = "Z1:";
            // 
            // angle2label
            // 
            this.angle2label.AutoSize = true;
            this.angle2label.Location = new System.Drawing.Point(252, 173);
            this.angle2label.Name = "angle2label";
            this.angle2label.Size = new System.Drawing.Size(36, 13);
            this.angle2label.TabIndex = 9;
            this.angle2label.Text = "angle:";
            // 
            // z2label
            // 
            this.z2label.AutoSize = true;
            this.z2label.Location = new System.Drawing.Point(153, 169);
            this.z2label.Name = "z2label";
            this.z2label.Size = new System.Drawing.Size(23, 13);
            this.z2label.TabIndex = 10;
            this.z2label.Text = "Z2:";
            // 
            // x2label
            // 
            this.x2label.AutoSize = true;
            this.x2label.Location = new System.Drawing.Point(48, 173);
            this.x2label.Name = "x2label";
            this.x2label.Size = new System.Drawing.Size(23, 13);
            this.x2label.TabIndex = 11;
            this.x2label.Text = "X2:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(170, 272);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(119, 321);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 13);
            this.answerLabel.TabIndex = 13;
            // 
            // coordinateLabel
            // 
            this.coordinateLabel.AutoSize = true;
            this.coordinateLabel.Location = new System.Drawing.Point(119, 379);
            this.coordinateLabel.Name = "coordinateLabel";
            this.coordinateLabel.Size = new System.Drawing.Size(0, 13);
            this.coordinateLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 442);
            this.Controls.Add(this.coordinateLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.x2label);
            this.Controls.Add(this.z2label);
            this.Controls.Add(this.angle2label);
            this.Controls.Add(this.z1label);
            this.Controls.Add(this.angle1label);
            this.Controls.Add(this.x1label);
            this.Controls.Add(this.z1input);
            this.Controls.Add(this.a1input);
            this.Controls.Add(this.x2input);
            this.Controls.Add(this.z2input);
            this.Controls.Add(this.a2input);
            this.Controls.Add(this.x1input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1input;
        private System.Windows.Forms.TextBox a2input;
        private System.Windows.Forms.TextBox z2input;
        private System.Windows.Forms.TextBox x2input;
        private System.Windows.Forms.TextBox a1input;
        private System.Windows.Forms.TextBox z1input;
        private System.Windows.Forms.Label x1label;
        private System.Windows.Forms.Label angle1label;
        private System.Windows.Forms.Label z1label;
        private System.Windows.Forms.Label angle2label;
        private System.Windows.Forms.Label z2label;
        private System.Windows.Forms.Label x2label;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label coordinateLabel;
    }
}

