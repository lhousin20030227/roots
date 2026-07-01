# ROOTS — PERFORMANCE REVIEW

Version: 1.0

Status: Active

---

## Purpose

Review the performance of systems, assets, and builds to ensure ROOTS consistently meets its technical targets. Every performance issue must be measured, documented, and resolved before approval.

---

## Review Information

- Review ID:
- Reviewer:
- Date:
- Optimizer / AI Agent:
- Task ID:
- Build Version:
- Target Platform:
- Unity Version:

---

## Performance Targets

- Target FPS: 60 FPS
- Frame Time: Stable
- Loading Time: As short as possible
- Memory Usage: Efficient
- Build Size: Optimized

---

## Review Checklist

### CPU

- Stable CPU usage.
- No unnecessary Update() calls.
- No expensive loops.
- No excessive allocations.
- No CPU spikes.

PASS / FAIL

### GPU

- Stable GPU usage.
- Draw calls optimized.
- Overdraw minimized.
- Lighting optimized.
- Materials optimized.

PASS / FAIL

### Memory

- No memory leaks.
- Textures optimized.
- Audio optimized.
- Meshes optimized.
- Garbage Collection under control.

PASS / FAIL

### Loading

- Fast scene loading.
- Efficient asset loading.
- No unnecessary blocking.
- No duplicate loading.

PASS / FAIL

### Assets

- Polygon budgets respected.
- Texture budgets respected.
- Audio compressed correctly.
- Unused assets removed.
- Duplicate assets eliminated.

PASS / FAIL

### Unity

- Static batching configured.
- Occlusion Culling configured.
- LOD used where appropriate.
- Baked lighting verified.
- Project settings optimized.

PASS / FAIL

### Gameplay

- Stable FPS during exploration.
- Stable FPS during interaction.
- Save/Load performance verified.
- Inventory performance verified.
- UI responsiveness verified.

PASS / FAIL

### Build

- No missing references.
- No runtime errors.
- No unnecessary packages.
- Build size acceptable.
- Release configuration verified.

PASS / FAIL

---

## Benchmark Results

- Average FPS:
- Minimum FPS:
- Maximum FPS:
- Average Frame Time:
- Peak Memory Usage:
- Build Size:
- Loading Time:

---

## Issues Found

- Critical:
- High:
- Medium:
- Low:
- Describe each issue clearly.

---

## Optimization Recommendations

- List measurable improvements.
- Estimate expected performance gains when possible.

---

## Final Result

- APPROVED
- CHANGES REQUESTED
- REJECTED

---

## Review Score

- Overall Score: __/100

---

## Files Reviewed

- List all reviewed systems, scenes, and assets.

---

## Reviewer Notes

- Additional observations.

---

## Approval

- Reviewer:
- Date:
- Signature (if applicable):

---

## Master Rule

No build may progress to the next milestone unless it consistently achieves the project's performance targets while preserving gameplay, visual quality, and stability.
