
namespace Lab3_6
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
            this.title = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.yearRelease = new System.Windows.Forms.Label();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.company = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.artist = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(42, 51);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(35, 17);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            this.title.UseWaitCursor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(115, 51);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(112, 22);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.UseWaitCursor = true;
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.yearRelease);
            this.groupBox1.Controls.Add(this.txtRelease);
            this.groupBox1.Controls.Add(this.company);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.country);
            this.groupBox1.Controls.Add(this.txtArtist);
            this.groupBox1.Controls.Add(this.artist);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.groupBox1.Location = new System.Drawing.Point(59, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Or Edit";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(330, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 22);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.UseWaitCursor = true;
            // 
            // yearRelease
            // 
            this.yearRelease.AutoSize = true;
            this.yearRelease.Location = new System.Drawing.Point(480, 93);
            this.yearRelease.Name = "yearRelease";
            this.yearRelease.Size = new System.Drawing.Size(94, 17);
            this.yearRelease.TabIndex = 10;
            this.yearRelease.Text = "Year Release";
            this.yearRelease.UseWaitCursor = true;
            // 
            // txtRelease
            // 
            this.txtRelease.Location = new System.Drawing.Point(577, 89);
            this.txtRelease.Name = "txtRelease";
            this.txtRelease.Size = new System.Drawing.Size(112, 22);
            this.txtRelease.TabIndex = 9;
            this.txtRelease.UseWaitCursor = true;
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(42, 88);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(67, 17);
            this.company.TabIndex = 8;
            this.company.Text = "Company";
            this.company.UseWaitCursor = true;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(577, 48);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(112, 22);
            this.txtCountry.TabIndex = 7;
            this.txtCountry.UseWaitCursor = true;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(272, 94);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(40, 17);
            this.price.TabIndex = 6;
            this.price.Text = "Price";
            this.price.UseWaitCursor = true;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(115, 85);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(112, 22);
            this.txtCompany.TabIndex = 5;
            this.txtCompany.UseWaitCursor = true;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(514, 51);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(57, 17);
            this.country.TabIndex = 4;
            this.country.Text = "Country";
            this.country.UseWaitCursor = true;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(330, 51);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(112, 22);
            this.txtArtist.TabIndex = 3;
            this.txtArtist.UseWaitCursor = true;
            // 
            // artist
            // 
            this.artist.AutoSize = true;
            this.artist.Location = new System.Drawing.Point(272, 53);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(40, 17);
            this.artist.TabIndex = 2;
            this.artist.Text = "Artist";
            this.artist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.artist.UseWaitCursor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(355, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(636, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Location = new System.Drawing.Point(46, 33);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.RowHeadersWidth = 51;
            this.dgvCatalog.RowTemplate.Height = 24;
            this.dgvCatalog.Size = new System.Drawing.Size(869, 170);
            this.dgvCatalog.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCatalog);
            this.groupBox2.Location = new System.Drawing.Point(30, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(943, 209);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 536);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label yearRelease;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label artist;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

