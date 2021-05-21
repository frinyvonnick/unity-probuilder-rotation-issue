# Issue creating a marble maze with ProBuilder

## Game

I want to create a marble where the player controls the maze itself like in Zelda BOTW.

## What I did

1 - Create the maze from a Cube and I extruded the boundaries of the maze
2 - Move the camera to have the right angle
3 - Add a script to rotate around the center of the mesh collider depending of input axis
4 - Add a Sphere and attach a rigidbody to it

## Problem

The sphere falls in the maze and is stopped by the collider but when I rotate the maze using the arrow keys the collider does not seems to rotate aswell since the sphere does not move.
