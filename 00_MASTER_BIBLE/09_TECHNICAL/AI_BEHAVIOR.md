# AI BEHAVIOR

## Purpose

This document defines how all AI-controlled characters behave in ROOTS.

The objective is to create believable human behavior rather than challenging gameplay.

---

# Philosophy

NPC AI exists to make the world feel alive.

Characters should behave like ordinary people following their daily lives.

The player is not the center of their world.

---

# Behavior States

Every NPC operates using a simple state machine.

## Idle

The NPC remains in place while performing natural idle animations.

Examples:

* Reading
* Sitting
* Drinking coffee
* Looking around
* Cleaning

---

## Routine

NPCs follow a daily schedule.

Examples:

* Going to work
* Walking home
* Shopping
* Visiting family
* Resting

Schedules may change depending on the story.

---

## Interaction

When approached by the player, the NPC:

* Stops current activity.
* Faces the player.
* Begins conversation.
* Returns to normal behavior after the dialogue ends.

---

## Investigation Response

NPC dialogue changes according to:

* Story progression.
* Evidence discovered.
* Previous conversations.
* Relationship with the player.

NPCs never reveal information they should not know.

---

## Movement

NPC movement should be:

* Smooth
* Natural
* Purposeful

NPCs should avoid:

* Random wandering.
* Sudden direction changes.
* Robotic movement.

---

## Awareness

NPCs react only to believable events.

Examples:

* The player speaking to them.
* A door opening nearby.
* Someone calling their name.
* A loud noise.

They should ignore unrealistic triggers.

---

# Memory

NPCs remember important interactions.

Examples:

* Previous conversations.
* Promises made.
* Questions already answered.
* Evidence shown by the player.

Memory influences future dialogue.

---

# Emotional States

NPCs may display emotions such as:

* Calm
* Happy
* Sad
* Worried
* Tired
* Curious
* Nervous
* Grieving

Emotions must change naturally based on story events.

---

# Navigation

NPCs navigate using predefined walkable paths.

They must:

* Avoid obstacles.
* Open usable doors.
* Wait if a path is blocked.
* Resume their routine when possible.

---

# Performance Rules

To optimize performance:

* Distant NPCs use simplified AI.
* Off-screen NPCs simulate routines without full processing.
* Full AI activates only when necessary.

---

# Forbidden Behavior

NPCs must never:

* Teleport.
* Know hidden information.
* React unrealistically.
* Repeat the same dialogue endlessly.
* Ignore major story events.

---

# Final Rule

AI behavior should always support immersion.

Players should feel they are living among real people with independent lives, routines, and emotions—not scripted game characters.
