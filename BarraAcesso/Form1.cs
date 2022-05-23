using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BarraAcesso
{
    public partial class Form1 : Form
    {
        //Enumera os tipos para usar com o switch (o 1,2,3 são da API do user32)
        public enum Actions { Normal = 1, Minimize = 2, Maximize = 3 };

        //Importa o user32.dll para poder usar as APIs nativas
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        //Busca um aplicativo pelo nome
        public static IntPtr FindWindow(string title)
        {
            Process[] pros = Process.GetProcessesByName(title);

            if (pros.Length == 0)
                return IntPtr.Zero;

            foreach (Process x in pros)
            {
                if (! x.MainWindowHandle.Equals(IntPtr.Zero))
                    return x.MainWindowHandle;
            }
            return pros[0].MainWindowHandle;
        }

        //Dispara a ação desejada, só tem 3 opções no exemplo
        public static void Action(string name, Actions act)
        {
            //
            IntPtr hWnd = FindWindow(name);

            if (!hWnd.Equals(IntPtr.Zero))
                ShowWindowAsync(hWnd, (int)act);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkype_Click(object sender, EventArgs e)
        {
            //Action("skype", Actions.Normal);
            Action("skype", Actions.Normal);
        }

        private void btnWhats_Click(object sender, EventArgs e)
        {
            Action("WhatsApp", Actions.Normal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
