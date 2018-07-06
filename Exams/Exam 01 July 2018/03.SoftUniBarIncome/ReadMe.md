# Problem 3 – SoftUni Bar Income

Let`s take a break and visit the game bar at SoftUni. It is about time for the people behind the bar to go home and you are the person who has to draw the line and calculate the money from the products that were sold throughout the day. Until you receive a line with text **&quot;end of shift&quot;** you will be given lines of input. But before processing that line you have to do some validations first.

**Each valid order** should have a **customer, product, count and a price:**

- Valid customer&#39;s name should be **surrounded by &#39;**** %&#39; **and must** start with a capital letter **, followed by** lower-case letters**
- Valid product **contains any word character** and must be **surrounded by &#39;&lt;&#39; and &#39;&gt;&#39;**
- Valid count is an **integer** , **surrounded by &#39;|&#39;**
- Valid price is any **real number followed by &#39;$&#39;**

The parts of a valid order should appear in the order given: **customer, product, count and a price**.

Between each part there can be other symbols, except ( **&#39;|&#39;, &#39;$&#39;, &#39;%&#39; and &#39;.&#39;** )

For each valid line print on the console: **&quot;{customerName}: {product} - {totalPrice}&quot;**

When you receive **&quot;end of shift&quot;** print the total amount of money for the day **rounded to 2 decimal places** in the following format: **&quot;Total income: {income}&quot;****.**

## Input / Constraints

- Strings that you have to process until you receive text **&quot;end of shift&quot;.**

## Output

- Print all of the valid lines in the format **&quot;{customerName}: {product} - {totalPrice}&quot;**
- After receiving **&quot;end of shift&quot;** print the total amount of money for the day rounded to 2 decimal places in the following format: **&quot;Total income: {income}&quot;**
- Allowed working **time** / **memory** : **100ms** / **16MB**.

## Examples

| **Input** | **Output** | **Comment** |
| --- | --- | --- |
| %George%&lt;Croissant&gt;|2|10.3$%Peter%&lt;Gum&gt;|1|1.3$%Maria%&lt;Cola&gt;|1|2.4$end of shift | George: Croissant - 20.60Peter: Gum - 1.30Maria: Cola - 2.40Total income: 24.30 | Each line is valid, so we print each order, calculating the total price of the product bought.At the end we print the total income for the day  |
| %InvalidName%&lt;Croissant&gt;|2|10.3$%Peter%&lt;Gum&gt;1.3$%Maria%&lt;Cola&gt;|1|2.4%Valid%&lt;Valid&gt;valid|10|valid20$end of shift | Valid: Valid - 200.00Total income: 200.00 | On the first line, the customer name isn`t valid, so we skip that line.
The second line is missing product count.The third line don`t have a valid price.And only the forth line is valid |