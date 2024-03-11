using System;
using System.Windows.Forms;

using Intern2.Mehrshad.ViewModels;
using Intern2.Mehrshad.Repositories;

namespace Intern2.Mehrshad.Forms
{
    public partial class ProductsCreateFm : Form
    {
        public ProductsCreateFm()
        {
            InitializeComponent();
        }

        private void ClearTextBox()
        {
            nameOfProducts.Text = "";
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsCreateFm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intern2DataSet3.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter3.Fill(this.intern2DataSet3.Category);

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

            // validation part
            if(nameOfProducts.Text.Replace(" " , "" ) == "")
            {
                var message = "please fill the balnk";
                MessageBox.Show(message);

                ClearTextBox();
            }
            else if(catCombo.Text.Replace(" " , "")  == "")
            {
                var message = "please fill the category";
                MessageBox.Show(message);

                ClearTextBox();
            }


            // sende data 
            var productVm  = new CreateProductVm()
            {
                Name = nameOfProducts.Text.Replace(" ", ""),
                CategoryID = catCombo.SelectedValue.ToString(),
                CategoryName = catCombo.SelectedText
            };

            // time to send it 

            var repo = new ProductRepository();
            repo.CreateProduct(productVm);

        }
    }
}
