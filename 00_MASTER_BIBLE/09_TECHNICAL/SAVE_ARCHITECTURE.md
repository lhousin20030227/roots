SAVE ARCHITECTURE
Purpose
The Save Architecture defines how ROOTS stores, organizes, and restores game data, ensuring the player's progress is always preserved accurately and reliably.

Save Philosophy
Saving must be invisible and trustworthy.
The player should never worry about losing progress, evidence, or story state.
The system prioritizes reliability over complexity.

Save Data Categories
Story Data

Current chapter
Active story flags
Completed story beats
Unlocked dialogue states


Player Data

Player position (per scene/checkpoint, not exact physics state)
Current objective
Relationship states with characters


Evidence Data

Collected evidence items
Evidence Board entries
Timeline entries unlocked
Read / unread status of documents


Inventory Data

Items currently held
Item states (used, combined, consumed)
Key items tied to puzzles


World Data

Object states (opened, locked, collected, used)
Door states
Container states
Triggered events per location


System Data

Settings (audio, video, controls)
Accessibility preferences
Language selection


Save Triggers
Saving occurs:

Automatically at chapter transitions.
Automatically after critical story events.
Automatically after collecting key evidence.
Manually if the player chooses a "Save" option (if enabled).

No save during unresolved mid-action states (e.g., mid-dialogue, mid-animation).

Save Slots

Multiple save slots are supported.
Each slot displays: Chapter name, playtime, timestamp, thumbnail (optional).
Autosave slot is separate from manual save slots.


Load Behavior

Loading restores all categories exactly as stored.
World objects rebuild their correct state before the player gains control.
Story flags are validated to prevent contradictions.
No partial or corrupted state is allowed to load.


Data Integrity Rules

Save files must be versioned (to support future updates).
Corrupted save files must fail safely, not crash the game.
Critical data is never overwritten until the new save completes successfully.
Backup of the previous save is kept until the new one is confirmed valid.


Performance Rules

Save operations run asynchronously when possible.
Save file size stays minimal (no redundant data).
Loading prioritizes story-critical data first, then cosmetic/world detail.


Forbidden Features
Do not include:

Permadeath / no-save modes.
Save scumming exploits affecting story logic.
Cloud-only saves with no local backup.
Save systems that can softlock the player.


Final Rule
The Save Architecture exists to protect the player's time and emotional investment in the story.
It must always be reliable, predictable, and invisible — the player should only ever think about the story, never about whether their progress is safe.
