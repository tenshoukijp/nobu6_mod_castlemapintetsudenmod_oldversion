using System.Windows.Forms;
using System.Collections;



partial class CastleMapInRetsudenViewerImplement : Form
{

    ArrayList csAllHexMapArray; // hexmap.nb6のデータ(の解凍したもの)の全て


    // hexmap.nb6の読み込み
    void LoadHexMap()
    {
        csAllHexMapArray = new ArrayList();
        int result = LS11DotNet.Ls11.DecodePack("CastleMapInRetsudenMod.nb6", csAllHexMapArray);

        if (result != 0)
        {
            MessageBox.Show("hexmap.n6p の読み込みに失敗しました。");
        }
    }
}
