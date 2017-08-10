namespace DesignPatternsExamples
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
            this.btnTestAmbientContext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestAmbientContext
            // 
            this.btnTestAmbientContext.Location = new System.Drawing.Point(12, 23);
            this.btnTestAmbientContext.Name = "btnTestAmbientContext";
            this.btnTestAmbientContext.Size = new System.Drawing.Size(163, 23);
            this.btnTestAmbientContext.TabIndex = 0;
            this.btnTestAmbientContext.Text = "Test ambient context";
            this.btnTestAmbientContext.UseVisualStyleBackColor = true;
            this.btnTestAmbientContext.Click += new System.EventHandler(this.btnTestAmbientContext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 433);
            this.Controls.Add(this.btnTestAmbientContext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestAmbientContext;
    }
}

