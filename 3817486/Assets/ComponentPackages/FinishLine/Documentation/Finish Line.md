**Finish Line User Guide**

This manual will explain the behaviours of the package and how it can be
used by someone to use in games.

**Behaviours**

DestroyPlayer Line

**DestroyPlayer**

This behaviour should be applied to the finish line or the object which
represents the finish line (which may have no mesh renderer). When the
player enters the trigger of the finish line, the player will be
destroyed from hierarchy. This is useful as it is the end of the race
etc. the player won't need to control the character anymore so
destroying them will be useful.

**Line**

This behaviour should be applied to the finish line or the object which
represents the finish line (which may have no mesh renderer). When the
player enters the trigger of the finish line, the UI on the canvas which
is linked to the behaviour will pop up once triggered and will disappear
after 5 seconds or any amount of seconds that the person may choose.
