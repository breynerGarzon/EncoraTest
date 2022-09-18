# Test summary

This test was built with the aim of generating an algorithm that allows the reordering of a text string regardless of its content. This ordering must be given in two factors.

 1. Based on the greatest number of alphabetic characters.
 2. Based on alphabetical order.

The above describes how the algorithm should work, but in addition to this, the number of text strings to reorder must also be requested through a console application.

# Proposed solution
 
This test is composed of a solution segmented into 4 layers which are segmented by responsibility, each layer is a project in .Net 5 and these are

- **Encora.ConsoleApp:** It is a console application whose responsibility is to request through the console the amount of string that will be the input to execute the reordering algorithm. This layer will capture the strings but will pass them to the **_Encora.Business_** layer, so that it performs the processing and reordering of the data.
- **Encora.Business:** It is a class library project whose responsibility
 is to perform algorithm processing, this layer exposes services represented by Interfaces that can be consumed by console applications, web apis, WPF applications, etc. For this test, this layer exposes the **_ISortedServices_** service, which performs the reordering of a text string based on the number of characters and alphabetical order. This same layer was used for the **_Encora.Business.Test_** layer for unit testing.
- **Encora.Model:** It is a class library that provides the dto classes or models that will be used to move data between the different layers of the test. As such it only has object definitions and has no business logic or implementations.
- **Encora.Business.Test:** It is an xunit testing project whose responsibility is to make the unit tests that will evaluate the operation of the layer **_Encora.Business_** for this layer a single class was developed, which will work under an input value and expected value allowing to interpret if the tests are successful.

# How to run the solution

1. Open the solution **_EncoraTest_**
2. Run project **_Encora.ConsoleApp_**.
3. The end user must enter the number of text strings to evaluate.
4. The end user must enter the number of text strings to be evaluated 1 by 1.
5. After entering the total number of strings, the original text strings will be printed along with their respective order.

# Evidence of functional tests:
To validate the functional tests, 6 test cases have been proposed where each of these varies in the number of strings to be processed and the content of each of these.

## Test case 1
 - Number of string: 2
 - String values
	
| Original string value | Expected value string
|-----------|:-----------:
|abaccadcc|ccccaaabd
|xyzxy|xxyyz
- Execution evidence

![image](https://user-images.githubusercontent.com/42897915/190917702-ee75b4eb-cdc4-4780-8f87-fc37bd4b1ad0.png)

## Test case 2
 - Number of string: 10
 - String values

| Original string value | Expected value string
|-----------|:-----------:
||
||
||
||
||
||
||
||
||
||
- Execution evidence

## Test case 3
 - Number of string: 5
 - String values

| Original string value | Expected value string
|-----------|:-----------:
||
||
||
||
||
- Execution evidence

## Test case 4
 - Number of string: 10
 - String values

| Original string value | Expected value string
|-----------|:-----------:
||
||
||
||
||
||
||
||
||
||

## Test case 5
 - Number of string: 3
 - String values

| Original string value | Expected value string
|-----------|:-----------:
||
||
||

- Execution evidence


## Test case 6
 - Number of string: 5
 - String values

| Original string value | Expected value string
|-----------|:-----------:
||
||
||
||
||

- Execution evidence
