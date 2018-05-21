# Problem 4. Anonymous Cache

The Anonymous are storing data on their dataservers about their activities. The CIA has higher the greatest hacker in the world – You. Your job is to extract their data and send it to the CIA. It won&#39;t be an easy task, Get Ready!

You will receive **several input lines** in one of the following formats:

- {dataSet}
- {dataKey} -&gt; {dataSize} | {dataSet}

The **dataSet** and **dataKey** are both strings. The **dataSize** is an **integer**. The **dataSets** hold **dataKeys** and their **dataSizes**.

If you receive only a **dataSet** you should **add** it. If you receive a **dataKey** and a **dataSize** , you should add them to the **given**** dataSet**.

And here&#39;s where the fun begins. If you receive a **dataKey** and a **dataSize** , but the given **dataSet**** does NOT exist **, you should** STORE **those** keys **and** values **in a** cache **. When the corresponding** dataSet **is** added **, you should** check **if the** cache **holds any** keys **and** values **referenced to it, and you should** add **them to the** dataSet**.

You should end your program when you receive the command &quot; **thetinggoesskrra**&quot;.  At that point you should extract the **dataSet** from the **data** with the **HIGHEST**** dataSize**(**SUM **of all its** dataSizes**), and you should print it.

**NOTE** : Elements in the **cache** , **should be CONSIDERED NON-EXISTANT**. You should **NOT** count them in the **final output**.

In case there are **NO**** dataSets **in the** data **, you** should ****NOT**** do anything**.

### Input

- The input comes in the form of commands in one of the formats specified above.
- The input ends when you receive the command &quot; **thetinggoesskrra**&quot;.

### Output

- As output you must print the **dataSet** with the **HIGHEST**** SUM **of all** dataSizes**.
- The output format is:

Data Set: {dataSet}, Total Size: {sumOfAllDataSizes}

$.{dataKey1}

$.{dataKey2}

...

- In case there are **NO**** dataSets **in the** data **, print** nothing**.

### Constrains

- The **dataSet** and **dataKey** are **both strings** which may contain **ANY ASCII** character except &#39;&#39;, &#39; **-**&#39;, &#39; **&gt;**&#39;, &#39; **|**&#39;.
- The **dataSize** is a **valid integer** in **range [0, 1.000.000.000]**.
- There will be **NO invalid input lines**.
- There will be **NO**** dataSets **with** EQUAL SUMMED **** dataSize**.
- There will be **NO DUPLICATE** keys.
- Allowed working **time/memory** : **100ms / 16MB**.

### Examples

| **Input** | **Output** |
| --- | --- |
| UsersBankAccountsADDB444 -&gt; 23111 | BankAccountsStudents -&gt; 2000 | UsersWorkers -&gt; 24233 | Usersthetinggoesskrra | Data Set: Users, Total Size: 26233$.Students$.Workers |
| CarsCar1 -&gt; 233333 | CarsCar23 -&gt; 266666 | CarsWarehouse2 -&gt; 10000 | BuildingsWarehouse3 -&gt; 480000 | BuildingsWarehouse5 -&gt; 100000 | BuildingsBuildingsthetinggoesskrra | Data Set: Buildings, Total Size: 590000$.Warehouse2$.Warehouse3$.Warehouse5 |

_...Why the Gunpowder treason_

_Should ever be forgot!..._

_                                                                                                       _ **V**