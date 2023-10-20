const int Rx = 0;
const int LED = 13;

void setup() {
  // put your setup code here, to run once:
  pinMode(LED, OUTPUT);
   Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:
   if(Serial.available()){ //값이 들어오는지 안 들어오는지 확인
    int userInput = Serial.parseInt();
    Serial.println(userInput);

    analogWrite(LED, userInput/4);
  }
}
