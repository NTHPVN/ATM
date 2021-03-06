namespace UI
{
    partial class ValidatePin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCheckMaPIN = new System.Windows.Forms.Label();
            this.lbLockCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(317, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập mã PIN của bạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(204, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "(Ấn ENTER để đồng ý, ấn CLEAR để nhập lại)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(307, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bạn nên che tay khi nhập mã PIN";
            // 
            // tbPIN
            // 
            this.tbPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPIN.Location = new System.Drawing.Point(475, 180);
            this.tbPIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPIN.MaxLength = 5;
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(131, 34);
            this.tbPIN.TabIndex = 1;
            this.tbPIN.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::UI.Properties.Resources.dongY;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(864, 316);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 54);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::UI.Properties.Resources.huyBo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(864, 391);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 54);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbCheckMaPIN
            // 
            this.lbCheckMaPIN.AutoSize = true;
            this.lbCheckMaPIN.BackColor = System.Drawing.Color.Transparent;
            this.lbCheckMaPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckMaPIN.ForeColor = System.Drawing.Color.Red;
            this.lbCheckMaPIN.Location = new System.Drawing.Point(345, 335);
            this.lbCheckMaPIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCheckMaPIN.Name = "lbCheckMaPIN";
            this.lbCheckMaPIN.Size = new System.Drawing.Size(377, 36);
            this.lbCheckMaPIN.TabIndex = 5;
            this.lbCheckMaPIN.Text = "Mã PIN của bạn chưa đúng";
            this.lbCheckMaPIN.Visible = false;
            // 
            // lbLockCard
            // 
            this.lbLockCard.AutoSize = true;
            this.lbLockCard.BackColor = System.Drawing.Color.Transparent;
            this.lbLockCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLockCard.ForeColor = System.Drawing.Color.Red;
            this.lbLockCard.Location = new System.Drawing.Point(365, 370);
            this.lbLockCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLockCard.Name = "lbLockCard";
            this.lbLockCard.Size = new System.Drawing.Size(326, 36);
            this.lbLockCard.TabIndex = 5;
            this.lbLockCard.Text = "Thẻ của bạn đã bị khóa";
            this.lbLockCard.Visible = false;
            // 
            // ValidatePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.default_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbLockCard);
            this.Controls.Add(this.lbCheckMaPIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ValidatePin";
            this.Size = new System.Drawing.Size(1081, 462);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCheckMaPIN;
        private System.Windows.Forms.Label lbLockCard;
    }
}
