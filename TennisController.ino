const int butPin1 = 2; //se usi un pin diverso, cambialo
const int butPin2 = 5; //se usi un pin diverso, cambialo

void setup()
{
  pinMode(butPin1, INPUT);
  pinMode(butPin2, INPUT);
  digitalWrite(2, HIGH);
  digitalWrite(5, HIGH);

  Serial.begin(9600);
  pinMode(A0,INPUT); //se usi un uscita analogica diversa, cambiala
  pinMode(A1,INPUT); //se usi un uscita analogica diversa, cambiala
}

void loop()
{
  if (digitalRead(butPin1) == LOW)
  {
    int analog1 = analogRead(0);
    String a = (String)analog1;
    Serial.println("LEFT " + a);
    delay(25);
  }

  if (digitalRead(butPin2) == LOW)
  {
    int analog2 = analogRead(1);
    String b = (String)analog2;
    Serial.println("RIGHT " + b);
    delay(25);
  }
}
