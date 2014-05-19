using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//[参照URL]http://anis774.net/codevault/inifile.html


    public partial class Form1 : Form
    {
        public static string stFilePath ="D:\\temp\\ini\\status";
        public Form1()
        {
            InitializeComponent();
        }
        //[書込]Iniﾌｧｲﾙ
        private void button2_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(stFilePath);

            ini["StatusInfo", "dat"] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //[読込]Iniﾌｧｲﾙ
        private void button1_Click(object sender, EventArgs e)
        {
            IniFile ini = new IniFile(stFilePath);
            string st = ini["StatusInfo", "dat"];
            MessageBox.Show(st);

            DateTime dt;
            if (DateTime.TryParseExact(st,"yyyy/MM/dd HH:mm:ss",null,System.Globalization.DateTimeStyles.None,out dt))
            {
                dt = dt.AddDays(1);
                MessageBox.Show(dt.ToString("yyyy/MM/dd HH:mm:ss"));
                Console.Write("aa");
            }
            


        }
    }
