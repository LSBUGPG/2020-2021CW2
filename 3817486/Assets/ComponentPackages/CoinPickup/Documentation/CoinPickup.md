**Coin Pickup User Guide**

This manual will explain the behaviours of the package and how it can be
used by someone to use in games.

**Behaviours**

PickupObject
ParticleDeath
KeepScore

**PickupObject -**

This behaviour should be applied to the player or destructive object
that will destory any object it touches. When the object enters a
trigger of another object, that said object would be destroyed by the
behaviour. This then removes the object from the hierarchy and the game
altogether.

**ParticleDeath -**

This behaviour should be applied to the coin or pickup object in the scene.
When the player or destructive object collides with the coin or pickup, the
particle effect will play for 2 seconds after it is destroyed. After those
2 seconds, the particle system will also be destroyed. The coin/pickup and
particle system will be destroyed and removed from the hiearchy, as long 
as **PickupObject** is also on the coin/pickup object.

**KeepScore -**

KeepScore is a script to count how many objects the player or character has
triggered/entered and updates a text gameobject on the canvas to reflect that.
The creator can choose how much score each object will give the player and what
the text on the canvas should say. The behaviour can also be modified to only
trigger for specific characters or enemies just by adding an if statement with
tags. 
