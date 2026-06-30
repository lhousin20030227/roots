# ROOTS_DIRECTOR/05_STANDARDS/CODING_STANDARD.md

# ROOTS — CODING STANDARD

Version: 1.0

---

# PURPOSE

Define a single coding standard for the entire ROOTS project.

Every programmer and AI Agent must follow these rules.

---

# LANGUAGE

Primary Language:

C#

Framework:

Unity

---

# PHILOSOPHY

Readable code.

Maintainable code.

Modular architecture.

Performance first.

Simplicity over cleverness.

Consistency over personal preference.

---

# SOLID

Follow SOLID principles whenever practical.

Single Responsibility.

Open/Closed.

Liskov Substitution.

Interface Segregation.

Dependency Inversion.

---

# CLASS RULES

One class = One responsibility.

Maximum recommended length:

500 lines.

Split large classes into smaller components.

---

# METHOD RULES

Keep methods focused.

Recommended maximum:

40 lines.

Avoid deeply nested logic.

Prefer early returns.

---

# FILE RULES

One public class per file.

File name must match class name.

---

# NAMING

Follow `NAMING_STANDARD.md`.

Never invent new naming styles.

---

# VARIABLES

Initialize when appropriate.

Keep scope as small as possible.

Avoid global mutable state.

Use meaningful names.

---

# MAGIC VALUES

Forbidden.

Use:

Constants

Enums

ScriptableObjects

Configuration files

---

# COMMENTS

Comment WHY.

Not WHAT.

Avoid obvious comments.

Remove outdated comments.

---

# ERROR HANDLING

Validate inputs.

Handle expected failures gracefully.

Log meaningful errors.

Never silently ignore exceptions.

---

# UNITY RULES

Avoid unnecessary Update().

Cache references.

Prefer events over polling.

Use Coroutines only when appropriate.

Avoid FindObjectOfType during gameplay.

Avoid GameObject.Find in production.

Avoid excessive GetComponent calls.

---

# SCRIPTABLEOBJECTS

Use for:

Configuration.

Game Data.

Item Definitions.

Audio Data.

UI Data.

Avoid storing runtime state.

---

# PREFABS

Keep reusable.

Avoid duplicated logic.

No scene-specific assumptions.

---

# EVENTS

Prefer events for communication.

Unsubscribe correctly.

Avoid memory leaks.

Avoid unnecessary static events.

---

# PERFORMANCE

Profile before optimizing.

Avoid unnecessary allocations.

Reuse objects.

Pool frequently spawned objects.

Avoid LINQ in performance-critical code.

Avoid expensive operations inside Update().

---

# DEPENDENCIES

Minimize dependencies.

Avoid circular references.

Use interfaces when appropriate.

Keep systems loosely coupled.

---

# ARCHITECTURE

Separate:

Gameplay

UI

Audio

Data

Save System

Input

Rendering

Debug

Never mix responsibilities.

---

# DEBUG CODE

Allowed during development.

Must be removed or disabled before release.

---

# TESTING

Every new system should be:

Manually tested.

Regression-safe.

Compatible with existing systems.

---

# DOCUMENTATION

Every significant system must include:

Purpose.

Dependencies.

Public API.

Configuration Notes.

Known Limitations.

---

# FORBIDDEN

Hardcoded paths.

Hardcoded references.

Duplicated logic.

Dead code.

Unused variables.

Unused methods.

Unused assets.

Temporary hacks.

Hidden side effects.

---

# QUALITY CHECK

Every code submission must be:

Readable.

Modular.

Reusable.

Optimized.

Documented.

Production-ready.

---

# MASTER RULE

If another developer cannot understand, modify and extend the code easily, the implementation is not ready for ROOTS.
