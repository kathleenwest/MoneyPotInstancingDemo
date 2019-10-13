namespace MoneyServerHost
{
    partial class Main
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lblStaticFunds = new System.Windows.Forms.Label();
            this.lstTransactions = new System.Windows.Forms.ListView();
            this.LogMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInstanceFunds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoneyServerHost.Properties.Resources.moneypot;
            this.pictureBox1.Location = new System.Drawing.Point(151, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(91, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(318, 46);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "The Money Pot";
            // 
            // lblStaticFunds
            // 
            this.lblStaticFunds.AutoSize = true;
            this.lblStaticFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticFunds.ForeColor = System.Drawing.Color.Green;
            this.lblStaticFunds.Location = new System.Drawing.Point(22, 192);
            this.lblStaticFunds.Name = "lblStaticFunds";
            this.lblStaticFunds.Size = new System.Drawing.Size(238, 37);
            this.lblStaticFunds.TabIndex = 2;
            this.lblStaticFunds.Text = "S:$100,000.00";
            // 
            // lstTransactions
            // 
            this.lstTransactions.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lstTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LogMessage});
            this.lstTransactions.FullRowSelect = true;
            this.lstTransactions.HideSelection = false;
            this.lstTransactions.Location = new System.Drawing.Point(11, 241);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(461, 148);
            this.lstTransactions.TabIndex = 3;
            this.lstTransactions.UseCompatibleStateImageBehavior = false;
            this.lstTransactions.View = System.Windows.Forms.View.Details;
            // 
            // LogMessage
            // 
            this.LogMessage.Text = "Log Messages";
            this.LogMessage.Width = 300;
            // 
            // lblInstanceFunds
            // 
            this.lblInstanceFunds.AutoSize = true;
            this.lblInstanceFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstanceFunds.ForeColor = System.Drawing.Color.Green;
            this.lblInstanceFunds.Location = new System.Drawing.Point(285, 192);
            this.lblInstanceFunds.Name = "lblInstanceFunds";
            this.lblInstanceFunds.Size = new System.Drawing.Size(187, 37);
            this.lblInstanceFunds.TabIndex = 4;
            this.lblInstanceFunds.Text = "I:$1,000.00";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(484, 402);
            this.Controls.Add(this.lblInstanceFunds);
            this.Controls.Add(this.lstTransactions);
            this.Controls.Add(this.lblStaticFunds);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Money Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblStaticFunds;
        private System.Windows.Forms.ListView lstTransactions;
        private System.Windows.Forms.ColumnHeader LogMessage;
        private System.Windows.Forms.Label lblInstanceFunds;
    }
}

