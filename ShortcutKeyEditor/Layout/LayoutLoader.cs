using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShortcutKeyEditor.Layout
{
    /// <summary>
    /// レイアウトローダー
    /// </summary>
    class LayoutLoader
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private LayoutLoader()
        {

        }

        /// <summary>
        /// レイアウト設定ファイルを読み込み
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static LayoutParam Load(string fileName)
        {
            LayoutParam param = new LayoutParam();

            try
            {
                var xml = XDocument.Load(fileName);

                var layout = xml.Element(ElementNameLayout);
                var tabs = layout.Elements(ElementNameTab);

                param.Tabs = new List<LayoutParam.Tab>();
                foreach (var tab in tabs)
                {
                    var layoutTab = new LayoutParam.Tab();
                    layoutTab.Id = tab.Attribute(AttributeNameId)?.Value;
                    layoutTab.Label = tab.Attribute(AttributeNameLabel)?.Value;
                    layoutTab.KeySets = new List<LayoutParam.KeySet>();

                    var keysets = tab.Elements(ElementNameKeySet);
                    foreach (var keyset in keysets)
                    {
                        var layoutKeyset = new LayoutParam.KeySet();
                        layoutKeyset.Id = keyset.Attribute(AttributeNameId)?.Value;
                        layoutKeyset.Label = keyset.Attribute(AttributeNameLabel)?.Value;
                        layoutKeyset.KeyTexts = new List<string>(keyset.Value.Split(','));
                        layoutKeyset.Description = keyset.Attribute(AttributeNameDescription)?.Value;
                        layoutTab.KeySets.Add(layoutKeyset);
                    }
                    param.Tabs.Add(layoutTab);
                }
            }
            catch
            {
                return null;
            }

            return param;
        }

        /// <summary>
        /// 要素名：レイアウトルート
        /// </summary>
        private static readonly string ElementNameLayout = "layout";

        /// <summary>
        /// 要素名：タブ
        /// </summary>
        private static readonly string ElementNameTab = "tab";

        /// <summary>
        /// 要素名：キー情報
        /// </summary>
        private static readonly string ElementNameKeySet = "keyset";

        /// <summary>
        /// 属性名：ラベル
        /// </summary>
        private static readonly string AttributeNameLabel = "label";

        /// <summary>
        /// 属性名：名前
        /// </summary>
        private static readonly string AttributeNameId = "id";

        /// <summary>
        /// 属性名：説明
        /// </summary>
        private static readonly string AttributeNameDescription = "description";
    }
}
