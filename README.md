# LA1500

# Projekt-Dokumentation


Gruppe Buttercup: Meyer, Burlet, Jashari, Jeanneret-W, Tanner

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   21.2.23    | 0.0.1   | Start des Projektes, Thema finden, UC-Digramm, PAP. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

Wir möchten in unity einen 3D endless runner mit zufälligen Hindernissen erstellen, bei dem man sich nach links rund rechts bewegen und springen kann.
Dabei wollen wir uns mit Unity vertraut machen und lernen wie man zufällig objekte erzeugt.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    Funktional   | Muss     | Als Spieler möchte ich nach rechts und links ausweichen können. |
| 2    |     Funktional  |  Muss     | Als Programmierer möchte ich Hindernisse als 3D Elemente erstellen können.|
| 3    |     Funktional  |  Muss     | Als Spieler möchte ich Coins einsammeln können. |
| 4    |     Funktional  |  Muss     | Als Spieler möchte ich springen können. |
| 5    |     Funktional  |   Muss    | Als Programmierer möchte ich lokalisieren können, wenn der Spieler in ein Hinderniss gerannt ist. |
| 6    |    Funktional   |   Muss    | Als Programmierer möchte ich die Hindernisse zufällig auf der strecke spawnen können.|
| 7    | Funktional      |   Muss    | Als Spieler möchte ich Rollen können|
| 8    | Funktional      |   Muss    | Als spieler möchte ich nach einem Tod dierekt Neustarten können|
| 9   |  Funktional     |   Muss    | Als Spieler möchte ich Items einsammeln können um mehr spass zu haben |
|10|Funktional|Muss|Als User möchte ich über Hindernisse springen können.|
|11|Funktional|Muss|Als User möchte ich unter Hindernisse rollen können.|
|12|Funktional|kann|Als User möchte ich das Item Methylamphetamin einsammeln können, um einfacher durch die Hindernisse zu kommen.|
|13|Funktional|Kann|Als User möchte ich das Ghost Item einsammeln können, um durch Hindernisse hindurch rennen zu können.|
|14|Funktional|Kann|Als User möchte ich einen Jungle Juice trinken können, damit ich höher springen kann.|
|15|Funktional|Kann|Als User möchte ich das John Cena Item einsammeln können, damit man den Charakter nicht mehr sieht.|
|16|Funktional|Kann|Als User möchte ich C2H5OH einsammeln können, damit ich zufällig in eine Richtung gehe.|
|17|Funktional|Kann|Als User möchte ich eine Bombe einsammeln können, die die Umgebung löscht, damit man einfach durchrennen kann.|
|18|Q|MUSS|Als User, möchte icht immer sehen wie weit ich gekommen bin.|


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
|12.1||||
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
|16.5|Sammelt Vodka ein|Timer läuft ab|Steuerung ist nicht mer invertiert.|
|17.1|Sammelt Bombe ein|E|Zerstört zwei Chunks|
|17.2|Spieler Rennt|Sammelt Bombe ein|Bomben Icon auf dem Screen|
|18.1|Spieler Rennt|Spieler Stirbt|Es wird ein Score gezeigt, wie weit man gekommen ist.|


### 1.4 Diagramme

✍️Fügen Sie hier ein Use Case-Diagramm mit mindestens 10 Anwendungsfällen ein; und einen PAP.

![image](https://user-images.githubusercontent.com/77541325/220318069-c8561ee2-01ac-41a6-acfa-016a0bde5364.png)
<img width="524" alt="Screenshot 2023-02-21 112812" src="https://user-images.githubusercontent.com/77541325/220322305-bc36ddb9-ab7b-423f-b622-cfc0fddd0e40.png">


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 



✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |



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
