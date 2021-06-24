**Door Opener Button User Guide**

This manual will explain the behaviours of the package and how it can be used by someone to use in games.

**Behaviours:**

OpenDoor
 CloseDoor

**Open Door –**

This behaviour should be applied to an object which will be pressed to open a door. The behaviour reacts to the players mouse reacting with the object&#39;s collider. This in turn translates and moves the door upwards using Vector3.up to a designated height that the developer can choose.

**Close Door –**

This behaviour can be added to the same object that _Open Door_ is applied to but can also be added to a separate object. This behaviour will close a door that may already be open or was opened by the _Open Door_ object. When the player clicks on the object, it will move the door downwards using Vector3.down to a designated height chosen by the developer.