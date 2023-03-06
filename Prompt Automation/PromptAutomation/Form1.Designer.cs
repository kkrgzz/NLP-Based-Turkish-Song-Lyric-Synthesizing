namespace PromptAutomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lyricsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedFileName = new System.Windows.Forms.Label();
            this.promptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.promptLabel = new System.Windows.Forms.Label();
            this.savePromptButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.songWithoutPromptCountLabel = new System.Windows.Forms.Label();
            this.songWithPromptCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.songsWithPromptListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.selectDirectoryButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFolderCountLabel = new System.Windows.Forms.Label();
            this.outputFolderListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.characterCountLabel = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lyricsRichTextBox
            // 
            this.lyricsRichTextBox.Location = new System.Drawing.Point(13, 131);
            this.lyricsRichTextBox.Name = "lyricsRichTextBox";
            this.lyricsRichTextBox.Size = new System.Drawing.Size(297, 505);
            this.lyricsRichTextBox.TabIndex = 1;
            this.lyricsRichTextBox.Text = "";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(13, 82);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(297, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Song Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Song Lyric";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.selectedFileName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.titleTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lyricsRichTextBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(415, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(326, 651);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selected File Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedFileName
            // 
            this.selectedFileName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.selectedFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(112)))), ((int)(((byte)(81)))));
            this.selectedFileName.Location = new System.Drawing.Point(13, 33);
            this.selectedFileName.Name = "selectedFileName";
            this.selectedFileName.Size = new System.Drawing.Size(297, 23);
            this.selectedFileName.TabIndex = 8;
            this.selectedFileName.Text = "-";
            this.selectedFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promptRichTextBox
            // 
            this.promptRichTextBox.Location = new System.Drawing.Point(13, 36);
            this.promptRichTextBox.Name = "promptRichTextBox";
            this.promptRichTextBox.Size = new System.Drawing.Size(372, 53);
            this.promptRichTextBox.TabIndex = 8;
            this.promptRichTextBox.Text = "";
            this.promptRichTextBox.TextChanged += new System.EventHandler(this.promptRichTextBox_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel2.Controls.Add(this.promptLabel);
            this.flowLayoutPanel2.Controls.Add(this.promptRichTextBox);
            this.flowLayoutPanel2.Controls.Add(this.savePromptButton);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 452);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(397, 211);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // promptLabel
            // 
            this.promptLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.promptLabel.ForeColor = System.Drawing.Color.White;
            this.promptLabel.Location = new System.Drawing.Point(13, 10);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(372, 23);
            this.promptLabel.TabIndex = 7;
            this.promptLabel.Text = "Enter the Prompt";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // savePromptButton
            // 
            this.savePromptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(123)))), ((int)(((byte)(107)))));
            this.savePromptButton.FlatAppearance.BorderSize = 0;
            this.savePromptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePromptButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.savePromptButton.ForeColor = System.Drawing.Color.White;
            this.savePromptButton.Location = new System.Drawing.Point(13, 95);
            this.savePromptButton.Name = "savePromptButton";
            this.savePromptButton.Size = new System.Drawing.Size(372, 35);
            this.savePromptButton.TabIndex = 9;
            this.savePromptButton.Text = "Save";
            this.savePromptButton.UseVisualStyleBackColor = false;
            this.savePromptButton.Click += new System.EventHandler(this.savePromptButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.songWithoutPromptCountLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.songWithPromptCountLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.songsWithPromptListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.filesListBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 349);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // songWithoutPromptCountLabel
            // 
            this.songWithoutPromptCountLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songWithoutPromptCountLabel.ForeColor = System.Drawing.Color.White;
            this.songWithoutPromptCountLabel.Location = new System.Drawing.Point(3, 319);
            this.songWithoutPromptCountLabel.Name = "songWithoutPromptCountLabel";
            this.songWithoutPromptCountLabel.Size = new System.Drawing.Size(180, 25);
            this.songWithoutPromptCountLabel.TabIndex = 10;
            this.songWithoutPromptCountLabel.Text = "Count: ";
            this.songWithoutPromptCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // songWithPromptCountLabel
            // 
            this.songWithPromptCountLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songWithPromptCountLabel.ForeColor = System.Drawing.Color.White;
            this.songWithPromptCountLabel.Location = new System.Drawing.Point(189, 319);
            this.songWithPromptCountLabel.Name = "songWithPromptCountLabel";
            this.songWithPromptCountLabel.Size = new System.Drawing.Size(180, 25);
            this.songWithPromptCountLabel.TabIndex = 9;
            this.songWithPromptCountLabel.Text = "Count: ";
            this.songWithPromptCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(189, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Songs with prompt";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // songsWithPromptListBox
            // 
            this.songsWithPromptListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.songsWithPromptListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songsWithPromptListBox.Font = new System.Drawing.Font("Arial", 9F);
            this.songsWithPromptListBox.ForeColor = System.Drawing.Color.White;
            this.songsWithPromptListBox.FormattingEnabled = true;
            this.songsWithPromptListBox.ItemHeight = 15;
            this.songsWithPromptListBox.Location = new System.Drawing.Point(189, 28);
            this.songsWithPromptListBox.Name = "songsWithPromptListBox";
            this.songsWithPromptListBox.Size = new System.Drawing.Size(180, 287);
            this.songsWithPromptListBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Songs without prompt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filesListBox
            // 
            this.filesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.filesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filesListBox.Font = new System.Drawing.Font("Arial", 9F);
            this.filesListBox.ForeColor = System.Drawing.Color.White;
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 15;
            this.filesListBox.Location = new System.Drawing.Point(3, 28);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(180, 287);
            this.filesListBox.TabIndex = 6;
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged_1);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel5.Controls.Add(this.selectDirectoryButton);
            this.flowLayoutPanel5.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(397, 434);
            this.flowLayoutPanel5.TabIndex = 12;
            // 
            // selectDirectoryButton
            // 
            this.selectDirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(123)))), ((int)(((byte)(107)))));
            this.selectDirectoryButton.FlatAppearance.BorderSize = 0;
            this.selectDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectDirectoryButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDirectoryButton.ForeColor = System.Drawing.Color.White;
            this.selectDirectoryButton.Location = new System.Drawing.Point(13, 13);
            this.selectDirectoryButton.Name = "selectDirectoryButton";
            this.selectDirectoryButton.Size = new System.Drawing.Size(372, 50);
            this.selectDirectoryButton.TabIndex = 1;
            this.selectDirectoryButton.Text = "Select Directory";
            this.selectDirectoryButton.UseVisualStyleBackColor = false;
            this.selectDirectoryButton.Click += new System.EventHandler(this.selectDirectoryButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.outputFolderCountLabel);
            this.flowLayoutPanel3.Controls.Add(this.outputFolderListBox);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(747, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(326, 651);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Output Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputFolderCountLabel
            // 
            this.outputFolderCountLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderCountLabel.ForeColor = System.Drawing.Color.White;
            this.outputFolderCountLabel.Location = new System.Drawing.Point(13, 33);
            this.outputFolderCountLabel.Name = "outputFolderCountLabel";
            this.outputFolderCountLabel.Size = new System.Drawing.Size(297, 25);
            this.outputFolderCountLabel.TabIndex = 10;
            this.outputFolderCountLabel.Text = "Count: 0";
            this.outputFolderCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputFolderListBox
            // 
            this.outputFolderListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.outputFolderListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFolderListBox.Font = new System.Drawing.Font("Arial", 9F);
            this.outputFolderListBox.ForeColor = System.Drawing.Color.White;
            this.outputFolderListBox.FormattingEnabled = true;
            this.outputFolderListBox.ItemHeight = 15;
            this.outputFolderListBox.Location = new System.Drawing.Point(13, 61);
            this.outputFolderListBox.Name = "outputFolderListBox";
            this.outputFolderListBox.Size = new System.Drawing.Size(297, 572);
            this.outputFolderListBox.TabIndex = 11;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.characterCountLabel);
            this.flowLayoutPanel4.Controls.Add(this.wordCountLabel);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(13, 136);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(372, 60);
            this.flowLayoutPanel4.TabIndex = 10;
            // 
            // characterCountLabel
            // 
            this.characterCountLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterCountLabel.ForeColor = System.Drawing.Color.White;
            this.characterCountLabel.Location = new System.Drawing.Point(3, 0);
            this.characterCountLabel.Name = "characterCountLabel";
            this.characterCountLabel.Size = new System.Drawing.Size(203, 25);
            this.characterCountLabel.TabIndex = 11;
            this.characterCountLabel.Text = "Character Count: ";
            this.characterCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCountLabel.ForeColor = System.Drawing.Color.White;
            this.wordCountLabel.Location = new System.Drawing.Point(3, 25);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(203, 25);
            this.wordCountLabel.TabIndex = 12;
            this.wordCountLabel.Text = "Word Count: ";
            this.wordCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1085, 675);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSON Prompt Automation";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox lyricsRichTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox promptRichTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button savePromptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label selectedFileName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox songsWithPromptListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button selectDirectoryButton;
        private System.Windows.Forms.Label songWithoutPromptCountLabel;
        private System.Windows.Forms.Label songWithPromptCountLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputFolderCountLabel;
        private System.Windows.Forms.ListBox outputFolderListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label characterCountLabel;
        private System.Windows.Forms.Label wordCountLabel;
    }
}

