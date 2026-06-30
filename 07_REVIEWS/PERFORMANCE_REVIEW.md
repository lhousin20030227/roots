# ROOTS_DIRECTOR/07_REVIEWS/PERFORMANCE_REVIEW.md

# ROOTS — PERFORMANCE REVIEW

Version: 1.0

Status: Active

---

# PURPOSE

Review the performance of systems, assets and builds to ensure ROOTS consistently meets its technical targets.

Every performance issue must be measured, documented and resolved before approval.

---

# REVIEW INFORMATION

Review ID

Reviewer

Date

Optimizer / AI Agent

Task ID

Build Version

Target Platform

Unity Version

---

# PERFORMANCE TARGETS

Target FPS

60 FPS

Frame Time

Stable

Loading Time

As short as possible

Memory Usage

Efficient

Build Size

Optimized

---

# REVIEW CHECKLIST

## CPU

* Stable CPU usage.
* No unnecessary Update() calls.
* No expensive loops.
* No excessive allocations.
* No CPU spikes.

PASS / FAIL

---

## GPU

* Stable GPU usage.
* Draw calls optimized.
* Overdraw minimized.
* Lighting optimized.
* Materials optimized.

PASS / FAIL

---

## Memory

* No memory leaks.
* Textures optimized.
* Audio optimized.
* Meshes optimized.
* Garbage Collection under control.

PASS / FAIL

---

## Loading

* Fast scene loading.
* Efficient asset loading.
* No unnecessary blocking.
* No duplicate loading.

PASS / FAIL

---

## Assets

* Polygon budgets respected.
* Texture budgets respected.
* Audio compressed correctly.
* Unused assets removed.
* Duplicate assets eliminated.

PASS / FAIL

---

## Unity

* Static batching configured.
* Occlusion Culling configured.
* LOD used where appropriate.
* Baked lighting verified.
* Project settings optimized.

PASS / FAIL

---

## Gameplay

* Stable FPS during exploration.
* Stable FPS during interaction.
* Save/Load performance verified.
* Inventory performance verified.
* UI responsiveness verified.

PASS / FAIL

---

## Build

* No missing references.
* No runtime errors.
* No unnecessary packages.
* Build size acceptable.
* Release configuration verified.

PASS / FAIL

---

# BENCHMARK RESULTS

Average FPS

Minimum FPS

Maximum FPS

Average Frame Time

Peak Memory Usage

Build Size

Loading Time

---

# ISSUES FOUND

Critical

High

Medium

Low

Describe each issue clearly.

---

# OPTIMIZATION RECOMMENDATIONS

List measurable improvements.

Estimate expected performance gains when possible.

---

# FINAL RESULT

APPROVED

CHANGES REQUESTED

REJECTED

---

# REVIEW SCORE

Overall Score

__/100

---

# FILES REVIEWED

List all reviewed systems, scenes and assets.

---

# REVIEWER NOTES

Additional observations.

---

# APPROVAL

Reviewer

Date

Signature (if applicable)

---

# MASTER RULE

No build may progress to the next milestone unless it consistently achieves the project's performance targets while preserving gameplay, visual quality and stability.
