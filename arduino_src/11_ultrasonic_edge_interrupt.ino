#include <PinChangeInterrupt.h>
#include <PinChangeInterruptBoards.h>
#include <PinChangeInterruptPins.h>
#include <PinChangeInterruptSettings.h>

const int trig_pin = 11;
const int echo_pin = 12;

unsigned long echo_duration =0;

void echoIsr(void){
  static unsigned long echo_begin =0;
  static unsigned long echo_end =0;

  unsigned int echo_pin_state= digitalRead(echo_pin);
  if(echo_pin_state == HIGH){ //상승엣지
    echo_begin=micros();
  }
  else{ //하강엣지
    echo_end=micros();
    echo_duration = echo_end - echo_begin;
  }
}
void setup() {
  // put your setup code here, to run once:
  pinMode(trig_pin, OUTPUT);
  pinMode(echo_pin, INPUT);

  attachPCINT(digitalPinToPCINT(trig_pin), echoIsr, CHANGE);
  //attachPCINT(digitalPinToPCINT(echo_pin), echoIsr, CHANGE);

  Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(echo_duration == 0){
    digitalWrite(trig_pin, LOW);
    delayMicroseconds(2);
    digitalWrite(trig_pin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trig_pin, LOW);
  }
  else{
    unsigned long distance = (echo_duration/2) / 29.1;
    Serial.print(distance);
    Serial.println(" cm");

    echo_duration=0;
    //delay(500);
  }
}
