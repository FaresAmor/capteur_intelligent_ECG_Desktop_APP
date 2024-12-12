String receivedValue = ""; // Pour stocker la valeur reçue

void setup() {
  Serial.begin(9600); // Initialiser la communication série
}

void loop() {
  while (Serial.available()) {
    char incomingChar = Serial.read(); // Lire le caractère
    if (incomingChar == '\n') { // Vérifier si c'est un caractère de nouvelle ligne
      // Afficher la valeur reçue

      Serial.println(receivedValue); // Afficher la chaîne assemblée
      receivedValue = ""; // Réinitialiser pour la prochaine lecture
    } else {
      receivedValue += incomingChar; // Ajouter le caractère à la chaîne
    }
  }
}