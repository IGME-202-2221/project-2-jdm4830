# Project Race Against The Pac

[Markdown Cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Here-Cheatsheet)

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

-   BGM: PacMan Theme Remix - https://www.youtube.com/watch?v=qtZ0hl-unM4

## Make it Your Own

- I will make it my own by racing another pacman version of the player. The AI will speed up from each ghost it eats. The player will slow down with each ghost it eats. There will be pillars that the AI dodges. Ghosts will also respawn in the center after being eaten by the player or enemy AI.
- The player controls Pac Man. The AI controls dark pac man. Dark Pac Man has increased attributes like speed, turn angle, vision range, and distance. You have to beat dark pac man before the time limit runs out at eating the ghosts. Once the timer is done, whoever has the high score wins!

## Known Issues

-The timer does not function, netiher does the score for eating ghosts.
-Could not get collission with ghosts with Pac Man & Dark Pac Man, which would cause the score to increase.

### Requirements not completed

-My agents dont really have any varying behavior that I could get to work successfully... 
-Could not get collission with ghosts with Pac Man & Dark Pac Man, which would cause the score to increase.

