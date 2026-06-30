# OPTIMIZATION

## Purpose

This document defines the optimization standards for ROOTS to ensure stable performance while maintaining visual quality.

Optimization is considered during development—not after the game is finished.

---

# Philosophy

Performance is a feature.

Every asset, system, and scene should be designed with efficiency in mind from the beginning.

---

# Performance Targets

Target Frame Rate:

* Minimum: 60 FPS
* Recommended: 120 FPS (High-End PCs)

Loading times should be as short as possible.

---

# 3D Models

Rules:

* Use appropriate polygon counts.
* Remove hidden geometry.
* Reuse modular assets.
* Create LODs for large objects.

Avoid unnecessarily complex meshes.

---

# Textures

* Use the lowest acceptable resolution.
* Compress textures appropriately.
* Reuse shared textures.
* Remove duplicate files.

Avoid oversized texture memory usage.

---

# Materials

* Reuse materials whenever possible.
* Reduce shader variations.
* Minimize material count per scene.

---

# Lighting

* Bake static lighting whenever possible.
* Use dynamic lighting only where required.
* Limit real-time shadows.
* Reduce unnecessary light sources.

---

# Audio

* Compress audio files.
* Stream long music tracks.
* Stop inactive audio sources.
* Reuse common sound effects.

---

# Animations

* Compress animation data.
* Pause off-screen animations.
* Reuse animation clips.
* Limit unnecessary bone counts.

---

# AI

* Simulate distant NPCs with simplified logic.
* Fully process only nearby NPCs.
* Disable inactive behaviors when possible.

---

# Scene Management

* Load only required scenes.
* Unload unused resources.
* Stream large environments when appropriate.
* Prevent unnecessary memory usage.

---

# Draw Calls

Reduce draw calls by:

* Reusing materials.
* Using mesh instancing.
* Combining static geometry where appropriate.

---

# Memory Management

* Release unused resources.
* Avoid duplicate assets.
* Monitor memory usage regularly.
* Optimize resource loading.

---

# Profiling

Regularly test performance using engine profiling tools.

Check:

* CPU usage
* GPU usage
* Memory usage
* Draw calls
* Loading times

Optimization decisions should be based on measured data.

---

# Design Rules

* Optimize continuously.
* Measure before changing.
* Never sacrifice gameplay for minor visual improvements.
* Prioritize stable performance over unnecessary effects.

---

# Final Rule

ROOTS should feel smooth on its target hardware.

Players should experience the story without performance issues interrupting immersion.
