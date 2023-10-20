#include <PinChangeInterrupt.h>
#include <PinChangeInterruptBoards.h>
#include <PinChangeInterruptPins.h>
#include <PinChangeInterruptSettings.h>

const int SW_0= 4;//2;
const int SW_1 = 5; //3;
const int LED_0 = 11;
const int LED_1 = 10;
int flag_0 = 0;
int flag_1 = 0;

void SW0_Pressed(){
    if(flag_0 == 1){
      digitalWrite(LED_0, LOW);
      flag_0 = 0;
    }    
    else
    {
      digitalWrite(LED_0, HIGH);
      flag_0 = 1;
    }
}
void SW1_Pressed(){
    if(flag_1 == 1){
      digitalWrite(LED_1, LOW);
      flag_1 = 0;
    }    
    else
    {
      digitalWrite(LED_1, HIGH);
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
  
  // attachInterrupt(digitalPinToInterrupt(SW_0), SW0_Pressed, RISING);
  // attachInterrupt(digitalPinToInterrupt(SW_1), SW1_Pressed, RISING);
    attachPCINT(digitalPinToPCINT(SW_0), SW0_Pressed, RISING);
    attachPCINT(digitalPinToPCINT(SW_1), SW1_Pressed, RISING);
}

void loop() {
  // put your main code here, to run repeatedly:
}
