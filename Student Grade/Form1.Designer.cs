/// <summary>
///  Design by Roeun SokHeng.
/// </summary>
namespace Student_Grade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtName = new TextBox();
            txtSSN = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtFinal = new TextBox();
            label3 = new Label();
            txtMidterm = new TextBox();
            btnEnter = new Button();
            btnDisplay = new Button();
            btnQuit = new Button();
            lstGrades = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(57, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(415, 23);
            txtName.TabIndex = 1;
            // 
            // txtSSN
            // 
            txtSSN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSSN.Location = new Point(40, 3);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(102, 23);
            txtSSN.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "SNN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(315, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Final";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFinal
            // 
            txtFinal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFinal.Location = new Point(353, 3);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(104, 23);
            txtFinal.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(148, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Midterm";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMidterm
            // 
            txtMidterm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMidterm.Location = new Point(207, 3);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.Size = new Size(102, 23);
            txtMidterm.TabIndex = 5;
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEnter.Location = new Point(3, 3);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(147, 48);
            btnEnter.TabIndex = 8;
            btnEnter.Text = "Enter Information";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDisplay.Location = new Point(156, 3);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(147, 48);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "Display Grade";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnQuit
            // 
            btnQuit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnQuit.Location = new Point(309, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(148, 48);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstGrades
            // 
            lstGrades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstGrades.FormattingEnabled = true;
            lstGrades.ItemHeight = 15;
            lstGrades.Location = new Point(12, 139);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(460, 154);
            lstGrades.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnQuit, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDisplay, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEnter, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 78);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(460, 56);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txtSSN, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(txtFinal, 5, 0);
            tableLayoutPanel2.Controls.Add(label4, 4, 0);
            tableLayoutPanel2.Controls.Add(txtMidterm, 3, 0);
            tableLayoutPanel2.Location = new Point(12, 41);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(460, 31);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 311);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lstGrades);
            Controls.Add(txtName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(500, 350);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Semester Grade";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtSSN;
        private Label label2;
        private Label label3;
        private TextBox txtMidterm;
        private Label label4;
        private TextBox txtFinal;
        private Button btnEnter;
        private Button btnDisplay;
        private Button btnQuit;
        private ListBox lstGrades;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}