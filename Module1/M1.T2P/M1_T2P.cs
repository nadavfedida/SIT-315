const uint8_t LED_RED = 4;
const uint8_t MotionSensor = 2;
uint8_t LED_STATE = LOW;

void setup()
{
  	Serial.begin(9600);
 	pinMode(MotionSensor, INPUT_PULLUP);
 	pinMode(LED_RED, OUTPUT);
	attachInterrupt(digitalPinToInterrupt(MotionSensor), toggle, FALLING);
}

void loop()
{
 delay(10000); 
}
void toggle()
{
  LED_STATE = !LED_STATE;
  digitalWrite(LED_RED, LED_STATE);
  if (LED_STATE == HIGH) { Serial.write("No motion \n"); }
  else { Serial.write("Motion \n"); }
}