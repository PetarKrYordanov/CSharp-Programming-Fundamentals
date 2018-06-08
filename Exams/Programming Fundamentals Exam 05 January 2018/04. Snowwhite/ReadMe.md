## Problem 4 – Snowwhite

Snow White loves her dwarfs, but there are so many and she doesn&#39;t know how to order them. Does she order them by name? Or by color of their hat? Or by physics? She can&#39;t decide, so its up to you to write a program that does it for her.

You will be receiving **several input lines** which contain **data** about **dwarfs** in the following format:

{dwarfName} &lt;:&gt; {dwarfHatColor} &lt;:&gt; {dwarfPhysics}

The **dwarfName** and the **dwarfHatColor** are **strings**. The **dwarfPhysics** is an **integer**.

You must **store** the **dwarfs** in your program. There are several rules though:

- If **2 dwarfs** have the **same name** but **different color** , they should be **considered different dwarfs** , and you should store **both** of them.
- If **2 dwarfs** have the **same name** and the **same color** , **store** the **one** with the **higher physics**.

When you receive the command &quot; **Once upon a time**&quot;, the input ends. You must **order** the **dwarfs** by **physics** in **descending order** and thenby **total**** count **of** dwarfs **with the** same hat color **in** descending order**.
Then you must print them all.

## Input

- The input will consists of **several input lines** , containing **dwarf data** in the format, specified above.
- The input **ends** when you receive the command &quot; **Once upon a time**&quot;.

## Output

- As output you must print the **dwarfs** , **ordered** in the way , specified above.
- The output format is: **({hatColor}) {name} &lt;-&gt; {physics}**

## Constraints

- The **dwarfName** will be a **string** which may contain **any ASCII** character except &#39;&#39; ( **space** ), &#39; **&lt;**&#39;, &#39; **:**&#39;, &#39; **&gt;**&#39;.
- The **dwarfHatColor** will be a **string** which may contain **any ASCII** character except &#39;&#39; ( **space** ), &#39; **&lt;**&#39;, &#39; **:**&#39;, &#39; **&gt;**&#39;.
- The **dwarfPhysics** will be an **integer** in **range [0, 2**
# 31
 **– 1]**.
- There will be **no invalid** input lines.
- If **all sorting criteria fail** , the order should be by **order** of **input**.

- Allowed working **time** / **memory** : **100ms** / **16MB**.

## Examples

| **Input** | **Output** |
| --- | --- |
| Pesho &lt;:&gt; Red &lt;:&gt; 2000Tosho &lt;:&gt; Blue &lt;:&gt; 1000Gosho &lt;:&gt; Green &lt;:&gt; 1000Sasho &lt;:&gt; Yellow &lt;:&gt; 4500Prakasho &lt;:&gt; Stamat &lt;:&gt; 1000Once upon a time | (Yellow) Sasho &lt;-&gt; 4500(Red) Pesho &lt;-&gt; 2000(Blue) Tosho &lt;-&gt; 1000(Green) Gosho &lt;-&gt; 1000(Stamat) Prakasho &lt;-&gt; 1000 |
| Pesho &lt;:&gt; Red &lt;:&gt; 5000Pesho &lt;:&gt; Blue &lt;:&gt; 10000Pesho &lt;:&gt; Red &lt;:&gt; 10000Gosho &lt;:&gt; Blue &lt;:&gt; 10000Once upon a time | (Blue) Pesho &lt;-&gt; 10000(Blue) Gosho &lt;-&gt; 10000(Red) Pesho &lt;-&gt; 10000  |