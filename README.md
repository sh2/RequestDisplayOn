# RequestDisplayOn

RequestDisplayOnは、ディスプレイへの表示要求を行うコンソールアプリケーションです。

コンピューターを長時間操作していないときに、スクリーンセーバーが起動したりディスプレイがオフになったりすることを抑止します。
スクリーンセーバーやディスプレイの設定を変更できない環境において、運用監視ツールのダッシュボードを表示したままにしておくといった使い方を想定しています。

## 動作環境

- Windows 10 Version 1809以降

## 使用方法

アーカイブファイルを任意のフォルダに展開し、RequestDisplayOn.exeを起動してください。
コマンドラインオプションはありません。

- 起動すると表示要求を行い入力待ちになります。コンソールウィンドウは最小化しておいて問題ありません
- Enterキーを押すと表示要求を解除します
- もう一度Enterキーを押すとアプリケーションを終了します

アンインストールする場合は、展開されたファイルを単純に削除してください。

## ビルド環境

- Visual Studio 2022
- .NET 6

## ノート

同じようなことをするアプリケーションは多数あると思います。
今回はWinRTに[DisplayRequest](https://learn.microsoft.com/ja-jp/uwp/api/windows.system.display.displayrequest?view=winrt-22621)というやりたいことを直接実現できるAPIがあったこと、加えて.NET 6以降ではWinRTのAPI呼び出しが[容易になった](https://learn.microsoft.com/ja-jp/windows/apps/desktop/modernize/desktop-to-uwp-enhance)ことから、コンパクトに実装できるのではないかと考えて作成しました。

リファレンスによるとDisplayRequestはアプリケーションがフォアグラウンドで実行されている間のみ動作するとされていますが、コンソールアプリケーションの場合はバックグラウンドに移動しても動作し続けるようです。
この仕様は明文化されたものではないため、将来的に本アプリケーションが意図通りに動かなくなる可能性はあります。

## 更新履歴

- 1.0.0 (2023-01-10)
  - 最初のリリース

## ライセンス

MIT License  
Copyright (c) 2023 [Sadao Hiratsuka](mailto:sh2@pop01.odn.ne.jp)

ソースコードは[GitHub](https://github.com/sh2/RequestDisplayOn)で公開しています。
