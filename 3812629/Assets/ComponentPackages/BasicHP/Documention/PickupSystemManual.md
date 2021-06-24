# Pickup System user guide

## PickupSystem script and prefab

This script contains the variable associated with the pickup. It is also where you link the script to your UI to display the variable. Do this by attaching the text element you want to use to display it to the pickupCountText gameObject reference. Note that it is configured by default to use TextMeshPro, as this is more commonly used. If you wish to use regular text, you can edit this on line 14.

The script should be attached to an empty gameObject. The prefab is an empty gameObject with the script already attached.

## Pickup script and prefab

The Pickup script attaches to the pickup. When an object with the "player" tag collides with the pickup it will trigger. Upon triggering it will change the value of the pickupCount variable in the PickupSystem script by the number defined in the countChange variable.

The prefab contains a basic object with the script attached to it. The model can be swapped for one of your choosing and then the prefab reused as needed.

Also note that the example scene does not inclued a means of collecting the pickup, but does show how to correctly connect the script to the UI.
