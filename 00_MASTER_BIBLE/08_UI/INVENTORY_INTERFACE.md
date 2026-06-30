INVENTORY INTERFACE
Purpose
The Inventory Interface defines how the player manages collected items, organizing personal belongings, puzzle items, and key objects in a clear, accessible manner that supports gameplay without unnecessary complexity.

Inventory Philosophy
The inventory should feel like a personal collection — organized but not overly gamified, practical but not mechanical.
The player should always know what they're carrying and why each item matters.

Inventory Access
Opening the Inventory

Opened via dedicated key (default: [I] on keyboard, [Menu] on controller).
Inventory accessible from gameplay or pause menu.
Quick access from HUD (doesn't require pausing).
Smooth transition animation (fade in/out, not jarring).


Closing the Inventory

Closed via same key, ESC, or Back button.
Closes smoothly to resume gameplay.


Inventory Screen Layout
┌─────────────────────────────────────────┐
│  INVENTORY                              │
│                                         │
│  Categories:  [All] [Items] [Keys]     │
│                                         │
│  ┌──────────────────────────────────┐  │
│  │ • Brass Key                      │  │
│  │   Opens the front door of home   │  │
│  │                                  │  │
│  │ • Father's Photograph            │  │
│  │   A worn family photo, faded     │  │
│  │                                  │  │
│  │ • Medical Record (Personal)      │  │
│  │   Official document, dated 1998  │  │
│  │                                  │  │
│  │ • Cassette Tape                  │  │
│  │   Labeled "Mom's Voice"          │  │
│  │                                  │  │
│  └──────────────────────────────────┘  │
│                                         │
│  [Item Details Panel]                  │
│  Brass Key                              │
│  "Opens the front door. I've had this  │
│  key for years. It feels heavier than  │
│  I remember."                           │
│                                         │
│  • Examine  • Use  • Drop (if usable)  │
│                                         │
└─────────────────────────────────────────┘

Inventory Categories
All
Shows every item collected (default view).

Items
Personal belongings, documents, and general items.
Examples: photographs, letters, personal objects, puzzle items.

Keys
Key items and puzzle objects used to unlock or solve.
Examples: keys, codes, tools needed for progression.

Documents
Optional category for documents/written evidence (if separate from Items).

Item Display
Each item shows:

Item Name — clear, readable label.
Item Description — optional flavor text or functional info (1–2 sentences).
Item Icon — small visual representation (optional but helpful).
Action Buttons — context-appropriate options (Examine, Use, Drop, etc.).


Item Properties
Examined Items

Player can view close-up 3D model (if applicable).
Inspection screen shows item from multiple angles.
Item description displayed during inspection.
Player can rotate item for better view (mouse drag or controller stick).


Key / Puzzle Items

Marked distinctly (icon or label) indicating they're needed for puzzles.
Functional properties shown (e.g., "Opens doors").
Cannot be dropped accidentally (confirmation required if player attempts to drop).


Documents / Evidence

Full text viewable in inventory (large, readable font).
Player can reopen previously read documents anytime.
Documents remain in inventory after reading.


Inventory Actions
Examine
Opens close-up view of item (if 3D model exists).

Use
Attempts to use item (may trigger interaction or puzzle solution).

Read
Opens document/letter for reading (if applicable).

Drop
Removes item from inventory.

Confirmation required for key items (prevent accidental loss).
Dropped items remain in current location (can be picked up again).


Inventory Constraints
Carrying Capacity

No hard item limit (ROOTS is exploration-focused, not survival-focused).
Optional soft limit if design requires (communicate clearly to player).


Item Permanence

Items never disappear unless narrative justifies it.
Player encouraged to keep items for evidence/investigation.
No "inventory is full" penalties.


Organization & Sorting

Items organized by category by default.
Within each category, items ordered by collection time (most recent at top, optional).
Player can manually organize if preferred (drag-to-reorder).


Inventory UI Consistency

Same visual style as other UI elements.
Colors from COLOR_PALETTE.md.
Typography matches menu system.
Interaction patterns consistent (buttons, scrolling, navigation).


Accessibility Features

Large, readable text (font size adjustable in settings).
Item descriptions clear and not abbreviating critical info.
Colorblind-friendly icons (not relying on color alone to distinguish items).
Controller navigation smooth and intuitive.
Keyboard support (arrow keys to navigate, Enter to select).


Performance Rules

Inventory loads instantly (no lag when opening).
Item previews render smoothly (no stuttering when browsing).
No unnecessary memory usage (items disposed when inventory closed).


Forbidden Inventory Practices
Do not include:

Excessive item limit that blocks progression.
Weight or encumbrance mechanics (overly gamified).
Confusing sorting or organization.
Items that disappear without explanation.
No way to examine or re-read collected items.


Final Rule
The Inventory should feel like the player's personal collection of memories and tools — organized, meaningful, and always accessible for reference and reflection.
