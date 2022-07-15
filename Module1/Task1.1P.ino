const int LED = 2;
const int MotionSensor = 3;
int CurrentMotionStatus = LOW;
int NewMotionStatus = LOW;

void setup()
{
  Serial.begin(9600);
  pinMode(MotionSensor, INPUT);
  pinMode(LED, OUTPUT);
}

void loop()
{
  NewMotionStatus = digitalRead(MotionSensor);
  if ( CurrentMotionStatus == LOW && NewMotionStatus == HIGH)
  {
    CurrentMotionStatus = HIGH;
    Serial.println("Motion detected!");
    digitalWrite(LED, HIGH); 
    delay(1000);
    digitalWrite(LED, LOW);
  	delay(1000); 
  }
  if(CurrentMotionStatus == HIGH && NewMotionStatus == LOW);
  {
    CurrentMotionStatus = LOW;
    Serial.println("---- No Motion ----");
  }
}