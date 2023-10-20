// Phi_Publish_DHT11.ino
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

const char* clientId = "mqtt_phirippa";
const char* userId = clientId;
const char* userPw = "1234";
char *topic_t = "Sensors/MyOffice/Outdoor/temp";
char *topic_h = "Sensors/MyOffice/Outdoor/humi";
char* server = "192.168.2.33"; 

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
    delay(1000);
  }
  Serial.println("\nConnected to broker");
  dht.begin();
}

void loop() {
  char buf[20];
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  if (isnan(h) || isnan(t) ) {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }

  String str = String(h);
  str.toCharArray(buf, str.length());
  client.publish(topic_h, buf);
  Serial.println(String(topic_h) + " : " + buf);
  
  str = String(t);
  str.toCharArray(buf, str.length());
  client.publish(topic_t, buf);
  Serial.println(String(topic_t)  + " : " + buf);
  delay(2000);
}
