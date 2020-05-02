# Keyboard Shortcuts Editor

generic shortcut editing form.

![Screenshot](https://raw.githubusercontent.com/wertrain/shortcut-key-editor-cs/master/screenshot.png)

## Editor layout file (example)

```xml
<?xml version="1.0" encoding="utf-8"?>
<layout>
  <tab label="基本操作" id="basic">
    <keyset label="元に戻す" id="undo" description="一つ元に戻します">Ctrl+Z</keyset>
    <keyset label="やり直し" id="redo">Ctrl+Y</keyset>
    <keyset label="すべて選択" id="select_all">Ctrl+A</keyset>
    <keyset label="コピー" id="copy">Ctrl+C</keyset>
    <keyset label="切り取る" id="cut">Ctrl+X</keyset>
    <keyset label="クリップボードの履歴" id="clipboard">LWin+V</keyset>
    <keyset label="ファイルを保存" id="save">Ctrl+S</keyset>
    <keyset label="ファイルを開く" id="open">Ctrl+o</keyset>
  </tab>
  <tab label="ファイルとフォルダ" id="file_and_folder">
    <keyset label="すべて選択" id="select_all">Ctrl+A</keyset>
    <keyset label="コピー" id="copy">Ctrl+C</keyset>
    <keyset label="移動" id="move">Ctrl+X</keyset>
  </tab>
</layout>
```

## Output settings file (example)

```xml
<?xml version="1.0" encoding="utf-8"?>
<shortcutkeys>
	<shortcutkey id="basic@undo">
		<key>Ctrl+Z</key>
	</shortcutkey>
	<shortcutkey id="basic@redo">
		<key>Ctrl+Y</key>
	</shortcutkey>
	<shortcutkey id="basic@select_all">
		<key>Ctrl+A</key>
	</shortcutkey>
	<shortcutkey id="basic@copy">
		<key>Ctrl+C</key>
	</shortcutkey>
	<shortcutkey id="basic@cut">
		<key>Ctrl+X</key>
	</shortcutkey>
	<shortcutkey id="basic@clipboard">
		<key>LWin+V</key>
	</shortcutkey>
	<shortcutkey id="basic@save">
		<key>Ctrl+S</key>
	</shortcutkey>
	<shortcutkey id="basic@open">
		<key>Ctrl+o</key>
	</shortcutkey>
	<shortcutkey id="file_and_folder@select_all">
		<key>Ctrl+A</key>
	</shortcutkey>
	<shortcutkey id="file_and_folder@copy">
		<key>Ctrl+C</key>
	</shortcutkey>
	<shortcutkey id="file_and_folder@move">
		<key>Ctrl+X</key>
	</shortcutkey>
</shortcutkeys>
```
