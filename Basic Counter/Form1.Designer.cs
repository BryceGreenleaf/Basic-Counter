namespace Basic_Counter
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Subtract = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(77, 133);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(129, 70);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Subtract
            // 
            this.btn_Subtract.Location = new System.Drawing.Point(263, 133);
            this.btn_Subtract.Name = "btn_Subtract";
            this.btn_Subtract.Size = new System.Drawing.Size(129, 70);
            this.btn_Subtract.TabIndex = 2;
            this.btn_Subtract.Text = "Subtract";
            this.btn_Subtract.UseVisualStyleBackColor = true;
            this.btn_Subtract.Click += new System.EventHandler(this.btn_Subtract_Click);
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.SystemColors.Control;
            this.results.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.results.Location = new System.Drawing.Point(115, 70);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(236, 39);
            this.results.TabIndex = 3;
            this.results.Text = "0";
            this.results.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Counter";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(173, 209);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 70);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 326);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.results);
            this.Controls.Add(this.btn_Subtract);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form1";
            this.Text = "Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Subtract;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Clear;
    }
}

