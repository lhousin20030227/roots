# CAMERA

## Purpose

The Camera System defines how the player sees and experiences the world of ROOTS.

The camera exists to maximize immersion, observation, and emotional storytelling.

---

# Camera Type

* First-Person Camera
* Real-time rendering
* Player-controlled view

The player experiences the story entirely through their own eyes.

---

# Camera Philosophy

The camera should feel natural and comfortable.

It should never distract the player from exploration or investigation.

Movement must be smooth and responsive.

---

# Field of View (FOV)

Default FOV:

* 90° (PC)
* Adjustable in Settings

Players may customize the FOV within a safe range.

Recommended Range:

* Minimum: 75°
* Maximum: 110°

---

# Camera Movement

The camera responds directly to mouse or controller input.

Requirements:

* Smooth rotation
* High precision
* Low input latency
* Consistent sensitivity

No artificial camera acceleration.

---

# Camera Bob

A subtle head movement is applied while walking.

States:

* Standing → None
* Walking → Light Bob
* Running → Slightly Increased Bob
* Inspecting Objects → Disabled

The intensity must be adjustable or disabled in Accessibility Settings.

---

# Interaction Camera

When inspecting important objects:

* Camera gently focuses on the object.
* Background remains visible.
* The player can rotate inspectable items.
* Exiting inspection instantly returns control.

No cinematic transitions are required.

---

# Dialogue Camera

Dialogue remains in first-person.

The player keeps control of camera movement within a limited angle.

NPCs maintain eye contact naturally.

Avoid switching to third-person or cinematic cameras.

---

# Cutscenes

Cutscenes are rare.

When necessary:

* Use in-engine sequences.
* Keep first-person whenever possible.
* Return control immediately after completion.

---

# Camera Collision

The camera must never pass through:

* Walls
* Doors
* Furniture
* Large objects

Collision handling should be smooth and invisible.

---

# Accessibility

Players can configure:

* Mouse Sensitivity
* Controller Sensitivity
* FOV
* Camera Bob
* Motion Blur
* Camera Shake

Accessibility settings should never affect gameplay balance.

---

# Forbidden Features

Do not include:

* Third-Person Camera
* Fixed Camera Angles
* Cinematic Camera Spam
* Forced Camera Rotations
* Excessive Camera Shake
* Motion Sickness Effects

---

# Performance Rules

The camera system should:

* Maintain stable frame timing.
* Avoid sudden jumps.
* Prevent clipping.
* Support high refresh rate displays.

---

# Final Rule

The camera is the player's eyes.

Every movement should reinforce the feeling of physically being inside the world of ROOTS, quietly observing, exploring, and uncovering the truth.
