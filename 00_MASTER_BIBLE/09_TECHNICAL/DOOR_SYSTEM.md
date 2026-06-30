# DOOR SYSTEM

## Purpose

The Door System controls how players access and move between locations in ROOTS.

Doors are not simple transitions—they support exploration, progression, and environmental storytelling.

---

# Philosophy

Every door should have a logical purpose.

A locked door must have a believable reason for being locked.

Players should never feel that doors exist only to block progress.

---

# Door Types

## Standard Door

Opens and closes freely.

Examples:

* Bedroom doors
* Bathroom doors
* Living room doors

---

## Locked Door

Requires a logical solution.

Unlock methods include:

* Physical key
* Numeric code
* Story progression
* NPC permission

---

## Permanently Locked Door

Cannot be opened during Part 1.

These doors hint at future content or inaccessible areas.

They should always have a believable explanation.

---

## Automatic Door

Used only where realistic.

Examples:

* Hospital entrances
* Public buildings

Automatic doors react naturally to player proximity.

---

# Door States

Every door has one of the following states:

* Open
* Closed
* Locked
* Unlocked
* Blocked
* Disabled (Scripted)

State changes are saved permanently.

---

# Player Interaction

The player can:

* Open
* Close
* Lock (when appropriate)
* Unlock
* Inspect

Interaction should require a single button press.

---

# Keys

Keys are unique inventory items.

Rules:

* Every key has one clear purpose.
* Keys remain in the inventory unless the story requires otherwise.
* Duplicate keys are avoided.

---

# Audio

Every door should have appropriate sounds.

Examples:

* Handle movement
* Lock click
* Hinges
* Wooden creak
* Metal door closing

Different materials produce different sounds.

---

# Animation

Door movement should be:

* Smooth
* Physics-aware
* Natural

Doors should never:

* Snap open instantly.
* Clip through objects.
* Pass through the player.

---

# AI Interaction

NPCs can:

* Open doors.
* Close doors.
* Wait if blocked.
* Respect locked doors.

NPC navigation should remain believable.

---

# Story Integration

Doors often represent progression.

Opening a previously locked door should feel meaningful because it reveals:

* New evidence
* New locations
* New memories
* New story events

---

# Performance Rules

* Only nearby doors process interaction logic.
* Door states persist across saves.
* Animations should be lightweight.
* Audio should be spatially positioned.

---

# Design Rules

* No invisible barriers.
* No arbitrary locked doors.
* Every locked door has a logical explanation.
* Every important door contributes to exploration or storytelling.

---

# Final Rule

A door in ROOTS is more than a passage.

Every door should create curiosity, reinforce realism, and make the world feel like a real place with history, privacy, and purpose.
