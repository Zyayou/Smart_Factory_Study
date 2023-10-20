#include <ESP8266WiFi.h>
#include <PubSubClient.h>
const char* ssid = "RiatechB2G";
const char* password = "12345678";

const char* userId = "mqtt_phirippa";
const char* userPw = "1234";
const char* clientId = userId;

char *topicSub = "Sensors/MyOffice/Indoor/Lux";
char *topicPub = "Sensors/MyOffice/Indoor/Lamp";

char* server = "192.168.2.36"; 
char messageBuf[100];

void callback(char* topic, byte* payload, unsigned int length) {  
  Serial.println("Message arrived!\nTtopic: " + String(topic));
  Serial.println("Length: "+ String(length, DEC));
  strncpy(messageBuf, (char*)payload, length);
  messageBuf[length] = '\0';
  String ledState = String(messageBuf);
  Serial.println("Payload: "+ ledState + "\n\n");
}

WiFiClient wifiClient; 
PubSubClient client(server, 1883, callback, wifiClient);


#define USER_SW D8


void setup() {
  Serial.begin(9600);
 
  Serial.print("\nConnecting to ");
  Serial.println(ssid);

  // 해당 공유기에 접속 시도
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(500);
  }
  Serial.println("\nWiFi Connected");
  
  // 공유기로부터 할당 받은 "(사설)IP 주소" 출력
  Serial.print("Local IP address : ");
  Serial.println(WiFi.localIP());
  Serial.println("Connecting to broker");
  while ( !client.connect(clientId, userId, userPw) ){ 
    Serial.print("*");
    delay(1000);
  }
  Serial.println("\nConnected to broker");
  Serial.println(String("Subscribing! topic = ") + topicSub);
  client.subscribe(topicSub);

  pinMode(USER_SW, INPUT);

}

int SW_state = 0;

void loop() {
  client.loop();
  
  int userSwitch = digitalRead(USER_SW);

  if(userSwitch == HIGH){
    if(SW_state == 0){
      client.publish(topicPub, "off");
      Serial.println(String(topicPub) + " : " + "off");
      SW_state =1;
    }
    else{
      client.publish(topicPub, "on");
      Serial.println(String(topicPub) + " : " + "on");
      SW_state = 0;
    }

    delay(500);
  }

}

