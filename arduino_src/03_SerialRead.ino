const int LED[4] = {11,10,9,6};
void serialEventRun(){
  String userInput = Serial.readString();
  userInput.trim();   
  if(userInput == "LED_ON"){
    for(int i=0; i<4; i++){
      digitalWrite(LED[i], HIGH);
    }
  }
  else if(userInput =="LED_OFF"){
    for(int i=0; i<4; i++){
      digitalWrite(LED[i], LOW);
    }
  }
  // switch(userInput){
  //   case "LED_ON" :
  //           digitalWrite(LED, HIGH);
  //           break;
  //   case "LED_OFF" :
  //           digitalWrite(LED, LOW);
  //           break;
  //   default:
  //           break;
  // }
}
void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  for(int i=0; i<4; i++){
    pinMode(LED[i], OUTPUT);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  // if(Serial.available()){ //값이 들어오는지 안 들어오는지 확인
  //   char userInput = Serial.read();
  //   //Serial.print(userInput);
  //   //Serial.print('\n');
  //   //Serial.print('\r');
    
  //   switch(userInput){
  //     case 'n' :
  //             digitalWrite(LED, HIGH);
  //             break;
  //     case 'f' :
  //             digitalWrite(LED, LOW);
  //             break;
  //     default:
  //             break;
  //   }
  // }
}
