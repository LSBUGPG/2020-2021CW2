# 2D Character Controller user guide

## CharacterController2D

This script can be applied to a `GameObject` to give it basic movement and jumping capabilities in 2D. It should have a `Rigidbody2D` attached in order to function correctly. Note that this script does not handle input or determine the movement speed by itself.

An empty gameObject should be placed at the base of the main object. This is then attached to the `Ground Check` slot. This allows the script to check for the ground.

## MovePlayer

This script works in conjunction with `CharacterController2D` to allow the player to control the `GameObject`'s movement. To use, apply this script to a `GameObject` containing the `CharacterController2D` script, then attach `CharacterController2D` to the `Controller` slot in the MovePlayer script.