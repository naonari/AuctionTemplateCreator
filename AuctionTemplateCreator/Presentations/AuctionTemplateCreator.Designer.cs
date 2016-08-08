namespace AuctionTemplateCreator.Presentations
{
    partial class AuctionTemplateCreator
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuctionTemplateCreator));
            this.pnlScreen = new NexFx.Controls.ExPanel();
            this.txtTitle = new NexFx.Controls.ExTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExecute = new NexFx.Controls.ExButton();
            this.txtSend = new NexFx.Controls.ExTextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.txtCaution = new NexFx.Controls.ExTextBox();
            this.lblCaution = new System.Windows.Forms.Label();
            this.txtDescription = new NexFx.Controls.ExTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreen.Controls.Add(this.txtTitle);
            this.pnlScreen.Controls.Add(this.lblTitle);
            this.pnlScreen.Controls.Add(this.btnExecute);
            this.pnlScreen.Controls.Add(this.txtSend);
            this.pnlScreen.Controls.Add(this.lblSend);
            this.pnlScreen.Controls.Add(this.txtCaution);
            this.pnlScreen.Controls.Add(this.lblCaution);
            this.pnlScreen.Controls.Add(this.txtDescription);
            this.pnlScreen.Controls.Add(this.lblDescription);
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(583, 512);
            this.pnlScreen.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.CaptionControl = this.lblTitle;
            this.txtTitle.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtTitle.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTitle.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTitle.Location = new System.Drawing.Point(15, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTitle.Size = new System.Drawing.Size(556, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "タイトル";
            // 
            // btnExecute
            // 
            this.btnExecute.CaptionControl = null;
            this.btnExecute.FocusedBackColor = System.Drawing.SystemColors.Control;
            this.btnExecute.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExecute.Location = new System.Drawing.Point(15, 470);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(556, 30);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "作成";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtSend
            // 
            this.txtSend.AcceptsReturn = true;
            this.txtSend.CaptionControl = this.lblSend;
            this.txtSend.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtSend.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSend.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSend.Location = new System.Drawing.Point(15, 378);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSend.Size = new System.Drawing.Size(556, 80);
            this.txtSend.TabIndex = 7;
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSend.Location = new System.Drawing.Point(12, 358);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(60, 17);
            this.lblSend.TabIndex = 6;
            this.lblSend.Text = "発送方法";
            // 
            // txtCaution
            // 
            this.txtCaution.AcceptsReturn = true;
            this.txtCaution.CaptionControl = this.lblCaution;
            this.txtCaution.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtCaution.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCaution.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCaution.Location = new System.Drawing.Point(15, 260);
            this.txtCaution.Multiline = true;
            this.txtCaution.Name = "txtCaution";
            this.txtCaution.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCaution.Size = new System.Drawing.Size(556, 80);
            this.txtCaution.TabIndex = 5;
            // 
            // lblCaution
            // 
            this.lblCaution.AutoSize = true;
            this.lblCaution.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCaution.Location = new System.Drawing.Point(12, 240);
            this.lblCaution.Name = "lblCaution";
            this.lblCaution.Size = new System.Drawing.Size(60, 17);
            this.lblCaution.TabIndex = 4;
            this.lblCaution.Text = "注意事項";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.CaptionControl = this.lblDescription;
            this.txtDescription.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtDescription.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescription.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDescription.Location = new System.Drawing.Point(15, 91);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(556, 133);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDescription.Location = new System.Drawing.Point(12, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "商品説明";
            // 
            // AuctionTemplateCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(583, 512);
            this.Controls.Add(this.pnlScreen);
            this.EnableEnterTransition = false;
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.GradationColor1 = System.Drawing.Color.Ivory;
            this.GradationColor2 = System.Drawing.Color.LightPink;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AuctionTemplateCreator";
            this.Text = "AuctionTemplateCreator";
            this.Load += new System.EventHandler(this.AuctionTemplateCreator_Load);
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NexFx.Controls.ExPanel pnlScreen;
        private NexFx.Controls.ExTextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private NexFx.Controls.ExButton btnExecute;
        private NexFx.Controls.ExTextBox txtSend;
        private System.Windows.Forms.Label lblSend;
        private NexFx.Controls.ExTextBox txtCaution;
        private System.Windows.Forms.Label lblCaution;
        private NexFx.Controls.ExTextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}
