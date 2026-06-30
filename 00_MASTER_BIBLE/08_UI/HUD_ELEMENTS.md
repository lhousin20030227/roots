HUD ELEMENTS
Purpose
HUD Elements define the minimal, contextual information displayed during gameplay in ROOTS, ensuring the player has necessary feedback without clutter or immersion-breaking UI.

HUD Philosophy
The HUD in ROOTS should be nearly invisible — present only when needed, minimal in scope, and always serving clarity over flash.
No stat bars, no numbers, no "game-like" elements — only natural, contextual information.

HUD Element Categories
Interaction Prompt
When displayed: Player looks at or approaches an interactive object.
Content:
[E] Read Letter

Interaction key in brackets (e.g., [E], [X], [△]).
Object name or action verb.
Appears near object or in screen corner.
Disappears immediately when object no longer targeted.

Design Rules:

Simple, readable font.
Subtle color from COLOR_PALETTE.md (not bright).
No background box (unless readability requires it).
Position: near object or bottom-center of screen (configurable).


Objective / Quest Marker
When displayed: Active objective or goal exists.
Content:
Current Objective: Find evidence about mother's past

Displayed in corner (usually top-left or top-right).
Current objective only (no quest log on HUD).
Updates when objective completes or changes.
Can be toggled off in settings (player preference).

Design Rules:

Subtle background box for readability (semi-transparent).
Muted color, not bright.
Small, non-intrusive font size.
Fades out after 5 seconds if not updated (reappears on change).


Subtitles
When displayed: NPC dialogue or important story audio occurs.
Content:
Father: "I need to tell you something important."

Speaker name or label.
Dialogue text (full speech, not abbreviated).
Displayed at bottom of screen.
Timing synced to voice acting.

Design Rules:

Large, readable font (16–20 pt minimum).
High contrast (light text on dark background, or vice versa).
Semi-transparent background for readability without opacity.
Position: bottom-center or configurable.
Optional background toggle (user preference).
Optional text size adjustment (accessibility).


Notification / Toast Messages
When displayed: Evidence collected, objective updated, save complete, etc.
Content:
New Evidence Added: Father's Letter

Brief, one-line message.
Auto-dismisses after 3–5 seconds.
Appears in corner (top-right typical).
No sound required (optional subtle chime).

Design Rules:

Small font (12–14 pt).
Subtle color and background.
Fade-in / fade-out animation (smooth, not jarring).
Never blocks critical gameplay view.


Subtitle Speaker Label
When displayed: Dialogue spoken.
Content:
Father (off-screen)
or
Voice Recording — Mother

Identifies who is speaking (especially important for off-screen dialogue).
Displayed above or near subtitle text.
Font smaller than dialogue text.


Environmental Context
When displayed: Player enters new location or significant moment.
Content:
Family Home — Living Room
or
[Later that day...]

Location name or time passage indicator.
Displayed briefly at scene transition.
Fades in and out over 2–3 seconds.
Optional (can be toggled off).


Subtitles & Accessibility
Subtitles are critical accessibility element:

Always available option in settings.
Font size adjustable (Small / Medium / Large).
Background opacity toggleable.
Color contrast high for readability.
Support for speaker identification (important for multi-character scenes).


HUD Positioning & Safe Areas
All HUD elements respect safe areas:

No critical UI near screen edges (accounts for older TVs, various displays).
Configurable positions (player can adjust if preferred).
Consistent positioning rules (e.g., objectives always top-left, notifications always top-right).


Animation & Transition

HUD elements fade in/out smoothly (no instant pops).
Transitions between HUD states smooth (e.g., objective update fades old, fades in new).
No distracting animations (keep it subtle).


Forbidden HUD Elements
Do not include:

Health bars or damage indicators.
Stamina or energy bars.
Minimap or radar.
Compass or directional markers.
Floating damage numbers or combat feedback.
Achievement popups or milestone notifications.
Unnecessary numbers or percentages.


Performance Rules

HUD rendered efficiently (minimal impact on frame rate).
HUD text rendered at native resolution (crisp, no scaling artifacts).
Text rendering doesn't cause frame hitches.


Final Rule
HUD elements should feel like natural extensions of the world — contextual information presented at the moment it's needed, then disappearing to let the player focus on exploration, story, and discovery.