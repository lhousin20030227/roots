# ASSET PIPELINE

## Purpose

This document defines the complete asset creation pipeline for ROOTS, ensuring every asset follows the same workflow, quality standards, and optimization rules.

---

# Pipeline Philosophy

Every asset must follow the same production process.

No asset should be added directly to the game without validation.

Consistency is more important than speed.

---

# Asset Workflow

```text
Idea
    ↓
Planning
    ↓
Creation
    ↓
Review
    ↓
Optimization
    ↓
Import
    ↓
Testing
    ↓
Approval
    ↓
Production
```

---

# Step 1 — Planning

Before creating any asset, define:

* Purpose
* Location
* Gameplay Role
* Story Role
* Technical Requirements

Every asset must have a reason to exist.

---

# Step 2 — Creation

Assets may include:

* 3D Models
* Materials
* Textures
* Animations
* Audio
* UI
* Icons
* Fonts
* Particles

Artists should follow project standards.

---

# Step 3 — Review

Verify:

* Visual quality
* Scale
* Naming
* Topology
* UV Mapping
* Consistency

Reject assets that fail quality standards.

---

# Step 4 — Optimization

Optimize before importing.

Examples:

* Reduce polygons.
* Compress textures.
* Remove unused materials.
* Delete hidden geometry.
* Optimize animations.

Performance comes before unnecessary detail.

---

# Step 5 — Import

Imported assets must:

* Use the correct folder.
* Follow naming conventions.
* Keep original scale.
* Preserve pivots.
* Preserve orientation.

---

# Step 6 — Testing

Every asset is tested for:

* Visual quality
* Performance
* Collision
* Lighting
* Interaction
* Animation (if applicable)

Problems must be fixed before approval.

---

# Step 7 — Approval

Only approved assets become part of the main project.

Rejected assets return to the creation stage.

---

# File Formats

Preferred formats:

* Models → `.glb`
* Textures → `.png`, `.jpg`, `.webp`
* Audio → `.ogg`, `.wav`
* Fonts → `.ttf`, `.otf`
* UI → `.svg`, `.png`

Avoid unnecessary file conversions.

---

# Folder Organization

Every asset belongs to exactly one category.

No duplicate files.

No temporary assets inside production folders.

---

# Version Control

Assets should use version numbers when needed.

Example:

```text
family_photo_v01.glb
family_photo_v02.glb
family_photo_final.glb
```

Only the approved version is used in production.

---

# Design Rules

* Every asset has a purpose.
* Every asset is optimized.
* Every asset follows naming conventions.
* Every asset is reviewed before use.
* Unused assets should be removed.

---

# Final Rule

Every asset in ROOTS should be created with the same goal: deliver a believable, optimized, and consistent world that supports the player's investigation and emotional journey.
