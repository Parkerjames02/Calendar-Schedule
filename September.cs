using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarScheduleApp
{
    public partial class September : Form
    {
        public September()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Friday, September 1st";
            Hide_All_TextBoxs();
            Day1TextBox.Show();
            Enable_All_Buttons();
            Day1Button.Enabled = false; 
            Hide_All_Save_Buttons();
            Day1SaveButton.Show();
            Hide_All_Load_Buttons();
            Day1LoadButton.Show();
        }

        August augustForm = new August();
        October octoberForm = new October();

        private void LeftButton_Click(object sender, EventArgs e)
        {
            augustForm.Show();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            octoberForm.Show();
        }

        private void Hide_All_TextBoxs()
        {
            Day1TextBox.Hide();
            Day2TextBox.Hide();
            Day3TextBox.Hide();
            Day4TextBox.Hide();
            Day5TextBox.Hide();
            Day6TextBox.Hide();
            Day7TextBox.Hide();
            Day8TextBox.Hide();
            Day9TextBox.Hide();
            Day10TextBox.Hide();
            Day11TextBox.Hide();
            Day12TextBox.Hide();
            Day13TextBox.Hide();
            Day14TextBox.Hide();
            Day15TextBox.Hide();
            Day16TextBox.Hide();
            Day17TextBox.Hide();
            Day18TextBox.Hide();
            Day19TextBox.Hide();
            Day20TextBox.Hide();
            Day21TextBox.Hide();
            Day22TextBox.Hide();
            Day23TextBox.Hide();
            Day24TextBox.Hide();
            Day25TextBox.Hide();
            Day26TextBox.Hide();
            Day27TextBox.Hide();
            Day28TextBox.Hide();
            Day29TextBox.Hide();
            Day30TextBox.Hide();
        }

        private void Enable_All_Buttons()
        {
            Day1Button.Enabled = true;
            Day2Button.Enabled = true;
            Day3Button.Enabled = true;
            Day4Button.Enabled = true;
            Day5Button.Enabled = true;
            Day6Button.Enabled = true;
            Day7Button.Enabled = true;
            Day8Button.Enabled = true;
            Day9Button.Enabled = true;
            Day10Button.Enabled = true;
            Day11Button.Enabled = true;
            Day12Button.Enabled = true;
            Day13Button.Enabled = true;
            Day14Button.Enabled = true;
            Day15Button.Enabled = true;
            Day16Button.Enabled = true;
            Day17Button.Enabled = true;
            Day18Button.Enabled = true;
            Day19Button.Enabled = true;
            Day20Button.Enabled = true;
            Day21Button.Enabled = true;
            Day22Button.Enabled = true;
            Day23Button.Enabled = true;
            Day24Button.Enabled = true;
            Day25Button.Enabled = true;
            Day26Button.Enabled = true;
            Day27Button.Enabled = true;
            Day28Button.Enabled = true;
            Day29Button.Enabled = true;
            Day30Button.Enabled = true;
        }

        private void Hide_All_Save_Buttons()
        {
            Day1SaveButton.Hide();
            Day2SaveButton.Hide();
            Day3SaveButton.Hide();
            Day4SaveButton.Hide();
            Day5SaveButton.Hide();
            Day6SaveButton.Hide();
            Day7SaveButton.Hide();
            Day8SaveButton.Hide();
            Day9SaveButton.Hide();
            Day10SaveButton.Hide();
            Day11SaveButton.Hide();
            Day12SaveButton.Hide();
            Day13SaveButton.Hide();
            Day14SaveButton.Hide();
            Day15SaveButton.Hide();
            Day16SaveButton.Hide();
            Day17SaveButton.Hide();
            Day18SaveButton.Hide();
            Day19SaveButton.Hide();
            Day20SaveButton.Hide();
            Day21SaveButton.Hide();
            Day22SaveButton.Hide();
            Day23SaveButton.Hide();
            Day24SaveButton.Hide();
            Day25SaveButton.Hide();
            Day26SaveButton.Hide();
            Day27SaveButton.Hide();
            Day28SaveButton.Hide();
            Day29SaveButton.Hide();
            Day30SaveButton.Hide();
        }

        private void Hide_All_Load_Buttons()
        {
            Day1LoadButton.Hide();
            Day2LoadButton.Hide();
            Day3LoadButton.Hide();
            Day4LoadButton.Hide();
            Day5LoadButton.Hide();
            Day6LoadButton.Hide();
            Day7LoadButton.Hide();
            Day8LoadButton.Hide();
            Day9LoadButton.Hide();
            Day10LoadButton.Hide();
            Day11LoadButton.Hide();
            Day12LoadButton.Hide();
            Day13LoadButton.Hide();
            Day14LoadButton.Hide();
            Day15LoadButton.Hide();
            Day16LoadButton.Hide();
            Day17LoadButton.Hide();
            Day18LoadButton.Hide();
            Day19LoadButton.Hide();
            Day20LoadButton.Hide();
            Day21LoadButton.Hide();
            Day22LoadButton.Hide();
            Day23LoadButton.Hide();
            Day24LoadButton.Hide();
            Day25LoadButton.Hide();
            Day26LoadButton.Hide();
            Day27LoadButton.Hide();
            Day28LoadButton.Hide();
            Day29LoadButton.Hide();
            Day30LoadButton.Hide();
        }

        private void Day1Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Friday, September 1st";
            Hide_All_TextBoxs();
            Day1TextBox.Show();
            Enable_All_Buttons();
            Day1Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day1SaveButton.Show();
            Hide_All_Load_Buttons();
            Day1LoadButton.Show();
        }

        private void Day2Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Saturday, September 2nd";
            Hide_All_TextBoxs();
            Day2TextBox.Show();
            Enable_All_Buttons();
            Day2Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day2SaveButton.Show();
            Hide_All_Load_Buttons();
            Day2LoadButton.Show();
        }

        private void Day3Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Sunday, September 3rd";
            Hide_All_TextBoxs();
            Day3TextBox.Show();
            Enable_All_Buttons();
            Day3Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day3SaveButton.Show();
            Hide_All_Load_Buttons();
            Day3LoadButton.Show();
        }

        private void Day4Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Monday, September 4th";
            Hide_All_TextBoxs();
            Day4TextBox.Show();
            Enable_All_Buttons();
            Day4Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day4SaveButton.Show();
            Hide_All_Load_Buttons();
            Day4LoadButton.Show();
        }

        private void Day5Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Tuesday, September 5th";
            Hide_All_TextBoxs();
            Day5TextBox.Show();
            Enable_All_Buttons();
            Day5Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day5SaveButton.Show();
            Hide_All_Load_Buttons();
            Day5LoadButton.Show();
        }

        private void Day6Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Wednesday, September 6th";
            Hide_All_TextBoxs();
            Day6TextBox.Show();
            Enable_All_Buttons();
            Day6Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day6SaveButton.Show();
            Hide_All_Load_Buttons();
            Day6LoadButton.Show();
        }

        private void Day7Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Thursday, September 7th";
            Hide_All_TextBoxs();
            Day7TextBox.Show();
            Enable_All_Buttons();
            Day7Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day7SaveButton.Show();
            Hide_All_Load_Buttons();
            Day7LoadButton.Show();
        }

        private void Day8Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Friday, September 8th";
            Hide_All_TextBoxs();
            Day8TextBox.Show();
            Enable_All_Buttons();
            Day8Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day8SaveButton.Show();
            Hide_All_Load_Buttons();
            Day8LoadButton.Show();
        }

        private void Day9Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Saturday, September 9th";
            Hide_All_TextBoxs();
            Day9TextBox.Show();
            Enable_All_Buttons();
            Day9Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day9SaveButton.Show();
            Hide_All_Load_Buttons();
            Day9LoadButton.Show();
        }

        private void Day10Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Sunday, September 10th";
            Hide_All_TextBoxs();
            Day10TextBox.Show();
            Enable_All_Buttons();
            Day10Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day10SaveButton.Show();
            Hide_All_Load_Buttons();
            Day10LoadButton.Show();
        }

        private void Day11Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Monday, September 11th";
            Hide_All_TextBoxs();
            Day11TextBox.Show();
            Enable_All_Buttons();
            Day11Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day11SaveButton.Show();
            Hide_All_Load_Buttons();
            Day11LoadButton.Show();
        }

        private void Day12Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Tuesday, September 12th";
            Hide_All_TextBoxs();
            Day12TextBox.Show();
            Enable_All_Buttons();
            Day12Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day12SaveButton.Show();
            Hide_All_Load_Buttons();
            Day12LoadButton.Show();
        }

        private void Day13Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Wednesday, September 13th";
            Hide_All_TextBoxs();
            Day13TextBox.Show();
            Enable_All_Buttons();
            Day13Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day13SaveButton.Show();
            Hide_All_Load_Buttons();
            Day13LoadButton.Show();
        }

        private void Day14Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Thursday, September 14th";
            Hide_All_TextBoxs();
            Day14TextBox.Show();
            Enable_All_Buttons();
            Day14Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day14SaveButton.Show();
            Hide_All_Load_Buttons();
            Day14LoadButton.Show();
        }

        private void Day15Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Friday, September 15th";
            Hide_All_TextBoxs();
            Day15TextBox.Show();
            Enable_All_Buttons();
            Day15Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day15SaveButton.Show();
            Hide_All_Load_Buttons();
            Day15LoadButton.Show();
        }

        private void Day16Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Saturday, September 16th";
            Hide_All_TextBoxs();
            Day16TextBox.Show();
            Enable_All_Buttons();
            Day16Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day16SaveButton.Show();
            Hide_All_Load_Buttons();
            Day16LoadButton.Show();
        }

        private void Day17Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Sunday, September 17th";
            Hide_All_TextBoxs();
            Day17TextBox.Show();
            Enable_All_Buttons();
            Day17Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day17SaveButton.Show();
            Hide_All_Load_Buttons();
            Day17LoadButton.Show();
        }

        private void Day18Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Monday, September 18th";
            Hide_All_TextBoxs();
            Day18TextBox.Show();
            Enable_All_Buttons();
            Day18Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day18SaveButton.Show();
            Hide_All_Load_Buttons();
            Day18LoadButton.Show();
        }

        private void Day19Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Tuesday, September 19th";
            Hide_All_TextBoxs();
            Day19TextBox.Show();
            Enable_All_Buttons();
            Day19Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day19SaveButton.Show();
            Hide_All_Load_Buttons();
            Day19LoadButton.Show();
        }

        private void Day20Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Wednesday, September 20th";
            Hide_All_TextBoxs();
            Day20TextBox.Show();
            Enable_All_Buttons();
            Day20Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day20SaveButton.Show();
            Hide_All_Load_Buttons();
            Day20LoadButton.Show();
        }

        private void Day21Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Thursday, September 21st";
            Hide_All_TextBoxs();
            Day21TextBox.Show();
            Enable_All_Buttons();
            Day21Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day21SaveButton.Show();
            Hide_All_Load_Buttons();
            Day21LoadButton.Show();
        }

        private void Day22Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Friday, September 22nd";
            Hide_All_TextBoxs();
            Day22TextBox.Show();
            Enable_All_Buttons();
            Day22Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day22SaveButton.Show();
            Hide_All_Load_Buttons();
            Day22LoadButton.Show();
        }

        private void Day23Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Saturday, September 23rd";
            Hide_All_TextBoxs();
            Day23TextBox.Show();
            Enable_All_Buttons();
            Day23Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day23SaveButton.Show();
            Hide_All_Load_Buttons();
            Day23LoadButton.Show();
        }

        private void Day24Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Sunday, September 24th";
            Hide_All_TextBoxs();
            Day24TextBox.Show();
            Enable_All_Buttons();
            Day24Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day24SaveButton.Show();
            Hide_All_Load_Buttons();
            Day24LoadButton.Show();
        }

        private void Day25Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Monday, September 25th";
            Hide_All_TextBoxs();
            Day25TextBox.Show();
            Enable_All_Buttons();
            Day25Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day25SaveButton.Show();
            Hide_All_Load_Buttons();
            Day25LoadButton.Show();
        }

        private void Day26Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Tuesday, September 26th";
            Hide_All_TextBoxs();
            Day26TextBox.Show();
            Enable_All_Buttons();
            Day26Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day26SaveButton.Show();
            Hide_All_Load_Buttons();
            Day26LoadButton.Show();
        }

        private void Day27Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Wednesday, September 27th";
            Hide_All_TextBoxs();
            Day27TextBox.Show();
            Enable_All_Buttons();
            Day27Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day27SaveButton.Show();
            Hide_All_Load_Buttons();
            Day27LoadButton.Show();
        }

        private void Day28Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Thursday, September 28th";
            Hide_All_TextBoxs();
            Day28TextBox.Show();
            Enable_All_Buttons();
            Day28Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day28SaveButton.Show();
            Hide_All_Load_Buttons();
            Day28LoadButton.Show();
        }

        private void Day29Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Friday, September 29th";
            Hide_All_TextBoxs();
            Day29TextBox.Show();
            Enable_All_Buttons();
            Day29Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day29SaveButton.Show();
            Hide_All_Load_Buttons();
            Day29LoadButton.Show();
        }

        private void Day30Button_Click(object sender, EventArgs e)
        {
            FullDateTextBox.Text = "Saturday, September 30th";
            Hide_All_TextBoxs();
            Day30TextBox.Show();
            Enable_All_Buttons();
            Day30Button.Enabled = false;
            Hide_All_Save_Buttons();
            Day30SaveButton.Show();
            Hide_All_Load_Buttons();
            Day30LoadButton.Show();
        }
        private void Day1SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day1TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day2SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day2TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day3SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day3TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day4SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day4TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day5SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day5TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day6SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day6TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day7SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day7TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day8SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day8TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day9SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day9TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day10SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day10TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day11SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day11TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day12SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day12TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day13SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day13TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day14SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day14TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day15SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day15TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day16SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day16TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day17SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day17TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day18SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day18TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day19SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day19TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day20SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day20TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day21SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day21TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day22SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day22TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day23SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day23TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day24SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day24TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day25SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day25TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day26SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day26TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day27SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day27TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day28SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day28TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day29SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day29TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day30SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                Day30TextBox.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day1LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if(openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day1TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day2LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day2TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day3LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day3TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day4LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day4TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day5LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day5TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day6LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day6TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day7LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day7TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day8LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day8TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day9LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day9TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day10LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day10TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day11LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day11TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day12LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day12TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day13LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day13TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day14LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day14TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day15LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day15TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day16LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day16TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day17LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day17TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day18LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day18TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day19LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day19TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day20LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day20TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day21LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day21TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day22LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day22TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day23LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day23TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day24LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day24TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day25LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day25TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day26LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day26TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day27LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day27TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day28LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day28TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day29LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day29TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Day30LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile.FileName.Length > 0)
            {
                Day30TextBox.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
