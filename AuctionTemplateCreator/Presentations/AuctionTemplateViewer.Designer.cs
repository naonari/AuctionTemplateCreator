namespace AuctionTemplateCreator.Presentations
{
    partial class AuctionTemplateViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuctionTemplateViewer));
            this.pnlScreen = new NexFx.Controls.ExPanel();
            this.btnDescriptionCopy = new NexFx.Controls.ExButton();
            this.btnTitleCopry = new NexFx.Controls.ExButton();
            this.txtTitle = new NexFx.Controls.ExTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDescription = new NexFx.Controls.ExTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlScreen.Controls.Add(this.btnDescriptionCopy);
            this.pnlScreen.Controls.Add(this.btnTitleCopry);
            this.pnlScreen.Controls.Add(this.txtTitle);
            this.pnlScreen.Controls.Add(this.lblTitle);
            this.pnlScreen.Controls.Add(this.txtDescription);
            this.pnlScreen.Controls.Add(this.lblDescription);
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(583, 512);
            this.pnlScreen.TabIndex = 0;
            // 
            // btnDescriptionCopy
            // 
            this.btnDescriptionCopy.CaptionControl = null;
            this.btnDescriptionCopy.FocusedBackColor = System.Drawing.SystemColors.Control;
            this.btnDescriptionCopy.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDescriptionCopy.Location = new System.Drawing.Point(15, 71);
            this.btnDescriptionCopy.Name = "btnDescriptionCopy";
            this.btnDescriptionCopy.Size = new System.Drawing.Size(23, 23);
            this.btnDescriptionCopy.TabIndex = 9;
            this.btnDescriptionCopy.UseVisualStyleBackColor = true;
            this.btnDescriptionCopy.Click += new System.EventHandler(this.btnDescriptionCopy_Click);
            // 
            // btnTitleCopry
            // 
            this.btnTitleCopry.CaptionControl = null;
            this.btnTitleCopry.FocusedBackColor = System.Drawing.SystemColors.Control;
            this.btnTitleCopry.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTitleCopry.Location = new System.Drawing.Point(15, 16);
            this.btnTitleCopry.Name = "btnTitleCopry";
            this.btnTitleCopry.Size = new System.Drawing.Size(23, 23);
            this.btnTitleCopry.TabIndex = 9;
            this.btnTitleCopry.UseVisualStyleBackColor = true;
            this.btnTitleCopry.Click += new System.EventHandler(this.btnTitleCopry_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AcceptsReturn = true;
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.CaptionControl = this.lblTitle;
            this.txtTitle.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtTitle.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTitle.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTitle.Location = new System.Drawing.Point(15, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTitle.Size = new System.Drawing.Size(556, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(43, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "タイトル";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.CaptionControl = this.lblDescription;
            this.txtDescription.FocusedBackColor = System.Drawing.Color.LightYellow;
            this.txtDescription.FocusedForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescription.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDescription.Location = new System.Drawing.Point(15, 99);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(556, 382);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDescription.Location = new System.Drawing.Point(44, 74);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(34, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "本文";
            // 
            // AuctionTemplateViewer
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
            this.Name = "AuctionTemplateViewer";
            this.Text = "Viewer";
            this.Load += new System.EventHandler(this.AuctionTemplateCreator_Load);
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NexFx.Controls.ExPanel pnlScreen;
        private NexFx.Controls.ExTextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private NexFx.Controls.ExTextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private NexFx.Controls.ExButton btnDescriptionCopy;
        private NexFx.Controls.ExButton btnTitleCopry;
    }
}
