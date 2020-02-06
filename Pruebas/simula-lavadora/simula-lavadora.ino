#include <Wire.h>

byte x = 255;
int temperatura=20;
byte pospuerta=0;
byte inclinacion=70;
byte quimicos=0;
byte agua=0;
byte antx;
int vapor;
int puerta;
int volquete;
int cubeta;
int valvula;
boolean inherciat;
boolean pulsocuentalitros;
boolean cambio;

void setup()
{
	Wire.begin();
	Serial.begin(9600);
	pinMode(2,INPUT_PULLUP);
	pinMode(3,INPUT_PULLUP);
	pinMode(4,INPUT_PULLUP);
	pinMode(5,INPUT_PULLUP);
	pinMode(6,INPUT_PULLUP);
	pinMode(7,INPUT_PULLUP);
	pinMode(8,INPUT_PULLUP);
	pinMode(9,INPUT_PULLUP);
	pinMode(10,INPUT_PULLUP);
	pinMode(13,OUTPUT);
}


void loop()
{
	delay(50);
	digitalWrite(13, LOW);
	cambio = false;
	// Desague
	if (digitalRead(2)==LOW)
	{
		valvula++;
		if (valvula > 5)
		{
			valvula=0;
			if (agua > 0)
			{
				agua--;
				cambio=true;
				Serial.print("Tirando agua ");
				Serial.println(agua);
			}
		}
		vapor++;
		if (vapor >= 5)
		{
			vapor=0; 
			if (temperatura > 10)
			{
				temperatura--;
				cambio=true;
			}
		}
	}
	// Agua fria o caliente
	if (digitalRead(3)==LOW)
	{
		valvula++;
		if (valvula > 3)
		{
			valvula = 0;
			pulsocuentalitros = !pulsocuentalitros;
			if (agua < 250)
			{
				cambio=true;
				agua++;
				Serial.print("Entrando agua ");
				Serial.println(agua);
			}
		}
	}
	// Vapor
	if (digitalRead(4) == LOW)
	{
		vapor++;
		if (vapor >= 10)
		{
			vapor = 0;
			inherciat = true;
			if (temperatura < 250)
			{
				temperatura++;
				cambio = true;
				Serial.print("Metiendo vapor ");
				Serial.println(temperatura);
			}
		}
	}
	else
	{
		vapor++;
		if (vapor >= 120)
		{
			vapor=0;
			if (inherciat) 
			{
				inherciat = false;
				if (temperatura < 250)
				{
					temperatura++;
					cambio = true;
					Serial.print("Inhercia temp ");
					Serial.println(temperatura);
				}
			}
			else
			{
				if (temperatura > 20)
				{
					temperatura--;  
					Serial.print("Maq enfriandose ");
					Serial.println(temperatura);
				}
			}
		}
	}
	// Abrir
	if (digitalRead(5)==LOW)
	{
		puerta++;
		if (puerta > 5)
		{
			puerta=0;
			if ( pospuerta < 250 )
			{
				pospuerta++;
				Serial.print("Abriendo puerta ");
				Serial.println(pospuerta);
				cambio=true;
			}
		}
	}
	// Cerrar
	if (digitalRead(6)==LOW)
	{
		puerta++;
		if (puerta > 5)
		{
			puerta=0;
			if ( pospuerta > 0 )
			{
				pospuerta--;
				Serial.print("Cerrando puerta ");
				Serial.println(pospuerta);
				cambio=true;
			}
		}
	}
	// Cubeta
	if (digitalRead(8) == LOW)
	{
		cubeta++;
		if (cubeta >= 10)
		{
			cubeta=0;
			if (quimicos > 0)
			{
				quimicos--;
				cambio=true;
				Serial.print("Metiendo quimicos ");
				Serial.println(quimicos);
			}
		}
	}
	else
	{
		cubeta++;
		if (cubeta >= 50)
		{
			cubeta=0;
			if (quimicos < 100)
			{
				quimicos++;
			}
		}
	}
	// Bajar
	if ((digitalRead(10)==LOW) && (digitalRead(7)==LOW))
	{
		volquete++;
		if (volquete > 3)
		{
			volquete=0;
			if ( inclinacion > 0 )
			{
				inclinacion--;
				cambio=true;
				Serial.print("Maquina bajando ");
				Serial.println(inclinacion);
			}
		}
	}

	// Subir
	if ((digitalRead(10)==LOW) && (digitalRead(7)==HIGH))
	{
		volquete++;
		if (volquete > 5)
		{
			volquete=0;
			if ( inclinacion < 250 )
			{
				inclinacion++;
				cambio=true;
				Serial.print ("Maquina subiendo ");
				Serial.println(inclinacion);
			}
		}
	}


	antx=x;

	if (pulsocuentalitros)
	{
		bitClear(x,0);
	}
	else
	{
		bitSet(x,0);
	}

	if ((pospuerta >= 60 ) && (pospuerta <= 70))
	{
		bitClear(x,1);
		bitSet(x,2);
	}
	else if ((pospuerta >= 0 ) && (pospuerta <= 10))
	{
		bitSet(x,1);
		bitClear(x,2);
	}
	else
	{
		bitSet(x,1);
		bitSet(x,2);
	}

	if (agua < 10)
	{
		bitSet(x,3);
	}
	else
	{
		bitClear(x,3);
	}
	if ((inclinacion >= 120 ) && (inclinacion <= 140))
	{
		bitClear(x,4);
		bitSet(x,5);
		bitSet(x,6);
	}
	else if ((inclinacion >= 60 ) && (inclinacion <= 80))
	{
		bitSet(x,4);
		bitClear(x,5);
		bitSet(x,6);
	}
	else if ((inclinacion >= 0 ) && (inclinacion <= 20))
	{
		bitSet(x,4);
		bitSet(x,5);
		bitClear(x,6);
	}
	else
	{
		bitSet(x,4);
		bitSet(x,5);
		bitSet(x,6);
	}
	if (quimicos <= 10)
	{
		bitSet(x,7);
	}
	else
	{
		bitClear(x,7);
	}
	analogWrite(11,temperatura);
	if (cambio)
	{ 
		delay(50);
		digitalWrite(13, HIGH);
	}
	if (x != antx)
	{
		if ((bitRead(antx,1)==1) && (bitRead(x,1)==0))
		{
			Serial.println("Puerta abierta");
		}
		if ((bitRead(antx,2)==1) && (bitRead(x,2)==0))
		{
			Serial.println("Puerta cerrada");
		}
		if ((bitRead(antx,3)==0) && (bitRead(x,3)==1))
		{
			Serial.println("Maq vacia");
		}
		if ((bitRead(antx,4)==1) && (bitRead(x,4)==0))
		{
			Serial.println("Maq arriba");
		}
		if ((bitRead(antx,5)==1) && (bitRead(x,5)==0))
		{
			Serial.println("Maq horizontal");
		}
		if ((bitRead(antx,6)==1) && (bitRead(x,6)==0))
		{
			Serial.println("Maq abajo");
		}
		if ((bitRead(antx,7)==0) && (bitRead(x,7)==1))
		{
			Serial.println("Cubeta vacia");
		}
		Wire.beginTransmission(39);
		Wire.write(x);
		Wire.endTransmission();
	}
}
