
namespace Memory_Game_RoMeRo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            statusLabel = new Label();
            GameTImer = new System.Windows.Forms.Timer(components);
            txtCountDown = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(215, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(215, 67);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(38, 15);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "status";
            // 
            // GameTImer
            // 
            GameTImer.Enabled = true;
            GameTImer.Interval = 1000;
            GameTImer.Tick += TimerEvent;
            // 
            // txtCountDown
            // 
            txtCountDown.AutoSize = true;
            txtCountDown.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCountDown.Location = new Point(215, 126);
            txtCountDown.Name = "txtCountDown";
            txtCountDown.Size = new Size(113, 21);
            txtCountDown.TabIndex = 1;
            txtCountDown.Text = "Timer Left: 30";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 344);
            Controls.Add(txtCountDown);
            Controls.Add(statusLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Memory Matching Game by RoMeRo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer GameTImer;
        private System.Windows.Forms.Label txtCountDown;
    }
}

