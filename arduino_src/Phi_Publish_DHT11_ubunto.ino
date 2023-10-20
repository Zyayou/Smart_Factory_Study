// Phi_Publish_DHT11_ubunto.ino //그렇게 크게 달라진건 없음
#include <ESP8266WiFi.h>
#include <PubSubClient.h>

// ----- DHT11 ------------------------
#include "DHT.h"
#define DHTPIN D4     
#define DHTTYPE DHT11  //DHT11
DHT dht(DHTPIN, DHTTYPE);
// -------------------------------------

const char* ssid = "RiatechB2G";
const char* password = "12345678";

const char* userId = "ship";
const char* userPw = "1234";
const char* clientId = "23asdfasdfasd8sdf";
char *topic = "Sensors/MyOffice/Indoor/SensorValue";
char* server = "192.168.2.55"; 

WiFiClient wifiClient; 
PubSubClient client(server, 1883, wifiClient);

void setup() {
  Serial.begin(9600);
 
  Serial.print("\nConnecting to ");
  Serial.println(ssid);

  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(500);
  }
  Serial.println("\nWiFi Connected");
  
  Serial.println("Connecting to broker");
  while ( !client.connect(clientId, userId, userPw) ){ 
    Serial.print("*");
    Serial.print(client.state());
    delay(1000);
  }
  Serial.println("\nConnected to broker");
  dht.begin();
}
void loop() {
  char payload[80];
  float h = dht.readHumidity();
  float t = dht.readTemperature();

  if (isnan(h) || isnan(t) ) {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }

  String sPayload = "{'Temp':"
                +String(t, 1)	// 소수점 한 자리만 붙여서 생성
                +",'Humi':"
                +String(h, 1)
                +"}"; 

  sPayload.toCharArray(payload, 80);
  client.publish(topic, payload);
  Serial.print(String(topic) + " ");  Serial.println(payload);
  delay(2000);
}