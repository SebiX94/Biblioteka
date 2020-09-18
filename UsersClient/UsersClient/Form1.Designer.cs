namespace UsersClient
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.BirthDay = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BooksGrid = new System.Windows.Forms.DataGridView();
            this.LoansTab = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LoanGrid = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.UserBinding = new System.Windows.Forms.BindingSource(this.components);
            this.Tabs.SuspendLayout();
            this.UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).BeginInit();
            this.LoansTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.UsersTab);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.LoansTab);
            this.Tabs.Location = new System.Drawing.Point(1, 4);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1049, 546);
            this.Tabs.TabIndex = 2;
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.button8);
            this.UsersTab.Controls.Add(this.BirthDay);
            this.UsersTab.Controls.Add(this.button2);
            this.UsersTab.Controls.Add(this.button1);
            this.UsersTab.Controls.Add(this.label4);
            this.UsersTab.Controls.Add(this.label2);
            this.UsersTab.Controls.Add(this.label1);
            this.UsersTab.Controls.Add(this.LastNameBox);
            this.UsersTab.Controls.Add(this.NameBox);
            this.UsersTab.Controls.Add(this.UsersDataGrid);
            this.UsersTab.Location = new System.Drawing.Point(4, 25);
            this.UsersTab.Margin = new System.Windows.Forms.Padding(4);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(4);
            this.UsersTab.Size = new System.Drawing.Size(1041, 517);
            this.UsersTab.TabIndex = 0;
            this.UsersTab.Text = "Czytelnicy";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // BirthDay
            // 
            this.BirthDay.Location = new System.Drawing.Point(616, 289);
            this.BirthDay.Margin = new System.Windows.Forms.Padding(4);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(265, 22);
            this.BirthDay.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 321);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Nowy Czytelnik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data urodzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imię";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(616, 218);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(248, 22);
            this.LastNameBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(616, 186);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(248, 22);
            this.NameBox.TabIndex = 4;
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Location = new System.Drawing.Point(9, 7);
            this.UsersDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.RowHeadersWidth = 51;
            this.UsersDataGrid.Size = new System.Drawing.Size(489, 450);
            this.UsersDataGrid.TabIndex = 3;
            this.UsersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGrid_CellContentClick);
            this.UsersDataGrid.DoubleClick += new System.EventHandler(this.UsersDataGrid_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.BooksGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1041, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Książki";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kategoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tytuł";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(681, 137);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Nowa ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(868, 137);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(681, 105);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(328, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(681, 73);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(681, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 22);
            this.textBox1.TabIndex = 5;
            // 
            // BooksGrid
            // 
            this.BooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGrid.Location = new System.Drawing.Point(8, 4);
            this.BooksGrid.Margin = new System.Windows.Forms.Padding(4);
            this.BooksGrid.Name = "BooksGrid";
            this.BooksGrid.RowHeadersWidth = 51;
            this.BooksGrid.Size = new System.Drawing.Size(489, 450);
            this.BooksGrid.TabIndex = 4;
            this.BooksGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksGrid_CellContentClick);
            // 
            // LoansTab
            // 
            this.LoansTab.Controls.Add(this.button5);
            this.LoansTab.Controls.Add(this.button7);
            this.LoansTab.Controls.Add(this.button6);
            this.LoansTab.Controls.Add(this.label9);
            this.LoansTab.Controls.Add(this.label8);
            this.LoansTab.Controls.Add(this.comboBox2);
            this.LoansTab.Controls.Add(this.comboBox1);
            this.LoansTab.Controls.Add(this.LoanGrid);
            this.LoansTab.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoansTab.Location = new System.Drawing.Point(4, 25);
            this.LoansTab.Margin = new System.Windows.Forms.Padding(4);
            this.LoansTab.Name = "LoansTab";
            this.LoansTab.Padding = new System.Windows.Forms.Padding(4);
            this.LoansTab.Size = new System.Drawing.Size(1041, 517);
            this.LoansTab.TabIndex = 2;
            this.LoansTab.Text = "Wypożyczenia";
            this.LoansTab.UseVisualStyleBackColor = true;
            this.LoansTab.Click += new System.EventHandler(this.LoansTab_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(896, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 34);
            this.button7.TabIndex = 6;
            this.button7.Text = "Zwróć Książkę";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(928, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "Wypożycz";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(843, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Książka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(843, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Czytelnik";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(913, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(913, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // LoanGrid
            // 
            this.LoanGrid.AllowUserToAddRows = false;
            this.LoanGrid.AllowUserToDeleteRows = false;
            this.LoanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoanGrid.Location = new System.Drawing.Point(7, 7);
            this.LoanGrid.Name = "LoanGrid";
            this.LoanGrid.ReadOnly = true;
            this.LoanGrid.RowHeadersWidth = 51;
            this.LoanGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.LoanGrid.RowTemplate.Height = 24;
            this.LoanGrid.Size = new System.Drawing.Size(455, 503);
            this.LoanGrid.TabIndex = 0;
            this.LoanGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanGrid_CellContentClick);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(739, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "Nowe Wypożyczenie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(616, 395);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 38);
            this.button8.TabIndex = 15;
            this.button8.Text = "Usuń";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // UserBinding
            // 
            this.UserBinding.DataSource = typeof(UsersClient.Users);
            this.UserBinding.CurrentChanged += new System.EventHandler(this.UserBinding_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.Tabs.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.UsersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).EndInit();
            this.LoansTab.ResumeLayout(false);
            this.LoansTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource UserBinding;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage LoansTab;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker BirthDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView BooksGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView LoanGrid;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
    }
}

