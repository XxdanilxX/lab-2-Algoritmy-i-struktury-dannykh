namespace lab_2_Algoritmy_i_struktury_dannykh
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

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabBinarySearch = new TabPage();
            labelArray = new Label();
            textBoxInput = new TextBox();
            buttonSearch = new Button();
            labelBaseResult = new Label();
            labelOptimizedResult = new Label();
            tabRemoveSpaces = new TabPage();
            labelInput = new Label();
            textBoxSentence = new TextBox();
            buttonRemoveSpaces = new Button();
            labelResult = new Label();
            tabControl.SuspendLayout();
            tabBinarySearch.SuspendLayout();
            tabRemoveSpaces.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabBinarySearch);
            tabControl.Controls.Add(tabRemoveSpaces);
            tabControl.Location = new Point(16, 18);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(533, 462);
            tabControl.TabIndex = 0;
            // 
            // tabBinarySearch
            // 
            tabBinarySearch.Controls.Add(labelArray);
            tabBinarySearch.Controls.Add(textBoxInput);
            tabBinarySearch.Controls.Add(buttonSearch);
            tabBinarySearch.Controls.Add(labelBaseResult);
            tabBinarySearch.Controls.Add(labelOptimizedResult);
            tabBinarySearch.Location = new Point(4, 29);
            tabBinarySearch.Margin = new Padding(4, 5, 4, 5);
            tabBinarySearch.Name = "tabBinarySearch";
            tabBinarySearch.Padding = new Padding(4, 5, 4, 5);
            tabBinarySearch.Size = new Size(525, 429);
            tabBinarySearch.TabIndex = 0;
            tabBinarySearch.Text = "Двійковий пошук";
            tabBinarySearch.UseVisualStyleBackColor = true;
            // 
            // labelArray
            // 
            labelArray.AutoSize = true;
            labelArray.Location = new Point(40, 31);
            labelArray.Margin = new Padding(4, 0, 4, 0);
            labelArray.Name = "labelArray";
            labelArray.Size = new Size(245, 20);
            labelArray.TabIndex = 0;
            labelArray.Text = "Масив для пошуку: {1, 2, 2, 3, 4, 25}";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(40, 77);
            textBoxInput.Margin = new Padding(4, 5, 4, 5);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(199, 27);
            textBoxInput.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(253, 77);
            buttonSearch.Margin = new Padding(4, 5, 4, 5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 35);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Знайти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // labelBaseResult
            // 
            labelBaseResult.AutoSize = true;
            labelBaseResult.Location = new Point(40, 138);
            labelBaseResult.Margin = new Padding(4, 0, 4, 0);
            labelBaseResult.Name = "labelBaseResult";
            labelBaseResult.Size = new Size(206, 20);
            labelBaseResult.TabIndex = 3;
            labelBaseResult.Text = "Результат базового пошуку: ";
            // 
            // labelOptimizedResult
            // 
            labelOptimizedResult.AutoSize = true;
            labelOptimizedResult.Location = new Point(40, 185);
            labelOptimizedResult.Margin = new Padding(4, 0, 4, 0);
            labelOptimizedResult.Name = "labelOptimizedResult";
            labelOptimizedResult.Size = new Size(254, 20);
            labelOptimizedResult.TabIndex = 4;
            labelOptimizedResult.Text = "Результат оптимізованого пошуку: ";
            // 
            // tabRemoveSpaces
            // 
            tabRemoveSpaces.Controls.Add(labelInput);
            tabRemoveSpaces.Controls.Add(textBoxSentence);
            tabRemoveSpaces.Controls.Add(buttonRemoveSpaces);
            tabRemoveSpaces.Controls.Add(labelResult);
            tabRemoveSpaces.Location = new Point(4, 29);
            tabRemoveSpaces.Margin = new Padding(4, 5, 4, 5);
            tabRemoveSpaces.Name = "tabRemoveSpaces";
            tabRemoveSpaces.Padding = new Padding(4, 5, 4, 5);
            tabRemoveSpaces.Size = new Size(525, 429);
            tabRemoveSpaces.TabIndex = 1;
            tabRemoveSpaces.Text = "Видалення пропусків";
            tabRemoveSpaces.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(40, 31);
            labelInput.Margin = new Padding(4, 0, 4, 0);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(296, 20);
            labelInput.TabIndex = 0;
            labelInput.Text = "Введіть речення з пропусками і крапкою";
            // 
            // textBoxSentence
            // 
            textBoxSentence.Location = new Point(40, 77);
            textBoxSentence.Margin = new Padding(4, 5, 4, 5);
            textBoxSentence.Name = "textBoxSentence";
            textBoxSentence.Size = new Size(399, 27);
            textBoxSentence.TabIndex = 1;
            // 
            // buttonRemoveSpaces
            // 
            buttonRemoveSpaces.Location = new Point(40, 123);
            buttonRemoveSpaces.Margin = new Padding(4, 5, 4, 5);
            buttonRemoveSpaces.Name = "buttonRemoveSpaces";
            buttonRemoveSpaces.Size = new Size(200, 35);
            buttonRemoveSpaces.TabIndex = 2;
            buttonRemoveSpaces.Text = "Видалити зайві пропуски";
            buttonRemoveSpaces.UseVisualStyleBackColor = true;
            buttonRemoveSpaces.Click += ButtonRemoveSpaces_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(40, 185);
            labelResult.Margin = new Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 3;
            labelResult.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 508);
            Controls.Add(tabControl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Лабораторна робота №2";
            tabControl.ResumeLayout(false);
            tabBinarySearch.ResumeLayout(false);
            tabBinarySearch.PerformLayout();
            tabRemoveSpaces.ResumeLayout(false);
            tabRemoveSpaces.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBinarySearch;
        private System.Windows.Forms.TabPage tabRemoveSpaces;
        private System.Windows.Forms.Label labelArray;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelBaseResult;
        private System.Windows.Forms.Label labelOptimizedResult;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxSentence;
        private System.Windows.Forms.Button buttonRemoveSpaces;
        private System.Windows.Forms.Label labelResult;


    }
}
