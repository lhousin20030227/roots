# PREFABS

## Purpose

This document defines the standards for reusable Prefabs (Packed Scenes) in ROOTS.

Prefabs allow consistent, reusable, and maintainable game objects throughout the project.

---

# Philosophy

A Prefab represents a complete reusable object.

Create once, use everywhere.

Changes made to a Prefab should automatically propagate to all its instances unless intentionally overridden.

---

# Prefab Categories

## Environment

Examples:

* House
* Room
* Fence
* Street Light
* Bus Stop
* Mailbox

---

## Furniture

Examples:

* Chair
* Table
* Bed
* Sofa
* Cabinet
* Bookshelf

---

## Interactive Objects

Examples:

* Door
* Drawer
* Light Switch
* Computer
* Radio
* Telephone

Each interactive Prefab should already include its required logic.

---

## Story Objects

Examples:

* Family Photograph
* Adoption Papers
* Diary
* Wedding Ring
* Military Medal

Story Prefabs must support inspection and evidence collection.

---

## NPC Prefabs

Every NPC Prefab should include:

* Character Model
* Animations
* Collision
* Navigation
* Dialogue Component
* Interaction Component

---

# Required Components

Each Prefab should contain only the components it actually needs.

Possible components include:

* Mesh
* Collision
* Audio
* Animation
* Interaction
* Navigation
* Script

Avoid unnecessary components.

---

# Reusability

Design Prefabs to be modular.

Examples:

* One chair Prefab used across many locations.
* One street lamp with different material variants.
* One door system reused throughout the project.

---

# Variants

Create variants instead of duplicating Prefabs.

Example:

```text
door_wood
door_wood_white
door_wood_old
door_wood_locked
```

Variants inherit from the original Prefab whenever possible.

---

# Optimization

* Remove unused components.
* Minimize node count.
* Share materials.
* Reuse animations.
* Keep scripts modular.

---

# Naming Convention

Examples:

```text
pf_house_small
pf_wooden_door
pf_family_photo
pf_hospital_bed
pf_office_desk
```

Prefix all Prefabs with:

`pf_`

---

# Design Rules

* Every Prefab must have a clear purpose.
* Every Prefab must be reusable.
* Every Prefab must be optimized.
* Every Prefab must follow project naming conventions.

---

# Final Rule

Prefabs are the building blocks of ROOTS.

Every Prefab should be modular, reusable, and easy to maintain, allowing the world to grow without creating unnecessary complexity.
