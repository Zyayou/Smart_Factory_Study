#define Volt 5.0/1024.0
const int analogPin = A0;
char buf[200] ;
const int LED[4] = {3,5,6,9};

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  for(int i=0; i<4;i++){
    pinMode(LED[i], OUTPUT);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  int analogValue = analogRead(analogPin);
  sprintf(buf, "%d, %s V",analogValue, String(analogValue*Volt).c_str(), 2);
  Serial.println(buf);


  unsigned long val = map(analogValue, 200, 1000, 0,255);
  analogWrite(LED[3], val);
  // for(int i=0; i<4; i++){
  //   if(analogValue > (1024/5*(1+i))){
  //     digitalWrite(LED[i], HIGH);  
  //   }
  //   else{
  //     digitalWrite(LED[i], LOW);  
  //   }

  for(int i=0; i<4; i++){
    if(analogValue/256>=(1+i)){
      analogWrite(LED[i], 255);  
    }
    else if(analogValue/256>=(0+i)){
      analogWrite(LED[i], int(analogValue%256/256.0*255));  
    }
  }

//저항계산
  // float V2 = analogValue*Volt;
  // float V1 = 5.0-V2;
  // float R2 = V2*10000/V1;
  // Serial.println(R2);
  
  
}
