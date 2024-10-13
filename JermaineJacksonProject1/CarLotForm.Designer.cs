namespace JermaineJacksonProject1
{
    partial class CarLotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CarLotBox = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            newCarAdditionToolStripMenuItem = new ToolStripMenuItem();
            ShopperBtn = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // CarLotBox
            // 
            CarLotBox.FormattingEnabled = true;
            CarLotBox.ItemHeight = 15;
            CarLotBox.Location = new Point(211, 113);
            CarLotBox.Name = "CarLotBox";
            CarLotBox.Size = new Size(386, 154);
            CarLotBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newCarAdditionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // newCarAdditionToolStripMenuItem
            // 
            newCarAdditionToolStripMenuItem.Name = "newCarAdditionToolStripMenuItem";
            newCarAdditionToolStripMenuItem.Size = new Size(107, 20);
            newCarAdditionToolStripMenuItem.Text = "NewCarAddition";
            newCarAdditionToolStripMenuItem.Click += newCarAdditionToolStripMenuItem_Click;
            // 
            // ShopperBtn
            // 
            ShopperBtn.Location = new Point(569, 354);
            ShopperBtn.Name = "ShopperBtn";
            ShopperBtn.Size = new Size(123, 23);
            ShopperBtn.TabIndex = 2;
            ShopperBtn.Text = "Add Shopper";
            ShopperBtn.UseVisualStyleBackColor = true;
            ShopperBtn.Click += ShopperBtn_Click;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShopperBtn);
            Controls.Add(menuStrip1);
            Controls.Add(CarLotBox);
            MainMenuStrip = menuStrip1;
            Name = "CarLotForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CarLotBox;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newCarAdditionToolStripMenuItem;
        private Button ShopperBtn;
    }
}
