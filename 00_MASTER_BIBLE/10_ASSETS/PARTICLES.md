# PARTICLES

## Purpose

This document defines the standards for all particle effects used in ROOTS.

Particles should subtly enhance realism and atmosphere without distracting the player.

---

# Philosophy

Particles exist to support the world—not to create visual spectacle.

Every effect should have a believable physical source.

---

# Particle Categories

## Weather

Examples:

* Rain
* Snow (if applicable)
* Mist
* Fog

Weather effects should respond naturally to environmental conditions.

---

## Dust

Examples:

* Sunlight dust
* Old attic dust
* Dust from opening old boxes
* Dust in abandoned rooms

Dust should be subtle and realistic.

---

## Smoke

Examples:

* Chimneys
* Steam vents
* Hot drinks
* Vehicle exhaust

Smoke should move naturally with airflow.

---

## Water

Examples:

* Dripping water
* Small splashes
* Running faucets
* Rain impacts

Water effects should remain physically believable.

---

## Environmental

Examples:

* Falling leaves
* Floating pollen
* Insects
* Ash (story-dependent)

These effects help locations feel alive.

---

## Interaction Effects

Triggered by player actions.

Examples:

* Dust when opening an old drawer.
* Small debris when moving objects.
* Paper particles from damaged documents.

Effects should remain subtle.

---

# Performance Rules

* Spawn particles only when necessary.
* Limit active particle count.
* Disable distant particle systems.
* Reuse particle materials.
* Use GPU particles only when beneficial.

Performance is more important than visual density.

---

# Visual Rules

Particles should:

* Blend naturally with the environment.
* Match lighting conditions.
* Respect wind direction.
* Fade smoothly.

Avoid exaggerated effects.

---

# Forbidden Effects

Do not include:

* Magical particles.
* Fantasy effects.
* Fireworks.
* Explosive visual effects.
* Neon trails.
* Cartoon particles.

ROOTS is grounded in realism.

---

# Optimization

* Keep particle lifetimes short.
* Minimize overdraw.
* Use texture atlases where possible.
* Remove inactive emitters.

---

# Design Rules

* Every particle has a purpose.
* Every effect has a believable source.
* Favor subtlety over quantity.
* Never distract from gameplay.

---

# Final Rule

Particles in ROOTS should quietly reinforce the feeling of a living world. Players should notice the atmosphere they create—not the particle systems themselves.
