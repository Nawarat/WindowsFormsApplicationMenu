using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Car_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = ("คำตอบของคุณ คือ " + Environment.NewLine);
            //เพศ
            if (radioButton2.Checked == true)
            {
                ans = ans + "เพศ : ชาย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "เพศ : หญิง" + Environment.NewLine;
            }
            // อายุ
            if (radioButton3.Checked == true)
            {
                ans = ans + "อายุ : น้อยกว่า 20 ปี" + Environment.NewLine;
            }
            else if (radioButton4.Checked == true)
            {
                ans = ans + "อายุ : 20 - 40 ปี" + Environment.NewLine;
            }
            else
            {
                ans = ans + "อายุ : มากกว่า 40 ปี" + Environment.NewLine;
            }
            //อายุรถ
            if (radioButton8.Checked == true)
            {
                ans = ans + "อายุรถ : ต่ำกว่า 5 ปี" + Environment.NewLine;
            }
            else if (radioButton7.Checked == true)
            {
                ans = ans + "อายุรถ : 5 - 10 ปี" + Environment.NewLine;
            }
            else
            {
                ans = ans + "อายุรถ : มากกว่า 10 ปี" + Environment.NewLine;
            }
            //คุณตรวจสภาพรถของคุณบ่อยแค่ไหน
            ans = ans + "คุณตรวจสภาพรถของคุณบ่อยแค่ไหน : ";
            if (radioButton9.Checked == true)
            {
                ans = ans + "บ่อยมาก" + Environment.NewLine;
            }
            else if (radioButton10.Checked == true)
            {
                ans = ans + "บ่อย" + Environment.NewLine;
            }
            else if (radioButton13.Checked == true)
            {
                ans = ans + "พอสมควร" + Environment.NewLine;
            }
            else if (radioButton11.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            // คุณตรวจสภาพรถ่อนออกเดินทางหรือไม่
            ans = ans + "คุณตรวจสภาพรถก่อนออกเดินทางหรือไม่ : ";
            if (radioButton17.Checked == true)
            {
                ans = ans + "ทุกครั้ง" + Environment.NewLine;
            }
            else if (radioButton16.Checked == true)
            {
                ans = ans + "เป็นบางครั้ง" + Environment.NewLine;
            }
            else if (radioButton18.Checked == true)
            {
                ans = ans + "นาน ๆ ครั้ง" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            //วิธีการตรวจสภาพรถของคุณ
            ans = ans + "วิธีการตรวจสภาพรถของคุณ : ";
            if (radioButton21.Checked == true)
            {
                ans = ans + "เข้าศูนย์" + Environment.NewLine;
            }
            else if (radioButton20.Checked == true)
            {
                ans = ans + "เข้าอู่" + Environment.NewLine;
            }
            else if (radioButton19.Checked == true)
            {
                ans = ans + "ตรวจด้วยตนเอง" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            //รถของคุณซ่อมบ่อยแค่ไหน
            ans = ans + "รถของคุณซ่อมบ่อยแค่ไหน : ";
            if (radioButton23.Checked == true)
            {
                ans = ans + "บ่อยมาก" + Environment.NewLine;
            }
            else if (radioButton22.Checked == true)
            {
                ans = ans + "บ่อย" + Environment.NewLine;
            }
            else if (radioButton24.Checked == true)
            {
                ans = ans + "พอสมควร" + Environment.NewLine;
            }
            else if (radioButton25.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            //คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน
            ans = ans + "คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน : ";
            if (radioButton27.Checked == true)
            {
                ans = ans + "มากที่สุด" + Environment.NewLine;
            }
            else if (radioButton28.Checked == true)
            {
                ans = ans + "มาก" + Environment.NewLine;
            }
            else if (radioButton30.Checked == true)
            {
                ans = ans + "พอสมควร" + Environment.NewLine;
            }
            else if (radioButton29.Checked == true)
            {
                ans = ans + "น้อย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ไม่เคยเลย" + Environment.NewLine;
            }
            ans = ans + "จัดทำโดย น.ส. นวรัตน์ จันทร์ขำ";
            MessageBox.Show(ans, "คำตอบของคุณ");
        }

    }
}
