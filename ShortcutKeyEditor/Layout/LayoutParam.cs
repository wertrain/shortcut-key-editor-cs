using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortcutKeyEditor.Layout
{
    /// <summary>
    /// レイアウトパラメータ
    /// </summary>
    class LayoutParam
    {
        /// <summary>
        /// タブのリスト
        /// </summary>
        public List<Tab> Tabs { get; set; }

        /// <summary>
        /// 所属キーのリスト
        /// </summary>
        public List<KeySet> KeySets { get; set; }

        /// <summary>
        /// タブ
        /// </summary>
        public class Tab
        {
            /// <summary>
            /// 識別名
            /// </summary>
            public string Id { get; set; }

            /// <summary>
            /// ラベル
            /// </summary>
            public string Label { get; set; }

            /// <summary>
            /// 割り当てるキーのリスト
            /// </summary>
            public List<KeySet> KeySets { get; set; }
        }

        /// <summary>
        /// 割り当てるキー
        /// </summary>
        public class KeySet
        {
            /// <summary>
            /// 識別名
            /// </summary>
            public string Id { get; set; }
            
            /// <summary>
            /// ラベル
            /// </summary>
            public string Label { get; set; }

            /// <summary>
            /// キー表示テキスト
            /// </summary>
            public List<string> KeyTexts { get; set; }
        }
    }
}
