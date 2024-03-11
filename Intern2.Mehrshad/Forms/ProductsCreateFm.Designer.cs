namespace Intern2.Mehrshad.Forms
{
    partial class ProductsCreateFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.nameOfProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.catCombo = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.intern2DataSet2 = new Intern2.Mehrshad.intern2DataSet2();
            this.ategory = new System.Windows.Forms.Label();
            this.intern2DataSet = new Intern2.Mehrshad.intern2DataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Intern2.Mehrshad.intern2DataSetTableAdapters.CategoryTableAdapter();
            this.intern2DataSet1 = new Intern2.Mehrshad.intern2DataSet1();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter1 = new Intern2.Mehrshad.intern2DataSet1TableAdapters.CategoryTableAdapter();
            this.categoryTableAdapter2 = new Intern2.Mehrshad.intern2DataSet2TableAdapters.CategoryTableAdapter();
            this.intern2DataSet3 = new Intern2.Mehrshad.Intern2DataSet();
            this.categoryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter3 = new Intern2.Mehrshad.Intern2DataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(321, 182);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 0;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // nameOfProducts
            // 
            this.nameOfProducts.Location = new System.Drawing.Point(196, 51);
            this.nameOfProducts.Name = "nameOfProducts";
            this.nameOfProducts.Size = new System.Drawing.Size(200, 20);
            this.nameOfProducts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(133, 182);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // catCombo
            // 
            this.catCombo.DataSource = this.categoryBindingSource3;
            this.catCombo.DisplayMember = "Name";
            this.catCombo.FormattingEnabled = true;
            this.catCombo.Location = new System.Drawing.Point(196, 89);
            this.catCombo.Name = "catCombo";
            this.catCombo.Size = new System.Drawing.Size(200, 21);
            this.catCombo.TabIndex = 4;
            this.catCombo.ValueMember = "CategoryID";
            // 
            // categoryBindingSource2
            // 
            this.categoryBindingSource2.DataMember = "Category";
            this.categoryBindingSource2.DataSource = this.intern2DataSet2;
            // 
            // intern2DataSet2
            // 
            this.intern2DataSet2.DataSetName = "intern2DataSet2";
            this.intern2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ategory
            // 
            this.ategory.AutoSize = true;
            this.ategory.Location = new System.Drawing.Point(130, 92);
            this.ategory.Name = "ategory";
            this.ategory.Size = new System.Drawing.Size(49, 13);
            this.ategory.TabIndex = 5;
            this.ategory.Text = "Category";
            // 
            // intern2DataSet
            // 
            this.intern2DataSet.DataSetName = "intern2DataSet";
            this.intern2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.intern2DataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // intern2DataSet1
            // 
            this.intern2DataSet1.DataSetName = "intern2DataSet1";
            this.intern2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.intern2DataSet1;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryTableAdapter2
            // 
            this.categoryTableAdapter2.ClearBeforeFill = true;
            // 
            // intern2DataSet3
            // 
            this.intern2DataSet3.DataSetName = "Intern2DataSet";
            this.intern2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource3
            // 
            this.categoryBindingSource3.DataMember = "Category";
            this.categoryBindingSource3.DataSource = this.intern2DataSet3;
            // 
            // categoryTableAdapter3
            // 
            this.categoryTableAdapter3.ClearBeforeFill = true;
            // 
            // ProductsCreateFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.ategory);
            this.Controls.Add(this.catCombo);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameOfProducts);
            this.Controls.Add(this.CreateBtn);
            this.Name = "ProductsCreateFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsCreateFm";
            this.Load += new System.EventHandler(this.ProductsCreateFm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intern2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox nameOfProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.ComboBox catCombo;
        private System.Windows.Forms.Label ategory;
        private intern2DataSet intern2DataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private intern2DataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private intern2DataSet1 intern2DataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private intern2DataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter1;
        private intern2DataSet2 intern2DataSet2;
        private System.Windows.Forms.BindingSource categoryBindingSource2;
        private intern2DataSet2TableAdapters.CategoryTableAdapter categoryTableAdapter2;
        private Intern2DataSet intern2DataSet3;
        private System.Windows.Forms.BindingSource categoryBindingSource3;
        private Intern2DataSetTableAdapters.CategoryTableAdapter categoryTableAdapter3;
    }
}