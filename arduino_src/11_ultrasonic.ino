const int trig_pin = 11;
const int echo_pin = 12;

void setup() {
  // put your setup code here, to run once:
  pinMode(trig_pin, OUTPUT);
  pinMode(echo_pin, INPUT);

  Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(trig_pin, LOW);
  delayMicroseconds(2);
  digitalWrite(trig_pin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig_pin, LOW);
  
  //불안정함? 좀이상함
  unsigned long t_begin = millis();
  long duration = pulseIn(echo_pin, HIGH);
  unsigned long t_end = millis();
  Serial.print(t_end - t_begin);
  Serial.print(" ms ");
  long distance = (duration/2) / 29.1;

  Serial.print(distance);
  Serial.println(" cm");

  delay(500);
}
