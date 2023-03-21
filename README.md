# LA1500

# Projekt-Dokumentation


Gruppe Buttercup: Meyer, Burlet, Jashari, Jeanneret-W, Tanner

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   21.2.23    | 0.0.1   | Start des Projektes, Thema finden, UC-Digramm, PAP.   |
| 28.2.23      | 0.0.2     |  Testfälle und Arbeitspakete erstellt               |
|7.3.22|0.0.3|Wir haben grundsätzlich nur versucht unser Projekt zu synchronisieren.|
|14.3.22|0.0.4|Wir hatten probleme mit Github, womit unser fortschritt bisschen zurückgesetz wurde, wir haben deshalb nochmals das Jump und das Movementscript machen müssen.|

## 1 Informieren

### 1.1 Ihr Projekt


Wir möchten in unity einen 3D endless runner mit zufälligen Hindernissen erstellen, bei dem man sich nach links rund rechts bewegen und springen kann.
Dabei wollen wir uns mit Unity vertraut machen und lernen wie man zufällig objekte erzeugt.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    Funktional   | Muss     | Als Spieler möchte ich nach rechts und links ausweichen können,um nicht zu sterben |
| 2    |     Funktional  |  Muss     | Als Spilere möchte ich Hindernisse als 3D Elemente haben, damit die welt gut aussieht|
| 3    |     Funktional  |  Muss     | Als Spieler möchte ich Coins einsammeln können, um upgades im shop kaufen zu klönnen |
| 4    |     Funktional  |  Muss     | Als Spieler möchte ich springen können, um hindernissen auszuweichem |
| 5    |     Funktional  |   Muss    | Als Spieler möchte ich lokalisieren können, wenn der ich in ein Hinderniss gerannt bin, damit ich eine Herausvorderung habe |
| 6    |    Funktional   |   Muss    | Als Spieler möchte ich dass die Hindernisse zufällig auf der strecke spawnen, damit es nicht langweilig wird|
| 7    | Funktional      |   Muss    | Als Spieler möchte ich Rollen können, um hohen objekten auszuweichen|
| 8    | Funktional      |   Muss    | Als spieler möchte ich nach einem Tod dierekt Neustarten können, dsamit ich nicht immer in den start bildschirm muss|
| 9   |  Funktional     |   Muss    | Als Spieler möchte ich ItemBoxen einsammeln können um mehr spass zu haben |
|10|Funktional|Muss|Als User möchte ich über Hindernisse springen können, um nicht im sprung zu sterben|
|11|Funktional|Muss|Als User möchte ich unter Hindernisse rollen können, um nicht während dem rollen zu sterben|
|12|Funktional|kann|Als User möchte ich das Item Ibuprofen einsammeln können, um einfacher durch die Hindernisse zu kommen.|
|13|Funktional|Kann|Als User möchte ich das Ghost Item einsammeln können, um durch Hindernisse hindurch rennen zu können.|
|14|Funktional|Kann|Als User möchte ich einen Jungle Juice trinken können, damit ich höher springen kann.|
|15|Funktional|Kann|Als User möchte ich das John Cena Item einsammeln können, damit man den Charakter nicht mehr sieht.|
|16|Funktional|Kann|Als User möchte ich C2H5OH einsammeln können, damit ich zufällig in eine Richtung gehe.|
|17|Funktional|Kann|Als User möchte ich eine Bombe einsammeln können, die die Umgebung löscht, damit man einfach durchrennen kann.|
|18|Q|MUSS|Als User, möchte icht immer sehen wie weit ich gekommen bin, damit ich mich mit freunden messen kann|
|19|funktional|Kann| Als user möchte ich meine Items im shop verbessern können, um die Vorteile zu erweitern|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|1.1|Spieler Rennt|A|Spieler geht nach links.|
|1.2|Spieler Rennt|D|Spieler geht nacht rechts.|
|3.1|Spieler Rennt|Sammelt eine Münze ein.|Der Münzcounter ist hochgegangen.|
|4.1|Spieler Rennt|W/SPACE|Spieler springt in die Luft.|
|5.1|Spieler Rennt|in ein Hinderniss|Tod des Spielers und Neustartmenü und Spiel hält an|
|6.1|Spieler Rennt|Spieler stirbt nicht|Neue Objekte / Chunks|
|6.2|Spieler Rennt|Spieler stirbt|Keine neuen Objekte / Chunks|
|7.1|Spieler Rennt|S/SHIFT|Spieler Rollt|
|8.1|Spieler Rennt|Spieler Stirbt|Neustartmenü|
|8.2|Spieler ist im Neustartmenü|Spieler drückt neustarten|Spieler Rennt|
|9.1|Spieler Rennt|Spieler sammelt ein Item ein|Funktion des Items wird ausgeführt.|
|10.1|Spieler Rennt|W/SPACE|Spieler springt über hinderniss ohne zu sterben.|
|11.1|Spieler Rennt|S/SHIFT|Spieler rollt unter hinderniss ohne zu sterben.|
|12.1|Spieler Rennt|Sammelt Ibuprofen ein|Welt wird langsamer, spieler animation wird schneller.|
|12.2|Sammelt Ibuprofen ein|Timer läuft ab|Alles ist wieder in normaler geschwindigkeit.|
|13.1|Sammelt Geistitem ein|Rennt in ein Hindernis|Geht durch das Hinderniss hindurch|
|13.2|Sammelt Geistitem ein|Ein Timer Läuft ab|Man ist wieder normal|
|14.1|Sammelt JungleJuice ein|W/SPACE|Springt doppelt so hoch.|
|14.2|Sammelt JungleJuice ein|Timer läuft ab|Man ist wieder normal.|
|15.1|Spieler Rennt|Sammelt John Cena ein|Spieler ist unsichtbar.|
|15.2|Sammelt John Cena ein|Timer läuft ab|Man ist wieder sichtbar.|
|16.1|Sammelt Vodka ein|A|Spieler geht nach rechts|
|16.2|Sammelt Vodka ein|D|Spieler geht nach links|
|16.3|Sammelt Vodka ein|W/SPACE|Spieler Rollt|
|16.4|Sammelt Vodka ein|S/SHIFT|Spieler Springt|
|16.5|Spieler rennt|Sammelt vodka ein|Musik änder sich|
|16.5|Sammelt Vodka ein|Timer läuft ab|Steuerung ist nicht mer invertiert, Musik wieder Normal|
|17.1|Sammelt Bombe ein|E|Zerstört zwei Chunks|
|17.2|Spieler Rennt|Sammelt Bombe ein|Bomben Icon auf dem Screen|
|18.1|Spieler Rennt|Spieler Stirbt|Es wird ein Score gezeigt, wie weit man gekommen ist.|
|19.1|spieler stirbt|spieler wählt im menü "shop" aus|shop erscheint|
|19.2|spieler ist im shop|spieler wählt upgrade aus|item wird verbessert|


### 1.4 Diagramme

✍️Fügen Sie hier ein Use Case-Diagramm mit mindestens 10 Anwendungsfällen ein; und einen PAP.

![image](https://user-images.githubusercontent.com/77541325/220318069-c8561ee2-01ac-41a6-acfa-016a0bde5364.png)
<img width="524" alt="Screenshot 2023-02-21 112812" src="https://user-images.githubusercontent.com/77541325/220322305-bc36ddb9-ab7b-423f-b622-cfc0fddd0e40.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|0.A|7.3.23|Tanner|Boden erstellen und Textur einfügen|15min|
|0.B|7.3.23|Jeanneret|Boden animieren|45min|
|0.C|7.3.23|Meyer|Spielfigur erstellen|30min|
|0.D|14.3.23|Jashari|Spielfigur animieren|90min|
|1.A|7.3.23|Burlet|Scrpit für Spielerbewegeung erstellen|30min|
|2.A|14.3.23|Meyer|3D elemente Erstellen und als chunks Speichern|60-90min|
|3.A|14.3.23|Burlet|Coin element erstellen und bei berührung mit Spieler zerstören|30min|
|3.B|21.3.23|Jeanneret|Coins zu Chunks ergänzen|15min|
|3.C|14.3.23|Tanner|Coin Counter erstellen|15min|
|4.A|7.3.23|Jashari|Springen zu Bewegeungsscript hinzufügen|5min|
|4.B|7.3.23|Burlet|Springen wenn man in der luft ist blockieren|5min|
|5.A|21.3.23|Burlet|Script zum Spieler hinzufügen, welches die Kollision mit Objekten erkennt|60min|
|6.A|14.3.23|Jeanneret|Chunks aus 2.A zufällig einfügen|30min|
|6.B|14.3.23|Jashari|Script erstellen um Chunks welche Hinter dem Spieler liegen wieder zu löschen|20min|
|7.A|7.3.23||Script der Spielerbewegung erweitern und rollen Hinzufügen|15min|
|8.A|21.3.23|Burlet|Neustartmenü erstellen|30min|
|9.A|14.3.23|Meyer|Script zum ItemsBoxen einsammeln erstellen und zum Spieler hinzufügen.|30min|
|9.B|21.3.23|Tanner|Timer script erstellen|15min|
|9.C|14.3.23|Jeanneret|Script zum einsammeln der ItemBox erstellen und zum Spieler hinzufügen|20min|
|10.A|14.3.23|--|||
|11.A|14.3.23|--|||
|12.A|21.3.23|Jashari|Script für die funktion von Ibuprofen hinzufügen|30min|
|13.A|21.3.23|Burlet|Script für Ghost item Hinzufügen|45min|
|14.A|21.3.23|Meyer|Script für Jungle juice hinzufügen|30min|
|15.A|21.3.23|Tanner|Script für John Cena erstellen|30min|
|16.A|21.3.23|Jeanneret|Script für C2H5OH|| erstellen|45min|
|17.A|21.3.23|Burlet|Script für Bombe ertsllen|60min|
|18.A|21.3.23|Jashari|Script für Score anzeige erstellen|45min|
|19.A|21.3.23|Meyer|Coins aus allen runden speichern|30min|
|19.B|21.3.23|Jeanneret|Shop erstellen und verbesserungen einfügen|60min|
Total: 935min / 15.5h
--> 3.1h/person


✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.
Wir haben uns dazu entschieden, dass der Charakter sich bewegt und einfach die Welt vorne generiert wird und hinten wieder verschwindet, anstatt dass sich die Welt bewegt und der Charakter da steht mit einer Rennanimation.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| 1.A  |       |           |               |                   |
| 1.A  |       |           |               |                   |
| 1.A  |       |           |               |                   |
| 1.A  |       |           |               |                   |
| 1.A  |       |           |               |                   |
| 1.A  |       |           |               |                   |
| 1.A  |       |           |               |                   |
| 4.A  | 7.3.23      |  Jashari         | 5min              |  15min                 |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
||       |          |        |
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
