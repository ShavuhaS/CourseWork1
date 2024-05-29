namespace IntegralEvaluation
{
    partial class MainForm
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
            panel_Bg = new Panel();
            panel_Calculate = new Panel();
            button_Calculate = new Button();
            label_Integral = new Label();
            pictureBox_Integral = new PictureBox();
            flowLayoutPanel_Calculate = new FlowLayoutPanel();
            label_Method = new Label();
            comboBox_Method = new ComboBox();
            panel_MainContent = new Panel();
            label_AB_info = new Label();
            panel_B = new Panel();
            label_B_info = new Label();
            flowLayoutPanel_B = new FlowLayoutPanel();
            label_B = new Label();
            textBox_B = new TextBox();
            panel_A = new Panel();
            label_A_info = new Label();
            flowLayoutPanel_A = new FlowLayoutPanel();
            label_A = new Label();
            textBox_A = new TextBox();
            flowLayoutPanel_Interval = new FlowLayoutPanel();
            label_Interval = new Label();
            textBox_Interval = new TextBox();
            flowLayoutPanel_Formula = new FlowLayoutPanel();
            label_Formula = new Label();
            textBox_Formula = new TextBox();
            pictureBox_FormulaGuide = new PictureBox();
            panel_Title = new Panel();
            label_Title = new Label();
            panel_Bg.SuspendLayout();
            panel_Calculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Integral).BeginInit();
            flowLayoutPanel_Calculate.SuspendLayout();
            panel_MainContent.SuspendLayout();
            panel_B.SuspendLayout();
            flowLayoutPanel_B.SuspendLayout();
            panel_A.SuspendLayout();
            flowLayoutPanel_A.SuspendLayout();
            flowLayoutPanel_Interval.SuspendLayout();
            flowLayoutPanel_Formula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_FormulaGuide).BeginInit();
            panel_Title.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Bg
            // 
            panel_Bg.BackgroundImage = Properties.Resources.random_number_gradient_pastel_math_background_vector;
            panel_Bg.BackgroundImageLayout = ImageLayout.Center;
            panel_Bg.Controls.Add(panel_Calculate);
            panel_Bg.Controls.Add(panel_MainContent);
            panel_Bg.Controls.Add(panel_Title);
            panel_Bg.Dock = DockStyle.Fill;
            panel_Bg.Location = new Point(0, 0);
            panel_Bg.Margin = new Padding(0);
            panel_Bg.Name = "panel_Bg";
            panel_Bg.Size = new Size(784, 561);
            panel_Bg.TabIndex = 0;
            // 
            // panel_Calculate
            // 
            panel_Calculate.Anchor = AnchorStyles.None;
            panel_Calculate.BackColor = Color.CadetBlue;
            panel_Calculate.BorderStyle = BorderStyle.FixedSingle;
            panel_Calculate.Controls.Add(button_Calculate);
            panel_Calculate.Controls.Add(label_Integral);
            panel_Calculate.Controls.Add(pictureBox_Integral);
            panel_Calculate.Controls.Add(flowLayoutPanel_Calculate);
            panel_Calculate.Location = new Point(160, 413);
            panel_Calculate.Name = "panel_Calculate";
            panel_Calculate.Size = new Size(469, 121);
            panel_Calculate.TabIndex = 4;
            // 
            // button_Calculate
            // 
            button_Calculate.Anchor = AnchorStyles.None;
            button_Calculate.BackColor = Color.LightBlue;
            button_Calculate.Cursor = Cursors.Hand;
            button_Calculate.Font = new Font("Lucida Fax", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_Calculate.Location = new Point(210, 59);
            button_Calculate.Name = "button_Calculate";
            button_Calculate.Size = new Size(196, 47);
            button_Calculate.TabIndex = 6;
            button_Calculate.Text = "Обчислити";
            button_Calculate.UseVisualStyleBackColor = false;
            button_Calculate.Click += button_Calculate_Click;
            // 
            // label_Integral
            // 
            label_Integral.Anchor = AnchorStyles.None;
            label_Integral.AutoSize = true;
            label_Integral.Font = new Font("Lucida Fax", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_Integral.Location = new Point(177, 69);
            label_Integral.Name = "label_Integral";
            label_Integral.Size = new Size(27, 27);
            label_Integral.TabIndex = 5;
            label_Integral.Text = "=";
            // 
            // pictureBox_Integral
            // 
            pictureBox_Integral.Image = Properties.Resources.integral;
            pictureBox_Integral.InitialImage = null;
            pictureBox_Integral.Location = new Point(80, 49);
            pictureBox_Integral.Name = "pictureBox_Integral";
            pictureBox_Integral.Size = new Size(110, 72);
            pictureBox_Integral.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Integral.TabIndex = 0;
            pictureBox_Integral.TabStop = false;
            // 
            // flowLayoutPanel_Calculate
            // 
            flowLayoutPanel_Calculate.Controls.Add(label_Method);
            flowLayoutPanel_Calculate.Controls.Add(comboBox_Method);
            flowLayoutPanel_Calculate.Dock = DockStyle.Top;
            flowLayoutPanel_Calculate.Location = new Point(0, 0);
            flowLayoutPanel_Calculate.Name = "flowLayoutPanel_Calculate";
            flowLayoutPanel_Calculate.Size = new Size(467, 49);
            flowLayoutPanel_Calculate.TabIndex = 4;
            // 
            // label_Method
            // 
            label_Method.Anchor = AnchorStyles.None;
            label_Method.BackColor = Color.Transparent;
            label_Method.Font = new Font("Lucida Fax", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Method.Location = new Point(3, 5);
            label_Method.Name = "label_Method";
            label_Method.Size = new Size(107, 33);
            label_Method.TabIndex = 1;
            label_Method.Text = "Метод: ";
            // 
            // comboBox_Method
            // 
            comboBox_Method.BackColor = Color.LightBlue;
            comboBox_Method.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Method.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Method.FormattingEnabled = true;
            comboBox_Method.Items.AddRange(new object[] { "Метод прямокутників", "Метод трапецій", "Метод Сімпсона" });
            comboBox_Method.Location = new Point(116, 3);
            comboBox_Method.Name = "comboBox_Method";
            comboBox_Method.Size = new Size(291, 38);
            comboBox_Method.TabIndex = 2;
            // 
            // panel_MainContent
            // 
            panel_MainContent.Anchor = AnchorStyles.None;
            panel_MainContent.BackColor = Color.CadetBlue;
            panel_MainContent.BorderStyle = BorderStyle.FixedSingle;
            panel_MainContent.Controls.Add(label_AB_info);
            panel_MainContent.Controls.Add(panel_B);
            panel_MainContent.Controls.Add(panel_A);
            panel_MainContent.Controls.Add(flowLayoutPanel_Interval);
            panel_MainContent.Controls.Add(flowLayoutPanel_Formula);
            panel_MainContent.Location = new Point(12, 112);
            panel_MainContent.MinimumSize = new Size(700, 270);
            panel_MainContent.Name = "panel_MainContent";
            panel_MainContent.Size = new Size(760, 270);
            panel_MainContent.TabIndex = 3;
            // 
            // label_AB_info
            // 
            label_AB_info.Anchor = AnchorStyles.None;
            label_AB_info.AutoSize = true;
            label_AB_info.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_AB_info.Location = new Point(368, 180);
            label_AB_info.Name = "label_AB_info";
            label_AB_info.Size = new Size(47, 18);
            label_AB_info.TabIndex = 8;
            label_AB_info.Text = "a < b";
            // 
            // panel_B
            // 
            panel_B.Controls.Add(label_B_info);
            panel_B.Controls.Add(flowLayoutPanel_B);
            panel_B.Location = new Point(437, 111);
            panel_B.Name = "panel_B";
            panel_B.Size = new Size(307, 73);
            panel_B.TabIndex = 7;
            // 
            // label_B_info
            // 
            label_B_info.Dock = DockStyle.Top;
            label_B_info.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_B_info.ImageAlign = ContentAlignment.TopCenter;
            label_B_info.Location = new Point(0, 51);
            label_B_info.Margin = new Padding(10, 0, 10, 0);
            label_B_info.Name = "label_B_info";
            label_B_info.Size = new Size(307, 22);
            label_B_info.TabIndex = 4;
            label_B_info.Text = "1e-6 <= |b| <= 1000 або b = 0";
            label_B_info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_B
            // 
            flowLayoutPanel_B.Controls.Add(label_B);
            flowLayoutPanel_B.Controls.Add(textBox_B);
            flowLayoutPanel_B.Dock = DockStyle.Top;
            flowLayoutPanel_B.Location = new Point(0, 0);
            flowLayoutPanel_B.Name = "flowLayoutPanel_B";
            flowLayoutPanel_B.Size = new Size(307, 51);
            flowLayoutPanel_B.TabIndex = 3;
            // 
            // label_B
            // 
            label_B.Anchor = AnchorStyles.None;
            label_B.BackColor = Color.Transparent;
            label_B.Font = new Font("Lucida Fax", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_B.Location = new Point(3, 4);
            label_B.Name = "label_B";
            label_B.Size = new Size(57, 33);
            label_B.TabIndex = 1;
            label_B.Text = "b =";
            // 
            // textBox_B
            // 
            textBox_B.Anchor = AnchorStyles.None;
            textBox_B.BackColor = Color.LightBlue;
            textBox_B.Font = new Font("Lucida Fax", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_B.ForeColor = Color.Gray;
            textBox_B.Location = new Point(66, 3);
            textBox_B.MaxLength = 60;
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(227, 36);
            textBox_B.TabIndex = 3;
            textBox_B.Enter += textBox_B_Enter;
            textBox_B.Leave += textBox_B_Leave;
            // 
            // panel_A
            // 
            panel_A.Controls.Add(label_A_info);
            panel_A.Controls.Add(flowLayoutPanel_A);
            panel_A.Location = new Point(24, 111);
            panel_A.Name = "panel_A";
            panel_A.Size = new Size(313, 73);
            panel_A.TabIndex = 6;
            // 
            // label_A_info
            // 
            label_A_info.Dock = DockStyle.Top;
            label_A_info.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_A_info.ImageAlign = ContentAlignment.TopCenter;
            label_A_info.Location = new Point(0, 51);
            label_A_info.Margin = new Padding(0);
            label_A_info.Name = "label_A_info";
            label_A_info.Size = new Size(313, 22);
            label_A_info.TabIndex = 4;
            label_A_info.Text = "1e-6 <= |a| <= 1000 або a= 0";
            label_A_info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_A
            // 
            flowLayoutPanel_A.Controls.Add(label_A);
            flowLayoutPanel_A.Controls.Add(textBox_A);
            flowLayoutPanel_A.Dock = DockStyle.Top;
            flowLayoutPanel_A.Location = new Point(0, 0);
            flowLayoutPanel_A.Name = "flowLayoutPanel_A";
            flowLayoutPanel_A.Size = new Size(313, 51);
            flowLayoutPanel_A.TabIndex = 3;
            // 
            // label_A
            // 
            label_A.Anchor = AnchorStyles.None;
            label_A.BackColor = Color.Transparent;
            label_A.Font = new Font("Lucida Fax", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_A.Location = new Point(3, 4);
            label_A.Name = "label_A";
            label_A.Size = new Size(56, 33);
            label_A.TabIndex = 1;
            label_A.Text = "a =";
            // 
            // textBox_A
            // 
            textBox_A.Anchor = AnchorStyles.None;
            textBox_A.BackColor = Color.LightBlue;
            textBox_A.Font = new Font("Lucida Fax", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_A.ForeColor = Color.Gray;
            textBox_A.Location = new Point(65, 3);
            textBox_A.MaxLength = 60;
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(227, 36);
            textBox_A.TabIndex = 2;
            textBox_A.Enter += textBox_A_Enter;
            textBox_A.Leave += textBox_A_Leave;
            // 
            // flowLayoutPanel_Interval
            // 
            flowLayoutPanel_Interval.Anchor = AnchorStyles.Top;
            flowLayoutPanel_Interval.BackColor = Color.Transparent;
            flowLayoutPanel_Interval.Controls.Add(label_Interval);
            flowLayoutPanel_Interval.Controls.Add(textBox_Interval);
            flowLayoutPanel_Interval.Location = new Point(23, 211);
            flowLayoutPanel_Interval.Name = "flowLayoutPanel_Interval";
            flowLayoutPanel_Interval.Size = new Size(721, 54);
            flowLayoutPanel_Interval.TabIndex = 5;
            // 
            // label_Interval
            // 
            label_Interval.Anchor = AnchorStyles.None;
            label_Interval.BackColor = Color.Transparent;
            label_Interval.Font = new Font("Lucida Fax", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Interval.Location = new Point(3, 6);
            label_Interval.Name = "label_Interval";
            label_Interval.Size = new Size(556, 33);
            label_Interval.TabIndex = 1;
            label_Interval.Text = "Кількість проміжків (точність, [1; 1000]) =";
            // 
            // textBox_Interval
            // 
            textBox_Interval.Anchor = AnchorStyles.None;
            textBox_Interval.BackColor = Color.LightBlue;
            textBox_Interval.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Interval.ForeColor = Color.Black;
            textBox_Interval.Location = new Point(565, 3);
            textBox_Interval.MaxLength = 60;
            textBox_Interval.Name = "textBox_Interval";
            textBox_Interval.Size = new Size(95, 39);
            textBox_Interval.TabIndex = 4;
            textBox_Interval.Enter += textBox_Interval_Enter;
            // 
            // flowLayoutPanel_Formula
            // 
            flowLayoutPanel_Formula.BackColor = Color.Transparent;
            flowLayoutPanel_Formula.Controls.Add(label_Formula);
            flowLayoutPanel_Formula.Controls.Add(textBox_Formula);
            flowLayoutPanel_Formula.Controls.Add(pictureBox_FormulaGuide);
            flowLayoutPanel_Formula.Location = new Point(24, 32);
            flowLayoutPanel_Formula.Name = "flowLayoutPanel_Formula";
            flowLayoutPanel_Formula.Size = new Size(720, 54);
            flowLayoutPanel_Formula.TabIndex = 2;
            // 
            // label_Formula
            // 
            label_Formula.Anchor = AnchorStyles.None;
            label_Formula.BackColor = Color.Transparent;
            label_Formula.Font = new Font("Lucida Fax", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_Formula.Location = new Point(3, 7);
            label_Formula.Name = "label_Formula";
            label_Formula.Size = new Size(91, 33);
            label_Formula.TabIndex = 1;
            label_Formula.Text = "f(x) =";
            // 
            // textBox_Formula
            // 
            textBox_Formula.Anchor = AnchorStyles.None;
            textBox_Formula.BackColor = Color.LightBlue;
            textBox_Formula.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Formula.ForeColor = Color.Black;
            textBox_Formula.Location = new Point(100, 4);
            textBox_Formula.MaxLength = 50;
            textBox_Formula.Name = "textBox_Formula";
            textBox_Formula.Size = new Size(544, 39);
            textBox_Formula.TabIndex = 1;
            textBox_Formula.Enter += textBox_Formula_Enter;
            textBox_Formula.Leave += textBox_Formula_Leave;
            // 
            // pictureBox_FormulaGuide
            // 
            pictureBox_FormulaGuide.Cursor = Cursors.Hand;
            pictureBox_FormulaGuide.Image = Properties.Resources.question_mark_svg;
            pictureBox_FormulaGuide.Location = new Point(650, 3);
            pictureBox_FormulaGuide.Name = "pictureBox_FormulaGuide";
            pictureBox_FormulaGuide.Size = new Size(58, 42);
            pictureBox_FormulaGuide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_FormulaGuide.TabIndex = 9;
            pictureBox_FormulaGuide.TabStop = false;
            pictureBox_FormulaGuide.Click += pictureBox_FormulaGuide_Click;
            // 
            // panel_Title
            // 
            panel_Title.BackColor = Color.CadetBlue;
            panel_Title.BackgroundImageLayout = ImageLayout.None;
            panel_Title.Controls.Add(label_Title);
            panel_Title.Dock = DockStyle.Top;
            panel_Title.Location = new Point(0, 0);
            panel_Title.Name = "panel_Title";
            panel_Title.Size = new Size(784, 68);
            panel_Title.TabIndex = 0;
            // 
            // label_Title
            // 
            label_Title.BorderStyle = BorderStyle.FixedSingle;
            label_Title.Dock = DockStyle.Fill;
            label_Title.Font = new Font("Lucida Fax", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label_Title.Location = new Point(0, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(784, 68);
            label_Title.TabIndex = 0;
            label_Title.Text = "Чисельне обчислення інтегралів";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel_Bg);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Чисельне обчислення інтегралів";
            panel_Bg.ResumeLayout(false);
            panel_Calculate.ResumeLayout(false);
            panel_Calculate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Integral).EndInit();
            flowLayoutPanel_Calculate.ResumeLayout(false);
            panel_MainContent.ResumeLayout(false);
            panel_MainContent.PerformLayout();
            panel_B.ResumeLayout(false);
            flowLayoutPanel_B.ResumeLayout(false);
            flowLayoutPanel_B.PerformLayout();
            panel_A.ResumeLayout(false);
            flowLayoutPanel_A.ResumeLayout(false);
            flowLayoutPanel_A.PerformLayout();
            flowLayoutPanel_Interval.ResumeLayout(false);
            flowLayoutPanel_Interval.PerformLayout();
            flowLayoutPanel_Formula.ResumeLayout(false);
            flowLayoutPanel_Formula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_FormulaGuide).EndInit();
            panel_Title.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_formula;
        private Button button_Calculate;
        private Label label_fx;
        private Label label_X;
        private TextBox textBox_x;
        private Panel panel_Bg;
        private Panel panel_Title;
        private Label label_Title;
        private Label label_Formula;
        private FlowLayoutPanel flowLayoutPanel_Formula;
        private TextBox textBox_Formula;
        private Panel panel_MainContent;
        private Label label_A;
        private TextBox textBox_A;
        private FlowLayoutPanel flowLayoutPanel_Interval;
        private Label label_Interval;
        private TextBox textBox_Interval;
        private Panel panel_Calculate;
        private FlowLayoutPanel flowLayoutPanel_A;
        private Panel panel_A;
        private Label label_A_info;
        private Panel panel_B;
        private Label label_B_info;
        private FlowLayoutPanel flowLayoutPanel_B;
        private Label label_B;
        private TextBox textBox_B;
        private Label label_AB_info;
        private FlowLayoutPanel flowLayoutPanel_Calculate;
        private Label label_Method;
        private ComboBox comboBox_Method;
        private PictureBox pictureBox_Integral;
        private Label label_Integral;
        private PictureBox pictureBox_FormulaGuide;
    }
}
