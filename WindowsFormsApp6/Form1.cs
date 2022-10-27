using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            var readsFile = new StreamReader("C:/logs.txt");    //путь файл
            string textFile = readsFile.ReadToEnd(); // чтение файла
            readsFile.Close();
            checkLetter(textFile, label1);
            
        }
        public static void checkLetter(string text,Label label1)
        {
            char[] letter = text.ToCharArray();
            int[] countLetter = new int[32];
            int[] countLetterUp = new int[32];
            
            for(int i = 0; i < letter.Length; i++)
            {
                for(int j = 0; j < 32; j++)
                {
                    if ((char)(letter[i])-1072 == j)
                    {
                        countLetter[j]++;
                    }
                }
            }
            for (int i = 0; i < letter.Length; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if ((char)(letter[i]) - 1040 == j)
                    {
                        countLetterUp[j]++;
                    }
                }
            }
            for (int i = 0; i < countLetter.Length; i++)
            {
                int v = 'а' + i;
                char letterName = Convert.ToChar(v);
                int u = 'А' + i;
                char letterNameUp = Convert.ToChar(u);
                label1.Text += letterName + " - " + countLetter[i].ToString()+"   "+letterNameUp+ " - " + countLetterUp[i];
                label1.Text += "\n";
                
            }
            
        }
    }
}
