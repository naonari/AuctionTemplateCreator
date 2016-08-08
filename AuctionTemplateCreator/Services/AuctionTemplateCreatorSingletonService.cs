using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AuctionTemplateCreator.Services
{
    public class AuctionTemplateCreatorSingletonService
    {
        // 単一のインスタンス。
        public static AuctionTemplateCreatorSingletonService _singleton = new AuctionTemplateCreatorSingletonService();

        /// <summary>
        /// 単一のインスタンスを取得します。
        /// </summary>
        /// <returns>単一のインスタンスを返します。</returns>
        public static AuctionTemplateCreatorSingletonService GetInstance()
        {
            return _singleton;
        }

        /// <summary>
        /// コンストラクタ定義。
        /// </summary>
        private AuctionTemplateCreatorSingletonService()
        {
            // アセンブリを取得。
            var asm = Assembly.GetExecutingAssembly();

            // アセンブリ名を取得します。
            var assemblyName = Path.GetFileNameWithoutExtension(this.GetType().Assembly.Location);

            // リソースファイルのパスを取得します。
            var resourcesPath = assemblyName + ".Resources.template.txt";

            // リソースファイル読み込み用のストリームリーダーをインスタンス化します。
            using (var sr = new StreamReader(asm.GetManifestResourceStream(resourcesPath), Encoding.GetEncoding("shift-jis")))
            {
                // リソースファイルを読み込みます。
                this._templateString = sr.ReadToEnd();

                //ストリームリーダーを閉じます。
                sr.Close();
            }
        }

        // 改行タグの文字列。
        private static readonly string NEWLINE_TAG = "<br>";

        // タイトルの置換文字列。
        private static readonly string REPLACED_TITLE = "{%title%}";

        // 商品説明の置換文字列。
        private static readonly string REPLACED_DESCRIPTION = "{%description%}";

        // 商品説明の置換文字列。
        private static readonly string REPLACED_CAUTION = "{%caution%}";
        
        // 商品説明の置換文字列。
        private static readonly string REPLACED_SEND = "{%send%}";

        // オークションのテンプレート文字列。
        private string _templateString;

        /// <summary>
        /// オークションのテンプレートをクリップボードに設定します。
        /// </summary>
        /// <param name="description">商品説明。</param>
        /// <param name="caution">注意事項。</param>
        /// <param name="send">発送方法。</param>
        public string GetTemplate(string title, string description, string caution, string send)
        {
            // 改行コードをタグに置換します。
            var descriptionStr = description.Replace(Environment.NewLine, NEWLINE_TAG);

            // 改行コードをタグに置換します。
            var cautionStr = caution.Replace(Environment.NewLine, NEWLINE_TAG);
            
            // 改行コードをタグに置換します。
            var sendStr = send.Replace(Environment.NewLine, NEWLINE_TAG);

            // テンプレートを取得します。
            var result = this._templateString.Replace(REPLACED_TITLE, descriptionStr).Replace(REPLACED_DESCRIPTION, descriptionStr).Replace(REPLACED_CAUTION, cautionStr).Replace(REPLACED_SEND, sendStr);

            return result;
        }
    }
}
