using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CalcRunner
{
    public partial class CalcRunner : Form
    {
        public CalcRunner()
        {
            InitializeComponent();

            myProcess.StartInfo = new ProcessStartInfo("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess.Start();
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Ошибка при запуске калькулятора: {ex.Message}","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }   
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                // Закрытие главного окна процесса
                myProcess.CloseMainWindow();

                // Освобождаем память
                myProcess.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при остановке калькулятора: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
