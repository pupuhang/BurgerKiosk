namespace BurgerKiosk
{
    partial class Form1
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
            lblTitle = new Label();
            grpMenu = new GroupBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grpOrder = new GroupBox();
            lstOrder = new ListBox();
            lblTotalCost = new Label();
            btnOrder = new Button();
            btnReset = new Button();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(25, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(139, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Location = new Point(25, 76);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(144, 242);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Location = new Point(7, 191);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(90, 24);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Location = new Point(6, 108);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(105, 24);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Location = new Point(12, 27);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(75, 24);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Location = new Point(296, 76);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(103, 242);
            grpOption.TabIndex = 2;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Location = new Point(3, 191);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(96, 24);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(1, 138);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(96, 24);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Location = new Point(1, 85);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(61, 24);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Location = new Point(3, 32);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(91, 24);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Location = new Point(467, 76);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(304, 242);
            grpOrder.TabIndex = 3;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(10, 32);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(277, 184);
            lstOrder.TabIndex = 0;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(482, 336);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(90, 20);
            lblTotalCost.TabIndex = 4;
            lblTotalCost.Text = "총 금액: 0원";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(482, 388);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(636, 391);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(lblTotalCost);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "BurgerKiosk";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpMenu;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private GroupBox grpOption;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
        private GroupBox grpOrder;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnReset;
    }
}
