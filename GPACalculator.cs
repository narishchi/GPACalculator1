using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator1
{
    public class GPACalculator
    {
        {
        private List<double> gpaList;  // เก็บข้อมูล GPA ทั้งหมด

        public GPACalculator()
        {
            gpaList = new List<double>(); // สร้าง List สำหรับเก็บ GPA
        }

        // ฟังก์ชันเพิ่ม GPA ลงใน List
        public bool SetGPA(double gpa)
        {
            if (gpa >= 0 && gpa <= 4)  // ตรวจสอบค่า GPA ว่าอยู่ระหว่าง 0 ถึง 4 หรือไม่
            {
                gpaList.Add(gpa);  // เพิ่ม GPA ลงใน List
                return true;
            }
            return false; // หากไม่ถูกต้องคืนค่า false
        }

        // ฟังก์ชันคำนวณ GPA เฉลี่ย
        public double GetGPAx()
        {
            if (gpaList.Count == 0)  // หากไม่มีค่า GPA ใน List ให้คืนค่า 0
                return 0;

            double sum = 0;
            foreach (var gpa in gpaList)
            {
                sum += gpa; // ผลรวม GPA
            }
            return sum / gpaList.Count;  // คืนค่า GPA เฉลี่ย
        }

        // ฟังก์ชันหาค่า GPA สูงสุด
        public double GetMaxGPA()
        {
            if (gpaList.Count == 0)  // หากไม่มีค่า GPA ใน List ให้คืนค่า 0
                return 0;

            double maxGPA = gpaList[0];
            foreach (var gpa in gpaList)
            {
                if (gpa > maxGPA) // เปรียบเทียบหา GPA สูงสุด
                {
                    maxGPA = gpa;
                }
            }
            return maxGPA; // คืนค่า GPA สูงสุด
        }

        // ฟังก์ชันหาค่า GPA ต่ำสุด
        public double GetMinGPA()
        {
            if (gpaList.Count == 0)  // หากไม่มีค่า GPA ใน List ให้คืนค่า 0
                return 0;

            double minGPA = gpaList[0];
            foreach (var gpa in gpaList)
            {
                if (gpa < minGPA) // เปรียบเทียบหา GPA ต่ำสุด
                {
                    minGPA = gpa;
                }
            }
            return minGPA; // คืนค่า GPA ต่ำสุด
        }

        // ฟังก์ชันคืนจำนวน GPA ที่เก็บไว้ใน List
        public int GetGPAListCount()
        {
            return gpaList.Count;
        }

        // ฟังก์ชันคืนค่า List ของ GPA ที่เก็บไว้
        public List<double> GetGPAList()
        {
            return new List<double>(gpaList); // คืนค่ารายการ GPA
        }
    }
}