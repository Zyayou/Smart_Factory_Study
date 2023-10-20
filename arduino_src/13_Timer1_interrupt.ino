#include <TimerOne.h>



const int LED=11;
unsigned long ms = 0;

void timerIsr(void){
  ms++;
  //digitalWrite(LED, !digitalRead(LED));
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(LED, OUTPUT);
  //Timer1.initialize(500000);
  Timer1.initialize(1000);
  Timer1.attachInterrupt(timerIsr);
}

void loop() {
  // put your main code here, to run repeatedly:
 Serial.println(ms);
}
