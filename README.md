# OilRig-Training-Simulator
## The files presented here show the logic behind production of the Virtual Reality training simulator "OilRig Training Simulator":-

* The [**GestureDetector script**](Assets/Scripts/GestureDetector.cs) stores the vector 3 transforms of the skeleton that's wrapped around the player's hand in VR on a key press and calls the "OnRecognized" event after a "gesture" made by the player is same as the skeleton bone data stored through this script.
* The [**JoyStickControl script**](Assets/Scripts/JoystickControl.cs) checks the collision between the top of the lever and player's hand, and on collision moves the lever is the forward and backward direction only using the LookAt technique. On moving the lever forward and backward three times, an event gets executed 
* Finally, the [**PhysicsButton script**](Assets/Scripts/PhysicsButton.cs) gets the configurableJoint component of an object and based on the linear limit within that component, creates a threshold. Once the player moves the objects beneath the Y position (thus breaking the treshold), an OnPressed event is triggered and once the object reverts back to initial position, an OnReleased event is triggered. 
* Finally, the [**Timer script**](Assets/Scripts/Timer.cs) gives the project the ability to save a float based data into minutes:seconds:hours format, shows the data via a text component and saves the data in a .txt file which can be accessed from the oculus quest 2 /Android directory.
* Finally, the [**PlayerData script**](Assets/Scripts/PlayerData.cs), [**SaveData script**](Assets/Scripts/SaveData.cs) and [**SaveSystem script**](Assets/Scripts/SaveSystem.cs) used the Data serialization method with Persistant Datapath method to retrieve the current time stored by the Timer script above, create the .txt file in the /Android directory and open it to input the retrieved data from "current time" and close the file afterwards. These scripts works with timer and communicate with each other to create a save system for this project.
* Finally, the [**TriggerSystem script**](Assets/Scripts/TriggerSystem.cs) uses triggers like button presses, lever pulls and other mechanics to call events generated from the script itself, this script created the order in which events will be triggered for the player 
* Finally, the [**HandTrackingGrabber script**](Assets/Scripts/HandTrackinGrabber.cs) uses the "pinch" feature provided by oculus's finger tracking system to let the player grab objects by simply pinching on them in VR environment. While doing so, they can also move around with the GestureDetector script to interact with other objects.
## If you'd like to play the program on a quest 2, please follow these instructions:-
1. Download the  [**OilRig Trainer.apk**](https://drive.google.com/file/d/1WTGJ-mLGk28n3vuhOgInZ_9ItNfbJpP_/view?usp=sharing) file.
2. Go to SideQuestVR.com and click on the GET SIDEQUEST button at the top of the page.
3. Select the version for your computer's operating system, either Windows, Mac, or Linux.
4. Open the downloaded installer file.
5. Accept any security dialogs that appear and run through the installation process. Once the installer has completed, launch SideQuest from your Start Menu, applications menu, or quick launch bar.
6. Connect your Oculus Quest or Quest 2 to your PC using a USB cable. Put on your headset, and select Allow USB debugging.
7. Make sure to check Always allow from this computer.
8. Click the Install APK file from a folder on the computer button at the top of SideQuest and select the OilRig Trainer.apk file you downloaded.
9. From the Oculus home screen within the headset, select Library on the bottom bar. 
10. If you don't see the bottom bar, press the Home button on your right controller.
11. Select Unknown Sources from the right-most drop-down menu and then you should be able to select the OilRig Trainer Simulator file.

*In case these instructions are not clear, please look at this link for instructions :- https://www.androidcentral.com/how-sideload-apps-oculus-quest *

**To look at the time recorded please follow these steps:-**
1. Plug in the quest 2.
2. Wear the quest 2 and click on the “Allow” button in the VR environment.
3. Once you are done with the above step, please find a text file on This PC\Quest 2\Internal shared storage\Android\data\com.VRForTrainingSim.OilRigTrainingSimulator\files\Timestamp.txt.

### Additionally, a Videoclip will give you a quick demo of the software..
Demo             |
:-------------------------:|
[![](https://i.ytimg.com/vi/sYnfYWVbeMs/maxresdefault.jpg)](https://youtu.be/sYnfYWVbeMs "Oil Rig Training Simulator") |
