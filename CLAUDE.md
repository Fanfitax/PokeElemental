# PokeElemental

Proyecto final de 2º semestre (Josman): juego de combates por turnos en Windows Forms con la estética de **Pokémon Esmeralda**.
Idioma de trabajo con el usuario: **español**.
Proyecto hermano ya terminado (solo de referencia, NO tocar): `C:\Users\josma\Documents\GitHub\ArenaElemental` (repo `Fanfitax/ArenaElemental`).

## MODO DE TRABAJO (lo más importante)
El usuario quiere **aprender**, no recibir el proyecto hecho. Su nivel es básico ("trátame como un alumno noob"): entiende listas, colas y los pilares de POO solo a nivel básico.
- **El usuario escribe el código.** Claude guía paso a paso: explica el concepto con ejemplos sencillos, da el esqueleto y pistas, y revisa lo que el usuario escribió (leyendo sus archivos).
- No pegar el código completo de un paso salvo que el usuario lo pida o esté bloqueado. Explicar siempre el "por qué".
- Cada paso termina con: **punto de control** (qué debe verse/funcionar), **commit en Git** y **3-4 preguntas de defensa**. El objetivo es que pueda defender el proyecto con 100 puntos.
- Enseñar Git en el camino (el usuario no lo domina): `git add`, `commit`, `push`, `status`, `log`. Los commits los hace el usuario con su nombre.
- El usuario tiene poco tiempo (~3 semanas desde el 2026-10-16, ritmo irregular: unos días 5 h, otros menos). Cada paso debe poder hacerse en 1,5-3 h. Se prioriza tener una **versión jugable lo antes posible** (paso 13).

## Restricciones técnicas
- **SharpDevelop 4.4**, .NET Framework 4.0 (sin Client Profile), **C# 4.0**: sin `$""`, `?.`, `nameof`, `async`, auto-propiedades con inicializador ni miembros con `=>`. Verificar con `C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /langversion:4`.
- **Plataforma x86**: en SharpDevelop "Target CPU" = `32-bit Intel-compatible processor` (el depurador no soporta 64 bits). Ya está bien configurado (`<PlatformTarget>x86</PlatformTarget>`).
- Estructura en disco: el repo es `C:\Users\josma\Documents\GitHub\PokeElemental` y el proyecto está en la subcarpeta `PokeElemental\PokeElemental\` (`.sln` y `.csproj` ahí dentro). El `.gitignore` va en la carpeta de afuera (la raíz del repo).
- Estilo de código: sin delegados anónimos ni `=>`; cada evento es un método con nombre. Pantallas creadas por código (sin diseñador visual). Sin base de datos: guardado en un `.txt` local (`partidas.txt`, igual que en ArenaElemental: se carga al abrir y se escribe con `File.AppendAllText`, con try/catch).
- Sin mochila ni huida: el menú de combate es solo **Luchar** y **Equipo**.

## Lo que el profesor exige
Estructuras de datos, herencia y polimorfismo (nada de base de datos). Plan para mostrarlo en la defensa:
- `List<Criatura>`: el equipo del jugador (se elige quién entra en el cambio).
- `Queue<string>`: los mensajes del cuadro de texto (salen uno a uno, como en Esmeralda).
- `Stack<string>`: historial del combate (la última jugada).
- `Dictionary`: tabla de tipos (ventajas/desventajas).
- Arreglo: los 4 movimientos de cada criatura.
- Herencia + polimorfismo: `Movimiento` abstracto con subclases (`MovimientoDano`, `MovimientoCuracion`, `MovimientoEstado`) que sobrescriben `Ejecutar()`; `Criatura` abstracta con una subclase por elemento.

## Diseño del juego
- 8 criaturas (2 por elemento: Fuego, Agua, Tierra, Aire), cada una con **4 movimientos con PP** (como Esmeralda). Triángulo: Agua > Fuego > Aire > Tierra > Agua (x1.5 / x0.5), a validar en el paso 4.
- Equipos de varias criaturas; el cambio es **a elección** (no FIFO como en ArenaElemental). Orden de ataque por velocidad.
- Reutilizar del proyecto ArenaElemental las ilustraciones (`Imagenes\`, personajes de cuerpo completo sobre fondo blanco, con fondo que se quita por código en `Ilustraciones.cs`) y los sonidos (`Sonidos\*.wav`). Solo hay ilustraciones de frente: la criatura del jugador va espejada/pequeña.
- Evitar nombres/sprites/música reales de Pokémon (derechos de autor): criaturas originales con esa estética.

## Estética Esmeralda (objetivo)
Un solo control dibuja la escena a 240x160 escalado x4 (ventana de 960x640, píxeles nítidos con `InterpolationMode.NearestNeighbor`), cuadro de texto de doble borde con efecto máquina de escribir, barras de vida animadas (verde/amarillo/rojo), menú 2x2 con cursor ▶ y control por teclado (flechas, Z = aceptar, X = volver), plataformas, enemigo arriba a la derecha y criatura propia abajo a la izquierda.

## Plan (≈19 pasos)
Semana 1 (el cerebro, sin gráficos): 1. Proyecto, repo y ventana. 2. `Criatura` y enum de tipos (encapsulamiento). 3. `Movimiento` abstracto y subclases. 4. Tabla de tipos con `Dictionary` y fórmula de daño. 5. Equipo con `List`. 6. Motor de batalla (turnos, velocidad, `Queue` de mensajes, `Stack` de historial).
Semana 2 (se ve como Esmeralda): 7. Escena dibujada. 8. Cuadro de texto con máquina de escribir. 9. Barras de vida animadas. 10. Menú principal con cursor y teclado. 11. Menú de movimientos (PP y tipo). 12. Pantalla de equipo y cambio. 13. CPU rival (**versión jugable**).
Semana 3 (completo y defendible): 14. Menú inicial y selección de equipo. 15. Guardado `.txt`, estadísticas y ranking. 16. Sonidos y efectos. 17. Pulido y pruebas. 18-19. Guía de defensa y simulacro de preguntas.

## Progreso
- [x] Paso 1 (parcial): proyecto creado en SharpDevelop, ventana negra de 960x640 con título "PokeElemental" funcionando, x86 configurado.
- [ ] Paso 1 pendiente: crear `.gitignore` en la raíz del repo, `git init -b main`, primer commit, crear el repo `PokeElemental` en GitHub (vacío) y `git push -u origin main`. Responder las 4 preguntas de defensa del paso 1.
- [ ] Pasos 2 a 19.
