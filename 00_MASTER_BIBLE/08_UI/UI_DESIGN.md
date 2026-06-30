UI DESIGN
Purpose
UI Design defines the visual and functional standards for all user interface elements in ROOTS, ensuring clarity, immersion, and accessibility while maintaining the game's quiet, grounded aesthetic.

UI Philosophy
The interface in ROOTS should feel like it barely exists.
UI exists to serve the story and gameplay, never to impress or distract — when the player notices the UI, it has failed.

Design Principles
Minimalism

Only essential information displayed.
No numerical stats, percentages, or game-mechanical HUD elements.
Clean, spacious layouts (not cramped or cluttered).


Clarity

All UI elements serve a clear purpose.
Typography readable at normal viewing distance (no tiny fonts).
Icons and labels unambiguous.
Hierarchy established through size, color, and spacing (not decoration).


Immersion

UI styled to fit the game world (not generic "game UI").
Diegetic UI preferred where possible (interfaces that exist in the world).
Minimal flat menus feel like game menus, not immersion-breaking overlays.


Consistency

Consistent visual language across all screens.
Consistent interaction patterns (navigation, confirmation, cancellation).
Consistent typography and color usage (from COLOR_PALETTE.md).


Visual Style
Typography

Clear, readable sans-serif font (e.g., Arial, Verdana, or custom equivalent).
Font size: at least 16–18 pt for body text (no tiny, hard-to-read UI).
Font weight variation used for hierarchy (bold for headers, regular for body).
No script, decorative, or hard-to-read fonts.


Color

All UI colors pulled from COLOR_PALETTE.md.
Text always legible (high contrast between text and background).
No bright neon or saturated colors in UI.
Muted, warm tones consistent with game atmosphere.


Layout & Spacing

Generous spacing between elements (not cramped).
Left-aligned or center-aligned text (predictable reading flow).
Consistent margins and padding throughout.
Grid-based layout for alignment and consistency.


Icons

Simple, clear iconography (recognizable at a glance).
Consistent stroke weight and style.
Icons support text labels (never icon-only UI).
Color scheme from COLOR_PALETTE.md.


Interactive Elements
Buttons

Subtle hover states (change color or brightness, not dramatic transformation).
Click feedback immediate (sound or visual confirmation).
Disabled state visually distinct but not harsh.


Text Input

Clear input fields with visible cursors.
Placeholder text helpful (shows what's expected).
Error messages clear and non-judgmental (not red alarms).


Sliders / Controls

Smooth, responsive controls.
Visual feedback for current value.
Keyboard support for input controls.


Accessibility First

All UI must support colorblind vision (no red/green-only indicators).
Text size adjustable in settings.
Subtitle support with size/background options.
Keyboard remapping for all input prompts.
Screen reader support where possible.


Responsive Design

UI scales to different screen resolutions.
Safe area margins for older or edge-case displays.
Touch-friendly input sizes (if controller support added).


Forbidden UI Elements
Do not include:

Health bars, mana bars, or stat displays.
Score counters, combo counters, or achievement popups.
Mini-maps or radar displays.
Excessive animations or "flashy" transitions.
Overly decorated or ornate UI.
Default game engine UI (replace with custom styled alternatives).


Final Rule
UI in ROOTS should support exploration and story comprehension without drawing attention to itself — the player should focus on the world and narrative, never on interface mechanics.