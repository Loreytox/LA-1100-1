# Projekt-Dokumentation

Lorenzo Lai

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   23.08.22    | 0.0.1   | Heute haben wir unsere erste Projektdokumentation gemacht.  |
|   30.08.22    | 0.0.2   | Heute habe ich mein Projekt (Numberguessing game) angefangen und bin gut unterwegs mit die Programmierung.                                                            |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Einen sehr simplen und einfache Number guesser game.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss            |   Funktional   | Als Spieler möchte ich wissen, dass wenn man einen Zahl hinein schreibt, es gesagt wird, ob es grösser oder kleiner ist, damit man weisst, ob man höher oder kleiner eintippen muss.  |
| 2    |   Muss          |   Funktional   | Als Spieler möchte ich wissen, wenn ich den richtigen Zahl eintippe, es direkt sagt, damit ich weiss, dass ich gewonnen habe.  |    | 3    |   Muss          |   Funktional   | Als Spieler möchte ich die wahl haben, dass wenn ich gewonnen habe, den Spiel neustarten kann, damit ich wieder spielenn kann.  |
| 4    |   kann          |   Qualität     | Als Spieler würde ich gerne einen kleinen Text am ende haben, der sagt, ob ich gewonnen habe, damit ich fröhlich bin.  |
| 5    |   Muss          |   Funktional   | Als Spieler möchte ich gerne ddie Möglichkeit habe, wieder zu spielen, nachdem ich die Richtige Zahl eingetippt habe.  |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Das Programm ist gestartet und den Zahl ist bereits schon geneririert worden.  | *hallo welt* |  *Bitte nur Zahlen eingeben!* |
| 1.2  |  Das Programm ist gestartet und den Zahl ist bereits schon geneririert worden.  |  *23*  |  *Zahl ist zu klein, bitte weiter probieren*.  |
| 2.1  |  Das Programm ist gestartet und den Zahl ist bereits schon gefunden worden.  | *Enter* | *Zahl erfolgreich gefunden.* |
| 3.1  |  Das Programm ist gestartet und den Zahl ist bereits schon gefunden worden.  | *Enter* | *Wahl wird gegeben, ob man weiterspielen möchte oder nicht.* |
| 4.1  |  Das Programm ist gestartet und den Zahl ist bereits schon gefunden worden.  | *Enter* | *Gratulation! Sie haben gewonnen!* |
| 5.1  |  Das Programm ist gestartet und den Zahl ist bereits schon gefunden worden.  | *Enter* | *Audio von- "We are the champions", spielt.*  |

### 1.4 Diagramme

![Number guesser game](https://user-images.githubusercontent.com/110893594/186111432-fb071fd7-6291-4304-8001-0f990c2ed75c.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  23.08.22  |  Ich  |  Realisierung eines Projektdokument.  |  4 * 45  |
| 1.B  |  30.08.22  |  Ich  |  Realisierung wird angefangen. (Numberguessing generator)  |  4 * 45  |
| 1.C  |  6.09.22   |  Ich  |  Realisierung wird fortgesetzt, beendet und getestet.  |  3 * 45 |
| 1.D  |  13.09.22  |  Ich  |  Projekt fertiggetestet und abgegeben  |  2 * 45  |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  30.08.22  |  Ich  |  10  |  30   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.