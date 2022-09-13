# Lern-Bericht
Lorenzo Lai

## Random number generator

Mein erste Projekt war ein Numbergenerator auf c# zu programmieren, dies war nicht einfach. Dieses Programm generiert ein beliebiges Zahl zwischen 1 und 100 und man muss dieses Zahl durch ausprobieren finden. Das Programm ssollte sagen, ob man zu tief oder zu hoch geschätzt hat, sodass man sich anpassen kann. Das Programm soltte auch nur Zahlen zwischen 1 und 100 akzeptieren, sowie auch keine Buchstaben; da sollte es: "Ungültige Eingabe" sagen.

## Was habe ich gelernt?

Ich habe gelernt, wie man mit einem *while* Schleife arbeitet, um Loops zu erstellen.

## Beschreibung

Dieses Projekt forderte mich sehr und somit habe ich auch vieles gelernt; Mein Projekt funktioniert auf eine simple *while(true)* Schleife die das ganze Prozess wiefderholt, Ich musste auch verstehen, die Wichtigkeit von Variabeln, da ohne Sie, gar nichts angefange werden kann. Ein beliebiges Zahll sollte generiert werden, das habe ich mit hilfe von die Webseite *Stackoverflow* gelernt. Um "Unbekannte" Eingaben zu fangen habe ich eine *try/catch* Schleife gemacht, die nur Zahlen akzeptiert. Eine *while ( versuch != zahl)* Schleife hat mich sehr geholfen, um die Frage: "Möchten Sie weiterspielen? ja/nein", zu beantworten, das finde ich sehr wichtig und es half mich sehr

```

if (versuch > 100 || versuch < 1)
                        {
                            throw new Exception();
                        }                      
                        if (versuch < zahl)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(":::::::::::::::::::::::::::::::::");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Falsch! Die gesuchte Zahl ist grösser als {0}.", versuch);
                        }
                        if (versuch > zahl)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(":::::::::::::::::::::::::::::::::");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Falsch! Die gesuchte Zahl ist kleiner als {0}.", versuch);
                        }
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Geben Sie bitte eine andere zahl als {0}: ", versuch);
                        versuch = Convert.ToInt32(Console.ReadLine());

```

Das wäre den Teil meines Codes, wo es gelesen und registriert wird, ob man zu tief, zu hoch oder nicht zwischen 1 und 100 geschätzt hat. Ds ist sehr wichtig, weil sonst würde man ohne bedingungen für zu tief/hoch nicht wissen, was zu tippen. Ich habe die *if* Schleife in kombination mit die *try/catch* Schleife verwendet mit einem *throw* command; somit können nur Zahlen zwischen 1 und 100 und keine Buchstaben akzeptiert werden.

![6t72jn](https://user-images.githubusercontent.com/110893594/189840107-bd637929-d7ee-496e-ae18-66e1f69f5c5c.gif)

Dies wäre was man auf der Konsole sieht und eintippen kann.

## Verifikation

Text-Beschreibung: Den text beschreibt wie ich die verschiedene Schleifen und Operatoren verstehe, dies ist nicht 100% Genau, da es nur mein Sicht-Punkt ist.

String: Das wäre den teil meines Codes wo die eigentliche Arbeitprozesse passieren.

GIF: Es zeigt, wie das ganze Programm funktioniert und operiert. (Inklusive testfälle wie wenn man eine Buchstabe eintippt)

# Reflektion zum Arbeitsprozess

Es ging alles ziemlich langsam und verzögert, doch gut habe ich die verifikationen mit den *if* Schleifen gemacht für zu gross/klein und ausserhalb von 1-100.

Den Looping teil des Codes wurde sehr kompliziert, damit verbrauchte ich etwa 3-5 Stunden nur für den Looping Teil meines Codes. Ich musste nun zusätzlich meine kameraden an um Hilfe bitten.

**VBV**: ich hätte werscheinlich besser meine IPERKA Protokoll benutzen sollen, da ich direkt von anfang an gefangen habe, zu programmieren und nicht zu planen.
