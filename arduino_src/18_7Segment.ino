const unsigned int led[8] = {3,4,5,6,7,8,9,10};
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
void setup() {
  // put your setup code here, to run once:
  for(int i = 0 ; i<8; i++){
    pinMode(led[i], OUTPUT);
  }

  // for(int i=0; i<8; i++){
  //   digitalWrite(led[i], HIGH);
  //   delay(500);
  // }
}
void display_fnd(int n){
   for(int j=0; j<8;j++){
    digitalWrite(led[j], num[n][j]);  
  }
}
void loop() {
//  for(int i=0; i<10;i++){
//   for(int j=0; j<8;j++){
//     digitalWrite(led[j], num[i][j]);  
//   }
//   delay(500);  
//  }

  for(int i=0; i<10; i++){
    display_fnd(i);
    delay(500);
  }
  
}
