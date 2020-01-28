using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangperson
{
    public partial class Form1 : Form
    {
        //init
        String[] words = {"airport", "alcohol", "awesome", "attack", "artist", "award", "design",
                "brother", "park", "number", "player", "school", "street", "tower",
                "weather", "damage", "crystal", "nowhere", "reward", "snake", "ghost",
                "cocoa", "compass", "cowboy", "happy", "popcorn", "sword", "light",
                "garden", "laptop", "mother", "sport", "yellow", "cookie", "fruit"};
        int wrongLetterCounter = 0;
        public List<char> guessedRight = new List<char>();
        public List<char> guessedWrong = new List<char>();
        int counter = 30;
        int points = 0;
        int counterWOutDuplicates = 0;
        string currentWord = "";
        int x = 0;
        char[] currentWordArray;
        public Form1()
        {
            InitializeComponent();
        }

        //timer
        private void timer_Tick(object sender, EventArgs e)
        {
            rightOrWrong.Text = "...";
            rightOrWrong.BackColor = Color.Silver;
            if (progressBar1.Value != 90)
            {
                progressBar1.Value += 3;
                labelTime.Text = counter.ToString();
                counter--;
            }
            if(progressBar1.Value == 90)
            {
                end();
            }
        }

        //end game
        public void end()
        {
            timer.Stop();
            labelTime.Visible = false;
            progressBar1.Value = 90;
            button1.Visible = true;
            EnteredLetter.ReadOnly = true;
            enter.Visible = false;
            button1.Text = "AGAIN?";
            button2.Visible = false;
        }

        //start game
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            if (true) // lazy to fix tabs and spaces
            {
                counter = 30;
                labelTime.Text = counter.ToString();
                EnteredLetter.ReadOnly = false;
                enter.Visible = true;
                Random random = new Random();
                String tester = words[random.Next(0, words.Length-1)];
                currentWord = tester;
                lettr1.Text = "_";
                lettr1.Visible = false;
                lettr2.Text = "_";
                lettr2.Visible = false;
                lettr3.Text = "_";
                lettr3.Visible = false;
                lettr4.Text = "_";
                lettr4.Visible = false;
                lettr5.Text = "_";
                lettr5.Visible = false;
                lettr6.Text = "_";
                lettr6.Visible = false;
                lettr7.Text = "_";
                lettr7.Visible = false;
                lab1.Text = "_";
                lab2.Text = "_";
                lab3.Text = "_";
                lab4.Text = "_";
                lab5.Text = "_";
                lab6.Text = "_";
                lb1.ForeColor = Color.LightBlue;
                lb2.ForeColor = Color.LightBlue;
                lb3.ForeColor = Color.LightBlue;
                lb4.ForeColor = Color.LightBlue;
                lb5.ForeColor = Color.LightBlue;
                lb6.ForeColor = Color.LightBlue;
                if (tester.Length == 4)
                {
                    lettr1.Visible = true;
                    lettr2.Visible = true;
                    lettr3.Visible = true;
                    lettr4.Visible = true;
                }
                if (tester.Length == 5)
                {
                    lettr1.Visible = true;
                    lettr2.Visible = true;
                    lettr3.Visible = true;
                    lettr4.Visible = true;
                    lettr5.Visible = true;
                }
                if (tester.Length == 6)
                {
                    lettr1.Visible = true;
                    lettr2.Visible = true;
                    lettr3.Visible = true;
                    lettr4.Visible = true;
                    lettr5.Visible = true;
                    lettr6.Visible = true;
                }
                if (tester.Length == 7)
                {
                    lettr1.Visible = true;
                    lettr2.Visible = true;
                    lettr3.Visible = true;
                    lettr4.Visible = true;
                    lettr5.Visible = true;
                    lettr6.Visible = true;
                    lettr7.Visible = true;
                }
                currentWordArray = tester.ToCharArray();
                timer.Start();
                progressBar1.Value = 0;
                x = 0;
                points = 0;
                wrongLetterCounter = 0;
                guessedRight.Clear();
                guessedWrong.Clear();
                counterWOutDuplicates = 0;
                button1.Visible = false;
                labelTime.Visible = true;
                //count word letters without duplicates
                List<char> dupliRemove = new List<char>();
                foreach (char cha in currentWordArray)
                {
                    if (!(dupliRemove.Contains(cha)))
                    {
                        dupliRemove.Add(cha);
                        counterWOutDuplicates++;
                    }
                }
            }
        }

        //test guess
        private void enter_Click(object sender, EventArgs e)
        {
            bool testr = false;
            int test = 0;
            if(char.TryParse(EnteredLetter.Text.ToLower(), out char c))
                c = char.Parse(EnteredLetter.Text.ToLower());
            EnteredLetter.Clear();
            
            //if right
            foreach (char ch in currentWordArray)
            {
                if(c == ch)
                {
                    if (!(guessedRight.Contains(c)))
                    {
                        guessedRight.Add(c);
                        points++;
                        rightOrWrong.BackColor = Color.Green;
                        rightOrWrong.Text = "✓";
                    }
                    test++;
                    testr = true;
                }
                x++;
                if (x == 1 && guessedRight.Contains(c) && testr)
                    lettr1.Text = c.ToString().ToUpper();
                if (x == 2 && guessedRight.Contains(c) && testr)
                    lettr2.Text = c.ToString();
                if (x == 3 && guessedRight.Contains(c) && testr)
                    lettr3.Text = c.ToString();
                if (x == 4 && guessedRight.Contains(c) && testr)
                    lettr4.Text = c.ToString();
                if (x == 5 && guessedRight.Contains(c) && testr)
                    lettr5.Text = c.ToString();
                if (x == 6 && guessedRight.Contains(c) && testr)
                    lettr6.Text = c.ToString();
                if (x == 7 && guessedRight.Contains(c) && testr)
                    lettr7.Text = c.ToString();
                testr = false;
            }
            if (points == counterWOutDuplicates)
            {
                end();
                MessageBox.Show("You win with " + counter + " points!");
            }
            x = 0;
            //if wrong
            if (test == 0)
            {
                if (!(guessedWrong.Contains(c)))
                {
                    rightOrWrong.BackColor = Color.Red;
                    rightOrWrong.Text = "X";
                    guessedWrong.Add(c);
                    wrongLetterCounter++;
                    if (wrongLetterCounter == 1)
                    {
                        lab1.Text = c.ToString().ToUpper();
                        lb1.ForeColor = Color.Black;
                    }
                    if (wrongLetterCounter == 2)
                    {
                        lab2.Text = c.ToString().ToUpper();
                        lb2.ForeColor = Color.Black;
                    }
                    if (wrongLetterCounter == 3)
                    {
                        lab3.Text = c.ToString().ToUpper();
                        lb3.ForeColor = Color.Black;
                    }
                    if (wrongLetterCounter == 4)
                    {
                        lab4.Text = c.ToString().ToUpper();
                        lb4.ForeColor = Color.Black;
                    }
                    if (wrongLetterCounter == 5)
                    {
                        lab5.Text = c.ToString().ToUpper();
                        lb5.ForeColor = Color.Black;
                    }
                    //end game
                    if (wrongLetterCounter == 6)
                    {
                        lab6.Text = c.ToString().ToUpper();
                        lb6.ForeColor = Color.Black;
                        end();
                        MessageBox.Show("You lost, the word was [" + currentWord + "]");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            end();
        }

    }
}
