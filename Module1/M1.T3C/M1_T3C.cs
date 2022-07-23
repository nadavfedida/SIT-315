const uint8_t LED_RED = 5;
const uint8_t MotionSensor = 4;
const uint8_t Btn_one = 3;
const uint8_t Btn_two = 2;

uint8_t LED_STATE = LOW;

void setup()
{
  	Serial.begin(9600);
 	pinMode(Btn_one, INPUT_PULLUP);
   	pinMode(Btn_two, INPUT_PULLUP);
 	pinMode(MotionSensor, INPUT);
 	pinMode(LED_RED, OUTPUT);
  
	attachInterrupt(digitalPinToInterrupt(Btn_one), toggle1, RISING);
  	attachInterrupt(digitalPinToInterrupt(Btn_two), toggle2, RISING);

}

void loop()
{
  	int MotionDetected = digitalRead(MotionSensor);
	if (MotionDetected == HIGH)
    {
      LED_STATE = HIGH;
      digitalWrite(LED_RED, LED_STATE);
      Serial.println("Motion sensor");
      delay(10000);
      digitalWrite(LED_RED, LOW);
    }
}
void toggle1()
{
  LED_STATE = !LED_STATE;
  digitalWrite(LED_RED, LED_STATE);
  if (LED_STATE == HIGH) { Serial.println("Button 1 - ON"); }
  else { Serial.println("Button 1 - OFF"); }
}
                       
void toggle2()
{
  LED_STATE = !LED_STATE;
  digitalWrite(LED_RED, LED_STATE);
  if (LED_STATE == HIGH) { Serial.println("Button 2 - ON"); }
  else { Serial.println("Button 2 - OFF"); }
}