# GPACalculator1
 # GPA Calculator Class Diagram

The following diagram represents the class structure of the GPA Calculator system.

```mermaid
classDiagram
    class GPACalculator {
        +List<double> gpaList
        +GPACalculator()
        +bool SetGPA(double gpa)
        +double GetGPAx()
        +double GetMaxGPA()
        +double GetMinGPA()
        +int GetGPAListCount()
        +List<double> GetGPAList()
    }

    class Form1 {
        +TextBox txtGPA
        +Button btnAddGPA
        +Button btnClear
        +Label lblAverage
        +Label lblMaxGPA
        +Label lblMinGPA
        +GPACalculator gpaCalculator
        +Form1()
        +void btnAddGPA_Click()
        +void UpdateGPAInfo()
        +void btnClear_Click()
    }

    Form1 "1" -- "1" GPACalculator : uses


#คำอธิบายเกี่ยวกับคลาสในระบบ
1. GPACalculator Class
คลาส GPACalculator มีฟังก์ชันหลักในการจัดการข้อมูล GPA ของนักศึกษา โดยใช้ List<double> เพื่อเก็บค่า GPA ที่กรอกเข้ามาและคำนวณข้อมูลต่างๆ:

Attributes:
gpaList: เป็น List<double> ที่เก็บค่าของ GPA ที่ผู้ใช้กรอกเข้ามา
Methods:
SetGPA(double gpa): ฟังก์ชันที่ใช้เพิ่มค่า GPA ลงใน gpaList หาก GPA อยู่ในช่วงที่ถูกต้อง (0 ถึง 4)
GetGPAx(): คำนวณและคืนค่า GPA เฉลี่ยจาก gpaList
GetMaxGPA(): คำนวณและคืนค่า GPA สูงสุดจาก gpaList
GetMinGPA(): คำนวณและคืนค่า GPA ต่ำสุดจาก gpaList
GetGPAListCount(): คืนค่าจำนวนของรายการ GPA ที่เก็บอยู่ใน gpaList
GetGPAList(): คืนค่ารายการ GPA ทั้งหมดที่เก็บใน gpaList
2. Form1 Class
คลาส Form1 เป็นคลาสที่ใช้งานใน UI (User Interface) และรับอินพุตจากผู้ใช้ โดยมีส่วนประกอบดังนี้:

Attributes:
txtGPA: ช่องกรอกข้อมูล GPA จากผู้ใช้
btnAddGPA: ปุ่มสำหรับเพิ่ม GPA ที่กรอกใน txtGPA
btnClear: ปุ่มสำหรับล้างข้อมูล
lblAverage, lblMaxGPA, lblMinGPA: ป้ายแสดงผล GPA เฉลี่ย, GPA สูงสุด, และ GPA ต่ำสุด
gpaCalculator: ตัวแปรที่เก็บอ็อบเจ็กต์ GPACalculator เพื่อคำนวณและเก็บข้อมูล GPA
Methods:
btnAddGPA_Click(): ฟังก์ชันที่ทำงานเมื่อคลิกปุ่ม "Add GPA" เพื่อตรวจสอบและเพิ่ม GPA ลงใน GPACalculator
UpdateGPAInfo(): ฟังก์ชันที่ใช้ในการอัปเดตผลลัพธ์ที่แสดงใน Labels (GPA เฉลี่ย, สูงสุด, ต่ำสุด)
btnClear_Click(): ฟังก์ชันที่ทำงานเมื่อคลิกปุ่ม "Clear" เพื่อรีเซ็ตการคำนวณทั้งหมดและล้างข้อมูลใน TextBox

