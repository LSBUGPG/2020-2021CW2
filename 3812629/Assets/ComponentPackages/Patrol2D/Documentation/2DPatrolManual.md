# 2D Patrol Behaviour user guide

## Patrol2D Script

The Patrol 2D contains a behaviour that will cause the attached object to move to the right until it reaches the end of the surface it is one. At which point it changes direction and moves left. This will repeat this indefinitely.

The speed variable determines the speed of the object. The distance variable determines how far down the raycast will look to check if the character is on the ground. A second, empty gameObject must be placed at the base of the main object, directly infront of where it will move. This is used to determine if the object should turn around. This gameObject should then be attached to Ground Detection.

The included prefab contains all of this set up correctly for reference.
