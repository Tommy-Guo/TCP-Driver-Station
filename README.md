# TCP-Driver-Station

This is a custom diver station with a custom skin written to control simple robots over a TCP connection. For my case, I used a Raspberry Pi as a controller on a mini robot. I used a wired Logitech Gamepad F310 controller as an input, it will work with other controllers but your mileage may vary. The purpose of sharing this is mainly for educational purposes but can be useful if you write your own client to connect to.

For those who have had the amazing pleasure of participating in FRC will surely recognize the theme's likeness to the FRC driver station it's design was based off of ;)

![](https://i.imgur.com/TUrCX4o.png)

The program will automatically detect and select the first joystick it finds and will begin tracking it's activity. The program runs a open TCP server that clients will detect and connect to. Since the program only send parsed joystick data to the client, you may choose and code which ever drive style you'd like your client.
