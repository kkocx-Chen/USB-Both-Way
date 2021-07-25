#include <ShiftRegister74HC595.h>

int latchPin = 9;  // Latch pin (STCP腳位)
int clockPin = 10; // Clock pin (SHCP腳位)
int dataPin = 11;  // Data pin (DS腳位)
int button = 12;
char f;
ShiftRegister74HC595<1> sr(dataPin, clockPin, latchPin);

// 設置74595 LED單個
// 引數:
//  - pin(int) 74595腳位
//  - high(bool) 開/關
/*void set74595LED(int pin, bool high) {
  sr.set(pin, high);
  if(!high) {
    pin = 8 + pin;
  }
  Serial.write(pin);
}

// 設置74595 LED全部
// 引數:
//  - high(bool) 設置全開/關
void set74595All(bool high) {
  if(high) {
    sr.setAllHigh();
    Serial.write(0);
    Serial.write(1);
    Serial.write(2);
    Serial.write(3);
    Serial.write(4);
    Serial.write(5);
    Serial.write(6);
    Serial.write(7);
  }else{
    sr.setAllLow();
    Serial.write(8);
    Serial.write(9);
    Serial.write(10);
    Serial.write(11);
    Serial.write(12);
    Serial.write(13);
    Serial.write(14);
    Serial.write(15);
  }*/

void setup() 
{
  Serial.begin(115200);
  //74595全關
  sr.setAllLow();
  pinMode(button, INPUT);
}
void loop()
{
    if (Serial.available()>0){ //小於0不送資料
    f = Serial.parseInt();
 if (button == LOW) {
    switch(f) {
        case 1: //led 全亮
            sr.setAllHigh(); // set all pins HIGH
            Serial.flush();
            Serial.println("A ON");
        break;
    } 
    }else {
        sr.setAllLow();
    
    
    }
   


    
}
}