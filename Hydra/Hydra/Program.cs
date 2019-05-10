using System.Threading;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        MessageBox.Show("Cut off a head, two more take its place.", "Hydra", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        Thread thread1 = new Thread(Main);
        Thread thread2 = new Thread(Main);
        thread1.Start();
        thread2.Start();
    }
}
