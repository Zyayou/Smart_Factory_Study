#include <PinChangeInterrupt.h>
#include <PinChangeInterruptBoards.h>
#include <PinChangeInterruptPins.h>
#include <PinChangeInterruptSettings.h>

unsigned long t1_prev=0;
const unsigned long t1_delay = 300;
unsigned long t2_prev=0;
const unsigned long t2_delay = 100;

const int SW_0= 4;
const int SW_1 = 5;
const int LED_0 = 11;
const int LED_1 = 10;
int flag_0 = 0;
int flag_1 = 0;

void SW0_Pressed(){
   flag_0 = (flag_0 == 0)? 1:0;
}
void SW1_Pressed(){
    if(flag_1 == 1){
      flag_1 = 0;
    }    
    else
    {
      flag_1 = 1;
    }
}

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(SW_0, INPUT);
  pinMode(LED_0, OUTPUT);
  pinMode(SW_1, INPUT);
  pinMode(LED_1, OUTPUT);
  
    attachPCINT(digitalPinToPCINT(SW_0), SW0_Pressed, RISING);
    attachPCINT(digitalPinToPCINT(SW_1), SW1_Pressed, RISING);
}

void loop() {
  unsigned long t1_now = millis()  ;
  unsigned long t2_now = millis()  ;
  if(t1_now - t1_prev >= t1_delay){
    if(flag_0 == 1){
      digitalWrite(LED_0, !digitalRead(LED_0));
    }
    else{
      digitalWrite(LED_0, LOW);
    }
      t1_prev = t1_now;
  }

  
  if(t2_now - t2_prev >= t2_delay){
    if(flag_1 == 1){
      digitalWrite(LED_1, !digitalRead(LED_1));
    }
    else{
      digitalWrite(LED_1, LOW);
    }
    t2_prev = t2_now;
  }
 
}

