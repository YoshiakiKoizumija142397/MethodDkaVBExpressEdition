# MethodDkaVBExpressEdition

高次代数方程式を解くための「DKA法（Durand-Kerner-Aberth法）」を用いた、Visual Basic Express Edition版のソースコードおよびプロジェクトアーカイブです。

## 概要

かつてN88-BASIC版として構築された高次方程式の解法ロジックを、Windows環境（Visual Basic Express Edition）へと移植・発展させた歴史的な実装コード（`Form1.vb`）です[cite: 1, 2]。画面上のUI操作（ボタンやラベル）と連携しながら、DKA法による複素数根の収束計算を遂行します[cite: 2]。

## 主な特徴

* **DKA法（修正版）の実装**: 高次代数方程式の根を効率的かつ高精度に求めるアルゴリズム[cite: 1, 2]。
* **イベント駆動型UI**: フォーム上のボタンやテキストボックスを用いたインタラクティブな係数入力および計算実行[cite: 2]。
* **オープンソース**: 本リポジトリのコードは、オープンな開発資産として公開されています。

## ファイル構成

* `Form1.vb` - メインフォームのロジックおよびDKA法による計算処理のソースコード[cite: 2]
* `LICENSE` - MITライセンス[cite: 2]
* `README.md` - プロジェクト解説ドキュメント[cite: 2]

## ライセンス

このプロジェクトは MITライセンス の下で公開されています。詳細は [LICENSE](./LICENSE) ファイルをご確認ください[cite: 2]。

## 開発者

小泉嘉章 (Yoshiaki Koizumi)
