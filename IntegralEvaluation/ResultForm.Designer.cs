namespace IntegralEvaluation
{
    partial class ResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel_BG = new Panel();
            tableLayoutPanel_MainContent = new TableLayoutPanel();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            flowLayoutPanel_Result = new FlowLayoutPanel();
            pictureBox_Integral = new PictureBox();
            label_Equals = new Label();
            textBox_Result = new TextBox();
            flowLayoutPanel_Buttons = new FlowLayoutPanel();
            button_SaveAsText = new Button();
            label_Complexity = new Label();
            label_ResultComplexity = new Label();
            panel_Title = new Panel();
            label_Title = new Label();
            panel_BG.SuspendLayout();
            tableLayoutPanel_MainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            flowLayoutPanel_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Integral).BeginInit();
            flowLayoutPanel_Buttons.SuspendLayout();
            panel_Title.SuspendLayout();
            SuspendLayout();
            // 
            // panel_BG
            // 
            panel_BG.BackColor = Color.DarkCyan;
            panel_BG.Controls.Add(tableLayoutPanel_MainContent);
            panel_BG.Controls.Add(panel_Title);
            panel_BG.Dock = DockStyle.Fill;
            panel_BG.Location = new Point(0, 0);
            panel_BG.Name = "panel_BG";
            panel_BG.Size = new Size(784, 561);
            panel_BG.TabIndex = 0;
            // 
            // tableLayoutPanel_MainContent
            // 
            tableLayoutPanel_MainContent.ColumnCount = 1;
            tableLayoutPanel_MainContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_MainContent.Controls.Add(chart, 0, 1);
            tableLayoutPanel_MainContent.Controls.Add(flowLayoutPanel_Result, 0, 0);
            tableLayoutPanel_MainContent.Controls.Add(flowLayoutPanel_Buttons, 0, 2);
            tableLayoutPanel_MainContent.Dock = DockStyle.Fill;
            tableLayoutPanel_MainContent.Location = new Point(0, 50);
            tableLayoutPanel_MainContent.Name = "tableLayoutPanel_MainContent";
            tableLayoutPanel_MainContent.RowCount = 3;
            tableLayoutPanel_MainContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel_MainContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_MainContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel_MainContent.Size = new Size(784, 511);
            tableLayoutPanel_MainContent.TabIndex = 1;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(3, 83);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = Color.FromArgb(255, 128, 0);
            series1.Legend = "Legend1";
            series1.Name = "Наближена функція";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = Color.MediumBlue;
            series2.Legend = "Legend1";
            series2.Name = "Функція";
            chart.Series.Add(series1);
            chart.Series.Add(series2);
            chart.Size = new Size(778, 375);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            // 
            // flowLayoutPanel_Result
            // 
            flowLayoutPanel_Result.Anchor = AnchorStyles.Top;
            flowLayoutPanel_Result.Controls.Add(pictureBox_Integral);
            flowLayoutPanel_Result.Controls.Add(label_Equals);
            flowLayoutPanel_Result.Controls.Add(textBox_Result);
            flowLayoutPanel_Result.Location = new Point(152, 3);
            flowLayoutPanel_Result.Name = "flowLayoutPanel_Result";
            flowLayoutPanel_Result.Size = new Size(480, 74);
            flowLayoutPanel_Result.TabIndex = 1;
            // 
            // pictureBox_Integral
            // 
            pictureBox_Integral.Anchor = AnchorStyles.Left;
            pictureBox_Integral.Image = Properties.Resources.integral;
            pictureBox_Integral.Location = new Point(3, 3);
            pictureBox_Integral.Name = "pictureBox_Integral";
            pictureBox_Integral.Size = new Size(95, 72);
            pictureBox_Integral.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Integral.TabIndex = 0;
            pictureBox_Integral.TabStop = false;
            // 
            // label_Equals
            // 
            label_Equals.Anchor = AnchorStyles.Left;
            label_Equals.Font = new Font("Lucida Fax", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Equals.Location = new Point(104, 6);
            label_Equals.Margin = new Padding(3);
            label_Equals.Name = "label_Equals";
            label_Equals.Size = new Size(26, 66);
            label_Equals.TabIndex = 1;
            label_Equals.Text = "=";
            label_Equals.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Result
            // 
            textBox_Result.Anchor = AnchorStyles.Left;
            textBox_Result.BackColor = Color.DarkCyan;
            textBox_Result.BorderStyle = BorderStyle.None;
            textBox_Result.Font = new Font("Lucida Fax", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Result.Location = new Point(136, 24);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.Size = new Size(331, 29);
            textBox_Result.TabIndex = 2;
            textBox_Result.Text = "result";
            // 
            // flowLayoutPanel_Buttons
            // 
            flowLayoutPanel_Buttons.Controls.Add(button_SaveAsText);
            flowLayoutPanel_Buttons.Controls.Add(label_Complexity);
            flowLayoutPanel_Buttons.Controls.Add(label_ResultComplexity);
            flowLayoutPanel_Buttons.Dock = DockStyle.Fill;
            flowLayoutPanel_Buttons.Location = new Point(3, 464);
            flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            flowLayoutPanel_Buttons.Size = new Size(778, 44);
            flowLayoutPanel_Buttons.TabIndex = 2;
            // 
            // button_SaveAsText
            // 
            button_SaveAsText.Anchor = AnchorStyles.Left;
            button_SaveAsText.BackColor = Color.LightBlue;
            button_SaveAsText.Cursor = Cursors.Hand;
            button_SaveAsText.Font = new Font("Lucida Fax", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_SaveAsText.Location = new Point(10, 3);
            button_SaveAsText.Margin = new Padding(10, 3, 3, 3);
            button_SaveAsText.Name = "button_SaveAsText";
            button_SaveAsText.Size = new Size(244, 37);
            button_SaveAsText.TabIndex = 4;
            button_SaveAsText.Text = "Зберегти в текстовий файл";
            button_SaveAsText.UseVisualStyleBackColor = false;
            button_SaveAsText.Click += button_SaveAsText_Click;
            // 
            // label_Complexity
            // 
            label_Complexity.Anchor = AnchorStyles.Left;
            label_Complexity.AutoSize = true;
            label_Complexity.Font = new Font("Lucida Fax", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_Complexity.Location = new Point(260, 10);
            label_Complexity.Name = "label_Complexity";
            label_Complexity.Size = new Size(189, 22);
            label_Complexity.TabIndex = 6;
            label_Complexity.Text = "Практична складність:";
            // 
            // label_ResultComplexity
            // 
            label_ResultComplexity.Anchor = AnchorStyles.Left;
            label_ResultComplexity.AutoSize = true;
            label_ResultComplexity.Font = new Font("Lucida Fax", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_ResultComplexity.Location = new Point(455, 10);
            label_ResultComplexity.Name = "label_ResultComplexity";
            label_ResultComplexity.Size = new Size(117, 22);
            label_ResultComplexity.TabIndex = 7;
            label_ResultComplexity.Text = "complexity";
            // 
            // panel_Title
            // 
            panel_Title.BackColor = Color.CadetBlue;
            panel_Title.Controls.Add(label_Title);
            panel_Title.Dock = DockStyle.Top;
            panel_Title.Location = new Point(0, 0);
            panel_Title.Name = "panel_Title";
            panel_Title.Size = new Size(784, 50);
            panel_Title.TabIndex = 0;
            // 
            // label_Title
            // 
            label_Title.Dock = DockStyle.Fill;
            label_Title.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_Title.Location = new Point(0, 0);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(784, 50);
            label_Title.TabIndex = 0;
            label_Title.Text = "Результат";
            label_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel_BG);
            Name = "ResultForm";
            Text = "Результат";
            panel_BG.ResumeLayout(false);
            tableLayoutPanel_MainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            flowLayoutPanel_Result.ResumeLayout(false);
            flowLayoutPanel_Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Integral).EndInit();
            flowLayoutPanel_Buttons.ResumeLayout(false);
            flowLayoutPanel_Buttons.PerformLayout();
            panel_Title.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_BG;
        private Panel panel_Title;
        private TableLayoutPanel tableLayoutPanel_MainContent;
        private Label label_Title;
        private FlowLayoutPanel flowLayoutPanel_Result;
        private PictureBox pictureBox_Integral;
        private Label label_Equals;
        private TextBox textBox_Result;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private FlowLayoutPanel flowLayoutPanel_Buttons;
        private Button button_SaveAsText;
        private Label label_Complexity;
        private Label label_ResultComplexity;
    }
}