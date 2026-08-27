# Fallout Terminal

A recreation of the classic terminal hacking experience from the **Fallout** series, developed in C#/.NET as a personal study project.

The project aims to recreate the look and mechanics of the Fallout terminal hacking minigame while serving as a practical exercise in **C#, .NET, object-oriented programming, software architecture and UI development**.

> **Note:** This is an unofficial fan-made project and is not affiliated with Bethesda Game Studios or Bethesda Softworks.

---

## 🎯 Project Goal

The final goal is to build a standalone terminal application inspired by the terminals found throughout the Fallout universe.

The application will reproduce the main elements of the hacking experience, including:

* Randomized password options
* Characters used to fill the terminal screen
* Password selection
* **Likeness** calculation
* Limited hacking attempts
* Dud removal through special bracket sequences
* Attempt restoration through bracket sequences
* Terminal-style visual presentation
* A graphical user interface inspired by the original Fallout terminals

The project is primarily being developed for **learning purposes**, with an emphasis on writing maintainable C# code and gradually separating the application's logic from its presentation layer.

---

## 🚧 Current Status

The project is currently in its **core logic development phase**.

The initial implementation is being developed as a console application, allowing the hacking mechanics to be tested before the graphical interface is introduced.

### ✅ Already implemented

* [x] Initial project structure
* [x] Separation of hacking-related logic into dedicated classes
* [x] File manipulation routines separated from the main program
* [x] Password collection
* [x] Randomized password selection
* [x] Fixed-length password generation
* [x] Filler character collection
* [x] Terminal content generation
* [x] Initial hacking mechanics
* [x] Password likeness comparison
* [x] Attempt tracking

### 🔨 Currently working on

* [ ] Positioning passwords within the generated terminal content
* [ ] Improving filler character generation
* [ ] Special bracket sequences
* [ ] Dud removal mechanic
* [ ] Attempt restoration mechanic
* [ ] Refining the terminal generation rules
* [ ] Improving separation between application logic and user interface

---

## 🖥️ User Interface

The current version uses the **.NET Console** as a temporary interface.

This approach allows the core mechanics to be developed and tested without initially introducing the complexity of a graphical framework.

Once the core system is stable, the project will move toward a graphical interface using either:

* **WPF**
* **Avalonia UI**

The graphical version will focus on reproducing the characteristic terminal aesthetic of Fallout, including:

* Monospaced terminal typography
* Green-on-black terminal presentation
* Hexadecimal memory addresses
* Random ASCII characters
* Password columns
* Terminal messages
* Cursor interaction
* Visual feedback
* CRT-inspired visual effects

The goal is to keep the hacking logic independent from the UI, allowing the same core system to be used regardless of the presentation layer.

---

## 🧠 Hacking Mechanics

The main gameplay mechanic is inspired by the terminal hacking system introduced in Fallout 3 and subsequently used in later Fallout games.

The player is presented with several possible passwords of the same length, mixed with random characters. Selecting an incorrect password provides a **likeness** value indicating how many characters match the correct password in the same position.

Special bracket sequences such as:

```text
(...)
[...]
{...}
<...>
```

can also be found among the random characters. In the original mechanic, these sequences can provide benefits such as removing an incorrect password or restoring hacking attempts.

The project aims to reproduce these mechanics while implementing the underlying logic independently.

---

## 🏗️ Project Structure

The project is being structured to keep responsibilities separated.

The main application entry point is intentionally kept lightweight, while dedicated classes are responsible for specific functionality.

The current architecture follows the general idea of:

```text
Program
│
├── Hacking Logic
│   ├── Password generation
│   ├── Terminal generation
│   ├── Likeness calculation
│   └── Hacking mechanics
│
└── File Management
    ├── Reading files
    └── Managing word collections
```

As development progresses, the project will further separate the **application logic** from the **presentation layer**, making the eventual migration from Console to WPF/Avalonia easier.

---

## 🛠️ Technologies

* **C#**
* **.NET**
* Console Application
* Object-Oriented Programming
* File I/O

### Planned

* **WPF or Avalonia UI**
* Improved UI architecture
* Terminal visual effects

---

## 📌 Roadmap

### Core

* [x] Project foundation
* [x] Word management
* [x] Filler characters
* [x] Basic terminal generation
* [x] Likeness system
* [ ] Complete bracket mechanics
* [ ] Complete hacking flow
* [ ] Improve terminal generation

### Interface

* [ ] Define UI architecture
* [ ] Create graphical terminal interface
* [ ] Recreate Fallout-inspired terminal layout
* [ ] Add animations and visual feedback
* [ ] Add CRT-inspired effects
* [ ] Replace Console input/output

### Future

* [ ] Terminal difficulty levels
* [ ] Configurable word pools
* [ ] Configurable terminal themes
* [ ] Sound effects
* [ ] Boot sequence
* [ ] Additional terminal interactions
* [ ] Physical terminal integration

---

## 📚 Purpose

This project is being developed primarily as a **learning exercise**.

The main objectives are to practice:

* C# and .NET
* Object-oriented programming
* Code organization
* Separation of responsibilities
* File manipulation
* Randomization and procedural generation
* User interaction
* UI development
* Software architecture

The Fallout terminal concept provides a practical and enjoyable way to apply these concepts to a project that can eventually become a physical interactive terminal.

---

## ⚠️ Disclaimer

This is an **unofficial fan project** created for educational and personal purposes.

Fallout and its related intellectual property belong to their respective owners, including Bethesda Softworks and Bethesda Game Studios.

This project is not affiliated with, endorsed by, or sponsored by Bethesda.

---

## 🚀 Project Status

**Development:** 🟡 In Progress

The project is currently focused on completing the core hacking mechanics before moving on to the graphical interface.
