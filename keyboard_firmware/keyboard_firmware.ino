#include <SPI.h>
enum {GAME, WIN, LOOSE};
unsigned char game=GAME;
unsigned char bg[3] = {32, 0, 45};
const unsigned int bitMask[16] = {4,2,128,64,8192,16384,4096,32768, 256,1024,2048,1,8,16,32,512};
//const unsigned int lightsScript[37] = {0, 5, 31, 63, 127, 511, 2047, 4095, 2047, 511, 127, 63, 31, 5, 0, 2048, 3584, 3968, 4032, 4064, 4090, 4095, 4090, 4064, 4032, 3968, 3584, 2048, 0, 2053, 3103, 4031, 4095, 4031, 3103, 2053, 99999};
//const unsigned int lightsScript1[15] = {0, 1, 2, 1024, 2048, 512, 256, 64, 32, 16, 4, 8, 128, 4095};
const unsigned int lightsScript[36] = {
    1029, 3471, 4063, 4095, 4063, 3471, 1029, 0,
    1025, 3337, 3353, 3385, 3961, 4091, 4095,
    4091, 3961, 3385, 3353, 3337, 1025, 0,
    4, 134, 710, 742, 758, 3070, 4095,
    3070, 758, 742, 710, 134, 4, 0
};
const unsigned int lightsScript1[15] = {1, 2048, 2, 4, 128, 64, 32, 16, 8, 1024, 256, 512, 4095, 0};
const unsigned int outMask[16] = {1, 1024, 2048, 16, 32, 64, 256, 512, 8, 128, 4, 2, 4096, 8192, 16384, 32768};
//                                +   +     +    !  -   -  -   -   +   +  +   +   !
unsigned char demo=0;
double alpha=0;
unsigned long in=0, out=0, keyPressd=0;
unsigned long rxDelay;
unsigned char downLow, downHigh;
unsigned char pressedLow;
unsigned char pressedHigh;
unsigned char releasedLow;
unsigned char releasedHigh;
unsigned long time;
unsigned char out1, out2;
unsigned char states1, states2;
void convertInput(){
  unsigned int s, r=0;
  s = states1 | (states2<<8);
  for(char i=0;i<16;i++){
      if(s & (1<<(i))) r+=bitMask[15-i];
  }
  states1 = r>>8;
  states2 = r;
}
uint8_t last_input_states1 = 0, last_input_states2 = 0;
String inputString ="";
enum { REG_LATCH = 11 };
void statusStrip(){
  unsigned char r=0, g=0, b=0;
  if(millis()<in){
    r = 1;
  }
  if(millis()<out){
    b = 1;
  }
  if(millis()<keyPressd){
    g = 1;
  }
  rgb0(r, g, b);
}
void blueLed(){
    if(millis()>rxDelay){
        alpha+=0.002;
        if(alpha<=3.14 || (alpha<=12.56 && alpha >= 9.42) || (alpha<=12.56 && alpha >= 9.42))
            analogWrite(11, -cos(alpha*4)*127+127);
        else if(alpha<=50)
            analogWrite(11, 10);
        else alpha=0;
    }
}
void rxtx(){
    rxDelay = millis()+50;
    analogWrite(11, 255);
    //alpha = 30;
}
uint16_t renumerate(uint16_t in){
 // f e d c b a 9 8    7 6 5 4 3 2 1 0
 // d c b a 9 8 7 _    6 5 4 3 2 1 0 _

 // f e d c b a 9 8    7 6 5 4 3 2 1 0
  uint16_t result = in << 2;
 // d c b a 9 8 7 6    5 4 3 2 1 0 _ _
 //           dcba9876543210
  result &= 0b1111111000000000;
 // d c b a 9 8 7 _    _ _ _ _ _ _ _ _
  in <<= 1;
 // e d c b a 9 8 7    6 5 4 3 2 1 0 _
 in &= 0b11111110;
 // _ _ _ _ _ _ _ _    6 5 4 3 2 1 0 _
 result |= in;
 // d c b a 9 8 7 _    6 5 4 3 2 1 0 _
 return result;
}
void writeShiftRegister(int ss_pin, uint8_t lo_unconverted, uint8_t hi_unconverted)
{
    unsigned int out=0;
    for(int i=0;i<8;i++){
        if(lo_unconverted & (1<<i)){
            out += outMask[i];
        }
    }
    for(int i=0;i<8;i++){
        if(hi_unconverted & (1<<i)){
            out += outMask[i+8];
        }
    }
  out = renumerate(out);
  PORTE &= 0b11111011;
  SPI.transfer((out>>8)&0xff);
  SPI.transfer((out) & 0xff);
  PORTE |= 0b100;
}
void blinking(){
  writeShiftRegister(8, 0x55, 0xaa);
  delay(1000);
  writeShiftRegister(8, 0xaa, 0x55);
  delay(1000);
  writeShiftRegister(8, 0x55, 0xaa);
  delay(1000);
  writeShiftRegister(8, 0xaa, 0x55);
  delay(1000);  
  writeShiftRegister(8, 0x55, 0xaa);
  delay(1000);
  writeShiftRegister(8, 0xaa, 0x55);
}
void cleanTimes(){
    pressedLow=0;
    pressedHigh=0;
    releasedLow=0;
    releasedHigh=0;
}
void setup()
{
  inputString.reserve(200);
  /* Включаем UART и SPI */
  SPI.begin();
  /* Включаем защёлку */
  pinMode(A0, OUTPUT);
  pinMode(A1, OUTPUT);
  pinMode(A2, OUTPUT);
  pinMode(A3, OUTPUT);
  pinMode(A4, OUTPUT);
  pinMode(A5, OUTPUT);
  pinMode(13, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(12, OUTPUT);
  
  pinMode(11, OUTPUT);
  digitalWrite(11, HIGH);
  pinMode(2, OUTPUT);
  digitalWrite(2, HIGH);
  DDRE |= 0b100;
  //blinking();
  delay(2000);
  digitalWrite(11, LOW);
  cleanTimes();
  digitalWrite(2, LOW);
  digitalWrite(2, HIGH);
  last_input_states1 = SPI.transfer(0);
  last_input_states2 = SPI.transfer(0);
  rgb3(0, 51, 0);
  rgb2(100,0,200);
  //delay(30000);
  rgb2(32,0,45);
  Serial.begin(115200);
  Serial1.begin(9600);
  Serial.println("ready!");
  Serial1.println("ready!");
  writeShiftRegister(8, 0, 0);
}
void sendButton(unsigned char pos, unsigned char reg){

    cleanTimes();
    switch (pos){
        case 0: pressedLow = (1<<reg);    break;
        case 1: pressedHigh = (1<<reg);   break;
        case 2: releasedLow = (1<<reg);   break;
        case 3: releasedHigh = (1<<reg);  break;
    }
    time=millis()-time;

    Serial.write(85);
    Serial.write(170);
    Serial.write(58);
    Serial.write(pressedLow);
    Serial.write(pressedHigh);
    Serial.write(releasedLow);
    Serial.write(releasedHigh);
    Serial.write(highByte(time));
    Serial.write(lowByte(time));
    Serial.write(10);
    time = millis();
    delay(5);
    rxtx();
    in = millis()+100;

}

void bl(){
    digitalWrite(11, HIGH);
    delay(200);
    digitalWrite(11, LOW);
    delay(200);
}

void checkInputRegs1(){
  if (states1 != last_input_states1)
  {
    uint8_t changed = states1 ^ last_input_states1;
    last_input_states1 = states1; // запоминаем текущие состояния
    
    for (int i = 0; i < 8; ++i)
    {
      if (changed & 1) // если состояние кнопки изменилось…
      {
        sendButton((states1 & 1)<<1, i);
        
      }
      changed >>= 1;
      states1 >>= 1;
    }
  }
}
void checkInputRegs2(){
  if (states2 != last_input_states2)
  {
    uint8_t changed = states2 ^ last_input_states2;
    last_input_states2 = states2; // запоминаем текущие состояния
    for (int i = 0; i < 8; ++i)
    {
      if (changed & 1) // если состояние кнопки изменилось…
      {
        sendButton(((states2 & 1)<<1)+1, i);
      }
      changed >>= 1;
      states2 >>= 1;
    }
  }
}
unsigned char grayencode(unsigned char g) 
{
    return g ^ (g >> 1);
}
unsigned char diode(double d){
    return d<0 ? 0 : d*250;
}
void keyLight(const unsigned int *script){
    static unsigned long int pause;
    static char i;
    if(pause<=millis()){
        pause = millis()+250;
        writeShiftRegister(8, script[i] & 0xff, script[i]>>8 & 0xff);
        i++;
        if( (demo==49 && i>=36) ||
            (demo>=50 && i>=14) ){
                  i=0;
            }
    }
}
void bgLight(){
    static unsigned long int pause;
    if(game == WIN){
        pause = millis()+1000;
        rgb2(0, 255, 0);
    }else if(game == LOOSE){
        pause = millis()+1000;
        rgb2(255, 0, 0);
    }
    game = GAME;
    if(demo>50 && pause<=millis()){
        rgb2(32,0,45);
        demo = 50;
    }
}
void demoShow(){
  if(demo==49) keyLight(lightsScript);
  else if(demo>=50) keyLight(lightsScript1);
}
void rgb0(unsigned char r, unsigned char g, unsigned char b){
                  digitalWrite(A2, r);
                  digitalWrite(A1, b);
                  digitalWrite(A4, g);
}
void rgb1(unsigned char r, unsigned char g, unsigned char b){
                  digitalWrite(A3, r);
                  digitalWrite(A0, b);
                  digitalWrite(A5, g);
}
void rgb2(unsigned char r, unsigned char g, unsigned char b){
                  //analogWrite(5, r);
                  //analogWrite(13, b);
                  //analogWrite(10, g);
                  analogWrite(10, r);
                  analogWrite(3, b);
                  analogWrite(13, g);
}
void rgb3(unsigned char r, unsigned char g, unsigned char b){
                  //digitalWrite(4, r);
                  //analogWrite(3, b);
                  //analogWrite(9, g);
                  analogWrite(9, r);
                  analogWrite(6, b);
                  analogWrite(5, g);
}
void rgb4(unsigned char r, unsigned char g, unsigned char b){
                  digitalWrite(8, r);
                  digitalWrite(4, b);
                  digitalWrite(12, g);
                  //digitalWrite(8, r);
                  //digitalWrite(12, b);
                  //digitalWrite(6, g);
}
void loop()
{
  blueLed();
  statusStrip();
  digitalWrite(2, LOW);
  digitalWrite(2, HIGH);
  states1 = SPI.transfer(0);
  states2 = SPI.transfer(0) & 0b11110000;
  convertInput();
   
  checkInputRegs1();
  checkInputRegs2();
  
  if(demo) demoShow();
  bgLight();
  
  while(Serial.available()){
      unsigned char c = Serial.read();
      inputString+=(char)c;
      //Serial1.write(c);
      if(c==10){
        
          if(inputString.length()==7 && inputString[0]==85 && inputString[1] == -86){
            /*Serial.println(inputString[2], DEC);*/
            if(inputString[2]==48){
              time = millis();
              keyPressd = millis()+100;
            }else if(inputString[2]==49){
              Serial.write(85);
              Serial.write(170);
              Serial.write(59);
              Serial.write(out2);
              Serial.write(out1);
              Serial.write(10);
            }else if(inputString[2]==50){
              out1 = inputString[3];
              out2 = inputString[4];
              writeShiftRegister(8, out1, out2);
              Serial.write(85);
              Serial.write(170);
              Serial.write(59);
              Serial.write(out2);
              Serial.write(out1);
              Serial.write(10);
              Serial1.print("Set lights to ");
              Serial1.print((unsigned char)inputString[3], DEC);
              Serial1.print(" ");
              Serial1.println((unsigned char)inputString[4], DEC);
              out = millis()+100;
            }else if(inputString[2]==56){
              writeShiftRegister(8, 0, 0);
              demo = inputString[3];
              if(demo==51){
                game = WIN;
              }else if(demo==52){
                game = LOOSE;
              }
            }else if(inputString[2]>=51){
              unsigned char channel;
              Serial1.print("Set rgb ");
              Serial1.print(channel = (unsigned char)inputString[2]-51, DEC);
              Serial1.print(" to ");
              Serial1.print((unsigned char)inputString[3], DEC);
              Serial1.print("\t");
              Serial1.print((unsigned char)inputString[4], DEC);
              Serial1.print("\t");
              Serial1.println((unsigned char)inputString[5], DEC);
              
              if(channel==0){
                rgb0(inputString[3], inputString[4], inputString[5]);
              }else if(channel==1){
                rgb1(inputString[3], inputString[4], inputString[5]);
              }else if(channel==2){
                rgb2(inputString[3], inputString[4], inputString[5]);
              }else if(channel==3){
                rgb3(inputString[3], inputString[4], inputString[5]);
              }else if(channel==4){
                rgb4(inputString[3], inputString[4], inputString[5]);
              }
            }
          }
          rxtx();
          inputString="";
    /*       UЄ8888 */
          Serial.println(demo);
      }
  }
  
}
