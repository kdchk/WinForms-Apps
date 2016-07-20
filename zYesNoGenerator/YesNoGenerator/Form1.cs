using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YesNoGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int questionsCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            YesNoGenerator yesNoGen = new YesNoGenerator() { Randomizer = new Random() };
            ColorGenerator colorGen = new ColorGenerator() { Colorizer = new Random() };
            label1.ForeColor = Color.FromArgb(colorGen.ColorCode(), colorGen.ColorCode(), colorGen.ColorCode());
            label1.Text = yesNoGen.Oracul();
            button1.Text = "Try Again!";

            questionsCount++;
            label2.Text = $"times asked: {questionsCount}";

            Console.WriteLine("----");
        }

        class YesNoGenerator
        {
            public Random Randomizer;
            string[] yesNo = { "No", "Yes" };

            public string Oracul()
            {
                int randomResult = Randomizer.Next(yesNo.Length);
                string answer = yesNo[randomResult];
                return $"Answer is: {answer}";
            }
        }
        class ColorGenerator
        {
            public Random Colorizer;
            short maxColorValue = 256;

            public byte ColorCode()
            {
                byte colorValue = (byte)Colorizer.Next(maxColorValue);
                Console.WriteLine(colorValue);
                return colorValue;
            }
        }
    }

}
