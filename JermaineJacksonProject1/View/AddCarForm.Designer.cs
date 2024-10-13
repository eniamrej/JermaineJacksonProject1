namespace JermaineJacksonProject1.View
{
    partial class AddCarForm
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
            MakeLbl = new Label();
            ModelLbl = new Label();
            MpgLbl = new Label();
            PriceLbl = new Label();
            MakeTxtBox = new TextBox();
            ModelTxtBox = new TextBox();
            AddNewCarBtn = new Button();
            MpgTxtBox = new TextBox();
            PriceTxtBox = new TextBox();
            SuspendLayout();
            // 
            // MakeLbl
            // 
            MakeLbl.AutoSize = true;
            MakeLbl.Location = new Point(208, 75);
            MakeLbl.Name = "MakeLbl";
            MakeLbl.Size = new Size(203, 15);
            MakeLbl.TabIndex = 0;
            MakeLbl.Text = "Please enter the make of the new car:";
            // 
            // ModelLbl
            // 
            ModelLbl.AutoSize = true;
            ModelLbl.Location = new Point(208, 117);
            ModelLbl.Name = "ModelLbl";
            ModelLbl.Size = new Size(208, 15);
            ModelLbl.TabIndex = 1;
            ModelLbl.Text = "Please enter the model of the new car:";
            // 
            // MpgLbl
            // 
            MpgLbl.AutoSize = true;
            MpgLbl.Location = new Point(208, 157);
            MpgLbl.Name = "MpgLbl";
            MpgLbl.Size = new Size(204, 15);
            MpgLbl.TabIndex = 2;
            MpgLbl.Text = "Please enter the MPG for the new car:";
            // 
            // PriceLbl
            // 
            PriceLbl.AutoSize = true;
            PriceLbl.Location = new Point(208, 199);
            PriceLbl.Name = "PriceLbl";
            PriceLbl.Size = new Size(204, 15);
            PriceLbl.TabIndex = 3;
            PriceLbl.Text = "Please enter the price for the new car:";
            // 
            // MakeTxtBox
            // 
            MakeTxtBox.Location = new Point(434, 72);
            MakeTxtBox.Name = "MakeTxtBox";
            MakeTxtBox.Size = new Size(96, 23);
            MakeTxtBox.TabIndex = 6;
            // 
            // ModelTxtBox
            // 
            ModelTxtBox.Location = new Point(434, 114);
            ModelTxtBox.Name = "ModelTxtBox";
            ModelTxtBox.Size = new Size(96, 23);
            ModelTxtBox.TabIndex = 7;
            // 
            // AddNewCarBtn
            // 
            AddNewCarBtn.Location = new Point(317, 263);
            AddNewCarBtn.Name = "AddNewCarBtn";
            AddNewCarBtn.Size = new Size(75, 23);
            AddNewCarBtn.TabIndex = 8;
            AddNewCarBtn.Text = "Add Car";
            AddNewCarBtn.UseVisualStyleBackColor = true;
            AddNewCarBtn.Click += AddNewCarBtn_Click;
            // 
            // MpgTxtBox
            // 
            MpgTxtBox.Location = new Point(434, 154);
            MpgTxtBox.Name = "MpgTxtBox";
            MpgTxtBox.Size = new Size(96, 23);
            MpgTxtBox.TabIndex = 9;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.Location = new Point(434, 196);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new Size(96, 23);
            PriceTxtBox.TabIndex = 10;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PriceTxtBox);
            Controls.Add(MpgTxtBox);
            Controls.Add(AddNewCarBtn);
            Controls.Add(ModelTxtBox);
            Controls.Add(MakeTxtBox);
            Controls.Add(PriceLbl);
            Controls.Add(MpgLbl);
            Controls.Add(ModelLbl);
            Controls.Add(MakeLbl);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MakeLbl;
        private Label ModelLbl;
        private Label MpgLbl;
        private Label PriceLbl;
        private TextBox MakeTxtBox;
        private TextBox ModelTxtBox;
        private Button AddNewCarBtn;
        private TextBox MpgTxtBox;
        private TextBox PriceTxtBox;
    }
}