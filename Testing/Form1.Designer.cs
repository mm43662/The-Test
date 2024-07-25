namespace Testing
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
            DayBox = new ComboBox();
            DayMonthBox = new ComboBox();
            MonthBox = new ComboBox();
            YearBox = new ComboBox();
            AddDateBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // DayBox
            // 
            DayBox.FormattingEnabled = true;
            DayBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            DayBox.Location = new Point(667, 83);
            DayBox.Name = "DayBox";
            DayBox.Size = new Size(121, 23);
            DayBox.TabIndex = 0;
            // 
            // DayMonthBox
            // 
            DayMonthBox.FormattingEnabled = true;
            DayMonthBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayMonthBox.Location = new Point(515, 83);
            DayMonthBox.Name = "DayMonthBox";
            DayMonthBox.Size = new Size(121, 23);
            DayMonthBox.TabIndex = 1;
            // 
            // MonthBox
            // 
            MonthBox.FormattingEnabled = true;
            MonthBox.Items.AddRange(new object[] { "תשרי", "מרחשוון", "כסליו", "טבת", "שבט", "אדר ראשון", "אדר שני", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" });
            MonthBox.Location = new Point(349, 83);
            MonthBox.Name = "MonthBox";
            MonthBox.Size = new Size(121, 23);
            MonthBox.TabIndex = 2;
            // 
            // YearBox
            // 
            YearBox.FormattingEnabled = true;
            YearBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג", "", "" });
            YearBox.Location = new Point(186, 83);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(121, 23);
            YearBox.TabIndex = 3;
            // 
            // AddDateBtn
            // 
            AddDateBtn.Location = new Point(62, 160);
            AddDateBtn.Name = "AddDateBtn";
            AddDateBtn.Size = new Size(75, 58);
            AddDateBtn.TabIndex = 4;
            AddDateBtn.Text = "להוספת התאריך";
            AddDateBtn.UseVisualStyleBackColor = true;
            AddDateBtn.Click += SendDateToService;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(723, 35);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "היום בשבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(580, 35);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 6;
            label2.Text = "היום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 35);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 35);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 8;
            label4.Text = "שנה";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddDateBtn);
            Controls.Add(YearBox);
            Controls.Add(MonthBox);
            Controls.Add(DayMonthBox);
            Controls.Add(DayBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private ComboBox DayBox;
        private ComboBox DayMonthBox;
        private ComboBox MonthBox;
        private ComboBox YearBox;
        private Button AddDateBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        }
    }
