using System;
using System.Windows.Forms;
using NexFx.Controls;
using AuctionTemplateCreator.Resources;

namespace AuctionTemplateCreator.Presentations
{
    public partial class AuctionTemplateViewer : ExForm
    {
        /// <summary>タイトルを設定・取得します。</summary>
        public string Title { get; set; }

        /// <summary>本文を設定・取得します。</summary>
        public string Description { get; set; }

        /// <summary>
        /// コンストラクタ定義。
        /// </summary>
        public AuctionTemplateViewer()
        {
            // 初期設定を行います。
            InitializeComponent();
        }

        /// <summary>
        /// 画面読込時の処理を行います。
        /// </summary>
        private void AuctionTemplateCreator_Load(object sender, EventArgs e)
        {
            // 初期化処理を行います。
            this.AuctionTemplateCreator_Initialize();
        }

        /// <summary>
        /// 初期化処理を行います。
        /// </summary>
        private void AuctionTemplateCreator_Initialize()
        {
            // 各コントローラを初期化します。
            this.txtTitle.Text = this.Title;
            this.txtDescription.Text = this.Description;
        }

        /// <summary>
        /// タイトルコピーボタン押下時の処理を行います。
        /// </summary>
        private void btnTitleCopry_Click(object sender, EventArgs e)
        {
            // クリップボードに設定します。
            Clipboard.SetDataObject(this.txtTitle.Text, true);

            // メッセージを表示します。
            MessageBox.Show(Messages.N0001, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 本文コピーボタン押下時の処理を行います。
        /// </summary>
        private void btnDescriptionCopy_Click(object sender, EventArgs e)
        {
            // クリップボードに設定します。
            Clipboard.SetDataObject(this.txtDescription.Text, true);

            // メッセージを表示します。
            MessageBox.Show(Messages.N0001, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
