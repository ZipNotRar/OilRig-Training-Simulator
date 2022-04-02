# OilRig-Training-Simulator
## The files presented here show the logic behind production of the Virtual Reality training simulator "OilRig Training Simulator":-

* The [**GestureDetector script**](Assets/Scripts/GestureDetector.cs) stores the vector 3 transforms of the skeleton that's wrapped around the player's hand in VR on a key press and calls the "OnRecognized" event after a "gesture" made by the player is same as the skeleton bone data stored through this script.
* The [**JoyStickControl script**](Assets/Scripts/JoystickControl.cs) checks the collision between the top of the lever and player's hand, and on collision moves the lever is the forward and backward direction only using the LookAt technique. On moving the lever forward and backward three times, an event gets executed 
* Finally, the [**PhysicsButton script**](Assets/Scripts/PhysicsButton.cs) gets the configurableJoint component of an object and based on the linear limit within that component, creates a threshold. Once the player moves the objects beneath the Y position (thus breaking the treshold), an OnPressed event is triggered and once the object reverts back to initial position, an OnReleased event is triggered. 
* Finally, the [**Timer script**](Assets/Scripts/Timer.cs) gives the project the ability to save a float based data into minutes:seconds:hours format, shows the data via a text component and saves the data in a .txt file which can be accessed from the oculus quest 2 /Android directory.
* Finally, the [**PlayerData script**](Assets/Scripts/PlayerData.cs), [**SaveData script**](Assets/Scripts/SaveData.cs) and [**SaveSystem script**](Assets/Scripts/SaveSystem.cs) used the Data serialization method with Persistant Datapath method to retrieve the current time stored by the Timer script above, create the .txt file in the /Android directory and open it to input the retrieved data from "current time" and close the file afterwards. These scripts works with timer and communicate with each other to create a save system for this project.
* Finally, the [**TriggerSystem script**](Assets/Scripts/TriggerSystem.cs) uses triggers like button presses, lever pulls and other mechanics to call events generated from the script itself, this script created the order in which events will be triggered for the player 
* Finally, the [**HandTrackingGrabber script**](Assets/Scripts/HandTrackinGrabber.cs) uses the "pinch" feature provided by oculus's finger tracking system to let the player grab objects by simply pinching on them in VR environment. While doing so, they can also move around with the GestureDetector script to interact with other objects.

### Additionally, a Videoclip will give you a quick demo of the software..
Run-Through             |
:-------------------------:|
[![](http://img.youtube.com/vi/_fxo8h80w28/0.jpg)](http://www.youtube.com/watch?v=_fxo8h80w28 "Stardome - A 3D Dome Painting Experience!!") |
