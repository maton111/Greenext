# String Calculator TDD Workshop
## How I develop

I have written the following code with Python 3.9 using as IDE PyCharm.

## How to launch the software

1. Instal Python in a version higher than 3.9
2. Download the repository on your device
3. Open the terminal
4. Enter the directory where you downloaded the repository
5. Digit the following code: **python3 main.py**
6. Write your String of number and wait for the outcome. If you want to proceed and write another, please write Y or y, otherwise N or n.

## Time needed to complete the steps
Create a simple String calculator with a method int Add(string numbers).

-[x] Total developing time 85 minutes


### Step 1 
Create a simple String calculator with a method int Add(string numbers).

1. The method can take 0, 1 or 2 numbers, separated by commas, and will return their sum, examples: 
  * **“”** should return **0**
  * **“1”** should return **1**
  * **“1,2”** should return **3**
2. Start with the simplest test case of an empty string and move to one and two numbers.
3. Remember to solve things as simply as possible so that you force yourself to write tests you did not think about.
4. Remember to refactor after each passing test.

-[x] Done and tested in 11 minutes

#### Tests Outcome

|  Input | Output |
|--------|--------|
|  0     | 0      |
|  1     | 1      |
|  4     | 4      |
|  4, 3  | 7      |

### Step 2
Allow the Add method to handle an unknown amount of numbers.

-[x] Done and tested in 2 minutes

#### Tests Outcome

| Input         | Output |
|---------------|--------|
| 4, 3, 3       | 10     |
| 4, 4, 4, 4, 4 | 20     |

### Step 3
Calling Add with a negative number will throw an exception **“negatives not allowed”** - and the negative that was passed.

If there are multiple negatives, show all of them in the exception message

-[x] Done and tested in 12 minutes

#### Tests Outcome

| Input     | Output                        |
|-----------|-------------------------------|
| 4, -1     | Negatives not allowed: -1     |
| -3        | Negatives not allowed: -3     |
| -3, -3    | Negatives not allowed: -3, -3 |
| 4, -3, -3 | Negatives not allowed: -3, -3 |

### Step 4
Numbers bigger than 1000 should be ignored, for example **“1000,2”** should return **2**

- [x] Done and tested in 5 minutes

#### Tests Outcome

| Input             | Output |
|-------------------|--------|
| 1000, 2           | 2      |
| 1000, 2, 1001, 2  | 4      |
| 13024, 2, 4, 3454 | 6      |

### Step 5
Support different delimiters
Delimiters can be of any length with the following format: 
  
* **“//[delimiter]//”**
  
for example: 

* **“//[\*\*\*]//1\*\*\*2\*\*\*3”**
  
should return **6**

-[x] Done and tested in 26 minutes

#### Tests Outcome

| Input                       | Output |
|-----------------------------|--------|
| //[\*\*\*]//1\*\*\*2\*\*\*3 | 6      |
| //[##]//5##4                | 9      |

### Step 6
Allow multiple delimiters like this:  

* **“//[delim1][delim2]//”**

for example 

* **“//[\*][%]//1\*2%3”**

should return **6**

-[x] Done and tested in 17 minutes

#### Tests Outcome

| Input               | Output |
|---------------------|--------|
| //[##][**]//5##4**4 | 13     |


### Step 7
Make sure you can also handle multiple delimiters with length longer than one char

-[x] Done and tested in 3 minutes

#### Tests Outcome

| Input                         | Output |
|-------------------------------|--------|
| //[a][ciao][ai]//1a45ciao2ai3 | 51     | 

### Step 8
General test of the whole program

-[x] Done and tested in 9 minutes

#### Tests Outcome

| Input                 | Output                                                               |
|-----------------------|----------------------------------------------------------------------|
| x                     | Please insert only number separated by comma with normal delimiter.  | 
| "Full of blank space" | 0                                                                    | 
| 4,,,,,,,4             | 8                                                                    | 
| ciao                  | Please insert only number separated by comma with normal delimiter.  | 
| 4 2                   | Please insert only number separated by comma with normal delimiter.  | 
| c42                   | Please insert only number separated by comma with normal delimiter.  | 
| @5                    | Please insert only number separated by comma with normal delimiter.  | 
| 4,,-1                 | Negatives not allowed: -1                                            | 
| 4&,5                  | Please insert only number separated by comma with normal delimiter.  | 