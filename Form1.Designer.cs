
namespace PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.staticCountdownLabel = new System.Windows.Forms.Label();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderSize = 4;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Poor Richard", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(151, 43);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(244, 105);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Play Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // staticCountdownLabel
            // 
            this.staticCountdownLabel.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticCountdownLabel.ForeColor = System.Drawing.Color.White;
            this.staticCountdownLabel.Location = new System.Drawing.Point(92, 208);
            this.staticCountdownLabel.Name = "staticCountdownLabel";
            this.staticCountdownLabel.Size = new System.Drawing.Size(255, 66);
            this.staticCountdownLabel.TabIndex = 1;
            this.staticCountdownLabel.Text = "Game Starting in:";
            this.staticCountdownLabel.Visible = false;
            // 
            // countdownLabel
            // 
            this.countdownLabel.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.Color.White;
            this.countdownLabel.Location = new System.Drawing.Point(345, 208);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(189, 43);
            this.countdownLabel.TabIndex = 2;
            this.countdownLabel.Text = "3";
            this.countdownLabel.Visible = false;
            // 
            // goLabel
            // 
            this.goLabel.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.Color.Red;
            this.goLabel.Location = new System.Drawing.Point(210, 329);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(173, 69);
            this.goLabel.TabIndex = 3;
            this.goLabel.Text = "Go!!!";
            this.goLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(563, 485);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.staticCountdownLabel);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label staticCountdownLabel;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Label goLabel;
    }
}

