namespace Client
{
    partial class Client
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStaticTitle = new System.Windows.Forms.Label();
            this.lblStaticMoneyTotal = new System.Windows.Forms.Label();
            this.lblInstanceTitle = new System.Windows.Forms.Label();
            this.lblInstanceMoneyTotal = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(54, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(46, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Client";
            // 
            // txtClientID
            // 
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.Location = new System.Drawing.Point(174, 9);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(79, 53);
            this.txtClientID.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(21, 234);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStaticTitle
            // 
            this.lblStaticTitle.AutoSize = true;
            this.lblStaticTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticTitle.Location = new System.Drawing.Point(32, 341);
            this.lblStaticTitle.Name = "lblStaticTitle";
            this.lblStaticTitle.Size = new System.Drawing.Size(209, 25);
            this.lblStaticTitle.TabIndex = 4;
            this.lblStaticTitle.Text = "Static Money Pot Total";
            // 
            // lblStaticMoneyTotal
            // 
            this.lblStaticMoneyTotal.AutoSize = true;
            this.lblStaticMoneyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticMoneyTotal.Location = new System.Drawing.Point(116, 381);
            this.lblStaticMoneyTotal.Name = "lblStaticMoneyTotal";
            this.lblStaticMoneyTotal.Size = new System.Drawing.Size(49, 36);
            this.lblStaticMoneyTotal.TabIndex = 5;
            this.lblStaticMoneyTotal.Text = "$0";
            // 
            // lblInstanceTitle
            // 
            this.lblInstanceTitle.AutoSize = true;
            this.lblInstanceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstanceTitle.Location = new System.Drawing.Point(32, 431);
            this.lblInstanceTitle.Name = "lblInstanceTitle";
            this.lblInstanceTitle.Size = new System.Drawing.Size(234, 25);
            this.lblInstanceTitle.TabIndex = 6;
            this.lblInstanceTitle.Text = "Instance Money Pot Total";
            // 
            // lblInstanceMoneyTotal
            // 
            this.lblInstanceMoneyTotal.AutoSize = true;
            this.lblInstanceMoneyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstanceMoneyTotal.Location = new System.Drawing.Point(116, 469);
            this.lblInstanceMoneyTotal.Name = "lblInstanceMoneyTotal";
            this.lblInstanceMoneyTotal.Size = new System.Drawing.Size(49, 36);
            this.lblInstanceMoneyTotal.TabIndex = 7;
            this.lblInstanceMoneyTotal.Text = "$0";
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.Blue;
            this.lblCountDown.Location = new System.Drawing.Point(16, 300);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(135, 25);
            this.lblCountDown.TabIndex = 8;
            this.lblCountDown.Text = "X seconds left";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(155, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(295, 528);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.lblInstanceMoneyTotal);
            this.Controls.Add(this.lblInstanceTitle);
            this.Controls.Add(this.lblStaticMoneyTotal);
            this.Controls.Add(this.lblStaticTitle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStaticTitle;
        private System.Windows.Forms.Label lblStaticMoneyTotal;
        private System.Windows.Forms.Label lblInstanceTitle;
        private System.Windows.Forms.Label lblInstanceMoneyTotal;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Button btnCancel;
    }
}

