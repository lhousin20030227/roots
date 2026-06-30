# SHADERS

## Purpose

This document defines the shader standards used in ROOTS.

Shaders should enhance realism and performance without drawing unnecessary attention to themselves.

---

# Philosophy

Shaders exist to support the visual experience.

Players should notice the world—not the shader effects.

Realism always takes priority over visual spectacle.

---

# Shader Types

## Standard PBR Shader

The default shader for almost every object.

Used for:

* Buildings
* Furniture
* Props
* Roads
* Vegetation
* Story objects

This should be the primary shader throughout the project.

---

## Transparent Shader

Used for transparent materials.

Examples:

* Glass
* Windows
* Bottles
* Picture frames

Transparency should remain realistic and optimized.

---

## Emissive Shader

Used only for objects that emit light.

Examples:

* Computer monitors
* Television screens
* LED indicators
* Exit signs

Emission should be subtle and believable.

---

## UI Shader

Used exclusively for interface elements.

Requirements:

* Sharp rendering
* Proper scaling
* High readability

---

## Water Shader

If water is used, it should be simple and realistic.

Avoid exaggerated reflections or fantasy effects.

---

# Visual Rules

Shaders should never create:

* Cartoon outlines
* Anime effects
* Cell shading
* Holographic effects
* Sci-fi visuals

ROOTS uses a grounded visual style.

---

# Performance Rules

Shaders should:

* Compile quickly.
* Be GPU-efficient.
* Minimize overdraw.
* Avoid unnecessary calculations.
* Reuse shader variants whenever possible.

---

# Lighting Compatibility

Shaders must work correctly with:

* Daylight
* Indoor lighting
* Night scenes
* Dynamic lights
* Baked lighting

Lighting transitions should remain natural.

---

# Transparency Rules

Transparent materials should:

* Render correctly.
* Avoid sorting artifacts where possible.
* Use transparency only when necessary.

Opaque materials are preferred whenever possible.

---

# Special Effects

Visual effects should remain subtle.

Examples:

* Wet surfaces after rain.
* Dust accumulation.
* Slight screen glow.
* Soft reflections.

Avoid dramatic visual effects that distract from gameplay.

---

# Design Rules

* Realistic appearance.
* Consistent rendering.
* Physically based workflow.
* High performance.
* Minimal complexity.

---

# Final Rule

Shaders in ROOTS should quietly enhance realism while remaining efficient. Their purpose is to support the atmosphere, never to become the focus of the player's attention.
