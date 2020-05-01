using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ShortcutKeyManager
{
    public class ShortcutKeyManager
    {
        /// <summary>
        /// 
        /// </summary>
        public class KeyParam
        {
            /// <summary>
            /// ショートカットキー文字列（"Ctrl+Z" のようなフォーマット）
            /// </summary>
            public List<string> KeyTexts { get; set; }

            /// <summary>
            /// 識別名
            /// </summary>
            public string Id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public List<Keys> Keys { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="keyParams"></param>
        /// <returns></returns>
        public static bool WriteSettings(string fileName, List<KeyParam> keyParams)
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create(fileName))
                {
                    writer.WriteStartElement(ElementNameShortcutkeys);

                    foreach (var keyParam in keyParams)
                    {
                        writer.WriteStartElement(ElementNameShortcutkey);
                        writer.WriteAttributeString(AttributeNameId, keyParam.Id);
                        foreach (var KeyText in keyParam.KeyTexts)
                        {
                            writer.WriteStartElement(ElementNameKey);
                            writer.WriteValue(KeyText);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, KeyParam> LoadSettings(string fileName)
        {
            var result = new Dictionary<string, KeyParam>();

            try
            {
                var xml = XDocument.Load(fileName);

                var root = xml.Element(ElementNameShortcutkeys);

                var shortcutKeys = root.Elements(ElementNameShortcutkey);
                foreach (var shortcutKey in shortcutKeys)
                {
                    var keyParam = new KeyParam();
                    keyParam.Id = shortcutKey.Attribute(AttributeNameId)?.Value;
                    keyParam.Keys = new List<Keys>();
                    keyParam.KeyTexts = new List<string>();

                    var keys = shortcutKey.Elements(ElementNameKey);
                    foreach (var key in keys)
                    {
                        keyParam.KeyTexts.Add(key.Value);
                        keyParam.Keys.Add(StringToKeys(key.Value));
                        result.Add(keyParam.Id, keyParam);
                    }     
                }
            }
            catch
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// 文字列のキーを Keys に変換
        /// （オプションキーも統合する）
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public static Keys StringToKeys(string stringKeys)
        {
            Keys result = Keys.None;
            foreach(var stringKey in stringKeys.Split(InputKeySeparator).Select(p => p.Trim()).ToList())
            {
                Keys key = Keys.None;
                if (Enum.TryParse(stringKey, out key))
                {
                    result = result | key;
                }
            }
            return result;
        }

        /// <summary>
        /// Keys を文字列に変換
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
            }

            if ((checkKey & Keys.Shift) == Keys.Shift)
            {
                if (keyText.Length > 0)
                {
                    keyText.Append(InputKeySeparator);
                }

                keyText.Append("Shift");
                checkKey &= ~Keys.Shift;
            }

            if ((checkKey & Keys.Alt) == Keys.Alt)
            {
                if (keyText.Length > 0)
                {
                    keyText.Append(InputKeySeparator);
                }

                keyText.Append("Alt");
                checkKey &= ~Keys.Alt;
            }

            if (checkKey != Keys.None)
            {
                if (!(checkKey == Keys.ControlKey || checkKey == Keys.ShiftKey || checkKey == Keys.Menu))
                {
                    if (keyText.Length > 0)
                    {
                        keyText.Append(InputKeySeparator);
                    }
                    keyText.Append(checkKey);
                }
            }

            return keyText.ToString();
        }

        /// <summary>
        /// 要素名：ショートカットキールート
        /// </summary>
        private static readonly string ElementNameShortcutkeys = "shortcutkeys";

        /// <summary>
        /// 要素名：ショートカットキー
        /// </summary>
        private static readonly string ElementNameShortcutkey = "shortcutkey";

        /// <summary>
        /// 要素名：キー
        /// </summary>
        private static readonly string ElementNameKey = "key";

        /// <summary>
        /// 属性名：名前
        /// </summary>
        private static readonly string AttributeNameId = "id";


        /// <summary>
        /// 入力されたキー表示のセパレータ
        /// </summary>
        private static char InputKeySeparator = '+';
    }
}
