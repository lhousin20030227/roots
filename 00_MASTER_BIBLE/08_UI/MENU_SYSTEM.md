MENU SYSTEM
Purpose
The Menu System defines the structure, navigation, and functionality of all non-gameplay screens in ROOTS, ensuring intuitive navigation and consistent experience across Main Menu, Pause Menu, Settings, Save/Load, and other support screens.

Menu Philosophy
Menus should feel calm, organized, and never overwhelming.
Navigation should be obvious and quick — players should never feel lost or confused in a menu.

Main Menu Structure
Screen Layout
┌─────────────────────────────────┐
│                                 │
│      ROOTS                      │
│                                 │
│  • New Game                     │
│  • Continue                     │
│  • Load Game                    │
│  • Settings                     │
│  • Credits                      │
│  • Exit                         │
│                                 │
└─────────────────────────────────┘

Game title prominent but not overwhelming.
Options listed vertically, easy to scan.
One option highlighted/selected at a time.
Clear visual feedback for selection.


Main Menu Options
New Game

Starts a fresh playthrough.
No difficulty selection (ROOTS has one difficulty mode).
Confirm before starting (prevent accidental new game over existing save).


Continue

Resumes most recent save automatically.
Disabled if no save exists.


Load Game

Full save slot browser (see Save/Load Screen below).


Settings

Opens Settings Menu (see Settings Menu below).


Credits

Scrolling list of all contributors.
Music plays during credits (calming, not jarring).
Can be skipped (ESC or button press).


Exit

Closes game gracefully.
Confirm dialog to prevent accidental exit.


Pause Menu Structure
Screen Layout
┌─────────────────────────────────┐
│  PAUSED                         │
│                                 │
│  • Resume                       │
│  • Save Game                    │
│  • Load Game                    │
│  • Settings                     │
│  • Main Menu                    │
│                                 │
└─────────────────────────────────┘

Pause menu overlays gameplay (slightly dimmed background).
Clear "PAUSED" label at top.
Quick-resume option prominent (Resume button or ESC key).


Pause Menu Options
Resume

Closes pause menu, resumes gameplay immediately.
ESC key also resumes (quick exit).


Save Game

Quick-save to autosave slot.
Confirmation when save complete.
Minimal friction (no "are you sure" dialogs unless overwriting manual save).


Load Game

Opens Save/Load browser.
Allows loading different save without returning to Main Menu.


Settings

Opens Settings Menu (same as Main Menu Settings).


Main Menu

Confirmation dialog (prevent accidental return to Main Menu mid-story).
Unsaved progress warning (if applicable).


Settings Menu Structure
Screen Layout
┌─────────────────────────────────┐
│  SETTINGS                       │
│                                 │
│  Audio                          │
│  • Master Volume: ■■■□□ 70%    │
│  • Music Volume: ■■■■□ 80%     │
│  • SFX Volume: ■■■■□ 80%       │
│  • Dialogue Volume: ■■■■■ 100% │
│                                 │
│  Video                          │
│  • Resolution: 1920x1080        │
│  • Fullscreen: ON / OFF         │
│  • Graphics: Low / Medium / High│
│                                 │
│  Accessibility                  │
│  • Subtitle Size: Small / Med / Large
│  • Subtitle Background: ON / OFF│
│  • UI Scale: 80% / 100% / 120%  │
│  • Colorblind Mode: OFF / Type 1 / Type 2
│                                 │
│  Input                          │
│  • Remap Controls               │
│  • Controller Sensitivity: ■■■□□
│                                 │
│  • Back                         │
│                                 │
└─────────────────────────────────┘

Settings Categories
Audio

Master Volume (affects all audio).
Music Volume (music specifically).
SFX Volume (sound effects and ambient).
Dialogue Volume (dialogue and voice acting).

All sliders show current percentage.

Video

Resolution (supported resolutions listed).
Fullscreen toggle (windowed vs. fullscreen).
Graphics quality (Low / Medium / High — affects draw distance, shadows, effects).


Accessibility

Subtitle Size (Small / Medium / Large).
Subtitle Background (toggle on/off for better readability).
UI Scale (80% / 100% / 120% — scales menu and in-world UI).
Colorblind Mode (toggle for colorblind-friendly UI adjustments).
Font Options (if multiple fonts supported).


Input

Remap Controls (allows custom key binding).
Controller Sensitivity (adjusts camera/look sensitivity).
Interaction Key (customizable, default [E] on keyboard).
Hold vs Toggle (interaction behavior preference).


Settings Persistence

All settings saved automatically (no "Apply" button required).
Settings persist across sessions.
No settings that are "baked in" and impossible to change.


Save/Load Screen
Layout
┌─────────────────────────────────┐
│  LOAD GAME                      │
│                                 │
│ > Save Slot 1 — Chapter 2       │
│   Time: 2h 15m | 6/28/2026     │
│   [Thumbnail preview]           │
│                                 │
│   Save Slot 2 — Chapter 1       │
│   Time: 1h 30m | 6/27/2026     │
│   [Thumbnail preview]           │
│                                 │
│   Save Slot 3 — [Empty]         │
│                                 │
│  < Slot 1 | Slot 2 | Slot 3 >  │
│                                 │
│  • Load  • Delete  • Back       │
│                                 │
└─────────────────────────────────┘

Save Slot Information
Each save slot displays:

Slot number (1–5 or more).
Current chapter / progress indicator.
Playtime (hours and minutes).
Date/time stamp.
Optional thumbnail (screenshot of current location).


Save Slot Actions

Load: Load selected save.
Delete: Delete selected save (confirmation required).
Back: Return to previous menu.


Confirmation Dialogs
Used for destructive or significant actions:
┌─────────────────────────────────┐
│  Delete this save?              │
│                                 │
│  This cannot be undone.         │
│                                 │
│  • Yes    • No                  │
│                                 │
└─────────────────────────────────┘

Simple yes/no choice.
"No" highlighted by default (safer).
Clear consequence stated.


Navigation Consistency

Consistent back button behavior (returns to previous menu).
Consistent confirm/cancel keys (Enter/ESC, or controller equivalents).
Consistent selection highlighting (visual feedback always clear).
No menu navigation dead-ends (always a way back).


Performance Rules

Menus load instantly (no loading screens between menus).
Settings applied immediately (no wait for "apply").
Save/Load smooth transitions (no jarring screen flips).


Forbidden Menu Practices
Do not include:

Complex nested menus (max 2 levels deep).
Slow animations or transitions.
Confusing navigation paths.
No back/exit option from any menu.
Mandatory tutorial screens on every game start.


Final Rule
Menus should feel like natural extensions of the game world — calm, organized, and designed for the player's convenience, never for visual spectacle.