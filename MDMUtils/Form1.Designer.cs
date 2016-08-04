namespace MDMUtils
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.accountList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchAccountButton = new System.Windows.Forms.Button();
            this.inputJDA = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.accountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.accountList);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchAccountButton);
            this.tabPage1.Controls.Add(this.inputJDA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // accountList
            // 
            this.accountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountName,
            this.typeAccount});
            this.accountList.Location = new System.Drawing.Point(12, 61);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(793, 331);
            this.accountList.TabIndex = 3;
            this.accountList.UseCompatibleStateImageBehavior = false;
            this.accountList.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "JDA";
            // 
            // searchAccountButton
            // 
            this.searchAccountButton.Location = new System.Drawing.Point(617, 6);
            this.searchAccountButton.Name = "searchAccountButton";
            this.searchAccountButton.Size = new System.Drawing.Size(188, 23);
            this.searchAccountButton.TabIndex = 1;
            this.searchAccountButton.Text = "Search";
            this.searchAccountButton.UseVisualStyleBackColor = true;
            this.searchAccountButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputJDA
            // 
            this.inputJDA.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputJDA.Location = new System.Drawing.Point(199, 9);
            this.inputJDA.Name = "inputJDA";
            this.inputJDA.Size = new System.Drawing.Size(208, 20);
            this.inputJDA.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // accountName
            // 
            this.accountName.Text = "Account";
            this.accountName.Width = 174;
            // 
            // typeAccount
            // 
            this.typeAccount.Text = "Type";
            this.typeAccount.Width = 251;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 426);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MDM Account Tools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button searchAccountButton;
        private System.Windows.Forms.TextBox inputJDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView accountList;
        private System.Windows.Forms.ColumnHeader accountName;
        private System.Windows.Forms.ColumnHeader typeAccount;
    }
}

