# ⚔️ CodeQuest: L'aventura del programador/a de videojocs

## Chapter 1. El camí del mag aprenent 🧙‍♀️

Has estat admès a l'Acadèmia d'Arcanistes, però abans de començar necessites entrenar el teu poder màgic.

1. Demana el **nom del mag**. El mag comença amb **0 punts de poder** i **nivell 1**.
2. Cada dia d'entrenament (**5 dies**), el mag dedica una quantitat aleatòria d'hores de meditació (entre 1 i 24 h) i obté una quantitat aleatòria de poder entre 1 i 10 punts (aleatori).
3. El **nivell** del mag depèn del poder acumulat: cada **10 punts de poder** puja un nivell. Calcula'l amb aquesta fórmula:

   ```
   nivell = 1 + (poder / 10)
   ```

4. Cada dia, mostra un missatge de la seva evolució dia a dia (acumulativa), amb un missatge tipus:

   ```
   ⌛ Dia 3 → Azrael, ja has meditat 10 hores i el teu poder ara és de 27 punts!
   ```

5. Si aquell dia el mag ha pujat de nivell, mostra a més un missatge extra:

   ```
   ⭐ → Azrael ha pujat al nivell 3!
   ```

6. Al final, mostra el **nivell final de poder**. Segons el total:

| Poder total | Missatge | Rang |
|-------------|----------|------|
| `< 20` | "Repeteixes a 2a convocatòria" | Raoden el Elantrí |
| `≥ 20` i `< 30` | "Encara confons la vareta amb una cullera" | Zyn el Buguejat |
| `≥ 30` i `< 35` | "Ets un Invocador de Brises Màgiques." | Arka Nullpointer |
| `≥ 35` i `< 40` | "Uau! Pots invocar dracs sense cremar el laboratori!" | Elarion de les Brases |
| `≥ 40` | "Has assolit el rang de Mestre dels Arcans!" | ITB-Wizard el Gris |

🔍 **TIP**:
- Investiga com crear nombres aleatoris amb la classe `Random`.
- Investiga com mostrar emojis per terminal.

---

## Chapter 2. El calabós del Drac RAMón el Poderós 🐉

El teu mag ha d'obtenir el tresor que s'amaga al Calabós del Drac RAMón el Poderós, on cada porta està protegida per un *codi d'accés digital*.

- Hi ha **3 portes**. Cada una té un codi aleatori entre (1 - 5).
- Tens **3 intents per porta**.
- Si falles una porta (consumit 3 intents intentant obrir-la), el joc acaba amb el missatge:

  ```
  El drac 🐲 ha detectat la teva presència i t'ha expulsat del servidor!
  ```

- Si encertes la porta (sense consumir 3 intents), apareix el missatge:

  ```
  El drac 🐲 et respecta. Has desbloquejat el següent nivell!
  ```

- Si arribes a la tercera porta i l'obres amb èxit, apareix el missatge:

  ```
  Has desbloquejat el nivell final. Pots quedar-te amb el tresor 💎 del drac 🐲!
  ```

🔍 **TIP**: Bucles imbricats.

---

## Chapter 3. Saquejar el botí 💰

Has aconseguit el tresor del drac 🐲 i, a sota del cau, has trobat una mina plena de *bitcoins màgics*!
Cada cop que mines, obtens una quantitat aleatòria de bitcoins d'entre **5 i 50 bits**, o potser res.
Només pots fer **5 excavacions** (una excavació on no trobes res també compta).

- Mostra el resultat de cada excavació.
- A cada excavació hi ha una **probabilitat del 20 %** de no trobar res.
  Pots simular-ho amb un número aleatori entre 1 i 100: si és 20 o menys, no trobes res.
- Si no es troba res, indica-ho amb un missatge:

  ```
  Avui no és el teu dia de sort, has trobat 0 bits 🪙.
  ```

- Si es troba alguna cosa, indica-ho amb un missatge amb la quantitat trobada (per exemple, 23):

  ```
  Avui és el teu dia de sort, has trobat 23 bits 🪙.
  ```

- Si el total és **> 200**, mostra:

  ```
  Has desbloquejat la GPU d'or ⚜️! Els teus encanteris van ara a 120 FPS!
  ```

- Si el total és **≤ 200**, mostra:

  ```
  La teva targeta màgica encara és integrada 🪵. Torna a la mina per provar sort!
  ```

🔍 **TIP**: Amb 5 excavacions pot resultar difícil obtenir un valor > 200 bits. Pots comprovar el missatge fent servir el Debug.
# Programacion
