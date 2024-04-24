# Math Operation Console App

This repository contains a simple C# console application that demonstrates method overloading in a class to perform different mathematical operations based on input types.

## Description

The `MathMethods2` class within the `MainMethodAssignment` namespace provides three overloaded methods, all named `MathOp`. Each method takes a different type of input and performs a unique mathematical operation:

- `MathOp(int number)` adds 7 to an integer.
- `MathOp(decimal number)` multiplies a decimal by 20 after converting it to an integer.
- `MathOp(string number)` takes a string, converts it to an integer, and then finds the remainder when it is divided by 3.
