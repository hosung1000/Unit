using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private PerformanceCounter Cpu, User, ram;
        private void Form1_Load(object sender, EventArgs e)
        {
            Cpu = new PerformanceCounter();
            Cpu.CategoryName = "Processor";
            Cpu.CounterName = "% Processor Time";
            Cpu.InstanceName = "1";

            User = new PerformanceCounter();
            User.CategoryName = "Processor";
            User.CounterName = "% User Time";
            User.InstanceName = "2";

            ram = new PerformanceCounter();
            ram.CategoryName = "Memory";
            ram.CounterName = "Available Bytes";
           
            timer1.Tick += timer_tick;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer_tick(object o , EventArgs e)
        {
            int cpu_p = (int)Cpu.NextValue();
            int User_p = (int)User.NextValue();
            int ram_p = (int)ram.NextValue();
            label_Cpu.Text = string.Format("CPU 가동률  :  {0}%",cpu_p);
            label_Cpu_Name.Text = string.Format("카운터 이름    :  {0}",Cpu.CounterName);
            label_Cpu_Help.Text = Cpu.CounterHelp;

            label_User.Text = string.Format("CPU 가동률  :  {0}%", User_p);
            label_User_Name.Text = string.Format("카운터 이름  :  {0}", User.CounterName);
            label_User_Help.Text = User.CounterHelp;

            label_Id.Text = string.Format("CPU 가동률  :  {0}kb", ram_p);
            label_Id_Name.Text = string.Format("카운터 이름  :  {0}", ram.CounterName);
            label_Id_Help.Text = ram.CounterHelp;

        }
    }
}
