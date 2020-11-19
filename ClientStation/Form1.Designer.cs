namespace ClientStation
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
            this.btnGetServerVersion = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnGetModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetServerVersion
            // 
            this.btnGetServerVersion.Location = new System.Drawing.Point(12, 12);
            this.btnGetServerVersion.Name = "btnGetServerVersion";
            this.btnGetServerVersion.Size = new System.Drawing.Size(183, 42);
            this.btnGetServerVersion.TabIndex = 0;
            this.btnGetServerVersion.Text = "Get Server Version";
            this.btnGetServerVersion.UseVisualStyleBackColor = true;
            this.btnGetServerVersion.Click += new System.EventHandler(this.btnGetServerVersion_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(12, 60);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(776, 378);
            this.tbxOutput.TabIndex = 1;
            // 
            // btnGetModel
            // 
            this.btnGetModel.Location = new System.Drawing.Point(201, 12);
            this.btnGetModel.Name = "btnGetModel";
            this.btnGetModel.Size = new System.Drawing.Size(183, 42);
            this.btnGetModel.TabIndex = 2;
            this.btnGetModel.Text = "Get Model";
            this.btnGetModel.UseVisualStyleBackColor = true;
            this.btnGetModel.Click += new System.EventHandler(this.btnGetModel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetModel);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnGetServerVersion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetServerVersion;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnGetModel;
    }
}

