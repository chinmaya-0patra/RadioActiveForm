namespace RadioActiveForm
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
            label1 = new Label();
            btech = new RadioButton();
            be = new RadioButton();
            bca = new RadioButton();
            mca = new RadioButton();
            others = new RadioButton();
            female = new RadioButton();
            male = new RadioButton();
            btnSubmit = new Button();
            gQual = new GroupBox();
            gGender = new GroupBox();
            gQual.SuspendLayout();
            gGender.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 64);
            label1.Name = "label1";
            label1.Size = new Size(399, 40);
            label1.TabIndex = 0;
            label1.Text = "Fill up all the details given below";
            // 
            // btech
            // 
            btech.AutoSize = true;
            btech.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btech.Location = new Point(173, 18);
            btech.Name = "btech";
            btech.Size = new Size(76, 24);
            btech.TabIndex = 1;
            btech.TabStop = true;
            btech.Text = "B.Tech";
            btech.UseVisualStyleBackColor = true;
            // 
            // be
            // 
            be.AutoSize = true;
            be.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            be.Location = new Point(173, 66);
            be.Name = "be";
            be.Size = new Size(48, 24);
            be.TabIndex = 3;
            be.TabStop = true;
            be.Text = "BE";
            be.UseVisualStyleBackColor = true;
            // 
            // bca
            // 
            bca.AutoSize = true;
            bca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bca.Location = new Point(173, 111);
            bca.Name = "bca";
            bca.Size = new Size(60, 24);
            bca.TabIndex = 4;
            bca.TabStop = true;
            bca.Text = "BCA";
            bca.UseVisualStyleBackColor = true;
            // 
            // mca
            // 
            mca.AutoSize = true;
            mca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mca.Location = new Point(173, 156);
            mca.Name = "mca";
            mca.Size = new Size(64, 24);
            mca.TabIndex = 5;
            mca.TabStop = true;
            mca.Text = "MCA";
            mca.UseVisualStyleBackColor = true;
            // 
            // others
            // 
            others.AutoSize = true;
            others.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            others.Location = new Point(173, 134);
            others.Name = "others";
            others.Size = new Size(77, 24);
            others.TabIndex = 9;
            others.TabStop = true;
            others.Text = "Others";
            others.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            female.Location = new Point(173, 89);
            female.Name = "female";
            female.Size = new Size(80, 24);
            female.TabIndex = 8;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            male.Location = new Point(173, 41);
            male.Name = "male";
            male.Size = new Size(64, 24);
            male.TabIndex = 7;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(438, 588);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gQual
            // 
            gQual.Controls.Add(btech);
            gQual.Controls.Add(be);
            gQual.Controls.Add(bca);
            gQual.Controls.Add(mca);
            gQual.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gQual.Location = new Point(279, 148);
            gQual.Name = "gQual";
            gQual.Size = new Size(402, 192);
            gQual.TabIndex = 11;
            gQual.TabStop = false;
            gQual.Text = "Qualifications :";
            // 
            // gGender
            // 
            gGender.Controls.Add(female);
            gGender.Controls.Add(male);
            gGender.Controls.Add(others);
            gGender.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gGender.Location = new Point(279, 361);
            gGender.Name = "gGender";
            gGender.Size = new Size(402, 192);
            gGender.TabIndex = 12;
            gGender.TabStop = false;
            gGender.Text = "Gender :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 652);
            Controls.Add(gGender);
            Controls.Add(gQual);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            gQual.ResumeLayout(false);
            gQual.PerformLayout();
            gGender.ResumeLayout(false);
            gGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton btech;
        private RadioButton be;
        private RadioButton bca;
        private RadioButton mca;
        private RadioButton others;
        private RadioButton female;
        private RadioButton male;
        private Button btnSubmit;
        private GroupBox gQual;
        private GroupBox gGender;
    }
}
