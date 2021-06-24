#Ascend Script Manual#

Drag the package into the assets window of your Unity Project and click import on the pop up window.

Drag this script onto the object you would like to control. Make sure this object has a rigidbody componet and make sure all the Constraint > Freeze rotation axis are ticked.

The code uses the key E to move upwards, the code will allow gravity to act upon it, which means that the object will fall when the key is released.

If you wish to change the speed of the ascent, go to the objects inspector and you can change the number in the Upwards Speed value under the AscendScript component.
If you wish to change the key used, please go to line 21 in the AscendScript script and change the letter "E" after "KeyCode." to any key you would like to use.