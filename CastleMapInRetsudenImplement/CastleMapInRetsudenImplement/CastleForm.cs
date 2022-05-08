using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

public partial class CastleMapInRetsudenViewerImplement : Form
{

    private void SetForm()
    {

        // フォームのサイズ
        this.Width = 480;
        this.Height = 320;
        // this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.AutoScroll = true;
    }



    public CastleMapInRetsudenViewerImplement()
    {

        if (!System.IO.File.Exists("CastleMapInRetsudenMod.nb6"))
        {
            MessageBox.Show("hexmap.nb6 のファイルがありません。\nこのエディタは天翔記フォルダにて起動してください");
            Environment.Exit(1);
        }
        if (!System.IO.File.Exists("CastleMapInRetsudenMod.dll"))
        {
            MessageBox.Show("LS11DotNet.dll のファイルがありません。\n該当ファイルは必要となります");
            Environment.Exit(1);
        }

        SetCastleImgTmpFileName();

        // フォームサイズ
        SetForm();

        // コンボボックス系処理
        SetAddComboBox();

        // イメージの登録(キャッシュ的な)
        RegistImages();

        // イメージインスタンスを確保。
        RegistPictureBoxes();

        // ヘックスマップの読み込み
        LoadHexMap();

        RePaintAllTips();
    }

    public String OnBeginPaint(int iCastleID, String strCastleName, int iCastleRank)
    {
        // 大居城であり、
        if (iCastleRank == 2) {

            // 大坂城もしくは、安土城であれば、
            const int kCastleOosaka = 167;
    		const int kCastleAzuchi = 136;
		    if ( iCastleID == kCastleOosaka || iCastleID == kCastleAzuchi ) {

                // 城マップとしては214番目である。
    			iCastleID = 214;
            }
		}

        CastleListComboBox.SelectedIndex = iCastleID;
        // 全て一端描画
        RePaintAllTips();
        return GetCastleImgTmpFileName();
    }

    public Image OnUpdatePaint()
    {
        return resultPicture;
    }

    public Image OnEndPaint()
    {
        try
        {
            // 用がなくなるので削除を試みる
            System.IO.File.Delete(GetCastleImgTmpFileName());
        }
        catch (Exception) {
        }
        return resultPicture;
    }


}