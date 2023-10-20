#include <Servo.h>

const int SERVO = 10;
const int analogPin = A0;
Servo servo;
void setup() {
  // put your setup code here, to run once:
  servo.attach(SERVO);
  servo.write(0);

  delay(1000);

  // for(int cnt=0;cnt<2;cnt++){
  //   servo.write(0);
  //   delay(1000);
  //   servo.write(180);
  //   delay(1000);
  // }

  // servo.detach();
}

void loop() {
  int analogValue = analogRead(analogPin);
  Serial.print(analogValue);
  unsigned long val = map(analogValue, 0, 1024, 0,180);
  servo.write(val);
}
