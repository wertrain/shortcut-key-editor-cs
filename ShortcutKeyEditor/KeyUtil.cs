using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortcutKeyEditor
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyUtil
    {
        /// <summary>
        /// Keys を文字列に変換する
        /// （オプションキーも統合されている前提）
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string KeysToString(Keys key)
        {
            var keyText = new StringBuilder();
            var checkKey = key;

            if ((checkKey & Keys.Control) == Keys.Control)
            {
                keyText.Append("Ctrl");
                checkKey &= ~Keys.Control;
                checkKey &= ~Keys.ControlKey;
            }

            if ((checkKey & Keys.Shift) == Keys.Shift)
            {
                if (keyText.Length > 0)
                {
                    keyText.Append(InputKeySeparator);
                }

                keyText.Append("Shift");
                checkKey &= ~Keys.Shift;
                checkKey &= ~Keys.ShiftKey;
            }

            if ((checkKey & Keys.Alt) == Keys.Alt)
            {
                if (keyText.Length > 0)
                {
                    keyText.Append(InputKeySeparator);
                }

                keyText.Append("Alt");
                checkKey &= ~Keys.Alt;
                checkKey &= ~Keys.Menu;
            }

            if (checkKey != Keys.None)
            {
                if (keyText.Length > 0)
                {
                    keyText.Append(InputKeySeparator);
                }
                keyText.Append(checkKey);
            }

            return keyText.ToString();
        }

        /// <summary>
        /// 入力されたキー表示のセパレータ
        /// </summary>
        private static string InputKeySeparator = "+";
    }
}
