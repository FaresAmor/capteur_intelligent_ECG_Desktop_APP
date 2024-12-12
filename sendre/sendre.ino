char message[6]; // Pour stocker la valeur du ADC (max 5 chiffres + 1 pour le caractère nul)

void setup() {
  Serial.begin(9600); // Initialiser la communication série
}

void loop() {
  int sensorValue = 550- analogRead(A0); // Lire la valeur sur A0

  // Convertir la valeur en chaîne de caractères
  snprintf(message, sizeof(message), "%d", sensorValue);

  // Envoyer chaque caractère de message
  for (int i = 0; message[i] != '\0'; i++) {
    Serial.write(message[i]); // Envoyer chaque caractère
  }
  
  Serial.write('\n'); // Envoyer un caractère de nouvelle ligne pour marquer la fin
  delay(40);


}