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
 // Serial.print (" X-Axis");
  Serial.print (",");
  Serial.println (y, DEC);
 // Serial.print (" Y-Axis");
//  Serial.println (",");
  delay (100);
  /*
  if(x < 482) // down
  {
  	Serial.write("down"); 
  	Serial.flush();
	delay(20);
  }
  if(x > 502) // up
  {  
  	Serial.write("jump");
  	Serial.flush();
	delay(20); 
	
  }
  if(y > 522) // right
  {
  	Serial.write("right"); 
  	Serial.flush();
	delay(20);
  }
  if(y < 502) // left
  { 
    Serial.write("left");
  	Serial.flush();
	delay(20);	
  }
  */
 }