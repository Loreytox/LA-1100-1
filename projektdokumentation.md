# Projekt-Dokumentation

Lorenzo Lai

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   23.08.22    | 0.0.1   | Heute haben wir unsere erste Projektdokumentation gemacht.  |
|   30.08.22    | 0.0.2   | Heute habe ich mein Projekt (Numberguessing game) angefangen und bin gut unterwegs mit die Programmierung.                                         
|   06.09.22    | 1.0.0   | Heute bin ich mit mein Projekt fertig geworden und somit kann ich jetzt anfangen neue Features zu addieren.  |

## 1 Informieren

### 1.1 Ihr Projekt

Einen sehr simplen und einfache Number guesser game.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss            |   Funktional   | Als Spieler möchte ich wissen, dass wenn man einen Zahl hinein schreibt, es gesagt wird, ob es grösser oder kleiner ist, damit man weisst, ob man höher oder kleiner eintippen muss.  |
| 2    |   Muss          |   Funktional   | Als Spieler möchte ich wissen, wenn ich den richtigen Zahl eintippe, es direkt sagt, damit ich weiss, dass ich gewonnen habe.  |    | 3    |   Muss          |   Funktional   | Als Spieler möchte ich die wahl haben, dass wenn ich gewonnen habe, den Spiel neustarten kann, damit ich wieder spielenn kann.  |
| 4    |   kann          |   Qualität     | Als Spieler würde ich gerne einen kleinen Text am ende haben, der sagt, ob ich gewonnen habe, damit ich fröhlich bin.  |
| 5    |   kann          |   Qualität     | Als Spieler würde ich gerne ein farbiges Text sehen.  |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Das Programm ist gestartet und den Zahl ist bereits schon geneririert worden.  | *hallo welt* |  *Bitte nur Zahlen eingeben!* |
| 1.2  |  Das Programm ist gestartet und den Zahl ist bereits schon geneririert worden.  |  *23*  |  *Zahl ist zu klein, bitte weiter probieren*.  |
| 1.3  |  Das Programm ist gestartet und den Zahl ist bereits schon geneririert worden.  |  *23*  |  *Zahl ist zu gross, bitte weiter probieren*.  |
| 2.1  |  Das Programm ist gestartet und den Zahl ist bereits schon gefunden worden.  | *Enter* | *Zahl erfolgreich gefunden.* |
| 3.1  |  Das Programm ist gestartet und den Zahl ist bereits schon gefunden worden.  | *Enter* | *Wahl wird gegeben, ob man weiterspielen möchte oder nicht.* |
| 4.1  |  Das Programm ist gestartet und den Zahl ist bereits schon gefunden worden.  | *Enter* | *Gratulation! Sie haben gewonnen!* |
| 5.1  |  Das Programm ist gestartet und den Zahl ist bereits schon geneririert worden.  | *23* | *Zahl ist zu klein, bitte weiter probieren*. (Farbiges Text: Gelb)

### 1.4 Diagramme

![Number guesser game](https://user-images.githubusercontent.com/110893594/186111432-fb071fd7-6291-4304-8001-0f990c2ed75c.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  30.08.22  |  Ich  |  Informationen holen und sich für die richtige Operatoren entscheiden   |  1 * 45  |
| 1.B  |  30.08.22  |  Ich  |  Variabeln werden erstellt und es wird mit *if/while* Schleife gearbeitet.  |  1 * 45  |
| 1.C  |  30.08.22  |  Ich  |  Operatoren zusammenbringen und konfigurieren, somit es gesagt wird, ob etwas grösser oder kleiner sein sollte. |  1 * 45 |
| 2.A  |  30.08.22  |  Ich  |  Sich darüber informieren, welche Operatoren was machen.  |  1 * 45  |
| 2.B  |  30.08.22  |  Ich  |  Es wird mit *==* gearbeitet.  |  1 * 45  |
| 3.A  |  06.09.22  |  Ich  |  Neue Variabel *y|n* werden esrtellt.  | 1 * 45  |
| 3.B  |  06.09.22  |  Ich  |  Wie vorher schon gelernt, Es wird jetzt mit *while* Schleifen programmiert.  |  2 * 45  |
| 4.A  |  06.09.22  |  Ich  |  Es wird mit: *Console.WriteLine(); und Console.ReadLine();* gearbeitet, um ein Text am ende zu erhalten.  |  1 * 45  |
| 5.A  |  10.09.22  |  Ich  |  Ich habe auf Stack Overflow den Codes und Stringss gefunden |  1 * 45  |
| 5.B  |  10.09.22  |  Ich  |  Ich habe vor jeden Console.WriteLine ein Console.ForegroundColor = ConsoleColor.(farbe); benutzt  |

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
|  1.A  |  30.08.22  |  Ich  |  1 * 45  |  1 * 45  |  
|  1.B  |  30.08.22  |  Ich  |  1 * 45  |  2 * 45  |
|  1.C  |  30.08.22  |  Ich  |  1 * 45  |  3 * 45  |
|  2.A  |  30.08.22  |  Ich  |  1 * 45  |  1 * 45  |
|  2.B  |  30.08.22  |  Ich  |  1 * 45  |  1 * 45  |
|  3.A  |  06.09.22  |  Ich  |  1 * 45  |  1 * 45  |
|  3.B  |  06.09.22  |  Ich  |  2 * 45  |  3 * 45  |
|  4.A  |  06.09.22  |  Ich  |  1 * 45  |  1 * 45  |

## 5 Kontrollieren



### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  10.09.22  | funktioniert |  Ich  |
| 1.2  |  10.09.22  |  funktioniert  | Ich |
| 1.3  |  10.09.22  |  funktioniert  |  Ich  |
| 2.1  |  10.09.22  | funktioniert | Ich |
| 3.1  |  10.09.22  | funktioniert | Ich |
| 4.1  |  10.09.22  | funktioniert | Ich |
| 5.1  |  10.09.22  | funktioniert | Ich |

Meine Testprotokolle sind perfekt und es ging alles gut.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |Zahl wird erraten, Wollen Sie sie nochmal Spielen?[Ja/Nein]|Andere Zeichen als Ja oder Nein|Ungültige Eingabe|Programm wird beendet.|

Explorative Tests wurden von Keanu Koelewijn durchgeführt.

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
