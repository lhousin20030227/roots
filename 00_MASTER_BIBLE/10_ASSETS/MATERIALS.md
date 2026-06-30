# MATERIALS

## Purpose

This document defines the standards for all materials used in ROOTS.

Materials should create a believable world while remaining optimized for real-time rendering.

---

# Philosophy

Materials should represent real-world surfaces.

Every material must match the object's age, environment, and condition.

Avoid exaggerated or unrealistic appearances.

---

# Material Categories

## Wood

Examples:

* Oak
* Pine
* Plywood
* Painted wood
* Old wood

Wood should display realistic grain, wear, and aging.

---

## Metal

Examples:

* Steel
* Iron
* Aluminum
* Brass
* Copper

Metal may include scratches, fingerprints, rust, or oxidation where appropriate.

---

## Concrete

Examples:

* Floors
* Walls
* Sidewalks
* Foundations

Concrete should show natural imperfections such as cracks, stains, and weathering.

---

## Glass

Examples:

* Windows
* Mirrors
* Picture frames
* Bottles

Glass should have realistic transparency and subtle reflections.

---

## Fabric

Examples:

* Curtains
* Sofas
* Clothing
* Carpets

Fabric should include believable folds, texture, and wear.

---

## Plastic

Examples:

* Switches
* Bottles
* Toys
* Containers

Plastic should vary from matte to glossy depending on the object.

---

## Paper

Examples:

* Letters
* Books
* Medical records
* Adoption documents
* Photographs

Paper materials should reflect age, folds, stains, and handling.

---

# PBR Workflow

All materials should follow a Physically Based Rendering (PBR) workflow.

Supported maps include:

* Base Color
* Normal
* Roughness
* Metallic
* Ambient Occlusion (when needed)

---

# Reusability

Materials should be reusable across multiple assets.

Examples:

* White painted wall
* Oak wood
* Office carpet
* Brushed steel

Avoid unnecessary duplicates.

---

# Material Instances

Use material instances whenever possible.

Only create unique materials when visual differences are significant.

---

# Realism Rules

Materials should include realistic imperfections such as:

* Dust
* Dirt
* Scratches
* Wear
* Fading
* Fingerprints

Perfect surfaces should be rare.

---

# Performance Rules

* Reuse materials whenever possible.
* Limit the number of unique materials per scene.
* Avoid unnecessary shader complexity.
* Compress texture maps appropriately.

---

# Design Rules

* Realistic appearance.
* Consistent style.
* Correct scale.
* Appropriate aging.
* Optimized performance.

---

# Final Rule

Every material in ROOTS should make objects feel believable. Players should unconsciously recognize surfaces as real, helping the world feel lived in and authentic.
