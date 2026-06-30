ANIMATION
Purpose
Animation defines how characters, objects, and environments move in ROOTS, ensuring all motion feels natural, purposeful, and supports immersion and storytelling.

Animation Philosophy
Animation should feel like realistic human movement and object interaction — never exaggerated, never "gamey."
Every animation must serve a narrative or functional purpose; idle animation exists only to keep characters feeling alive.

Character Animation Standards
Locomotion

Walking: natural pace, slight upper body sway, weight transfer visible.
Idle: subtle breathing, occasional weight shifts, realistic standing posture.
No running — the game is exploration-based, not action-based.

All locomotion animations must match character personality and physical condition (age, build, emotional state).

Interaction Animations
Characters perform subtle animations when interacting:

Reaching toward objects.
Opening doors or drawers.
Holding objects naturally.
Listening intently during dialogue.
Emotional reactions (shock, sadness) expressed through body language.

Interaction animations should be quick and natural — never theatrical or lengthy.

Dialogue Animations

Characters maintain natural body language during conversation.
Lip sync matches voice acting precisely.
Occasional hand gestures reinforce emotional content, but kept minimal.
No exaggerated head bobbing or constant hand movements.


Emotional Animations
Characters may express emotion through:

Posture shifts.
Facial micro-expressions.
Hand placement.
Breathing patterns.

All emotional expression must align with character personality defined in 04_CHARACTERS/.

Object Animation Standards
Interactive Objects

Doors: smooth swing motion, weight feels realistic, speed matches door type.
Drawers: smooth pull/push, friction implied through deceleration.
Switches/buttons: subtle click or press, immediate response.
Containers: opening/closing feels weighted and purposeful.

All object animations should complete in 0.5–1.5 seconds (quick, not lingering).

Environmental Animations

Light switches: instant or very quick transition.
Curtains/blinds: smooth, controlled movement.
Time-of-day transitions: gradual lighting shifts (no jarring changes).

Environmental animations should support mood, never distract.

Animation Quality Standards

Smooth frame interpolation — no jerky or stepped movement.
Proper weight and momentum in all motion.
Anticipation present in character actions (slight body prep before movement).
Natural ease-in / ease-out on all transitions (no linear movement start/stop).


Lip Sync Standards

Phoneme-based lip sync (matching mouth shapes to spoken sounds).
Sync must be frame-accurate to voice audio.
Mouth shapes keep subtle, realistic proportions (no exaggerated anime-style mouths).


Animation Performance Rules

Use skeletal animation for characters (not per-frame keyframe animation).
Object animations use efficient transform tweens where possible.
Animation blend spaces smooth transitions between states (walking to idle, etc.).


Animation Consistency Rules

Same character in different scenes uses consistent movement vocabulary.
Similar objects (doors, drawers) animate consistently across all locations.
Timing and speed match emotional context and narrative progression.


Forbidden Animations
Do not include:

Slow, drawn-out interaction animations.
Exaggerated or cartoonish character movements.
T-pose or broken rigging visible.
Animations without clear purpose (decorative fidgeting, etc.).
Out-of-sync lip movement.
Movement that contradicts character personality.


Final Rule
Every animation in ROOTS must support the illusion that the player is inhabiting a real, quiet place with real people — movement should feel observed from life, never designed for flashiness.