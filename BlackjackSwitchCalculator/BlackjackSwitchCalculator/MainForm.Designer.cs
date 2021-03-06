
namespace BlackjackSwitchCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtHand1Card1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHand1Card2 = new System.Windows.Forms.TextBox();
            this.txtHand2Card1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHand2Card2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDealerUpCard = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStrategy = new System.Windows.Forms.TextBox();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtHand1Card1
            // 
            this.txtHand1Card1.Location = new System.Drawing.Point(68, 38);
            this.txtHand1Card1.Name = "txtHand1Card1";
            this.txtHand1Card1.Size = new System.Drawing.Size(73, 20);
            this.txtHand1Card1.TabIndex = 0;
            this.txtHand1Card1.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "1st Card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dealer:";
            // 
            // txtHand1Card2
            // 
            this.txtHand1Card2.Location = new System.Drawing.Point(68, 64);
            this.txtHand1Card2.Name = "txtHand1Card2";
            this.txtHand1Card2.Size = new System.Drawing.Size(73, 20);
            this.txtHand1Card2.TabIndex = 3;
            this.txtHand1Card2.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtHand2Card1
            // 
            this.txtHand2Card1.Location = new System.Drawing.Point(206, 38);
            this.txtHand2Card1.Name = "txtHand2Card1";
            this.txtHand2Card1.Size = new System.Drawing.Size(73, 20);
            this.txtHand2Card1.TabIndex = 1;
            this.txtHand2Card1.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2nd Card:";
            // 
            // txtHand2Card2
            // 
            this.txtHand2Card2.Location = new System.Drawing.Point(206, 64);
            this.txtHand2Card2.Name = "txtHand2Card2";
            this.txtHand2Card2.Size = new System.Drawing.Size(73, 20);
            this.txtHand2Card2.TabIndex = 4;
            this.txtHand2Card2.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "4th Card:";
            // 
            // txtDealerUpCard
            // 
            this.txtDealerUpCard.Location = new System.Drawing.Point(68, 12);
            this.txtDealerUpCard.Name = "txtDealerUpCard";
            this.txtDealerUpCard.Size = new System.Drawing.Size(73, 20);
            this.txtDealerUpCard.TabIndex = 2;
            this.txtDealerUpCard.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "3rd Card:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(68, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Strategy:";
            // 
            // txtStrategy
            // 
            this.txtStrategy.Location = new System.Drawing.Point(68, 90);
            this.txtStrategy.Name = "txtStrategy";
            this.txtStrategy.ReadOnly = true;
            this.txtStrategy.Size = new System.Drawing.Size(73, 20);
            this.txtStrategy.TabIndex = 5;
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Location = new System.Drawing.Point(68, 145);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(68, 17);
            this.chkTopMost.TabIndex = 9;
            this.chkTopMost.Text = "TopMost";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 171);
            this.Controls.Add(this.chkTopMost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStrategy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDealerUpCard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHand2Card1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHand1Card1);
            this.Controls.Add(this.txtHand2Card2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHand1Card2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack Switch Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHand1Card1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHand1Card2;
        private System.Windows.Forms.TextBox txtHand2Card1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHand2Card2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDealerUpCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStrategy;
        private System.Windows.Forms.CheckBox chkTopMost;
    }
}

