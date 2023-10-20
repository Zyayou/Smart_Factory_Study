#include <ESP8266WiFi.h>
#include <PubSubClient.h>
#include <Wire.h>
#include <BH1750.h>

BH1750 lightMeter;

#define USER_LED  D0
const char* ssid = "RiatechB2G";
const char* password = "12345678";

const char* userId = "mqtt_ship";
const char* userPw = "1234";
const char* clientId = userId;
char *topicSub = "Sensors/MyOffice/Indoor/Lamp";
char *topicPub = "Sensors/MyOffice/Indoor/Lux";
char* server = "192.168.2.36"; 
char messageBuf[100];

void callback(char* topic, byte* payload, unsigned int length) {  
  Serial.println("Message arrived!\nTtopic: " + String(topic));
  Serial.println("Length: "+ String(length, DEC));
  strncpy(messageBuf, (char*)payload, length);
  messageBuf[length] = '\0';
  String ledState = String(messageBuf);
  Serial.println("Payload: "+ ledState + "\n\n");
  if( ledState == "on" ){      digitalWrite(USER_LED, LOW);
  } else if (ledState=="off") { digitalWrite(USER_LED, HIGH);
  } else {                      Serial.println("Wrong Message"); }
}

WiFiClient wifiClient; 
PubSubClient client(server, 1883, callback, wifiClient);

void setup() {
  pinMode(USER_LED, OUTPUT);
  Serial.begin(9600);
  
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");     delay(1000);
  }
  Serial.println("\nWiFi Connected");
 
  while ( !client.connect(clientId, userId, userPw) ){ 
    Serial.print("*");     delay(1000);
  }
  Serial.println("\nConnected to broker");
  Serial.println(String("Subscribing! topic = ") + topicSub);
  client.subscribe(topicSub);
 }

void loop() { 
  client.loop();

  char buf[20];
  String strLuxValue =  String( lightMeter.readLightLevel() );
  strLuxValue.toCharArray(buf, strLuxValue.length() );
  client.publish(topicPub, buf);
  Serial.println(String(topicPub) + " : " + buf);
  delay(7000);
}