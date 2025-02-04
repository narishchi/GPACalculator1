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

