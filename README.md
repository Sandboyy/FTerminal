# `ROBCO INDUSTRIES (TM) TERMLINK PROTOCOL`

```text
╔══════════════════════════════════════════════════════════════════╗
║           ROBCO INDUSTRIES (TM) TERMLINK PROTOCOL               ║
║                                                                  ║
║  > INITIALIZING SYSTEM...                                       ║
║  > LOADING PROJECT DATA...                                      ║
║  > SECURITY PROTOCOL: ACTIVE                                    ║
║  > SYSTEM STATUS: OPERATIONAL                                  ║
║                                                                  ║
║  PROJECT: FALLOUT TERMINAL                                      ║
║  STATUS:  DEVELOPMENT IN PROGRESS                               ║
╚══════════════════════════════════════════════════════════════════╝
```

> **"War. War never changes."**

A fan-made recreation of the classic terminal hacking experience from the **Fallout** series, developed with **C#/.NET** as a personal study project.

The project aims to reproduce the core mechanics and atmosphere of the Fallout terminal hacking minigame while providing a practical environment for studying **C#, .NET, object-oriented programming, software architecture and UI development**.

> ⚠️ **NOTICE:** This is an unofficial fan-made project and is not affiliated with Bethesda Game Studios or Bethesda Softworks.

---

## `> SYSTEM OVERVIEW`

The final objective is to create a standalone terminal application inspired by the computer terminals found throughout the Fallout universe.

The application will recreate the main elements of the hacking experience:

```text
[ SYSTEM FEATURES ]

✓ RANDOMIZED PASSWORDS
✓ TERMINAL FILLER CHARACTERS
✓ PASSWORD SELECTION
✓ LIKENESS CALCULATION
✓ LIMITED HACKING ATTEMPTS
✓ SPECIAL BRACKET SEQUENCES
✓ DUD REMOVAL
✓ ATTEMPT RESTORATION
✓ TERMINAL-STYLE INTERFACE
✓ FALLOUT-INSPIRED VISUAL PRESENTATION
```

The project is primarily being developed for **learning purposes**, with a particular focus on writing maintainable C# code and separating application logic from the presentation layer.

---

## `> DEVELOPMENT STATUS`

**SYSTEM STATUS:** `UNDER DEVELOPMENT`

The project is currently focused on implementing and testing the **core hacking mechanics**.

The initial version is being developed as a console application. This allows the underlying systems to be tested before introducing the complexity of a graphical interface.

### `> COMPLETED MODULES`

* [x] Initial project structure
* [x] Separation of hacking-related logic into dedicated classes
* [x] File manipulation routines
* [x] Password collection
* [x] Randomized password selection
* [x] Fixed-length password generation
* [x] Filler character collection
* [x] Terminal content generation
* [x] Initial hacking mechanics
* [x] Password likeness comparison
* [x] Attempt tracking

### `> ACTIVE DEVELOPMENT`

* [ ] Password positioning within terminal content
* [ ] Filler character generation improvements
* [ ] Special bracket sequences
* [ ] Dud removal mechanic
* [ ] Attempt restoration mechanic
* [ ] Terminal generation rules
* [ ] Further separation between application logic and UI

---

## `> HACKING PROTOCOL`

The main gameplay mechanic is inspired by the terminal hacking system introduced in **Fallout 3** and subsequently used in later Fallout titles.

The player is presented with several possible passwords of the same length, mixed with random characters.

Selecting an incorrect password produces a **likeness** value, representing the number of characters that match the correct password in the same position.

```text
> PASSWORD REQUIRED
> ATTEMPTS REMAINING: 4

  SECURITY
  TERMINAL
  DECODING
  PROTOCOL

> ENTER PASSWORD:
```

Special character sequences are also present throughout the terminal:

```text
(...)
[...]
{...}
<...>
```

These sequences provide additional interactions, such as removing an incorrect password or restoring hacking attempts.

The goal of this project is to reproduce these mechanics while implementing the underlying system independently.

---

## `> TERMINAL INTERFACE`

The current interface is intentionally simple.

```text
CURRENT INTERFACE
────────────────────────────────────────

.NET CONSOLE

STATUS: FUNCTIONAL
PURPOSE: CORE LOGIC TESTING

────────────────────────────────────────
FUTURE INTERFACE

WPF / AVALONIA UI

STATUS: PLANNED
PURPOSE: FINAL TERMINAL PRESENTATION
```

The Console is being used as a temporary interface while the core systems are developed.

Once the hacking mechanics are stable, the project will move toward a graphical interface using **WPF or Avalonia UI**.

The final interface will aim to reproduce the characteristic Fallout terminal aesthetic:

* Monospaced terminal typography
* Green-on-black presentation
* Hexadecimal memory addresses
* Random ASCII characters
* Password columns
* Terminal system messages
* Cursor interaction
* Visual feedback
* CRT-inspired effects
* Boot and shutdown sequences

The architecture is being designed so that the hacking logic remains independent from the interface.

This should allow the same core system to be used with either a Console or graphical UI.

---

## `> SYSTEM ARCHITECTURE`

The project is being structured around separation of responsibilities.

The main application entry point is intentionally kept lightweight, while dedicated classes handle specific functionality.

Current conceptual structure:

```text
FalloutTerminal
│
├── Program
│
├── Hacking
│   ├── Password generation
│   ├── Terminal generation
│   ├── Likeness calculation
│   └── Hacking mechanics
│
└── File Management
    ├── Word collection
    └── File operations
```

As development progresses, the project will further separate the **application logic** from the **presentation layer**.

The long-term objective is to allow the terminal interface to be replaced without requiring major changes to the underlying hacking system.

---

## `> TECHNOLOGY STACK`

### Current

```text
LANGUAGE        C#
FRAMEWORK       .NET
INTERFACE       Console
PARADIGM        Object-Oriented Programming
STORAGE         File I/O
```

### Planned

```text
UI              WPF / Avalonia UI
ARCHITECTURE    UI / Logic separation
VISUALS         CRT-inspired terminal effects
AUDIO           Terminal sound effects
```

---

## `> DEVELOPMENT ROADMAP`

### `CORE SYSTEM`

* [x] Project foundation
* [x] Word management
* [x] Filler characters
* [x] Basic terminal generation
* [x] Likeness system
* [ ] Complete bracket mechanics
* [ ] Complete hacking flow
* [ ] Improve terminal generation
* [ ] Refine game rules

### `GRAPHICAL INTERFACE`

* [ ] Define UI architecture
* [ ] Select WPF or Avalonia
* [ ] Create graphical terminal interface
* [ ] Recreate Fallout-inspired terminal layout
* [ ] Add animations and visual feedback
* [ ] Add CRT-inspired effects
* [ ] Replace Console input/output

### `FUTURE SYSTEMS`

* [ ] Terminal difficulty levels
* [ ] Configurable word pools
* [ ] Configurable terminal themes
* [ ] Sound effects
* [ ] Boot sequence
* [ ] Shutdown sequence
* [ ] Additional terminal interactions
* [ ] Physical terminal integration

---

## `> PROJECT OBJECTIVE`

This project is being developed primarily as a **learning exercise**.

The main objectives are to gain practical experience with:

```text
C# / .NET
    ↓
Object-Oriented Programming
    ↓
Code Organization
    ↓
Separation of Responsibilities
    ↓
File Manipulation
    ↓
Randomization & Procedural Generation
    ↓
User Interaction
    ↓
UI Development
    ↓
Software Architecture
```

The Fallout terminal concept provides a practical and enjoyable way to apply these concepts to a project that can eventually become a **physical interactive terminal**.

---

## `> PROJECT STATUS`

```text
╔════════════════════════════════════════════════════╗
║                                                    ║
║  PROJECT STATUS                                    ║
║                                                    ║
║  CORE SYSTEM       ███████████░░░░░░░░             ║
║  GRAPHICAL UI      ░░░░░░░░░░░░░░░░░░░░             ║
║  PHYSICAL BUILD    ░░░░░░░░░░░░░░░░░░░░             ║
║                                                    ║
║  STATUS: IN DEVELOPMENT                            ║
║                                                    ║
╚════════════════════════════════════════════════════╝
```

The current development focus is completing the core hacking mechanics before moving on to the graphical terminal interface.

---

## `> DISCLAIMER`

This is an **unofficial fan project** created for educational and personal purposes.

**Fallout** and its related intellectual property belong to their respective owners, including Bethesda Softworks and Bethesda Game Studios.

This project is not affiliated with, endorsed by, or sponsored by Bethesda.

---

```text
ROBCO INDUSTRIES (TM)

TERMLINK PROTOCOL TERMINATED.

> THANK YOU FOR USING ROBCO INDUSTRIES AUTOMATED TERMINAL SERVICES.

> GOODBYE.
```
