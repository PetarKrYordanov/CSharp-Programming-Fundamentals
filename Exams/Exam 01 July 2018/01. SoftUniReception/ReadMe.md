# Problem 1 – SoftUni Reception

Every day thousands of students pass by the reception at SoftUni with different questions to ask and the employees have to help everyone by providing all the information and to answer all of the questions.

There are **3 employees** working on the reception all day. Each of them can handle **different number**** of students ****per hour**. Your task is to **calculate how much time** it will take to **answer all the questions** of given number of students.

First you will receive 3 lines with integers, representing **count of students that each of the employee can**  **help per**  **hour.** On the next line you will receive **students count as a single integer**.

**Every forth**  **hour all of the employees have a break, so they don&#39;t work**  **for a**  **hour.** This is the only break for the employees, because they don`t need rest, nor have a personal life. Calculate the time needed to answer all the student&#39;s questions and print it in the following format: **&quot;Time needed: {time}h.&quot;**

## Input / Constraints

- On first three lines -   **each employee efficiency** -  integer in range **[1 - 100]**
- On the fourth line - **students count** – integer in range **[0 – 10000]**
- Input will always be valid and in the range specified

## Output

- Print a single line: **&quot;Time needed: {time}h.&quot;**
- Allowed working **time** / **memory** : **100ms** / **16MB**

## Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| 56420 | Time needed: 2h. | All employees can answer 15 students per hour. After the first hour there are 5 students left to be answered.All students will be answered in the second hour. |
| 12345 | Time needed: 10h. | All employess can answer 6 students per hour. In the first 3 hours they have answered 6 \* 3 = 18 students. Then they have a break for an hour.After the next 3 hours there are
18 + 6 \* 3 = 36 answered students. After the break for an hour, there are only 9 students to answer.So in the 10th hour all of the student&#39;s questions would be answered. |
| 32540 | Time needed: 5h. |   |