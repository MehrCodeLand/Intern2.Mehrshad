using System;
using System.Windows.Forms;
using System.Threading;

namespace Intern2.Mehrshad.Forms
{
    public partial class HomeFm : Form
    {
        public HomeFm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var message = "bye";
            MessageBox.Show(message);
            Thread.Sleep(500);

            Application.Exit();
        }

        private void SeeAllBtn_Click(object sender, EventArgs e)
        {
            var createProducts = new ProductsCreateFm();
            createProducts.ShowDialog();
        }
    }
}
