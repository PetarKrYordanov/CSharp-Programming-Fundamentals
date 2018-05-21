# Problem 3. Anonymous Vox

The Anonymous&#39;s main communication channel is based on encoded messages. The CIA has targetted that channel, assuming that it holds sensitive information. You have been hired to decode and break their internal com. system.

You will receive an input line containing a **single string** – the **encoded text**. Then, on the **next line** you will receive several values in the following format: &quot; **{value1}{value2}{value3}...**&quot;.

You must find the **encoded placeholders** in the **text** and **REPLACE** each one of them with the **value** that corresponds to its **index**.
**Example** : **placeholder1 – value1** , **placeholder2 – value2** etc. There may be **more values** than **placeholders** or **more placeholders** than **values**.

The **placeholders** consist of 3 blocks **{start}**** {placeholder} ****{end}**. The **start** should consist only of **English alphabet letters**. The **placeholder** may contain **ANY ASCII** character. The **end** should be **EXACTLY EQUAL** to the **start**. The idea is that you have to find the **placeholders** , and **REPLACE** their **placeholder** block with the **value** at that **index**.

Example Placeholders: &quot; **a****..... ****a**&quot;, &quot; **b****!d! ****b**&quot;, &quot; **asd**** xxxxx ****asd**&quot;, &quot; **pesho**** gosho ****pesho**&quot;...

You **must**** ALWAYS **match the placeholder with the** LONGEST ****start** and the **RIGHTMOST**** end **. For example if you have &quot;** asddvdasd **&quot; you should** NOT **match &quot;** d ****v**** d **&quot; as a placeholder, you should match &quot;** asd ****dvd**** asd**&quot;.

At the end you must **print** the **result**** text **, after you&#39;ve** replaced **the** values**.

### Input

- On the **first input line** you will receive the **encoded text**.
- On the **second input line** you will receive the **placeholders**.

### Output

- As output you must print a **single line** containing the **resulting text** , after the replacing of values.

### Constrains

- The **given**** text **may contain** ANY ASCII** character.
- The **given values** may contain **ANY ASCII** character except &#39; **{**&#39; and &#39; **}**&#39;.
- The **given values** will **AWLAYS** follow the format specified above.
- Allowed working **time/memory** : **100ms / 16MB**.

### Examples

| **Input** | **Output** |
| --- | --- |
| Hello\_mister,\_Hello{ Jack } | Hello Jack Hello |
| ASD\_\_\_asdfffasd{this}{exam}{problem}{is}{boring} | ASD\_\_\_asdthisasd |
| Whatsup\_ddd\_sup{Dude} | WhatsupDudesup |
| HeypalHey\_\_\_\_\_\_how\_ya\_how\_doin\_how{first}{second} | HeyfirstHey\_\_\_\_\_\_howsecondhow |

_...I know of no reason__..._