 https://stackedit.io/app#
 
 # Learn BDD
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

A chess board is composed of a 8x8 ````case```
```TODO: image empty chess```

Horizontal rows are called **Rank**, while Vertical are called **File**
```TODO: image file/row```

Each ```case``` is identified with a unique number reflecting its position, File is first item of a position, while Rank is the last item.
````TODO: image positions board```

# Writing your first behavior

The branch to clone is ```Step1_FirstBehavior```

## Exploring solution architecture

-image de la solution avec explication ```TODO```

## User Story: 

A user story follow a simple template like:
**As a** <type of user>, **I want** <some goal>, **so that** <some reason>.

It also contains business rules.

From business rules, we can deduce functionnal examples.

Let's start with a first user story.

| User Story **Pawn** |
| ------------------- |
| As a pawn, I want to move following the chess rules, so that chess rules are respected |
| One step forward rule: A white pawn can move one step forward, in the rank direction. ```Introduce image``` |



-formalisation de l'US -> 1 seule règle

# Adding another behavior

-partir de la solution au point precedent
-branche à cloner = Step2_SecondBehaviorAndRefacto
-on complète l'US precedente, et on ajouter une US sur une autre piece
-réutilisation de steps, du scenario context

# Implementing all behaviors

-branche à cloner = Step3_AllBehaviors
-formalisation de l'ensemble des US

# Generating documentation

-usilisation de pickles

# Generating advanced documentation

-images
-test result
-xl, doc...