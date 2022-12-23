namespace PBOFinalProject
{
    partial class EditPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.EditActivityBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditDateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EditTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EditPlaceBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masukan Nama Kegiatan";
            // 
            // EditActivityBox
            // 
            this.EditActivityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditActivityBox.Location = new System.Drawing.Point(127, 69);
            this.EditActivityBox.Name = "EditActivityBox";
            this.EditActivityBox.Size = new System.Drawing.Size(561, 30);
            this.EditActivityBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Masukan Tanggal Kegiatan";
            // 
            // EditDateBox
            // 
            this.EditDateBox.Location = new System.Drawing.Point(127, 135);
            this.EditDateBox.Name = "EditDateBox";
            this.EditDateBox.Size = new System.Drawing.Size(208, 22);
            this.EditDateBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Masukan Waktu/Jam Kegiatan";
            // 
            // EditTimeBox
            // 
            this.EditTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EditTimeBox.Location = new System.Drawing.Point(130, 193);
            this.EditTimeBox.Name = "EditTimeBox";
            this.EditTimeBox.Size = new System.Drawing.Size(208, 22);
            this.EditTimeBox.TabIndex = 12;
            this.EditTimeBox.Value = new System.DateTime(2022, 12, 16, 18, 52, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Masukan Tempat Kegiatan";
            // 
            // EditPlaceBox
            // 
            this.EditPlaceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPlaceBox.Location = new System.Drawing.Point(127, 261);
            this.EditPlaceBox.Name = "EditPlaceBox";
            this.EditPlaceBox.Size = new System.Drawing.Size(561, 30);
            this.EditPlaceBox.TabIndex = 14;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(307, 318);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(169, 50);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(30, 393);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(133, 45);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Kembali";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.backButton);
            // 
            // EditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.EditPlaceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditTimeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditDateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditActivityBox);
            this.Controls.Add(this.label1);
            this.Name = "EditPage";
            this.Text = "EditPage";
            this.Load += new System.EventHandler(this.EditPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditActivityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker EditDateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EditTimeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EditPlaceBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button BackButton;
    }
}