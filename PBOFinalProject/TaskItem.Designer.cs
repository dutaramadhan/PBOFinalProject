namespace PBOFinalProject
{
    partial class TaskItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.activityText = new System.Windows.Forms.Label();
            this.placeText = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activityText
            // 
            this.activityText.AutoSize = true;
            this.activityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityText.Location = new System.Drawing.Point(3, 9);
            this.activityText.Name = "activityText";
            this.activityText.Size = new System.Drawing.Size(64, 25);
            this.activityText.TabIndex = 0;
            this.activityText.Text = "label1";
            // 
            // placeText
            // 
            this.placeText.AutoSize = true;
            this.placeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeText.Location = new System.Drawing.Point(188, 9);
            this.placeText.Name = "placeText";
            this.placeText.Size = new System.Drawing.Size(64, 25);
            this.placeText.TabIndex = 1;
            this.placeText.Text = "label1";
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.Location = new System.Drawing.Point(317, 9);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(64, 25);
            this.dateText.TabIndex = 2;
            this.dateText.Text = "label1";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText.Location = new System.Drawing.Point(449, 9);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(64, 25);
            this.timeText.TabIndex = 3;
            this.timeText.Text = "label1";
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.White;
            this.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(593, 6);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(70, 30);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(668, 6);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(36, 30);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "X";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // TaskItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.placeText);
            this.Controls.Add(this.activityText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaskItem";
            this.Size = new System.Drawing.Size(711, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activityText;
        private System.Windows.Forms.Label placeText;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
