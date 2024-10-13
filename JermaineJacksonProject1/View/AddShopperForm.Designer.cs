namespace JermaineJacksonProject1.View
{
    partial class AddShopperForm
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
            ShopperName = new Label();
            MoneyLbl = new Label();
            ShopperNameTxtBox = new TextBox();
            MoneyTxtBox = new TextBox();
            AddShopperBtn = new Button();
            SuspendLayout();
            // 
            // ShopperName
            // 
            ShopperName.AutoSize = true;
            ShopperName.Location = new Point(128, 49);
            ShopperName.Name = "ShopperName";
            ShopperName.Size = new Size(206, 15);
            ShopperName.TabIndex = 0;
            ShopperName.Text = "Please enter the name of the shopper:";
            // 
            // MoneyLbl
            // 
            MoneyLbl.AutoSize = true;
            MoneyLbl.Location = new Point(128, 99);
            MoneyLbl.Name = "MoneyLbl";
            MoneyLbl.Size = new Size(328, 15);
            MoneyLbl.TabIndex = 1;
            MoneyLbl.Text = "Please enter the amount of money the shopper has available:";
            // 
            // ShopperNameTxtBox
            // 
            ShopperNameTxtBox.Location = new Point(352, 46);
            ShopperNameTxtBox.Name = "ShopperNameTxtBox";
            ShopperNameTxtBox.Size = new Size(100, 23);
            ShopperNameTxtBox.TabIndex = 2;
            // 
            // MoneyTxtBox
            // 
            MoneyTxtBox.Location = new Point(462, 91);
            MoneyTxtBox.Name = "MoneyTxtBox";
            MoneyTxtBox.Size = new Size(100, 23);
            MoneyTxtBox.TabIndex = 3;
            // 
            // AddShopperBtn
            // 
            AddShopperBtn.Location = new Point(233, 171);
            AddShopperBtn.Name = "AddShopperBtn";
            AddShopperBtn.Size = new Size(75, 23);
            AddShopperBtn.TabIndex = 4;
            AddShopperBtn.Text = "Add";
            AddShopperBtn.UseVisualStyleBackColor = true;
            AddShopperBtn.Click += AddShopperBtn_Click;
            // 
            // AddShopperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddShopperBtn);
            Controls.Add(MoneyTxtBox);
            Controls.Add(ShopperNameTxtBox);
            Controls.Add(MoneyLbl);
            Controls.Add(ShopperName);
            Name = "AddShopperForm";
            Text = "AddShopperForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShopperName;
        private Label MoneyLbl;
        private TextBox ShopperNameTxtBox;
        private TextBox MoneyTxtBox;
        private Button AddShopperBtn;
    }
}