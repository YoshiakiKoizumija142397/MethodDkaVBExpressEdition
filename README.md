# MethodDkaVBExpressEdition

高次代数方程式を解くための「DKA法（Durand-Kerner-Aberth法）」を用いた、Visual Basic Express Edition版のソースコードおよびプロジェクトアーカイブです。

## 概要

かつてN88-BASIC版として構築された高次方程式の解法ロジックを、Windows環境（Visual Basic Express Edition）へと移植・発展させた歴史的な実装コード（Form1.vb）です。画面上のUI操作（ボタンやラベル）と連携しながら、DKA法による複素数根の収束計算を遂行します。

## 主な特徴

* **DKA法（修正版）の実装**: 高次代数方程式の根を効率的かつ高精度に求めるアルゴリズム。
* **イベント駆動型UI**: フォーム上のボタンやテキストボックスを用いたインタラクティブな係数入力および計算実行。
* **オープンソース**: 本リポジトリのコードは、オープンな開発資産として公開されています。

## ファイル構成

* `Form1.vb` - メインフォームのロジックおよびDKA法による計算処理のソースコード
* `LICENSE` - MITライセンス
* `README.md` - プロジェクト解説ドキュメント


Source Reconstruction History / ソースコード復元経緯
English

This repository contains a reconstructed version of the original MethodDka source code.

The original source code was developed during the N88-BASIC era and was later ported to Visual Basic Express Edition. Unfortunately, neither the original floppy disks nor the floppy disk drives used during development have survived.

However, printed source code listings created at that time were preserved by the author. These printed listings became the only remaining record of the software.

The source code published in this repository was reconstructed from those printed listings. The listings were digitized using Google Lens OCR and manually reviewed and corrected where possible.

Although every effort has been made to preserve the original implementation faithfully, OCR-based reconstruction may contain transcription mistakes, typographical errors, or minor deviations from the original source code.

Therefore, this repository should be regarded as a historical reconstruction based on surviving printed materials rather than a bit-for-bit reproduction of the original storage media.

The purpose of this publication is to preserve the historical development of MethodDka and make its implementation available for study, reference, software preservation, and future development.

Released under the MIT License.

日本語

本リポジトリは、MethodDka のオリジナルソースコードを復元したものです。

オリジナルのソースコードは N88-BASIC 時代に開発され、その後 Visual Basic Express Edition へ移植されました。しかし、開発当時に使用していたフロッピーディスクおよびフロッピーディスクドライブは現存していません。

一方で、当時印刷して保管していたソースコードのプリントアウトが残されていました。これらのプリントアウトは、現在確認できる唯一の開発資料です。

本リポジトリで公開しているソースコードは、それらのプリントアウトを基に復元したものです。Google Lens による OCR 読み取りを行い、可能な範囲で目視による確認と修正を実施しています。

原実装の忠実な再現に努めていますが、OCR による復元作業を経ているため、転記ミス、読み取り誤差、またはオリジナルとの相違が一部残っている可能性があります。

そのため、本リポジトリはオリジナル媒体の完全な複製ではなく、現存する印刷資料に基づく歴史的復元版として公開しています。

本公開の目的は、MethodDka の開発史を保存し、その実装を研究、学習、ソフトウェア保存活動、および将来の開発に役立てることにあります。

MIT License のもとで公開しています。


## MethodDka Lineage / MethodDka の系譜

N88-BASIC Version
        ↓
VB Express Edition Version
        ↓
Modern MethodDka
  - Arbitrary Precision Arithmetic
  - Complex Coefficients
  - Simultaneous Root Finding
  - Horner Verification
  - Error Radius Estimation
  - Zenodo DOI Publication


## ライセンス

このプロジェクトは MITライセンス の下で公開されています。詳細は [LICENSE](./LICENSE) ファイルをご確認ください。

## 開発者

小泉嘉章 (Yoshiaki Koizumi)
