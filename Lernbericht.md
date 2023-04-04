# Lern-Bericht
Buttercup  Meyer, Burlet, Jashari, Jeanneret-W, Tanner

## Einleitung

Wir wollten ein Endlessrunner in Unity programmieren

## Was habe ich gelernt?

Wie man automatischer rennen programmiert.

## Beschreibung

Dieser Code definiert eine Skript-Komponente "Move", die an ein Unity-Spielobjekt angehängt werden kann.
Das Skript ermöglicht es dem Spielobjekt, sich mit einer konstanten Geschwindigkeit in Richtung seiner Vorwärtsachse (in der Weltkoordinaten) zu bewegen.
Die öffentliche Variable "speed" definiert die Geschwindigkeit, mit der das Spielobjekt bewegt werden soll.
Sie kann von außen verändert werden und ermöglicht so eine einfache Anpassung der Bewegungsgeschwindigkeit.
Standardmäßig ist die Geschwindigkeit auf 5,0 festgelegt. Die Methode "Start" wird einmal aufgerufen, wenn das Spielobjekt erstellt wird.
Hier kann man Aktionen ausführen, die beim Start des Spielobjekts ausgeführt werden sollen.
In diesem Fall bleibt die Methode leer. Die Methode "Update" wird einmal pro Frame aufgerufen und führt die eigentliche Bewegung des Spielobjekts aus.
Hier wird das Spielobjekt mithilfe der "Transform.Translate" -Methode in Richtung seiner Vorwärtsachse verschoben. Der Bewegungswert wird mit der Geschwindigkeit multipliziert und mit "Time.deltaTime" skaliert, um sicherzustellen, dass die Bewegung unabhängig von der Framerate des Spiels ist.
Das bedeutet, dass sich das Objekt immer gleich schnell bewegt, unabhängig davon, wie schnell das Spiel gerade läuft.
"Vector3.forward" bezieht sich auf die Vorwärtsachse des Spielobjekts in Weltkoordinaten.

```C#

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5.0f; 
    
    // Start is called before the first frame update
    void Start()
    {
    }    

    // Update is called once per frame
   void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
```

![Screenshot 2023-04-04 091142](https://user-images.githubusercontent.com/110892742/229721458-362e9cff-4f56-4a63-81c3-08233c7262ed.png)


## Verifikation

Es erklärt Personen die einen Endlessrunner wollen programmieren, welcher Code man benuzten muss und was der Code überhaupt macht.

# Reflektion zum Arbeitsprozess

Wir konnten schnell ein gutes Projekt auswählen.

Wir hatten komunikationsprobleme in den Distanzunterrichten.

**VBV**: Am anfang einen Gruppenchat erstelllen damit wir Termine machen können wenn wir alle zusammen arbeiten sollen.
