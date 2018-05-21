# Problem 1. Padawan Equipment

Yoda is starting his newly created Jedi academy. So, he asked master Ivan Cho to **buy** the **needed equipment**. The number of **items** depends on **how many students will sign up**. The equipment for the Padawan contains **lightsabers, belts and robes**.

You will be given **the amount of money Ivan Cho has** , the **number of students** and the **prices of each item**. You have to help Ivan Cho **calculate** if the **money** he has is **enough to buy all of the equipment** , or how much more money he needs.
Because the lightsabres sometimes brake, Ivan Cho should **buy 10% more** , **rounded up** to the next integer.Also, every **sixth belt is free**.

## Input / Constraints

The input data should be read from the console. It will consist of **exactly 5 lines** :

- The **amount of money** Ivan Cho has – **floating-point number** in **range [0.0****0****…1,000.00]**
- The **count of students – integer in range [0…100]**
- The **price of lightsabers** for a **single**  **sabre**  **– floating-point number** in **range [0.****0****0…100.00]**
- The **price of robes** for a **single robe – floating-point number** in **range [0.****0****0…100.00]**
- The **price of belts** for a **single**** belt – floating-point number **in** range [0.0 ****0**** …100.00]**

The **input data will always be valid**. **There is no need to check it explicitly**.

## Output

The output should be printed on the console.

- **If the calculated price of the equipment is less or equal to the money Ivan Cho has:**
  - **oo**&quot; **The money is enough - it would cost {the cost of the equipment}lv.**&quot;
- **If the calculated price of the equipment is more than the money Ivan Cho has:**
  - **oo**  &quot; **Ivan Cho will need {neededMoney}lv more.**&quot;
- **All prices** must be **rounded to two digits after the decimal point.**

## Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 10021.02.03.0 | The money is enough - it would cost 13.00lv. | Needed equipment for 2 padawans  :sabresPrice\*(studentsCount + 10%) + robesPrice \* (studentsCount) +beltsPrice\*(studentsCount-freeBelts)1\*(3) + 2\*(2) + 3\*(2) = 13.0013.00 &lt;= 100 – the money will be enough. |
| **Input** | **Output** | **Comments** |
| 1004212.04.03.0 | Ivan Cho will need 737.00lv more. | Needed equipment for 42 padawans:12\*47 +4\*42 +3\*35 = 837.00837&gt;100 – need 737.00 lv. more. |

_...May_ _the force
 be with you_ _..._