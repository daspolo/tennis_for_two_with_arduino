# tennis_for_two_with_arduino
Tennis for two game made with an arduino and Unity.

STEP TO REPRODUCE IT:

- Buy an arduino
- Buy a breadboard
- Buy 2 buttons
- Buy 2 potenziometers
- Buy Jumper Cables
- Download the Arduino IDE: https://www.arduino.cc/en/software

Add to the breadboard the two potenziometers and the two buttons, following the following image: 
![main](https://user-images.githubusercontent.com/80603037/117862800-5a4f1180-b293-11eb-98f3-2b6a26e24b6c.jpg)


Connect the breadboard 5V and GND to the two pins of Arduino. Connect the two potenziometer pins (+-) to the breadboard as you can see above.
Connect the two potenziometers pins to the analog output of arduino (A0 and A1). Connect the two GND of the buttons togheter and after connect them to the GND output of arduino. Connect the other side of the buttons to the two digital pins of arduino (in my case, I used the 2 and 5 pins).
![MVIMG_20210511_174426-min](https://user-images.githubusercontent.com/80603037/117863686-57085580-b294-11eb-9b55-12ad4b28681d.jpg)

![MVIMG_20210511_174448-min](https://user-images.githubusercontent.com/80603037/117863791-71423380-b294-11eb-84cb-0cca06fae3db.jpg)

Connect arduino to the computer, run the arduino IDE, download the TennisController.ino file from this repo and compile it.
Download the game for your OS from the releases of this repo and run the application. Specify the port of the arduino in which is connected.

<h3>Unity Project</h3>
Got this far? <a href="https://github.com/daspolo/tennis_for_two_with_arduino/tree/master">Here</a> you will find the project in unity and more information.
