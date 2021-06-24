#Missile Launcher Manual#

Drag the package into the assets window of your Unity Project and click import on the pop up window.

Drag the script onto the obeject on the scene or the hiarchy that you want the missiles to instantiate from.
Note: Make sure this object is facing the directiontion you want the missile to move away from, the missile moves away in the direction of the objects blue arrow.
Note: Make sure that the objects box collider has Is 'Trigger ticked', so that the instantiated objects dont collide with the the object spawner.
Create a rigidbody for the object and untick 'Use Gravity' and tick 'Is Kinematic' to remove unwanted physics.
Opening up the Contraits tab on the Rigidbody tab and tick all 6 boxes, to make sure that the obect wont move in any way.

Make sure that the object you want to instantiate and move away is available in your assets file in the Project tab.
Drag the object from the Project tab into the Projectile box under the codes tab in the object spawners inspector.
Add the code to this object to in the Project tab.
Add a Rigidbody to this asset and untick 'Use Gravity'.
Open up the constraints and tick any rotation axis you dont want the missile to move in. (This is optional and will depend on your own project.)

If you wish to change the rate the missiles spawns, go to line 29 and change the number '2.0' to the number you wish to add. (This will work in seconds).
If you wish to change the speed the missiles move, go to line 37 and change the number '10' to any number you like.