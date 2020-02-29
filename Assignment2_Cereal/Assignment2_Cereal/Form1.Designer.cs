namespace Assignment2_Cereal
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
            this.SortButton = new System.Windows.Forms.Button();
            this.CerealDataGrid = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.CerealDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(817, 803);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(394, 95);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "button1";
            this.SortButton.UseVisualStyleBackColor = true;
            // 
            // CerealDataGrid
            // 
            this.CerealDataGrid.AllowUserToOrderColumns = true;
            this.CerealDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CerealDataGrid.Location = new System.Drawing.Point(12, 12);
            this.CerealDataGrid.Name = "CerealDataGrid";
            this.CerealDataGrid.Size = new System.Drawing.Size(1199, 475);
            this.CerealDataGrid.TabIndex = 1;
            this.CerealDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CerealDataGrid_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(207, 493);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1007, 304);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 493);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(188, 304);
            this.checkedListBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 910);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CerealDataGrid);
            this.Controls.Add(this.SortButton);
            this.Name = "Form1";
            this.Text = "Extreme Cereal Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CerealDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.DataGridView CerealDataGrid;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

