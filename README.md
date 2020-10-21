# C# OOP PRactice - Pen Class

## Deadline: October 22, 2020, 9am
## Last edited: October 21, 2020

## Author: Krisztina Pap

## Instructions
### Introduction
This practice is designed to help you familiarize yourself with class creation, as well as the instantiation of objects.
### Requirements
- Code written in Program.cs to test the functionality of your class.
- “Pen” class created:

#### Properties:
- “Brand”
- “Colour”
- “InkLevel”
Backing variable is a double representing mL.
Validates that the value must be between 0 and “MaxInk” at all times.
- “MaxInk”
Double value representing mL.
- “HasLid”

#### Methods:
“Write()”
- Overloaded method that will either accept no parameters or a character count.
- Subtract ink for the character count provided (one character equals 0.05mL of ink).
- If the method is called with no parameters, assume the character count is 10.
Greedy and default constructors.

### Challenges
Research and implement a ToString() override that will output a string in the format: “This is a red Bic pen without a lid with approximately 55% of the ink remaining.”
- Round the ink level to the nearest 5%.
- Use at least one ternary statement.


## Trello Project Board:
https://trello.com/b/jXgRVdWw/c-oop-practice-pen

## References/Citations
- [submain: Parameterless Constructor](https://blog.submain.com/c-constructor-usage-examples-best-practices/)