namespace My_Inventory_Management_System
{
    partial class InventoryManagementSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.produceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.produceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Inventory Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // produceTextBox
            // 
            this.produceTextBox.Location = new System.Drawing.Point(102, 88);
            this.produceTextBox.Name = "produceTextBox";
            this.produceTextBox.Size = new System.Drawing.Size(174, 20);
            this.produceTextBox.TabIndex = 1;
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Location = new System.Drawing.Point(12, 178);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.Size = new System.Drawing.Size(738, 260);
            this.inventoryGridView.TabIndex = 2;
            this.inventoryGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGridView_CellDoubleClick);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(102, 120);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(174, 52);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(293, 120);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(174, 52);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(479, 120);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(174, 52);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(293, 88);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(174, 20);
            this.quantityTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(479, 88);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(174, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // produceLabel
            // 
            this.produceLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produceLabel.Location = new System.Drawing.Point(99, 62);
            this.produceLabel.Name = "produceLabel";
            this.produceLabel.Size = new System.Drawing.Size(177, 23);
            this.produceLabel.TabIndex = 8;
            this.produceLabel.Text = "Produce:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(290, 62);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(177, 23);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Quantity:";
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(476, 62);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(177, 23);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price:";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(293, 466);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 52);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // InventoryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(770, 530);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.produceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.inventoryGridView);
            this.Controls.Add(this.produceTextBox);
            this.Controls.Add(this.label1);
            this.Name = "InventoryManagementSystem";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.InventoryManagementSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox produceTextBox;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label produceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

