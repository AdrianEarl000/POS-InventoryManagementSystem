namespace POS_InventoryManagementSystem
{
    partial class CashierOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cashierOrder_clearBtn = new System.Windows.Forms.Button();
            this.cashierOrder_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrder_addBtn = new System.Windows.Forms.Button();
            this.cashierOrder_qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierOrder_price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cashierOrder_prodName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cashierOrder_prodID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierOrder_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cashierOrder_reciept = new System.Windows.Forms.Button();
            this.cashierOrder_payOrders = new System.Windows.Forms.Button();
            this.cashierOrder_change = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cashierOrder_amount = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cashierOrder_totalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 379);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Available Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 307);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(572, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 317);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cashierOrder_clearBtn);
            this.panel2.Controls.Add(this.cashierOrder_removeBtn);
            this.panel2.Controls.Add(this.cashierOrder_addBtn);
            this.panel2.Controls.Add(this.cashierOrder_qty);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cashierOrder_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cashierOrder_prodName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cashierOrder_prodID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrder_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 378);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select your Orders";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cashierOrder_clearBtn
            // 
            this.cashierOrder_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_clearBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_clearBtn.Location = new System.Drawing.Point(370, 303);
            this.cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            this.cashierOrder_clearBtn.Size = new System.Drawing.Size(115, 37);
            this.cashierOrder_clearBtn.TabIndex = 15;
            this.cashierOrder_clearBtn.Text = "Clear";
            this.cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_clearBtn.Click += new System.EventHandler(this.cashierOrder_clearBtn_Click);
            // 
            // cashierOrder_removeBtn
            // 
            this.cashierOrder_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_removeBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_removeBtn.Location = new System.Drawing.Point(163, 303);
            this.cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            this.cashierOrder_removeBtn.Size = new System.Drawing.Size(115, 37);
            this.cashierOrder_removeBtn.TabIndex = 14;
            this.cashierOrder_removeBtn.Text = "Remove";
            this.cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_removeBtn.Click += new System.EventHandler(this.cashierOrder_removeBtn_Click);
            // 
            // cashierOrder_addBtn
            // 
            this.cashierOrder_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_addBtn.FlatAppearance.BorderSize = 0;
            this.cashierOrder_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_addBtn.Location = new System.Drawing.Point(23, 303);
            this.cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            this.cashierOrder_addBtn.Size = new System.Drawing.Size(115, 37);
            this.cashierOrder_addBtn.TabIndex = 13;
            this.cashierOrder_addBtn.Text = "Add";
            this.cashierOrder_addBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_addBtn.Click += new System.EventHandler(this.cashierOrder_addBtn_Click);
            // 
            // cashierOrder_qty
            // 
            this.cashierOrder_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_qty.Location = new System.Drawing.Point(383, 175);
            this.cashierOrder_qty.Name = "cashierOrder_qty";
            this.cashierOrder_qty.Size = new System.Drawing.Size(129, 26);
            this.cashierOrder_qty.TabIndex = 9;
            this.cashierOrder_qty.ValueChanged += new System.EventHandler(this.cashierOrder_qty_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantity:";
            // 
            // cashierOrder_price
            // 
            this.cashierOrder_price.AutoSize = true;
            this.cashierOrder_price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_price.Location = new System.Drawing.Point(159, 233);
            this.cashierOrder_price.Name = "cashierOrder_price";
            this.cashierOrder_price.Size = new System.Drawing.Size(87, 18);
            this.cashierOrder_price.TabIndex = 7;
            this.cashierOrder_price.Text = "Category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price ($):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cashierOrder_prodName
            // 
            this.cashierOrder_prodName.AutoSize = true;
            this.cashierOrder_prodName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodName.Location = new System.Drawing.Point(159, 178);
            this.cashierOrder_prodName.Name = "cashierOrder_prodName";
            this.cashierOrder_prodName.Size = new System.Drawing.Size(87, 18);
            this.cashierOrder_prodName.TabIndex = 5;
            this.cashierOrder_prodName.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Name:";
            // 
            // cashierOrder_prodID
            // 
            this.cashierOrder_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodID.FormattingEnabled = true;
            this.cashierOrder_prodID.Location = new System.Drawing.Point(382, 71);
            this.cashierOrder_prodID.Name = "cashierOrder_prodID";
            this.cashierOrder_prodID.Size = new System.Drawing.Size(130, 28);
            this.cashierOrder_prodID.TabIndex = 3;
            this.cashierOrder_prodID.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_prodID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product ID:";
            // 
            // cashierOrder_category
            // 
            this.cashierOrder_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_category.FormattingEnabled = true;
            this.cashierOrder_category.Location = new System.Drawing.Point(126, 71);
            this.cashierOrder_category.Name = "cashierOrder_category";
            this.cashierOrder_category.Size = new System.Drawing.Size(130, 28);
            this.cashierOrder_category.TabIndex = 1;
            this.cashierOrder_category.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category:";
            this.label2.Click += new System.EventHandler(this.label2_Click);

            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.cashierOrder_reciept);
            this.panel4.Controls.Add(this.cashierOrder_payOrders);
            this.panel4.Controls.Add(this.cashierOrder_change);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cashierOrder_amount);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.cashierOrder_totalPrice);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(560, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 763);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "All Orders";
            // 
            // cashierOrder_reciept
            // 
            this.cashierOrder_reciept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_reciept.FlatAppearance.BorderSize = 0;
            this.cashierOrder_reciept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_reciept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_reciept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_reciept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_reciept.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_reciept.Location = new System.Drawing.Point(15, 708);
            this.cashierOrder_reciept.Name = "cashierOrder_reciept";
            this.cashierOrder_reciept.Size = new System.Drawing.Size(282, 37);
            this.cashierOrder_reciept.TabIndex = 22;
            this.cashierOrder_reciept.Text = "Reciept";
            this.cashierOrder_reciept.UseVisualStyleBackColor = false;
            this.cashierOrder_reciept.Click += new System.EventHandler(this.cashierOrder_reciept_Click);
            // 
            // cashierOrder_payOrders
            // 
            this.cashierOrder_payOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.cashierOrder_payOrders.FlatAppearance.BorderSize = 0;
            this.cashierOrder_payOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_payOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(145)))), ((int)(((byte)(105)))));
            this.cashierOrder_payOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashierOrder_payOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_payOrders.ForeColor = System.Drawing.Color.White;
            this.cashierOrder_payOrders.Location = new System.Drawing.Point(15, 640);
            this.cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            this.cashierOrder_payOrders.Size = new System.Drawing.Size(282, 37);
            this.cashierOrder_payOrders.TabIndex = 16;
            this.cashierOrder_payOrders.Text = "Pay Orders";
            this.cashierOrder_payOrders.UseVisualStyleBackColor = false;
            this.cashierOrder_payOrders.Click += new System.EventHandler(this.cashierOrder_payOrders_Click);
            // 
            // cashierOrder_change
            // 
            this.cashierOrder_change.AutoSize = true;
            this.cashierOrder_change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_change.Location = new System.Drawing.Point(154, 578);
            this.cashierOrder_change.Name = "cashierOrder_change";
            this.cashierOrder_change.Size = new System.Drawing.Size(43, 18);
            this.cashierOrder_change.TabIndex = 21;
            this.cashierOrder_change.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Change:";
            // 
            // cashierOrder_amount
            // 
            this.cashierOrder_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_amount.Location = new System.Drawing.Point(154, 504);
            this.cashierOrder_amount.Name = "cashierOrder_amount";
            this.cashierOrder_amount.Size = new System.Drawing.Size(143, 26);
            this.cashierOrder_amount.TabIndex = 19;
            this.cashierOrder_amount.TextChanged += new System.EventHandler(this.cashierOrder_amount_TextChanged);
            this.cashierOrder_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrder_amount_KeyDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(282, 320);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Amount ($):";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(572, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(334, 317);
            this.panel5.TabIndex = 1;
            // 
            // cashierOrder_totalPrice
            // 
            this.cashierOrder_totalPrice.AutoSize = true;
            this.cashierOrder_totalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_totalPrice.Location = new System.Drawing.Point(154, 456);
            this.cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            this.cashierOrder_totalPrice.Size = new System.Drawing.Size(43, 18);
            this.cashierOrder_totalPrice.TabIndex = 17;
            this.cashierOrder_totalPrice.Text = "0.00";
            this.cashierOrder_totalPrice.Click += new System.EventHandler(this.cashierOrder_totalPrice_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "Total Price ($):";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrder";
            this.Size = new System.Drawing.Size(883, 798);
            this.Load += new System.EventHandler(this.CashierOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cashierOrder_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cashierOrder_prodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cashierOrder_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cashierOrder_prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cashierOrder_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cashierOrder_clearBtn;
        private System.Windows.Forms.Button cashierOrder_removeBtn;
        private System.Windows.Forms.Button cashierOrder_addBtn;
        private System.Windows.Forms.TextBox cashierOrder_amount;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cashierOrder_totalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cashierOrder_change;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cashierOrder_reciept;
        private System.Windows.Forms.Button cashierOrder_payOrders;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        
    }
}
