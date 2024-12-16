namespace CAFE_INIZIO
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPASTRY = new System.Windows.Forms.Button();
            this.btnCOFFEE = new System.Windows.Forms.Button();
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.PrPriceTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrCatCb = new System.Windows.Forms.ComboBox();
            this.PrQtyTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLOGOUT = new System.Windows.Forms.Button();
            this.btnORDER = new System.Windows.Forms.Button();
            this.btnCOSTUMER = new System.Windows.Forms.Button();
            this.btnPRODUCT = new System.Windows.Forms.Button();
            this.btnEMPLOYEE = new System.Windows.Forms.Button();
            this.btnHOME = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLOGOUT);
            this.panel1.Controls.Add(this.btnORDER);
            this.panel1.Controls.Add(this.btnCOSTUMER);
            this.panel1.Controls.Add(this.btnPRODUCT);
            this.panel1.Controls.Add(this.btnEMPLOYEE);
            this.panel1.Controls.Add(this.btnHOME);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 580);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnPASTRY);
            this.panel3.Controls.Add(this.btnCOFFEE);
            this.panel3.Controls.Add(this.ProductDGV);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnDELETE);
            this.panel3.Controls.Add(this.btnEDIT);
            this.panel3.Controls.Add(this.btnSAVE);
            this.panel3.Controls.Add(this.PrPriceTb);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.PrCatCb);
            this.panel3.Controls.Add(this.PrQtyTb);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.PrNameTb);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(4, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1277, 470);
            this.panel3.TabIndex = 7;
            // 
            // btnPASTRY
            // 
            this.btnPASTRY.BackColor = System.Drawing.Color.Moccasin;
            this.btnPASTRY.Image = global::CAFE_INIZIO.Properties.Resources.cake;
            this.btnPASTRY.Location = new System.Drawing.Point(149, 41);
            this.btnPASTRY.Margin = new System.Windows.Forms.Padding(4);
            this.btnPASTRY.Name = "btnPASTRY";
            this.btnPASTRY.Size = new System.Drawing.Size(125, 55);
            this.btnPASTRY.TabIndex = 29;
            this.btnPASTRY.Text = "PASTRY";
            this.btnPASTRY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPASTRY.UseVisualStyleBackColor = false;
            this.btnPASTRY.Click += new System.EventHandler(this.btnPASTRY_Click);
            // 
            // btnCOFFEE
            // 
            this.btnCOFFEE.BackColor = System.Drawing.Color.Coral;
            this.btnCOFFEE.Image = global::CAFE_INIZIO.Properties.Resources.coffee_cup;
            this.btnCOFFEE.Location = new System.Drawing.Point(16, 41);
            this.btnCOFFEE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCOFFEE.Name = "btnCOFFEE";
            this.btnCOFFEE.Size = new System.Drawing.Size(125, 55);
            this.btnCOFFEE.TabIndex = 28;
            this.btnCOFFEE.Text = "COFFEE";
            this.btnCOFFEE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCOFFEE.UseVisualStyleBackColor = false;
            this.btnCOFFEE.Click += new System.EventHandler(this.btnCOFFEE_Click);
            // 
            // ProductDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductDGV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ProductDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductDGV.Location = new System.Drawing.Point(15, 190);
            this.ProductDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ProductDGV.Name = "ProductDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PeachPuff;
            this.ProductDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductDGV.Size = new System.Drawing.Size(1240, 267);
            this.ProductDGV.TabIndex = 27;
            this.ProductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDGV_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(465, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "PRODUCT LIST";
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDELETE.Image = global::CAFE_INIZIO.Properties.Resources.exitbutton;
            this.btnDELETE.Location = new System.Drawing.Point(1137, 105);
            this.btnDELETE.Margin = new System.Windows.Forms.Padding(4);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(119, 52);
            this.btnDELETE.TabIndex = 25;
            this.btnDELETE.Text = "DELETE";
            this.btnDELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEDIT.Image = global::CAFE_INIZIO.Properties.Resources.view;
            this.btnEDIT.Location = new System.Drawing.Point(1011, 105);
            this.btnEDIT.Margin = new System.Windows.Forms.Padding(4);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(119, 52);
            this.btnEDIT.TabIndex = 24;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSAVE.Image = global::CAFE_INIZIO.Properties.Resources.add;
            this.btnSAVE.Location = new System.Drawing.Point(884, 105);
            this.btnSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(119, 52);
            this.btnSAVE.TabIndex = 23;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // PrPriceTb
            // 
            this.PrPriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrPriceTb.Location = new System.Drawing.Point(701, 127);
            this.PrPriceTb.Margin = new System.Windows.Forms.Padding(4);
            this.PrPriceTb.Name = "PrPriceTb";
            this.PrPriceTb.Size = new System.Drawing.Size(160, 26);
            this.PrPriceTb.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(696, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "QUANTITY";
            // 
            // PrCatCb
            // 
            this.PrCatCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrCatCb.FormattingEnabled = true;
            this.PrCatCb.Items.AddRange(new object[] {
            "16oz",
            "22oz",
            "BREAD"});
            this.PrCatCb.Location = new System.Drawing.Point(331, 126);
            this.PrCatCb.Margin = new System.Windows.Forms.Padding(4);
            this.PrCatCb.Name = "PrCatCb";
            this.PrCatCb.Size = new System.Drawing.Size(160, 28);
            this.PrCatCb.TabIndex = 12;
            // 
            // PrQtyTb
            // 
            this.PrQtyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrQtyTb.Location = new System.Drawing.Point(520, 127);
            this.PrQtyTb.Margin = new System.Windows.Forms.Padding(4);
            this.PrQtyTb.Name = "PrQtyTb";
            this.PrQtyTb.Size = new System.Drawing.Size(160, 26);
            this.PrQtyTb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "CATEGORY";
            // 
            // PrNameTb
            // 
            this.PrNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrNameTb.Location = new System.Drawing.Point(16, 126);
            this.PrNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.PrNameTb.Name = "PrNameTb";
            this.PrNameTb.Size = new System.Drawing.Size(285, 23);
            this.PrNameTb.TabIndex = 9;
            this.PrNameTb.TextChanged += new System.EventHandler(this.PrNameTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "PRODUCTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLOGOUT
            // 
            this.btnLOGOUT.Image = global::CAFE_INIZIO.Properties.Resources.exitbutton;
            this.btnLOGOUT.Location = new System.Drawing.Point(672, 15);
            this.btnLOGOUT.Margin = new System.Windows.Forms.Padding(4);
            this.btnLOGOUT.Name = "btnLOGOUT";
            this.btnLOGOUT.Size = new System.Drawing.Size(101, 84);
            this.btnLOGOUT.TabIndex = 6;
            this.btnLOGOUT.Text = "LOGOUT";
            this.btnLOGOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLOGOUT.UseVisualStyleBackColor = true;
            this.btnLOGOUT.Click += new System.EventHandler(this.btnLOGOUT_Click);
            // 
            // btnORDER
            // 
            this.btnORDER.Image = global::CAFE_INIZIO.Properties.Resources.orders;
            this.btnORDER.Location = new System.Drawing.Point(563, 15);
            this.btnORDER.Margin = new System.Windows.Forms.Padding(4);
            this.btnORDER.Name = "btnORDER";
            this.btnORDER.Size = new System.Drawing.Size(101, 84);
            this.btnORDER.TabIndex = 5;
            this.btnORDER.Text = "ORDER";
            this.btnORDER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnORDER.UseVisualStyleBackColor = true;
            this.btnORDER.Click += new System.EventHandler(this.btnORDER_Click);
            // 
            // btnCOSTUMER
            // 
            this.btnCOSTUMER.Image = global::CAFE_INIZIO.Properties.Resources.costumer;
            this.btnCOSTUMER.Location = new System.Drawing.Point(453, 15);
            this.btnCOSTUMER.Margin = new System.Windows.Forms.Padding(4);
            this.btnCOSTUMER.Name = "btnCOSTUMER";
            this.btnCOSTUMER.Size = new System.Drawing.Size(101, 84);
            this.btnCOSTUMER.TabIndex = 4;
            this.btnCOSTUMER.Text = "COSTUMER";
            this.btnCOSTUMER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCOSTUMER.UseVisualStyleBackColor = true;
            this.btnCOSTUMER.Click += new System.EventHandler(this.btnCOSTUMER_Click);
            // 
            // btnPRODUCT
            // 
            this.btnPRODUCT.Image = global::CAFE_INIZIO.Properties.Resources.iced_coffee;
            this.btnPRODUCT.Location = new System.Drawing.Point(344, 15);
            this.btnPRODUCT.Margin = new System.Windows.Forms.Padding(4);
            this.btnPRODUCT.Name = "btnPRODUCT";
            this.btnPRODUCT.Size = new System.Drawing.Size(101, 84);
            this.btnPRODUCT.TabIndex = 3;
            this.btnPRODUCT.Text = "PRODUCT";
            this.btnPRODUCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPRODUCT.UseVisualStyleBackColor = true;
            this.btnPRODUCT.Click += new System.EventHandler(this.btnPRODUCT_Click);
            // 
            // btnEMPLOYEE
            // 
            this.btnEMPLOYEE.Image = global::CAFE_INIZIO.Properties.Resources.user;
            this.btnEMPLOYEE.Location = new System.Drawing.Point(235, 15);
            this.btnEMPLOYEE.Margin = new System.Windows.Forms.Padding(4);
            this.btnEMPLOYEE.Name = "btnEMPLOYEE";
            this.btnEMPLOYEE.Size = new System.Drawing.Size(101, 84);
            this.btnEMPLOYEE.TabIndex = 2;
            this.btnEMPLOYEE.Text = "EMPLOYEE";
            this.btnEMPLOYEE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEMPLOYEE.UseVisualStyleBackColor = true;
            this.btnEMPLOYEE.Click += new System.EventHandler(this.btnEMPLOYEE_Click);
            // 
            // btnHOME
            // 
            this.btnHOME.Image = global::CAFE_INIZIO.Properties.Resources.house;
            this.btnHOME.Location = new System.Drawing.Point(125, 15);
            this.btnHOME.Margin = new System.Windows.Forms.Padding(4);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(101, 84);
            this.btnHOME.TabIndex = 1;
            this.btnHOME.Text = "HOME";
            this.btnHOME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHOME.UseVisualStyleBackColor = true;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CAFE_INIZIO.Properties.Resources.Header;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 84);
            this.panel2.TabIndex = 0;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 576);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product";
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLOGOUT;
        private System.Windows.Forms.Button btnORDER;
        private System.Windows.Forms.Button btnCOSTUMER;
        private System.Windows.Forms.Button btnPRODUCT;
        private System.Windows.Forms.Button btnEMPLOYEE;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrQtyTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrPriceTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PrCatCb;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.Button btnPASTRY;
        private System.Windows.Forms.Button btnCOFFEE;
    }
}