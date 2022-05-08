using System;
using System.Windows.Forms;


class CastleMainProgram
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        CastleMapInRetsudenViewerImplement f = new CastleMapInRetsudenViewerImplement();
        f.OnBeginPaint(100, "", 0);
        Application.Run(f);
    }
}