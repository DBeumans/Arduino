# Arduino To Unity

For our school project ( Endless runner ) we had to implement a 2 axis arduino controller.

Here we will show you the code what we put in to the arduino.

We used [Codebender.cc](https://codebender.cc) to write code for our arduino

(C++)

```c++
 int joyPin1 = A0;                
 int joyPin2 = A1;    


 void setup() {
  Serial.begin(9600);
 }

 void loop() {
   int x, y;
  x = analogRead (joyPin1);//getal 0 - 1023
  y = analogRead (joyPin2);
  Serial.print (x, DEC);
  Serial.print (",");
  Serial.println (y, DEC);
  delay (100);
  ```


Now go to your Unity project and create a new C# script and name it what ever you want, for example " Arduino Support ".

Open your script and past te following code:

[Code](https://github.com/DBeumans/Arduino/blob/master/Scripts/ArduinoSupport.cs)

