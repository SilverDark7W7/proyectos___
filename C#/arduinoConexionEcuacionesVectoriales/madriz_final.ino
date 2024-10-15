int x1=2;
int x2=3;
int x3=4;
int x4=5;
int x5=6;
int x6=7;
int x7=8;
int x8=9;
int x9=10;
int x10=11;
int y1=22;
int y2=23;
int y3=24;
int y4=25;
int y5=26;
int y6=27;
int y7=28;
int y8=29;
int y9=30;
int y10=31;
int poder=100;
boolean cuadrante_x_positivo=false;
boolean cuadrante_x_negativo=false;
boolean cuadrante_y_positivo=false;
boolean cuadrante_y_negativo=false;
boolean diagonal_x_positivo=false;
boolean diagonal_x_negativo=false;
boolean diagonal_y_positivo=false;
boolean diagonal_y_negativo=false;
void setup() {
Serial.begin(9600);
pinMode(x1,OUTPUT);
pinMode(x2,OUTPUT);
pinMode(x3,OUTPUT);
pinMode(x4,OUTPUT);
pinMode(x5,OUTPUT);
pinMode(x6,OUTPUT);
pinMode(x7,OUTPUT);
pinMode(x8,OUTPUT);
pinMode(x9,OUTPUT);
pinMode(x10,OUTPUT);

pinMode(y1,OUTPUT);
pinMode(y2,OUTPUT);
pinMode(y3,OUTPUT);
pinMode(y4,OUTPUT);
pinMode(y5,OUTPUT);
pinMode(y6,OUTPUT);
pinMode(y7,OUTPUT);
pinMode(y8,OUTPUT);
pinMode(y9,OUTPUT);
pinMode(y10,OUTPUT);
}
void loop() {
if(Serial.available()>0){
String cord= Serial.readStringUntil('\n');
cord.trim();
if(cord=="si"){
  encender_todas();

}
else if (cord=="loco"){

  for(int i=1;i<5;i++){
  digitalWrite(x1, LOW);
  digitalWrite(y1, HIGH);
  delay(poder);

  digitalWrite(x1, HIGH);
  digitalWrite(y1, LOW);
  delay(poder);

  digitalWrite(x2, LOW);
  digitalWrite(y2, HIGH);
  delay(poder);

  digitalWrite(x2, HIGH);
  digitalWrite(y2, LOW);
  delay(poder);

  digitalWrite(x3, LOW);
  digitalWrite(y3, HIGH);
  delay(poder);

  digitalWrite(x3, HIGH);
  digitalWrite(y3, LOW);
  delay(poder);

  digitalWrite(x4, LOW);
  digitalWrite(y4, HIGH);
  delay(poder);

  digitalWrite(x4, HIGH);
  digitalWrite(y4, LOW);
  delay(poder);

  digitalWrite(x5, LOW);
  digitalWrite(y5, HIGH);
  delay(poder);

  digitalWrite(x5, HIGH);
  digitalWrite(y5, LOW);
  delay(poder);

  digitalWrite(x6, LOW);
  digitalWrite(y6, HIGH);
  delay(poder);

  digitalWrite(x6, HIGH);
  digitalWrite(y6, LOW);
  delay(poder);

   digitalWrite(x7, LOW);
  digitalWrite(y7, HIGH);
  delay(poder);

  digitalWrite(x7, HIGH);
  digitalWrite(y7, LOW);
  delay(poder);

  digitalWrite(x8, LOW);
  digitalWrite(y8, HIGH);
  delay(poder);

  digitalWrite(x8, HIGH);
  digitalWrite(y8, LOW);
  delay(poder);

  digitalWrite(x9, LOW);
  digitalWrite(y9, HIGH);
  delay(poder);

  digitalWrite(x9, HIGH);
  digitalWrite(y9, LOW);
  delay(poder);

  digitalWrite(x10, LOW);
  digitalWrite(y10, HIGH);
  delay(poder);

  digitalWrite(x10, HIGH);
  digitalWrite(y10, LOW);
  delay(poder);

    apagar_todas();


 digitalWrite(x1, LOW);
  digitalWrite(y1, HIGH);
  delay(poder);
  digitalWrite(x2, LOW);
  digitalWrite(y2, HIGH);
  delay(poder);
  digitalWrite(x3, LOW);
  digitalWrite(y3, HIGH);
  delay(poder);
  digitalWrite(x4, LOW);
  digitalWrite(y4, HIGH);
  delay(poder);
  digitalWrite(x5, LOW);
  digitalWrite(y5, HIGH);
  delay(poder);
  digitalWrite(x6, LOW);
  digitalWrite(y6, HIGH);
  delay(poder);
   digitalWrite(x7, LOW);
  digitalWrite(y7, HIGH);
  delay(poder);
  digitalWrite(x8, LOW);
  digitalWrite(y8, HIGH);
  delay(poder);
  digitalWrite(x9, LOW);
  digitalWrite(y9, HIGH);
  delay(poder);
  digitalWrite(x10, LOW);
  digitalWrite(y10, HIGH);
  delay(poder);
  }

}
else if(cord=="no"){
apagar_todas();
}
else if(cord=="cordx"){
    cuadrante_x_positivo=true;

}
  else if(cord=="x1"){
    apagar_todas();
    digitalWrite(x1, LOW);
    digitalWrite(y5, HIGH);
    }
    else if(cuadrante_x_positivo && cord=="x2"){
    apagar_todas();
    digitalWrite(x2, LOW);
    digitalWrite(y5, HIGH);
    }
    else if(cuadrante_x_positivo && cord=="x3"){
    apagar_todas();
    digitalWrite(x3, LOW);
    digitalWrite(y5, HIGH);
    }
    else if(cuadrante_x_positivo && cord=="x4"){
    apagar_todas();
    digitalWrite(x4, LOW);
    digitalWrite(y5, HIGH);
    }
    else if(cuadrante_x_positivo && cord=="x5"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y5, HIGH);
    }
else if(cord=="cord-x"){
    cuadrante_x_negativo=true;  
}
    else if(cuadrante_x_negativo && cord=="x1"){
    apagar_todas();
    digitalWrite(x6, LOW);
    digitalWrite(y5, HIGH);
    }
    else if(cuadrante_x_negativo && cord=="x2"){
    apagar_todas();
    digitalWrite(x7, LOW);
    digitalWrite(y5, HIGH);
    }
    else if(cuadrante_x_negativo && cord=="x3"){
    apagar_todas();
    digitalWrite(x8, LOW);
    digitalWrite(y5, HIGH);
    }
    else if(cuadrante_x_negativo && cord=="x4"){
    apagar_todas();
    digitalWrite(x9, LOW);
    digitalWrite(y5, HIGH);
    }
    else if(cuadrante_x_negativo && cord=="x5"){
    apagar_todas();
    digitalWrite(x10, LOW);
    digitalWrite(y5, HIGH);
    }
else if(cord=="cordy"){
    cuadrante_y_positivo=true;  
}
   else if(cuadrante_y_positivo && cord=="y1"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y1, HIGH);
    }
    else if(cuadrante_y_positivo && cord=="y2"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y2, HIGH);
    }
    else if(cuadrante_y_positivo && cord=="y3"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y3, HIGH);
    }
    else if(cuadrante_y_positivo && cord=="y4"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y4, HIGH);
    }
    else if(cuadrante_y_positivo && cord=="y5"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y5, HIGH);
    }
else if(cord=="cord-y"){
    cuadrante_y_negativo=true;  
}
   else if(cuadrante_y_negativo && cord=="y1"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y6, HIGH);
    }
    else if(cuadrante_y_negativo && cord=="y2"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y7, HIGH);
    }
    else if(cuadrante_y_negativo && cord=="y3"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y8, HIGH);
    }
    else if(cuadrante_y_negativo && cord=="y4"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y9, HIGH);
    }
    else if(cuadrante_y_negativo && cord=="y5"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y10, HIGH);
    }
else if(cord=="cordxd"){
    diagonal_x_positivo=true;  
}
  else if(diagonal_x_positivo && cord=="x1y1"){
    apagar_todas();
    digitalWrite(x1, LOW);
    digitalWrite(y1, HIGH);
    }
    else if(diagonal_x_positivo && cord=="x2y2"){
    apagar_todas();
    digitalWrite(x2, LOW);
    digitalWrite(y2, HIGH);
    }
    else if(diagonal_x_positivo && cord=="x3y3"){
    apagar_todas();
    digitalWrite(x3, LOW);
    digitalWrite(y3, HIGH);
    }
    else if(diagonal_x_positivo && cord=="x4y4"){
    apagar_todas();
    digitalWrite(x4, LOW);
    digitalWrite(y4, HIGH);
    }
    else if(diagonal_x_positivo && cord=="x5y5"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y5, HIGH);
    }
else if(cord=="cord-xd"){
    diagonal_x_negativo=true; 
}
  else if(diagonal_x_negativo && cord=="x1y1"){
    apagar_todas();
    digitalWrite(x6, LOW);
    digitalWrite(y6, HIGH);
    }
    else if(diagonal_x_negativo && cord=="x2y2"){
    apagar_todas();
    digitalWrite(x7, LOW);
    digitalWrite(y7, HIGH);
    }
    else if(diagonal_x_negativo && cord=="x3y3"){
    apagar_todas();
    digitalWrite(x8, LOW);
    digitalWrite(y8, HIGH);
    }
    else if(diagonal_x_negativo && cord=="x4y4"){
    apagar_todas();
    digitalWrite(x9, LOW);
    digitalWrite(y9, HIGH);
    }
    else if(diagonal_x_negativo && cord=="x5y5"){
    apagar_todas();
    digitalWrite(x10, LOW);
    digitalWrite(y10, HIGH);
    }
else if(cord=="cordyd"){
    diagonal_y_positivo=true; 
}
    else if(diagonal_y_positivo && cord=="x1y1"){
    apagar_todas();
    digitalWrite(x5, LOW);
    digitalWrite(y6, HIGH);
    }
     else if(diagonal_y_positivo && cord=="x2y2"){
    apagar_todas();
    digitalWrite(x4, LOW);
    digitalWrite(y7, HIGH);
    }
     else if(diagonal_y_positivo && cord=="x3y3"){
    apagar_todas();
    digitalWrite(x3, LOW);
    digitalWrite(y8, HIGH);
    }
     else if(diagonal_y_positivo && cord=="x4y4"){
    apagar_todas();
    digitalWrite(x2, LOW);
    digitalWrite(y9, HIGH);
    }
     else if(diagonal_y_positivo && cord=="x5y5"){
    apagar_todas();
    digitalWrite(x1, LOW);
    digitalWrite(y10, HIGH);
    }
else if(cord=="cord-yd"){
    diagonal_y_negativo=true; 
}
     else if(diagonal_y_negativo && cord=="x1y1"){
    apagar_todas();
    digitalWrite(x6, LOW);
    digitalWrite(y5, HIGH);
    }
     else if(diagonal_y_negativo && cord=="x2y2"){
    apagar_todas();
    digitalWrite(x7, LOW);
    digitalWrite(y4, HIGH);
    }
     else if(diagonal_y_negativo && cord=="x3y3"){
    apagar_todas();
    digitalWrite(x8, LOW);
    digitalWrite(y3, HIGH);
    }
     else if(diagonal_y_negativo && cord=="x4y4"){
    apagar_todas();
    digitalWrite(x9, LOW);
    digitalWrite(y2, HIGH);
    }
     else if(diagonal_y_negativo && cord=="x5y5"){
    apagar_todas();
    digitalWrite(x10, LOW);
    digitalWrite(y1, HIGH);
    }

// else if(cord=="plano"){
//   plano();

// }
else if(cord=="fuera"){
apagar_todas();
cuadrante_x_positivo=false;
cuadrante_x_negativo=false;
cuadrante_y_positivo=false;
cuadrante_y_negativo=false;

diagonal_x_positivo=false;
diagonal_x_negativo=false;
diagonal_y_positivo=false;
diagonal_y_negativo=false;
}
delay(poder);
cord = "";
}

}

void encender_todas(){
digitalWrite(x1, LOW);
digitalWrite(x2, LOW);
digitalWrite(x3, LOW);
digitalWrite(x4, LOW);
digitalWrite(x5, LOW);
digitalWrite(x6, LOW);
digitalWrite(x7, LOW);
digitalWrite(x8, LOW);
digitalWrite(x9, LOW);
digitalWrite(x10, LOW);

digitalWrite(y1, HIGH);
digitalWrite(y2, HIGH);
digitalWrite(y3, HIGH);
digitalWrite(y4, HIGH);
digitalWrite(y5, HIGH);
digitalWrite(y6, HIGH);
digitalWrite(y7, HIGH);
digitalWrite(y8, HIGH);
digitalWrite(y9, HIGH);
digitalWrite(y10, HIGH);
}
void apagar_todas(){
digitalWrite(x1, HIGH);
  digitalWrite(x2, HIGH);
  digitalWrite(x3, HIGH);
  digitalWrite(x4, HIGH);
  digitalWrite(x5, HIGH);
  digitalWrite(x6, HIGH);
  digitalWrite(x7, HIGH);
  digitalWrite(x8, HIGH);
  digitalWrite(x9, HIGH);
  digitalWrite(x10, HIGH);

  digitalWrite(y1, LOW);
  digitalWrite(y2, LOW);
  digitalWrite(y3, LOW);
  digitalWrite(y4, LOW);
  digitalWrite(y5, LOW);
  digitalWrite(y6, LOW);
  digitalWrite(y7, LOW);
  digitalWrite(y8, LOW);
  digitalWrite(y9, LOW);
  digitalWrite(y10, LOW);
}
// void plano(){
//   // Encender las luces en los brazos de la cruz
//   apagar_todas();
//   digitalWrite(x1, LOW);
//   digitalWrite(x2, LOW);
//   digitalWrite(x3, LOW);
//   digitalWrite(x4, LOW);
//   digitalWrite(x6, LOW);
//   digitalWrite(x7, LOW);
//   digitalWrite(x8, LOW);
//   digitalWrite(x9, LOW);
//   digitalWrite(x10, LOW);

//   digitalWrite(y5, HIGH);
// }
