using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;



partial class CastleMapInRetsudenViewerImplement : Form
{

    Image[] basePictureImg;
    Image[] wallPictureImg;
    Image[] ridePictureImg;

    Image resultPicture;

    const int iColMax = 18;
    const int iRowMax = 16;

    const int iTipImageSize = 16;

    const int iLeftStandingPos = 12;
    const int iTopStandingPos = 24;

    const int iCastleNum = 214;

    const int iHexmapCastleStartID = 952;

    // ピクチャーボックスの配置。
    // 下地・城壁・さらに上に乗るものの３層
    private void RegistPictureBoxes()
    {
        // 下地
        this.basePictureImg = new Image[iColMax * iRowMax];

        // 城壁
        this.wallPictureImg = new Image[iColMax * iRowMax];

        // 本丸・曲輪・茂み 等
        this.ridePictureImg = new Image[iColMax * iRowMax];

    }

    Point GetPicturePos(int col, int row)
    {
        if (row % 2 == 0)
        {
            return new Point(
                iLeftStandingPos + col * iTipImageSize,
                iTopStandingPos + row * iTipImageSize);
        }
        else
        {
            return new Point(
                iLeftStandingPos + (iTipImageSize / 2) + col * iTipImageSize,
                iTopStandingPos + row * iTipImageSize);
        }
    }


    void RePaintBaseTips()
    {

        // コンボボックスで選択した城の「チップリスト」を取得
        ArrayList csOneHexMapTipsList = (ArrayList)csAllHexMapArray[GetSelectedHexMapID()];

        for (int i = 0; i < iRowMax * iColMax; i++)
        {
            // ベース
            Byte tip = (Byte)csOneHexMapTipsList[i];
            Image baseImage = baseImages[tip];
            this.basePictureImg[i] = baseImage;
        }

    }

 
    void RePaintWallTips()
    {

        // コンボボックスで選択した城の「チップリスト」を取得
        ArrayList csOneHexMapTipsList = (ArrayList)csAllHexMapArray[GetSelectedHexMapID()];

        for (int i = 0; i < iRowMax * iColMax; i++)
        {

            // ウォール
            Byte tip = (Byte)csOneHexMapTipsList[i + (iColMax * iRowMax) * 1];
            Image wallImage = wallImages[tip];
            this.wallPictureImg[i] = wallImage;
        }
    }

    void RePaintRideTips()
    {

        // コンボボックスで選択した城の「チップリスト」を取得
        ArrayList csOneHexMapTipsList = (ArrayList)csAllHexMapArray[GetSelectedHexMapID()];

        for (int i = 0; i < iRowMax * iColMax; i++)
        {

            // ライド
            Byte tip = (Byte)csOneHexMapTipsList[i + (iColMax * iRowMax) * 2];
            Image rideImage = rideImages[tip];
            this.ridePictureImg[i] = rideImage;
        }
    }

    void RePaintResultTips()
    {
        Bitmap result = new Bitmap(imgDialogBackground, 320, 304);

        // ベースとなるイメージ
        Graphics g = Graphics.FromImage(result);

        int i = 0;
        for (int row = 0; row < iRowMax; row++)
        {
            for (int col = 0; col < iColMax; col++)
            {

                Point pos = GetPicturePos(col, row);
                //------------- 重ね表示
                // 土地重ね
                g.DrawImage(this.basePictureImg[i], pos.X, pos.Y, iTipImageSize, iTipImageSize);

                if ((int)this.wallPictureImg[i].Tag != 0xFF)
                {// 透明ではない
                    // 壁重ね
                    g.DrawImage(this.wallPictureImg[i], pos.X, pos.Y, iTipImageSize, iTipImageSize);
                }
                if ((int)this.ridePictureImg[i].Tag != 0xFF)
                { // 透明ではない
                    // 他重ね
                    g.DrawImage(this.ridePictureImg[i], pos.X, pos.Y, iTipImageSize, iTipImageSize);
                }

                i++;
            }
        }

        // 重ねたので破棄
        g.Dispose();

        this.resultPicture = result;
    }


    void RePaintAllTips()
    {
        RePaintBaseTips();
        RePaintWallTips();
        RePaintRideTips();
        RePaintResultTips();

        SaveImage();

    }

    void SaveImage()
    {
        try
        {
            //画像を作成する
            Bitmap bmp = new Bitmap(this.resultPicture);

            //PNG形式で保存する
            bmp.Save(GetCastleImgTmpFileName(), System.Drawing.Imaging.ImageFormat.Png);

            //後片付け
            bmp.Dispose();
        }
        catch (Exception e)
        {
            System.Windows.Forms.MessageBox.Show(e.Message);
        }
    }

    String tmpFileName;

    void SetCastleImgTmpFileName()
    {
        tmpFileName = System.IO.Path.GetTempPath() + @"\" + "CastleMapInRetsudenMod.tmp";
    }
    String GetCastleImgTmpFileName()
    {
        return tmpFileName;
    }
}
