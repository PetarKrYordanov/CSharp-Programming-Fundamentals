# 1.Exercises: Arrays

Problems for exercises and homework for the [&quot;Programming Fundamentals&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

You can check your solutions here: [https://judge.softuni.bg/Contests/207/Arrays-Exercises](https://judge.softuni.bg/Contests/207/Arrays-Exercises).

1. 1.Largest Common End

Read **two**** arrays ****of**** words **and find the length of the** largest common end** (left or right).

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| **hi php java** csharp sql html css js **hi php java** js softuni nakov java learn | 3 | The largest common end is at the left: **hi php java** |
| hi php java xml csharp **sql html css js** nakov java **sql html css js** | 4 | The largest common end is at the right: **sql html css js** |
| I love programmingLearn Java or C# | 0 | No common words at the left and right |

### Hints

- Scan the arrays from left to right until the end of the shorter is reached and count the equal elements.
- Scan the arrays form right to left until the start of the shorter is reached.
- Keep the start position and the length of the longest equal start / end.

1. 2.Rotate and Sum

To &quot; **rotate** an array on the right&quot; means to move its last element first: {1, 2, 3}  {3, 1, 2}.

Write a program to read an array of **n**** integers**(space separated on a single line) and an integer**k **, rotate the array right** k ****times** and sum the obtained arrays after each rotation as shown below.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 3 2 4 -12 | 3 2 5 6  | rotated1[] = -1  3  2  4rotated2[] =  4 -1  3  2sum[] =  3  2  5  6 |
| 1 2 31 | 3 1 2  | rotated1[] = 3 1 2sum[] = 3 1 2 |
| 1 2 3 4 53 | 12 10 8 6 9  | rotated1[] = 5  1  2  3  4rotated2[] = 4  5  1  2  3rotated3[] = 3  4  5  1  2sum[] = 12 10  8  6  9 |

### Hints

- After **r** rotations the element at position **i** goes to position **(i + r) % n**.
- The **sum[]** array can be calculated by two nested loops: for **r** = **1** … **k** ; for **i** = **0** … **n-1**.

1. 3.Fold and Sum

Read an array of **4\*k** integers, fold it like shown below, and print the sum of the upper and lower two rows (each holding 2 \* k integers):

 ![](data:image/*;base64,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)

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 5 **2 3** 6 | 7 9 | 5  6  +2  3  =7  9 |
| 1 2 **3 4 5 6** 7 8 | 5 5 13 13 | 2  1  8  7  +3  4  5  6  =5  5 13 13 |
| 4 3 -1 **2 5 0 1 9 8** 6 7 -2 | 1 8 4 -1 16 14 | -1  3  4 -2  7  6  + 2  5  0  1  9  8  = 1  8  4 -1 16 14 |

### Hints

- Create the **first row** after folding: the first **k** numbers reversed, followed by the last **k** numbers reversed.
- Create the **second row** after folding: the middle 2\ ***k** numbers.
- **Sum** the first and the second rows.

1. 4.Sieve of Eratosthenes

Write a program to find **all prime numbers in range [1…n]**. Implement the algorithm called &quot;Sieve of Eratosthenes&quot;: [https://en.wikipedia.org/wiki/Sieve\_of\_Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes). Steps in the &quot;Sieve of Eratosthenes&quot; algorithm:

1. Assign **primes** [0… **n**] = **true**
2. Assign **primes** [0] = **primes** [1] = **false**
3. Find the smallest **p** , whichholds **primes** [**p**] = **true**
  - Print **p** (it is prime)
  - Assign **primes** [2\ ***p**] = **primes** [3\ ***p**] = **primes** [4\ ***p**] = … = **false**
4. Repeat for the next smallest **p** &lt; **n**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 6 | 2 3 5 |
| 25 | 2 3 5 7 11 13 17 19 23 |

1. 5.Compare Char Arrays

Compare two char arrays lexicographically (letter by letter).

Print the them in alphabetical order, each on separate line.

### Examples

| **Input** | **Output** |
| --- | --- |
| a b cd e f | abcdef |
| p e t e ra n n i e | anniepeter |
| a n n i ea n | anannie |
| a ba b | abab |

### Hints

- Compare the first letter of **arr1[]** and **arr2[]**, if equal, compare the next letter, etc.
- If all letters are equal, the smaller array is the **shorter**.
- If all letters are equal and the array lengths are the same, the arrays are **equal**.

1. 6.Max Sequence of Equal Elements

Write a program that finds the **longest sequence of equal elements** in an array of integers. If several longest sequences exist, print the leftmost one.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 1 1 2 3 3 **2 2 2** 1 | 2 2 2 |
| **1 1 1** 2 3 1 3 3 | 1 1 1 |
| **4 4 4 4** | 4 4 4 4 |
| 0 **1 1** 5 2 2 6 3 3 | 1 1 |

### Hints

- Start with the sequence that consists of the first element: **start** = **0** , **len** = **1**.
- Scan the elements from left to right, starting at the second element: **pos** = **1** … **n-1**.
  - At each step compare the current element with the element on the left.
    - Same value you have found a sequence longer by one **len** ++.
    - Different value start a new sequence from the current element: **start** = **pos** , **len** = **1**.
  - After each step remember the sequence it is found to be longest at the moment: **bestStart** = **start** , **bestLen** = **len**.
- Finally, print the longest sequence by using **bestStart** and **bestLen**.

1. 7.Max Sequence of Increasing Elements

Write a program that finds the **longest increasing subsequence** in an array of integers. The longest increasing subsequence is a **portion of the array** (subsequence) that is strongly **increasing** and has the **longest possible length**. If several such subsequences exist, find the left most of them.

### Examples

| **Input** | **Output** |
| --- | --- |
| 3 **2 3 4** 2 2 4 | 2 3 4 |
| 4 5 **1 2 3 4 5** | 1 2 3 4 5 |
| **3 4 5 6** | 3 4 5 6 |
| **0 1** 1 2 2 3 3 | 0 1 |

### Hints

- Use the same algorithm like in the previous problem (Max Sequence of Equal Elements).

1. 8.Most Frequent Number

Write a program that finds the **most frequent number** in a given sequence of numbers.

- Numbers will be in the range [0…65535].
- In case of multiple numbers with the same maximal frequency, print the leftmost of them.

### Examples

| **Input** | **Output** | **Output** |
| --- | --- | --- |
| **4** 1 1 **4** 2 3 **4 4** 1 2 **4** 9 3 | 4 | The number **4** is the most frequent (occurs 5 times) |
| **2 2 2 2** 1 **2 2 2** | 2 | The number **2** is the most frequent (occurs 7 times) |
| **7 7 7** 0 2 2 2 0 10 10 10 | 7 | The numbers **2** , **7** and **10** have the same maximal frequence (each occurs 3 times). The leftmost of them is **7**. |

1. 9.Index of Letters

Write a program that creates an array containing all letters from the alphabet ( **a** - **z** ). Read a lowercase word from the console and print the **index of each of its letters in the letters array**.

### Examples

| **Input** | **Output** |
| --- | --- |
| abcz | a -&gt; 0b -&gt; 1c -&gt; 2z -&gt; 25 |
| softuni | s -&gt; 18o -&gt; 14f -&gt; 5t -&gt; 19u -&gt; 20n -&gt; 13i -&gt; 8 |

1. 10.Pairs by Difference

Write a program that **count the number of pairs** in given array **which**** difference is equal to given number**.

### Input

- The **first line** holds the **sequence of numbers**.
- The **second line** holds the **difference**.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 5 3 4 22 | 3 | Pairs of elements with difference 2 -&gt; {1, 3}, {5, 3}, {4, 2} |
| 5 3 8 10 12 11 | 0 | No pairs with difference 1 |

1. 11.Equal Sums

Write a program that determines if there **exists an element in the array** such that the **sum of the elements on its left** is **equal** to the **sum of the elements on its right**. If there are **no elements to the left / right** , their **sum is considered to be 0**. Print the **index** that satisfies the required condition or **&quot;no&quot;** if there is no such index.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 1 233 | 2 | At a[2] -&gt; left sum = 3, right sum = 3a[0] + a[1] = a[3] |
| 1 2 | no | At a[0] -&gt; left sum = 0, right sum = 2At a[1] -&gt; left sum = 1, right sum = 0No such index exists |
| 1 | 0 | At a[0] -&gt; left sum = 0, right sum = 0 |
| 1 2 3 | no | No such index exists |
| 10 5 5993 4 2 5 1 1 4 | 3 | At a[3] -&gt; left sum = 20, right sum = 20a[0] + a[1] + a[2] = a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10] |