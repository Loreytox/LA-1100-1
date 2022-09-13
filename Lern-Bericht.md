# Lern-Bericht
Lorenzo Lai

## Random number generator

Mein erste Projekt war ein Numbergenerator auf c# zu programmieren, dies war nicht einfach. Dieses Programm generiert ein beliebiges Zahl zwischen 1 und 100 und man muss dieses Zahl durch ausprobieren finden. Das Programm ssollte sagen, ob man zu tief oder zu hoch geschätzt hat, sodass man sich anpassen kann. Das Programm soltte auch nur Zahlen zwischen 1 und 100 akzeptieren, sowie auch keine Buchstaben; da sollte es: "Ungültige Eingabe" sagen.

## Was habe ich gelernt?

Ich habe gelernt, wie man mit einem *while* Schleife arbeitet, um Loops zu erstellen.

## Beschreibung

Dieses Projekt forderte mich sehr und somit habe ich auch vieles gelernt; Mein Projekt funktioniert auf eine simple *while(true)* Schleife die das ganze Prozess wiefderholt, Ich musste auch verstehen, die Wichtigkeit von Variabeln

'''

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

'''

Das wäre den Teil meines Codes, wo es gelesen und registriert wird, ob man zu tief, zu hoch oder nicht zwischen 1 und 100 geschätzt hat. Ds ist sehr wichtig, weil sonst würde man ohne bedingungen für zu tief/hoch nicht wissen, was zu tippen. Ich habe die *if* Schleife in kombination mit die *try/catch* Schleife verwendet mit einem *throw* command; somit können nur Zahlen zwischen 1 und 100 und keine Buchstaben akzeptiert werden.



![6t72jn](https://user-images.githubusercontent.com/110893594/189840107-bd637929-d7ee-496e-ae18-66e1f69f5c5c.gif)

* Eine textliche Beschreibung
* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
