const int LED[4] = {13,12,11,10};
void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  Serial.println(sizeof(LED));

  for(int i=0; i<(sizeof(LED)/sizeof(int)) ; i++){
    pinMode(LED[i],OUTPUT);
  }
  for(int i=0; i<(sizeof(LED)/sizeof(int)) ; i++){
    digitalWrite(LED[i],LOW);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
   for(int i=0; i<999;i++){
    for(int j=0; j<(sizeof(LED)/sizeof(int)) ; j++){
      digitalWrite(LED[j],LOW);
     }
    delayMicroseconds(999-i);

    for(int j=0; j<(sizeof(LED)/sizeof(int)) ; j++){
      digitalWrite(LED[j],HIGH);
     }
    delayMicroseconds(1+i);
  }  

  for(int i=0; i<999;i++){
     for(int j=0; j<(sizeof(LED)/sizeof(int)) ; j++){
      digitalWrite(LED[j],HIGH);
     }
    delayMicroseconds(999-i);
    
    for(int j=0; j<(sizeof(LED)/sizeof(int)) ; j++){
      digitalWrite(LED[j],LOW);
     }
    delayMicroseconds(1+i);
  }  
}
