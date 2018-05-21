# Problem 3. Star Enigma

The war is in its peak, but you, young Padawan, can turn the tides with your programming skills. You are tasked to create a program to **decrypt** the messages of The Order and prevent the death of hundreds of lives.

You will receive several messages, which are **encrypted** using the legendary star enigma. You should **decrypt the messages** , following these rules:

To properly decrypt a message, you should **count all the letters**** [s, t, a, r] **–** case insensitive **and** remove **the count from the** current ASCII value of each symbol** of the encrypted message.

After decryption:

Each message should have a **planet name, population, attack type (&#39;A&#39;, as attack or &#39;D&#39;, as destruction) and soldier count.**

The planet name **starts after****&#39;@&#39; **and contains** only letters from the Latin alphabet**.

The planet population **starts after &#39;:&#39;** and is an **Integer** ;

The attack type may be **&quot;A&quot;(attack) or &quot;D&quot;(destruction)** and must be **surrounded by &quot;!&quot;** (exclamation mark).

The **soldier count** starts after **&quot;-&gt;&quot;** and should be an Integer.

The order in the message should be: **planet name -&gt; planet population -&gt; attack type -&gt; soldier count.** Each part can be separated from the others by **any character except: &#39;@&#39;, &#39;-&#39;, &#39;!&#39;, &#39;:&#39; and &#39;&gt;&#39;.**

## Input / Constraints

- The **first line**** holds n **– the number of** messages **–** integer in range [1…100];**
- On the next **n** lines, you will be receiving encrypted messages.

## Output

After decrypting all messages, you should print the decrypted information in the following format:

First print the attacked planets, then the destroyed planets.
**&quot;Attacked planets: {attackedPlanetsCount}&quot;
&quot;-&gt; {planetName}&quot;
&quot;Destroyed planets: {destroyedPlanetsCount}&quot;
&quot;-&gt; {planetName}&quot;**

The planets should be **ordered by name**** alphabetically.**

## Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 2 **ST** CDoghudd4=63333$D$0 **A** 53333EHf **s** y **ts** nhf?8555&amp;I&amp;2C9555 **SR** | Attacked planets: 1-&gt; AlderaaDestroyed planets: 1-&gt; Cantonica | We receive two messages, to decrypt them we calculate the key:First message has decryption key 3. So we substract from each characters code 3. **PQ@**** Alderaa ****1:**** 30000 ****!**** A ****!-&gt;**** 20000 **The second message has key 5.** @ ****Cantonica**** : ****3000****! ****D****!-&gt; ****4000**** NM ****Both messages are valid** and they contain planet, population, attack type and soldiers count. After decrypting all messages we print each planet according the format given. |
| **Input** | **Output** | **Comments** |
| 3 **tt** (&#39;&#39;DG **s** vywge **r** x&gt;6444444444%H%1B9444GQh **rr** | **A** 977777(H( **TTTT** EHf **s** y **ts** nhf?8555&amp;I&amp;2C9555 **SR** | Attacked planets: 0Destroyed planets: 2-&gt; Cantonica-&gt; Coruscant | We receive three messages.Message one is decrypted with key 4: **pp$##@**** Coruscant ****:**** 2000000000 ****!**** D ****!-&gt;**** 5000 **Message two is decrypted with key 7:** @ ****Jakku**** : ****200000****! ****A****!MMMM **This is** invalid message **, missing soldier count, so we continue.The third message has key 5.** @ ****Cantonica**** : ****3000****! ****D****!-&gt; ****4000**** NM** |

&quot;It&#39;s a trap!&quot; – Admiral Ackbar