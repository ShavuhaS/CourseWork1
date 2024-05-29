namespace IntegralEvaluation
{
    partial class GuideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuideForm));
            panel_BG = new Panel();
            tableLayoutPanel_Rules = new TableLayoutPanel();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel_Rule4 = new Panel();
            label_Rule4 = new Label();
            panel_Rule3 = new Panel();
            label_Rule3 = new Label();
            panel_Rule2 = new Panel();
            label_Rule2 = new Label();
            panel_Rule1 = new Panel();
            label_Rule1 = new Label();
            panel_Title = new Panel();
            label_Title = new Label();
            panel_BG.SuspendLayout();
            tableLayoutPanel_Rules.SuspendLayout();
            panel_Rule4.SuspendLayout();
            panel_Rule3.SuspendLayout();
            panel_Rule2.SuspendLayout();
            panel_Rule1.SuspendLayout();
            panel_Title.SuspendLayout();
            SuspendLayout();
            // 
            // panel_BG
            // 
            panel_BG.BackColor = Color.DarkCyan;
            panel_BG.Controls.Add(tableLayoutPanel_Rules);
            panel_BG.Controls.Add(panel_Rule4);
            panel_BG.Controls.Add(panel_Rule3);
            panel_BG.Controls.Add(panel_Rule2);
            panel_BG.Controls.Add(panel_Rule1);
            panel_BG.Controls.Add(panel_Title);
            panel_BG.Dock = DockStyle.Fill;
            panel_BG.Location = new Point(0, 0);
            panel_BG.Name = "panel_BG";
            panel_BG.Size = new Size(784, 561);
            panel_BG.TabIndex = 0;
            // 
            // tableLayoutPanel_Rules
            // 
            tableLayoutPanel_Rules.ColumnCount = 2;
            tableLayoutPanel_Rules.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Rules.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Rules.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel_Rules.Controls.Add(label2, 1, 0);
            tableLayoutPanel_Rules.Controls.Add(label1, 0, 0);
            tableLayoutPanel_Rules.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel_Rules.Dock = DockStyle.Fill;
            tableLayoutPanel_Rules.Location = new Point(0, 244);
            tableLayoutPanel_Rules.Name = "tableLayoutPanel_Rules";
            tableLayoutPanel_Rules.RowCount = 2;
            tableLayoutPanel_Rules.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Rules.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel_Rules.Size = new Size(784, 317);
            tableLayoutPanel_Rules.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.BackColor = Color.DarkCyan;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(392, 63);
            textBox2.Margin = new Padding(0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(392, 254);
            textBox2.TabIndex = 3;
            textBox2.TabStop = false;
            textBox2.Text = resources.GetString("textBox2.Text");
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Lucida Fax", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(392, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(392, 63);
            label2.TabIndex = 1;
            label2.Text = "Функції:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Lucida Fax", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(392, 63);
            label1.TabIndex = 0;
            label1.Text = "Операції:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkCyan;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 63);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(392, 254);
            textBox1.TabIndex = 2;
            textBox1.TabStop = false;
            textBox1.Text = "\"+\"    —    Додавання\r\n\"-\"     —    Віднімання або унарний мінус\r\n\"*\"     —    Множення\r\n\"/\"     —    Ділення\r\n\"()\"    —    Пріоритет операцій (дужки)";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel_Rule4
            // 
            panel_Rule4.Controls.Add(label_Rule4);
            panel_Rule4.Dock = DockStyle.Top;
            panel_Rule4.Location = new Point(0, 184);
            panel_Rule4.Name = "panel_Rule4";
            panel_Rule4.Size = new Size(784, 60);
            panel_Rule4.TabIndex = 3;
            // 
            // label_Rule4
            // 
            label_Rule4.Dock = DockStyle.Fill;
            label_Rule4.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_Rule4.Location = new Point(0, 0);
            label_Rule4.Name = "label_Rule4";
            label_Rule4.Size = new Size(784, 60);
            label_Rule4.TabIndex = 0;
            label_Rule4.Text = "Приклад формули: sqrt(x) - (3 + 2)*6 - pow(x, (2 + 4) / 3)";
            label_Rule4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Rule3
            // 
            panel_Rule3.Controls.Add(label_Rule3);
            panel_Rule3.Dock = DockStyle.Top;
            panel_Rule3.Location = new Point(0, 144);
            panel_Rule3.Name = "panel_Rule3";
            panel_Rule3.Size = new Size(784, 40);
            panel_Rule3.TabIndex = 5;
            // 
            // label_Rule3
            // 
            label_Rule3.Dock = DockStyle.Fill;
            label_Rule3.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_Rule3.Location = new Point(0, 0);
            label_Rule3.Name = "label_Rule3";
            label_Rule3.Size = new Size(784, 40);
            label_Rule3.TabIndex = 4;
            label_Rule3.Text = "- Доступні константи: число Пі (\"pi\") і число Ейлера (\"e\")";
            label_Rule3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Rule2
            // 
            panel_Rule2.Controls.Add(label_Rule2);
            panel_Rule2.Dock = DockStyle.Top;
            panel_Rule2.Location = new Point(0, 94);
            panel_Rule2.Name = "panel_Rule2";
            panel_Rule2.Size = new Size(784, 50);
            panel_Rule2.TabIndex = 2;
            // 
            // label_Rule2
            // 
            label_Rule2.Dock = DockStyle.Fill;
            label_Rule2.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_Rule2.Location = new Point(0, 0);
            label_Rule2.Name = "label_Rule2";
            label_Rule2.Size = new Size(784, 50);
            label_Rule2.TabIndex = 3;
            label_Rule2.Text = "- Дозволено вводити числа, константи, операції, функції, дужки та змінну \"x\" в нижньому регістрі";
            label_Rule2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Rule1
            // 
            panel_Rule1.BackColor = Color.Transparent;
            panel_Rule1.Controls.Add(label_Rule1);
            panel_Rule1.Dock = DockStyle.Top;
            panel_Rule1.Location = new Point(0, 54);
            panel_Rule1.Name = "panel_Rule1";
            panel_Rule1.Size = new Size(784, 40);
            panel_Rule1.TabIndex = 1;
            // 
            // label_Rule1
            // 
            label_Rule1.Dock = DockStyle.Fill;
            label_Rule1.Font = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_Rule1.Location = new Point(0, 0);
            label_Rule1.Name = "label_Rule1";
            label_Rule1.Size = new Size(784, 40);
            label_Rule1.TabIndex = 0;
            label_Rule1.Text = "- Введення дробових чисел відбувається через крапку, а не кому (наприклад, 3.5)";
            label_Rule1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Title
            // 
            panel_Title.BackColor = Color.CadetBlue;
            panel_Title.Controls.Add(label_Title);
            panel_Title.Dock = DockStyle.Top;
            panel_Title.Location = new Point(0, 0);
            panel_Title.Name = "panel_Title";
            panel_Title.Size = new Size(784, 54);
            panel_Title.TabIndex = 0;
            // 
            // label_Title
            // 
            label_Title.Dock = DockStyle.Fill;
            label_Title.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.Location = new Point(0, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(784, 54);
            label_Title.TabIndex = 0;
            label_Title.Text = "Правила введення формули";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuideForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel_BG);
            Name = "GuideForm";
            Text = "Правила введення формули";
            panel_BG.ResumeLayout(false);
            tableLayoutPanel_Rules.ResumeLayout(false);
            tableLayoutPanel_Rules.PerformLayout();
            panel_Rule4.ResumeLayout(false);
            panel_Rule3.ResumeLayout(false);
            panel_Rule2.ResumeLayout(false);
            panel_Rule1.ResumeLayout(false);
            panel_Title.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_BG;
        private Panel panel_Title;
        private Label label_Title;
        private Panel panel_Rule1;
        private Label label_Rule1;
        private Panel panel_Rule2;
        private Label label_Rule2;
        private Panel panel_Rule4;
        private Label label_Rule4;
        private TableLayoutPanel tableLayoutPanel_Rules;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel_Rule3;
        private Label label_Rule3;
    }
}