\*\*Checkpoints User Guide\*\*

This manual will explain the behaviours of the package and how it can be
used by someone to use in games.

\*\*Behaviours\*\*

Checkpoint\
NextCheckpoint

\*\*Checkpoint -\*\*

This behaviour should be applied to the object that will reset the
position of the player to the location of the checkpoint which they are
currently on. When the player enters the objects collider it will
trigger and send the player back to the set checkpoint which will be
chosen in the inspector. The player can be sent back to that checkpoint
as many times as the object with the trigger is still in the hierarchy.

\*\*NextCheckpoint -\*\*

This behaviour should be applied to an object with a collider that when
the player collides with it, it will remove the last checkpoint and the
object that triggers it. So, when the player hits the next object, it
will trigger and send them to the new checkpoint. This will then be the
viable checkpoint that will be used until destroyed like the last one.
