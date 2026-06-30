# 3D MODELS

## Purpose

This document defines the standards for all 3D models used in ROOTS.

Every model should support realism, performance, and consistency.

---

# Philosophy

3D models should represent real-world objects.

The player should immediately recognize what an object is and how it fits into the environment.

---

# Model Categories

## Architecture

Examples:

* Houses
* Apartments
* Hospitals
* Schools
* Shops
* Offices

---

## Furniture

Examples:

* Chairs
* Tables
* Beds
* Cabinets
* Shelves
* Sofas

---

## Props

Examples:

* Books
* Keys
* Cups
* Clocks
* Lamps
* Computers

---

## Story Objects

Examples:

* Family photographs
* Adoption papers
* Wedding ring
* Diary
* Military medal
* Cassette tape

These assets require the highest level of detail because players inspect them closely.

---

## Environment

Examples:

* Trees
* Roads
* Sidewalks
* Fences
* Street signs
* Benches

---

# Scale

All models must use real-world measurements.

Examples:

* 1 Unit = 1 Meter
* Doors ≈ 2 meters high
* Tables ≈ 75 cm high
* Chairs ≈ 45 cm seat height

Maintain consistent proportions throughout the project.

---

# Pivot Rules

Every model must have a logical pivot.

Examples:

* Door → Hinges
* Drawer → Sliding edge
* Chair → Center
* Lamp → Base

Proper pivots simplify interaction and animation.

---

# Topology

Models should:

* Use clean geometry.
* Avoid unnecessary polygons.
* Avoid non-manifold geometry.
* Avoid duplicated vertices.

Topology should be optimized for real-time rendering.

---

# UV Mapping

Every model must have:

* Clean UV layout
* Minimal stretching
* Efficient texture usage
* No overlapping UVs unless intentional

---

# Collision

Interactive models require collision.

Rules:

* Simple collision whenever possible.
* Accurate collision for gameplay objects.
* No unnecessary complex collision meshes.

---

# Level of Detail (LOD)

Large models should include multiple LODs.

Example:

* LOD0 → Highest quality
* LOD1 → Medium quality
* LOD2 → Low quality

LOD transitions should be visually smooth.

---

# File Format

Preferred format:

* `.glb`

This format preserves:

* Meshes
* Materials
* Animations
* Hierarchy

---

# Design Rules

* Realistic proportions.
* Consistent style.
* Optimized geometry.
* Proper naming.
* Correct pivots.
* Correct scale.

---

# Final Rule

Every 3D model in ROOTS should feel like a real object that naturally belongs in the world, supporting immersion without sacrificing performance.
