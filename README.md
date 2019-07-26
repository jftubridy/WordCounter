input = cat:
input sentence = A catatonic cat can't categorize catheters without education.
A catatonic(no) cat(yes) can't categorize(no) catheters(no) without education(no).
count = 1. 

split inputSentence at  {' ', ',', '.', ';', ':', '!', '?', '/', '@', '#', '$', '%', '^', '^', '&', '*', '(', ')', '-', '_', '=', '+', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'}

check if any split off words in sentence.ToLower == input word

check if catatonic = word, it shouldn't


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