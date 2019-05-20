using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Frm
{
    /***
     *                    _ooOoo_
     *                   o8888888o
     *                   88" . "88
     *                    (| -_- |)
     *                    O\ = /O
     *              ____/`---'\____
     *              .   ' \\| |// `.
     *               / \\||| : |||// \
     *             / _||||| -:- |||||- \
     *               | | \\\ - /// | |
     *             | \_| ''\---/'' | |
     *              \ .-\__ `-` ___/-. /
     *           ___`. .' /--.--\ `. . __
     *        ."" '< `.___\_<|>_/___.' >'"".
     *       | | : `- \`.;`\ _ /`;.`/ - ` : | |
     *         \ \ `-. \_ __\ /__ _/ .-` / /
     * ======`-.____`-.___\_____/___.-`____.-'======
     *                    `=---='
     *
     * .............................................
     *          佛祖保佑             永无BUG
     */
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new Form_Login().Show();
            Application.Run();
        }
    }
}
