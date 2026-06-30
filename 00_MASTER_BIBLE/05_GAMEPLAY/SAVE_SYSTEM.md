# SAVE SYSTEM

## Purpose

The Save System preserves the player's progress while maintaining immersion and preventing the loss of meaningful investigation progress.

---

# Save Philosophy

The player should never lose significant progress because of forgetting to save.

Saving should be simple, reliable, and transparent.

---

# Save Types

## Manual Save

The player can manually save the game at almost any time through the pause menu.

This is the primary save method.

---

## Auto Save

The game automatically saves after important events.

Examples:

* Completing an objective.
* Collecting critical evidence.
* Solving a major puzzle.
* Unlocking a new location.
* Finishing a chapter.

Auto Save should never interrupt gameplay.

---

## Quick Save

Quick Save is available outside of scripted sequences.

It creates a temporary save that can be overwritten.

---

# Save Data

Each save file stores:

* Current Chapter
* Current Objectives
* Inventory
* Evidence Board
* Puzzle Progress
* Dialogue Progress
* NPC Relationship States
* Unlocked Locations
* Player Position
* World State
* Game Settings
* Play Time
* Save Timestamp

---

# World Persistence

The world remembers everything the player has done.

Examples:

* Opened doors remain open.
* Solved puzzles stay solved.
* Collected evidence cannot reappear.
* NPC dialogue reflects previous conversations.
* Completed objectives remain completed.

---

# Checkpoints

Invisible checkpoints exist before important story events.

If a save becomes corrupted or unusable, the player can continue from the latest checkpoint.

---

# Save Restrictions

Saving is temporarily disabled during:

* Cutscenes.
* Critical scripted events.
* Loading screens.

Saving becomes available again immediately afterward.

---

# Multiple Save Slots

Players may create multiple save files.

Recommended features:

* Unlimited manual save slots.
* Auto Save slot.
* Quick Save slot.

This allows players to revisit earlier parts of the story.

---

# Loading

Loading a save restores the exact game state without altering story progression.

No evidence, objectives, or world changes should be lost.

---

# Design Rules

* Saving must be fast.
* Loading must be reliable.
* No save limitations.
* No penalties for saving frequently.
* No permanent fail states caused by saving.

---

# Final Rule

The Save System exists to protect the player's investigation. Every save should faithfully preserve the world, the story, and every discovery made during the journey toward the truth.
