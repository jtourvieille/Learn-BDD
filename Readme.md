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