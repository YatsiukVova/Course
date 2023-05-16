namespace Course
{
    partial class FormFilter
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
            this.gbRating = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRatingMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRatingMax = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbRating.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRating
            // 
            this.gbRating.Controls.Add(this.tbRatingMax);
            this.gbRating.Controls.Add(this.label2);
            this.gbRating.Controls.Add(this.tbRatingMin);
            this.gbRating.Controls.Add(this.label1);
            this.gbRating.Location = new System.Drawing.Point(53, 36);
            this.gbRating.Name = "gbRating";
            this.gbRating.Size = new System.Drawing.Size(339, 145);
            this.gbRating.TabIndex = 0;
            this.gbRating.TabStop = false;
            this.gbRating.Text = "Рейтинг";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(53, 223);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Від ";
            // 
            // tbRatingMin
            // 
            this.tbRatingMin.Location = new System.Drawing.Point(47, 58);
            this.tbRatingMin.Name = "tbRatingMin";
            this.tbRatingMin.Size = new System.Drawing.Size(77, 27);
            this.tbRatingMin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "До";
            // 
            // tbRatingMax
            // 
            this.tbRatingMax.Location = new System.Drawing.Point(192, 58);
            this.tbRatingMax.Name = "tbRatingMax";
            this.tbRatingMax.Size = new System.Drawing.Size(88, 27);
            this.tbRatingMax.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbRating);
            this.Name = "FormFilter";
            this.Text = "Фільтр";
            this.gbRating.ResumeLayout(false);
            this.gbRating.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbRating;
        private Button btnOk;
        private TextBox tbRatingMax;
        private Label label2;
        private TextBox tbRatingMin;
        private Label label1;
        private Button btnCancel;
    }
}