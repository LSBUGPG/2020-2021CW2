#Gravity Inverter Manual#

Drag the package into the assets window of your Unity Project and click import on the pop up window.

Drag the script onto player character object on the scene or in the hiarchy.

Go to the kill object's inspector, bring up the drop down on 'Tag', click 'Add Tag...', click the plus symbol in the 'Tags' section and type Lose. Note: If you want to use a different tag name, then make sure to change the word 'Lose', on line 20, to the identical word that you used for the tag name.
Go back to the kill object's inspector and click on the Tag's drop down menu and select your newly created tag.

In this example the code will freeze the game on collision, you can put whatever code you need for the game inside the if statement starting on line 20.