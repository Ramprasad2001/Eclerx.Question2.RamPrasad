
namespace Eclerx.Question2.RamPrasad
{
    partial class Form1
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
            this.LblCustomerCity = new System.Windows.Forms.Label();
            this.TxtByCity = new System.Windows.Forms.TextBox();
            this.LblSort = new System.Windows.Forms.Label();
            this.ComboSort = new System.Windows.Forms.ComboBox();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.GridShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridShow)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCustomerCity
            // 
            this.LblCustomerCity.AutoSize = true;
            this.LblCustomerCity.Location = new System.Drawing.Point(138, 48);
            this.LblCustomerCity.Name = "LblCustomerCity";
            this.LblCustomerCity.Size = new System.Drawing.Size(114, 17);
            this.LblCustomerCity.TabIndex = 0;
            this.LblCustomerCity.Text = "Customer by City";
            // 
            // TxtByCity
            // 
            this.TxtByCity.Location = new System.Drawing.Point(317, 48);
            this.TxtByCity.Name = "TxtByCity";
            this.TxtByCity.Size = new System.Drawing.Size(100, 22);
            this.TxtByCity.TabIndex = 1;
            // 
            // LblSort
            // 
            this.LblSort.AutoSize = true;
            this.LblSort.Location = new System.Drawing.Point(141, 95);
            this.LblSort.Name = "LblSort";
            this.LblSort.Size = new System.Drawing.Size(54, 17);
            this.LblSort.TabIndex = 2;
            this.LblSort.Text = "Sort By";
            // 
            // ComboSort
            // 
            this.ComboSort.FormattingEnabled = true;
            this.ComboSort.Items.AddRange(new object[] {
            "CreditLimit : Low to high",
            "CreditLimit : High to low",
            "Customer Name : A to Z",
            "Customer Name : Z to A"});
            this.ComboSort.Location = new System.Drawing.Point(317, 95);
            this.ComboSort.Name = "ComboSort";
            this.ComboSort.Size = new System.Drawing.Size(121, 24);
            this.ComboSort.TabIndex = 3;
            this.ComboSort.SelectedIndexChanged += new System.EventHandler(this.ComboSort_SelectedIndexChanged);
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(604, 95);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(75, 23);
            this.BtnGetData.TabIndex = 4;
            this.BtnGetData.Text = "Get Data";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // GridShow
            // 
            this.GridShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridShow.Location = new System.Drawing.Point(73, 174);
            this.GridShow.Name = "GridShow";
            this.GridShow.RowHeadersWidth = 51;
            this.GridShow.RowTemplate.Height = 24;
            this.GridShow.Size = new System.Drawing.Size(623, 244);
            this.GridShow.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridShow);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.ComboSort);
            this.Controls.Add(this.LblSort);
            this.Controls.Add(this.TxtByCity);
            this.Controls.Add(this.LblCustomerCity);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustomerCity;
        private System.Windows.Forms.TextBox TxtByCity;
        private System.Windows.Forms.Label LblSort;
        private System.Windows.Forms.ComboBox ComboSort;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.DataGridView GridShow;
    }
}

