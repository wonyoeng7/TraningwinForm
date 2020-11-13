using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _2020_8_19WinForm
{
    class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
      
        static void Main(string[] args)
        {
            CreateMyForm();
        }

        private static void CreateMyForm()
        {
            Form form1 = new Form();

            Button button1 = new Button();
            Button button2 = new Button();

            button1.Text = "OK";
            button1.Location = new System.Drawing.Point(10, 10);
            button2.Text = "Cancel";
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 10);

            form1.Text = "My Dialog Box";

            button1.Click += Button1_Click;

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.StartPosition = FormStartPosition.CenterScreen;

            form1.Controls.Add(button1);
            form1.Controls.Add(button2);

            form1.ShowDialog();
        }

        private static void Button1_Click(object sender,EventArgs e)
        {
            MessageBox.Show("Ok Button clicked!");
        }
    }
}
