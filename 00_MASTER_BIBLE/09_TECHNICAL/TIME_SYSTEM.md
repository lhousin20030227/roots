TIME SYSTEM
Purpose
The Time System defines how time progresses inside ROOTS, and how it affects lighting, story pacing, and world behavior.
Time should support immersion and storytelling without becoming a survival or management mechanic.

Time Philosophy
ROOTS is not a real-time simulation game.
Time exists to serve atmosphere and narrative, not gameplay pressure.
The player should never feel rushed or punished by the passage of time.

Time Structure
Story-Driven Time
Time advances primarily through story progression, not a real-time clock.
Examples:

Moving to a new chapter changes time of day.
Completing key objectives may shift the time period.
Some scenes are locked to a specific time (morning, evening, night).


Scene-Based Time
Each location has a defined time state when the player enters it.
This avoids unnecessary real-time tracking and keeps lighting/mood consistent with the story beat.

Optional Ambient Cycle
Inside certain open or semi-open areas, a slow ambient day/night cycle may run for atmosphere only.
It does not affect:

Puzzles
NPC schedules
Story triggers

It only affects lighting and mood.

Time and Story
Specific story moments require specific time settings.
Examples:

A flashback during a quiet afternoon.
A discovery during early morning.
A confrontation at night.

Time settings are always controlled by the Story System, never randomized.

Time and NPCs
NPCs do not follow complex real-time schedules.
NPC presence and behavior are tied to:

Story progression
Current chapter
Specific scripted scenes

This keeps NPC behavior predictable and easy to write around.

Time and Lighting
The Time System feeds directly into the Lighting System.
Examples:

Morning → soft natural light.
Afternoon → bright natural light.
Evening → warm indoor light.
Night → minimal natural light, artificial light becomes primary.


Time Skips
Time may skip forward between scenes or chapters.
Rules:

Skips must be narratively justified (e.g., "Later that day...").
No mechanical time-skip menu or sleep mechanic.
Skips are handled automatically by the Story System.


Performance Rules

No constant real-time clock calculations unless ambient cycle is active.
Lighting transitions are precomputed or lightweight.
Time state is stored as a simple variable, not a complex simulation.


Forbidden Features
Do not include:

Real-time survival mechanics (hunger, sleep, fatigue).
Day/night cycles that affect puzzle availability arbitrarily.
NPC schedules requiring complex AI routines.
Time pressure or countdown mechanics.


Final Rule
Time in ROOTS exists to support mood, lighting, and narrative pacing.
It should always feel like a natural backdrop to the story — never a system the player has to manage.