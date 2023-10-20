#define Volt 5.0/1024.0
const int analogPin = A0;
char buf[200] ;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:
  int analogValue = analogRead(analogPin);
  sprintf(buf, "%d, %s V",analogValue, String(analogValue*Volt).c_str(), 2);
  // Serial.print(analogValue);
  // Serial.print(", ");
  // Serial.print(analogValue*Volt, 2);
  // Serial.println("V");
  Serial.println(buf);
  
}
