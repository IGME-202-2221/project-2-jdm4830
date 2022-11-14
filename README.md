# Project Race Against The Pac

[Markdown Cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Here-Cheatsheet)

_REPLACE OR REMOVE EVERYTING BETWEEN "\_"_

### Student Info

-   Name: Jordan Mazza
-   Section: 202

## Simulation Design

My simulation will be like pacman but not stuck on a horizontal/vertical only movement. The player will control pac-man and try to eat as many
ghosts as they can. There will be another Agent as pacman also eating the ghosts. There will be a timer for a certain amount of time
and by the end of it, the player has to eat mroe ghosts then the agent. The ghosts will also respawn after they are eaten in the center
just like pacman.

### Controls

-   Player will move by WASD with keyboard input only, moving in any x/y direction.
    -   Keyboard movement
    -   The player will move the character to eat the ghosts

## Pac-Man

This is the player controlled agent.

### Original State

This is the state that the player starts out as in the beginning of the game

#### Steering Behaviors

- The player controls the player with WASD like normal, and moves at a normal speed!
   
#### State Transistions

- This agent is in this state in the begeinning of the game. 
   
### Eating State

This is the state when the player runs into the other ghosts. When they cross the ghost, they stop for 1 second, then can be controlled again.

#### Steering Behaviors

- Player controls pacman with WASD still, but will be slower moving the more ghosts you eat.
   
#### State Transistions

- When eating a ghost, it transitions to this state.

## Dark Pac-Man

This is the AI controlled pacman, that is also trying to eat ghosts. It is trying to eat more than the player before time runs out.

### Normal State

Eat as many ghosts as they can before the timer ends

#### Steering Behaviors

- _List all behaviors used by this state_
- Obstacles - Avoids the pillar objects
- Seperation -Seperates from the player
   
#### State Transistions

- Starts out the game in this state
   
### Eating State

Eats a ghost. Speeds up after each ghost is eaten. Opposite of the player state transition (slowing down)

#### Steering Behaviors

- State moves on its own
- Obstacles - Goes through pillars
- Seperation - Player Object
   
#### State Transistions

- Runs into a ghost

## Sources

-   _List all project sources here –models, textures, sound clips, assets, etc._
-   _If an asset is from the Unity store, include a link to the page and the author’s name_

## Make it Your Own

- I will make it my own by racing another pacman version of the player. The AI will speed up from each ghost it eats. The player will slow down with each ghost it eats. There will be pillars that the AI dodges. Ghosts will also respawn in the center after being eaten by the player or enemy AI.
- _If you will add more agents or states make sure to list here and add it to the documention above_
- _If you will add your own assets make sure to list it here and add it to the Sources section

## Known Issues

_List any errors, lack of error checking, or specific information that I need to know to run your program_

### Requirements not completed

_If you did not complete a project requirement, notate that here_

