# Issue creating a marble maze with ProBuilder

## Game

I want to create a marble where the player controls the maze itself like in Zelda BOTW.

## What I did

- Create the maze from a Cube with ProBuilder and I extruded the boundaries of the maze
- Move the camera to have the right angle
- Add a script to rotate around the center of the mesh collider depending of input axis
- Add a Sphere and attach a rigidbody to it

## Problem

The sphere falls in the maze and is stopped by the collider but when I rotate the maze using the arrow keys the collider does not seems to rotate aswell since the sphere does not move.

![Preview of the bug in Unity](/bug.gif)
