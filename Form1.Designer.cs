namespace GPACalculator1
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
            txtGPA = new TextBox();
            lblAverage = new Label();
            btnAddGPA = new Button();
            lblMaxGPA = new Label();
            lblMinGPA = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(156, 62);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(100, 23);
            txtGPA.TabIndex = 0;
            txtGPA.TextChanged += txtGPA_TextChanged;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(20, 29);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(57, 15);
            lblAverage.TabIndex = 1;
            lblAverage.Text = "เฉลี่ย GPA:";
            // 
            // btnAddGPA
            // 
            btnAddGPA.Location = new Point(262, 62);
            btnAddGPA.Name = "btnAddGPA";
            btnAddGPA.Size = new Size(103, 23);
            btnAddGPA.TabIndex = 2;
            btnAddGPA.Text = "Add";
            btnAddGPA.UseVisualStyleBackColor = true;
            btnAddGPA.Click += btnAddGPA_Click;
            // 
            // lblMaxGPA
            // 
            lblMaxGPA.AutoSize = true;
            lblMaxGPA.Location = new Point(20, 54);
            lblMaxGPA.Name = "lblMaxGPA";
            lblMaxGPA.Size = new Size(59, 15);
            lblMaxGPA.TabIndex = 3;
            lblMaxGPA.Text = "สูงสุด GPA:";
            // 
            // lblMinGPA
            // 
            lblMinGPA.AutoSize = true;
            lblMinGPA.Location = new Point(20, 82);
            lblMinGPA.Name = "lblMinGPA";
            lblMinGPA.Size = new Size(60, 15);
            lblMinGPA.TabIndex = 4;
            lblMinGPA.Text = "ต่ำสุด GPA:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAverage);
            groupBox1.Controls.Add(lblMaxGPA);
            groupBox1.Controls.Add(lblMinGPA);
            groupBox1.Location = new Point(134, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 112);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 65);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 7;
            label5.Text = "ใส่คะเเนน";
            label5.Click += label5_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(180, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 391);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(btnAddGPA);
            Controls.Add(txtGPA);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGPA;
        private Label lblAverage;
        private Button btnAddGPA;
        private Label lblMaxGPA;
        private Label lblMinGPA;
        private GroupBox groupBox1;
        private Label label5;
        private Button btnClear;
    }
}
