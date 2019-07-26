input = cat:
input sentence = A catatonic cat can't categorize catheters without education.
A catatonic(no) cat(yes) can't categorize(no) catheters(no) without education(no).
count = 1. 

check for a " " in input, if so return "one word please"
this will make sure i'm not getting "fat cat" as a word

check if "',', '.', ';', ':', '!', '?', '-', '_', comes after input  //don't need this can just split at that char too
was going to check special char, but can just split at them, which will filter out catatonic ect. 

check if any split off words in sentence.ToLower == word



Before coding, write plain English specs in a text file (or your README). Commit these before writing any code.

Each spec should include a specific input and output and a description sentence explaining why you selected that input value as the simplest way to test the behavior your spec covers.

Other Hints
Create a class called RepeatCounter containing logic for counting how many times a word appears in a string of words.

Using more than one method could make your logic easier to test. For instance, you might have one method to test whether input is valid, and another for searching the string of words.

Plain English specs were committed in a text file or README before coding.
Specs include specific input and output and a descriptive sentence.
Specs begin with the simplest possible behavior and progress to more complex cases, cover different input values.
All specs have been written up correctly as test methods.
All tests are passing, and described functionality is present.