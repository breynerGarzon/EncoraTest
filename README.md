# Test summary

This test was built with the aim of generating an algorithm that allows the reordering of a text string regardless of its content. This ordering must be given in two factors.

 1. Based on the greatest number of alphabetic characters.
 2. Based on alphabetical order.

The above describes how the algorithm should work, but in addition to this, the number of text strings to reorder must also be requested through a console application.

# Proposed solution

This test is composed of a solution segmented into 4 layers which are segmented by responsibility, each layer is a project in .Net 5 and these are

- **Encora.ConsoleApp:** It is a console application whose responsibility is to request through the console the amount of string that will be the input to execute the reordering algorithm. This layer will capture the strings but will pass them to the **Encora.Business** layer, so that it performs the processing and reordering of the data.
- **Encora.Business:** It is a class library project whose responsibility
 is to perform algorithm processing, this layer exposes services represented by Interfaces that can be consumed by console applications, web apis, WPF applications, etc. For this test, this layer exposes the **_ISortedServices_** service, which performs the reordering of a text string based on the number of characters and alphabetical order. This same layer was used for the **_Encora.Business.Test_ layer. ** for unit testing.
- **Encora.Model:** It is a class library that provides the dto classes or models that will be used to move data between the different layers of the test. As such it only has object definitions and has no business logic or implementations.
- **Encora.Business.Test:** It is an xunit testing project whose responsibility is to make the unit tests that will evaluate the operation of the layer **_Encora.Business_** for this layer a single class was developed, which will work under an input value and expected value allowing to interpret if the tests are successful.

