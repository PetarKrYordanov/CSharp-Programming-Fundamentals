# Problem 3 – Snowflake

Tony and Andi have been researching the snowflake structure for quite some time now. They managed to write a program which extracts a text pattern from the snowflake, but it oftenly produces invalid data. They begged you to help them, so you must write a program which validates the text pattern.

The **snowflake** has **3 elements** :

- **Surface** – should **NOT** contain **letters** and **digits**.
- **Mantle** – should **ONLY** contain **digits** and **underscores** (&quot; **\_**&quot;).
- **Core** – should **ONLY** contain **letters**.

You will receive several input lines, which will represent the **snowflake**. A **valid** snowflake is in the following format:

{surface}
{mantle}
{surface}{mantle}{core}{mantle}{surface}
{mantle}
{surface}

You must check if **all elements** are **valid** , by the **rules specified above**. If even one element is invalid, you should print &quot; **Invalid**&quot;.

If all are valid you should print &quot; **Valid**&quot; and the **length** of the **core** part on the **next line**.

## Input

- The input will consist of exactly **5 input lines** , in the format **specified above**.

## Output

- If **all the elements** of the **snowflake** are **valid** , you must print &quot; **Valid**&quot;, and the **length** of the **core**.
- If **even one** of the **elements** is **invalid** , you must print &quot; **Invalid**&quot;.

## Constraints

- The elements of the input may contain **ANY ASCII character**.
- The **input** will **always consist** of **5 input lines**.
- The input **may not always** be in the **valid snowflake**** format**.

- Allowed working **time** / **memory** : **100ms** / **16MB**.

## Examples

| **Input** | **Output** |
| --- | --- |
| \*-\*1\_1\_1\*\*\*444asd444\*\*\*1\_1\_1\*-\* | Valid3 |
| !!!!!!14741-2Asdasdasdasd555!\_\_\_-- | Valid12 |
| AsdAsdAsdAsdasd  | Invalid |