# INTERACTION SYSTEM

## Purpose

The Interaction System defines how the player communicates with the world of ROOTS.

Every interaction should feel immediate, believable, and meaningful.

---

# Interaction Philosophy

The player interacts with the world exactly as a real person would.

Interactions should be:

* Simple
* Responsive
* Context-aware
* Story-driven

Every interaction must have a clear purpose.

---

# Interaction Types

## Inspect

Closely examine an object.

Examples:

* Documents
* Photographs
* Furniture
* Personal belongings
* Evidence

Inspection may reveal hidden details.

---

## Pick Up

Collect an important object.

Examples:

* Keys
* Letters
* Medical records
* Puzzle items
* Personal objects

Collected items are automatically stored in the Inventory or Evidence Board.

---

## Use

Use an item on a compatible object.

Examples:

* Unlock a door with a key.
* Insert a cassette into a recorder.
* Enter a code on a keypad.
* Use a flashlight in a dark area.

Only logical interactions are allowed.

---

## Read

Read written material.

Examples:

* Notes
* Letters
* Diaries
* Official documents
* Books

Players may reopen previously read documents at any time.

---

## Listen

Play audio evidence.

Examples:

* Voice recordings
* Voicemail
* Cassette tapes
* Radio messages

Playback can be paused, resumed, or replayed.

---

## Talk

Interact with NPCs.

Dialogue depends on:

* Story progress
* Collected evidence
* Previous conversations
* Relationship level

---

## Open / Close

Interact with movable objects.

Examples:

* Doors
* Drawers
* Cabinets
* Windows
* Storage boxes

Animations should feel smooth and realistic.

---

# Interaction Detection

The game automatically detects the most relevant nearby object.

Priority:

1. Story-critical object
2. Puzzle object
3. Evidence
4. NPC
5. General interactive object

This minimizes accidental interactions.

---

# Interaction UI

When an object is available, display:

* Interaction icon
* Object name
* Action prompt

Example:

```text
[E] Read Letter
```

The interface should remain minimal and disappear when not needed.

---

# Feedback

Successful interactions provide immediate feedback through:

* Animation
* Sound
* UI confirmation (when necessary)
* Character reaction

The player should always understand that the action succeeded.

---

# Accessibility

Support:

* Hold or Toggle interaction
* Remappable interaction key
* Larger interaction prompts
* Subtitle support
* High-contrast interaction icons

---

# Performance Rules

* Only nearby objects are checked for interaction.
* Detection updates efficiently.
* Interaction logic should have minimal performance impact.

---

# Forbidden Features

Do not include:

* Fake interactive objects.
* Excessive button mashing.
* Long interaction animations.
* Confusing prompts.
* Interactions without purpose.

---

# Final Rule

Every interaction in ROOTS should strengthen immersion.

When the player presses a button, they should feel like they are naturally interacting with a real object in a real place—not triggering a game mechanic.
