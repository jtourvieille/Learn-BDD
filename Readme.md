
 https://stackedit.io/app#
 
 # Learn BDD
 This serie of exercices is made to learn BDD practically. It is divided into linked steps. Follow them in order to achieve the full course.
 We use ```C#``` as reference language, but any other object oriented language is fine four our needs. The application uses the minimal external libraries, to limit the overhead. 
 ```mstest``` and ```SpecFlow``` are the needed libraries
 # Application pitch
 The application is based on the chess game. We need to implement move rules for each piece of the game, ie: **pawn**, **rook**, **knight**, **bishop**, **queen** and **king**.
 We will simplify the full game rules by considering that the board empty. Thus, we do not consider "collisition" or "blocking path" problematics.
# Cloning the right branch
This repository contains multiple branches targetting different aspects of BDD.
- ```Step1_FirstBehavior``` is the starting point to write your first Gherkin, and implement your first behavior
- ```Step2_SecondBehaviorAndRefacto``` shows how to share steps between Features/Scenarios
- ```Step3_AllBehaviors``` is the starting point to complete a fully acceptable documented implementation
- ```Step4_DocGeneration``` uses pickles as a generating tool, to produce a readeable website describing your application
- ```Step5_AdvancedDocGeneration``` show some advanced techniques to go further with the documentation
- ```FinalStep``` contains all the previous stuff

# Board explanation

-definition du board, file, rank, numérotation...
The board is defined as a 8x8 boxes.
[Empty Board](Images/EmptyBoard.png)
Vertical indexing is called **File**, while horizontal indexing is called **Rank**.
[File Rank Board](Images/FileRankBoard.png)
Combining **File** and **Rank** gives a **Position** on the chessboard.
[Board](Images/Board.png)

# Writing your first behavior

## Exploring solution architecture

Our starting point will be this solution:
[Initial solution](Images/InitialSolution.png)
It contains 2 projects:
-**Chess**: the implementation project
-**Chess.Tests**: the test project

All needed libraries are already referenced. You should not use another one.

## User Story: 

A user story follow a simple template like:
**As a** ```type of user```, **I want** ```some goal```, **so that** ```some reason```.

It also contains **business rules**.

From one **business rules**, we can deduce one or more **functionnal examples**. They are finally translated into **Scenarios**. Generally, a **User Story** is mapped to a **Feature**.

Let's start with a first User Story.

>User Story **Pawn**
As a pawn, I want to move following the chess rules, so that chess rules are respected.
One step forward rule: A white pawn can move one step forward, in the vertical direction.
[Board](Images/Pawn-1.png)

## Goal
Now that you have a Business rule, you have to transform it into real code!
>**Tip**: start by adding a new SpecFlow feature file.