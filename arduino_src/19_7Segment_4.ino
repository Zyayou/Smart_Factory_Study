const unsigned int led[8] ={2,3,4,5,6,7,8,9};
const unsigned int com[4] ={10,11,12,13};

int num[10][8] = {{1,1,1,1,1,1,0,0},
{0,1,1,0,0,0,0,0},
{1,1,0,1,1,0,1,0},
{1,1,1,1,0,0,1,0},
{0,1,1,0,0,1,1,0},
{1,0,1,1,0,1,1,0},
{1,0,1,1,1,1,1,0},
{1,1,1,0,0,0,0,0},
{1,1,1,1,1,1,1,0},
{1,1,1,0,0,1,1,0}
};
void display_fnd(int n){
  display_clear();
  for(int j=0; j<8;j++){
    digitalWrite(led[j], !num[n][j]);  
  }
}

void display_clear(){
  for(int j=0; j<8;j++){
    digitalWrite(led[j], HIGH);  
  }
}

void setup() {
  // put your setup code here, to run once:
  for (int i=0; i<8; i++){
    pinMode(led[i], OUTPUT); 
  }
  for (int i=0; i<8; i++){
    digitalWrite(led[i], HIGH);
  }

  for (int i=0; i<4;i++){
    pinMode(com[i], OUTPUT); 
  }
  for (int i=0; i<4;i++){
    digitalWrite(com[i], LOW); 
  }
  
}

void loop() {
  // put your main code here, to run repeatedly:

  digitalWrite(com[0], HIGH);
  display_fnd(1);
  delay(5);
  digitalWrite(com[0], LOW);
  
  digitalWrite(com[1], HIGH);
  display_fnd(2);
  delay(5);
  digitalWrite(com[1], LOW);
  
  digitalWrite(com[2], HIGH);
  display_fnd(3);
  delay(5);
  digitalWrite(com[2], LOW);
  
  digitalWrite(com[3], HIGH);
  display_fnd(4);
  delay(5);
  digitalWrite(com[3], LOW);


}
