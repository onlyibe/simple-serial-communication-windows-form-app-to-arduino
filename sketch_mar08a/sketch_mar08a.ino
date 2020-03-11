int ledpin = 2;

void setup() {
  // put your setup code here, to run once:
  pinMode(ledpin, LOW);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.read() == '1') {
    digitalWrite(ledpin, HIGH);
  }
  else(Serial.read() == '0'); {
    digitalWrite(ledpin, LOW);
  }
}
