const int SW_0= 2;
const int SW_1 = 3;
const int LED_0 = 11;
const int LED_1 = 10;
int flag_0 = 0;
int flag_1 = 0;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(SW_0, INPUT);
  pinMode(LED_0, OUTPUT);
  pinMode(SW_1, INPUT);
  pinMode(LED_1, OUTPUT);
  
  
}

void loop() {
  // put your main code here, to run repeatedly:
  int val_0 = digitalRead(SW_0);
  int val_1 = digitalRead(SW_1);
  //Serial.println(val);
  
  if(val_0 == 1){
    if(flag_0 == 1){
      digitalWrite(LED_0, LOW);
      flag_0 = 0;
    }    
    else
    {
      digitalWrite(LED_0, HIGH);
      flag_0 = 1;
    }
    delay(300);
  }

  if(val_1 == 1){
    if(flag_1 == 1){
      digitalWrite(LED_1, LOW);
      flag_1 = 0;
    }    
    else
    {
      digitalWrite(LED_1, HIGH);
      flag_1 = 1;
    }
    delay(300);
  }
}
