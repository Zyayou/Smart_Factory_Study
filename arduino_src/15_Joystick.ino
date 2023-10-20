const int Xin = A0;
const int Yin = A1;
const int KEYin = 3;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(KEYin, INPUT_PULLUP); //PULLUP : 내부 5V사용, 저항을 안쓸수 있지만 로직이 반대가 됨(안누르면1, 누르면0)
}

void loop() {
  // put your main code here, to run repeatedly:
  int xVal = analogRead(Xin);
  int yVal = analogRead(Yin);
  int buttonVal = digitalRead(KEYin);

  Serial.print("X = ");
  Serial.println(xVal, DEC);
  Serial.print("Y = ");
  Serial.println(yVal, DEC);
  Serial.print("button is ");
  if(buttonVal == HIGH){
    Serial.println("Not Pressed");
  }
  else{
    Serial.println("Pressed");
  }
  
}
