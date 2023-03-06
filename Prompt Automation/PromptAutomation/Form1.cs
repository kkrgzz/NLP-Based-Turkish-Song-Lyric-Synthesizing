using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;

namespace PromptAutomation
{

    public partial class Form1 : Form
    {

        private String selectedPath = "";
        private String selectedJSONPath = "";
        private String outputJSONPath = "";
        private String currentSelectedSongTitle = "";

        private int currentSelectedSong;

        private int songWithPromptCount = 0;
        private int songWithoutPromptCount = 0;
        private int outputSongCount = 0;

        
        public Form1()
        {
            InitializeComponent();

            formItemEnableState(false);
        }

        public class Song
        {
            public string title { get; set; }
            public string lyrics { get; set; }
            public string prompt { get; set; }

        }

        private void formItemEnableState(bool state)
        {
            savePromptButton.Enabled = state;
            promptRichTextBox.Enabled = state;
            titleTextBox.Enabled = state;
            lyricsRichTextBox.Enabled = state;
        }

        private void selectDirectoryButton_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the folder that include song files.";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog.SelectedPath;

                getSongsInDirectory( selectedPath );
                getSongsInOutput(selectedPath + "\\output");

                selectDirectoryButton.Text = "Select Directory \n" + selectedPath;
            }
            
        }

        private void getSongsInDirectory(String path)
        {
            filesListBox.Items.Clear();
            songsWithPromptListBox.Items.Clear();

            songWithoutPromptCount = 0;
            songWithPromptCount = 0;

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] Files = directoryInfo.GetFiles("*.json");

            foreach (FileInfo file in Files)
            {
                if (getPromptData(selectedPath + "\\" + file.Name) == "")
                {
                    if (file.Name.IndexOf("_tr.json") != -1)
                    {
                        filesListBox.Items.Add(file.Name);
                        songWithoutPromptCount++;
                    }
                }
                else
                {
                    songsWithPromptListBox.Items.Add(file.Name);
                    songWithPromptCount++;
                }
                    
            }

            formItemEnableState(true);

            songWithPromptCountLabel.Text = "Count: " + Convert.ToString(songWithPromptCount);
            songWithoutPromptCountLabel.Text = "Count: " + Convert.ToString(songWithoutPromptCount);
        }

        private void getSongsInOutput( String path )
        {
            outputSongCount = 0;
            outputFolderListBox.Items.Clear();

            if (Directory.Exists(path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                FileInfo[] files = directoryInfo.GetFiles("*.json");

                foreach (FileInfo file in files)
                {
                    outputFolderListBox.Items.Add(file.Name);
                    outputSongCount++;
                }
            } else
            {
                Directory.CreateDirectory(path);
            }

            outputFolderCountLabel.Text = "Count: " + outputSongCount;
        }

        private String getPromptData(String path)
        {
            string prompt = "";

            try
            {
                string text = File.ReadAllText(path);
                text = text.Substring(1, text.Length - 2);

                var song = JsonSerializer.Deserialize<Song>(text);

                prompt = song.prompt;
            }
            catch
            {
                prompt = "";
            }
            return prompt;
        }

        private void filesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            currentSelectedSongTitle = filesListBox.GetItemText(filesListBox.SelectedItem);

            currentSelectedSong = filesListBox.SelectedIndex;

            selectedJSONPath = selectedPath + "\\" + currentSelectedSongTitle;

            outputJSONPath = selectedPath + "\\output\\" + currentSelectedSongTitle;

            selectedFileName.Text = filesListBox.GetItemText(filesListBox.SelectedItem);

            try
            {
                string text = File.ReadAllText(selectedJSONPath);
                text = text.Substring(1, text.Length - 2);
                
                var song = JsonSerializer.Deserialize<Song>(text);
                
                titleTextBox.Text = song.title;
                lyricsRichTextBox.Text = song.lyrics;
                promptRichTextBox.Text = song.prompt;
            } catch
            {
                titleTextBox.Text = "Failed!";
                lyricsRichTextBox.Text = "Failed!";
            }
        }

        private void savePromptButton_Click(object sender, EventArgs e)
        {   
            
            if (Directory.Exists(selectedPath + "\\output"))
            { 
                List<Song> song = new List<Song>();

                song.Add(new Song()
                {
                    title = titleTextBox.Text,
                    lyrics = lyricsRichTextBox.Text,
                    prompt = promptRichTextBox.Text
                });

                string json = JsonSerializer.Serialize(song);
                File.WriteAllText(outputJSONPath, json);
                
                selectedFileName.Text = "-";
                titleTextBox.Text = "";
                lyricsRichTextBox.Text = "";
                promptRichTextBox.Text = "";

                getSongsInOutput(selectedPath + "\\output");

                File.Delete(selectedPath + "\\" + currentSelectedSongTitle);
                filesListBox.Items.RemoveAt(currentSelectedSong);
                
                songWithoutPromptCount--;
                songWithoutPromptCountLabel.Text = "Count: " + Convert.ToString(songWithoutPromptCount);

            } else
            {
                Directory.CreateDirectory(selectedPath + "\\output");
            }
            
        }

        private void promptRichTextBox_TextChanged(object sender, EventArgs e)
        {
            String inputString = promptRichTextBox.Text;
            String[] tempArr = inputString.Split(' ');

            wordCountLabel.Text = "Word Count: " + tempArr.Length.ToString();
            characterCountLabel.Text = "Character Count: " + inputString.Length.ToString();
        }
    }
}
