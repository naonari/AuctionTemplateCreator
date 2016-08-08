using System;
using System.Windows.Forms;
using NexFx.Controls;
using AuctionTemplateCreator.Resources;
using AuctionTemplateCreator.Services;

namespace AuctionTemplateCreator.Presentations
{
    public partial class AuctionTemplateCreator : ExForm
    {
        /// <summary>
        /// コンストラクタ定義。
        /// </summary>
        public AuctionTemplateCreator()
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
            this.txtTitle.Clear();
            this.txtDescription.Clear();
            this.txtCaution.Clear();
            this.txtSend.Clear();

            // 初期フォーカスを設定します。
            this.txtTitle.Focus();
        }

        /// <summary>
        /// 作成ボタン押下時の処理を行います。
        /// </summary>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            // タイトルが未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtTitle.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "タイトル");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 商品説明が未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtDescription.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "商品説明");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 注意事項が未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtDescription.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "注意事項");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 発送方法が未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtDescription.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "発送方法");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // サービスを取得します。
            var atcss = AuctionTemplateCreatorSingletonService.GetInstance();

            // テンプレートを取得します。
            var template = atcss.GetTemplate(this.txtTitle.Text, this.txtDescription.Text, this.txtCaution.Text, this.txtSend.Text);

            // Viewerをインスタンス化します。
            var viewer = new AuctionTemplateViewer();

            // Viewerに値を設定します。
            viewer.Title = this.txtTitle.Text;
            viewer.Description = template;

            // Viewerを表示します。
            viewer.Show(this);
        }
    }
}
