UI SYSTEM
Purpose
The UI System defines how information is displayed to the player across ROOTS, ensuring clarity, immersion, and minimal interference with the narrative experience.

UI Philosophy
The interface should feel like it barely exists.
ROOTS favors diegetic and minimal UI over heavy HUD elements, keeping the player focused on exploration and discovery rather than menus and numbers.

UI Categories
HUD (In-World)
Minimal elements shown during normal gameplay.
Examples:

Interaction prompt (e.g., "[E] Read Letter")
Objective marker (subtle, optional)
Subtitles (if enabled)

No health bars, no ammo counters, no score, no minimap clutter.

Menus
Non-diegetic screens accessed intentionally by the player.
Examples:

Main Menu
Pause Menu
Settings Menu
Save / Load Menu

Menus are clean, calm, and consistent in style across the game.

Inventory & Evidence Board UI
Dedicated full-screen interfaces.
Requirements:

Clear categorization (Items / Evidence / Documents).
Easy navigation (no deep nested menus).
Visual consistency with the game's art direction.


Dialogue UI
Appears only during conversations.
Includes:

NPC name
Spoken line
Response options (if any)
Skip / Replay controls

Disappears completely outside dialogue.

Notifications
Brief, non-intrusive messages.
Examples:

"New Evidence Added"
"Objective Updated"
"Document Read"

Notifications fade automatically and never block gameplay.

UI Visual Style

Clean typography, easy to read.
Muted color palette matching the game's tone.
No flashy animations or arcade-style effects.
Consistent iconography across all systems.


UI Behavior Rules

UI never blocks critical gameplay view unnecessarily.
All UI is dismissible without losing progress.
No UI element appears without a clear purpose.
Critical information is never hidden behind unnecessary steps.


Accessibility
Support:

Adjustable UI scale.
Subtitle size and background options.
Colorblind-friendly palettes.
Remappable input prompts shown dynamically (keyboard/controller).


Performance Rules

UI elements use efficient rendering (no unnecessary overdraw).
Menus load instantly.
No UI logic running when not visible.


Forbidden Features
Do not include:

Health bars, stamina bars, ammo counters.
Score systems or combo counters.
Intrusive tutorial popups during key story moments.
Overly decorative UI that distracts from content.


Final Rule
The UI in ROOTS should support the story and never compete with it.
If the player notices the interface more than the world around them, the UI has failed its purpose.