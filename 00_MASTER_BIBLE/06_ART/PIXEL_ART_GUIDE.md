PIXEL ART GUIDE
Purpose
This document defines the exact technical and stylistic standards for creating Pixel Art textures used across ROOTS, ensuring every asset shares the same consistent look.

Pixel Art Philosophy
Pixel Art in ROOTS is not retro/arcade-styled — it is used as a texture technique applied to realistic low poly geometry.
The goal is a handcrafted, grounded look, never a nostalgic 8-bit or 16-bit game aesthetic.

Base Pixel Grid Standards

Texture resolutions stay in power-of-two sizes: 16x16, 32x32, 64x64, 128x128.
Category-based resolution:

Hero/story props → 64x64 or 128x128.
Environment surfaces (walls, floors) → 32x32 or 64x64 (tiled).
Set dressing/background props → 16x16 or 32x32.


Resolution choice depends on object importance and viewing distance, never randomly mixed.


Pixel Density Consistency

Texel density (pixels per real-world unit) must remain consistent within the same asset category.
No object should appear "blurrier" or "sharper" than nearby objects of the same category.
Pixel density checked against character scale as the reference unit.


Filtering & Rendering Rules

Point (Nearest Neighbor) filtering only — no bilinear or trilinear filtering.
No mipmapping artifacts that blur pixel edges at distance; use sharp mip transitions or disable where needed.
No anti-aliasing applied to texture edges.
Pixel grid must align cleanly with UV mapping — no stretched or rotated pixels.


Color Rules

All pixel art textures pull from COLOR_PALETTE.md.
Limited color count per texture (favor restraint over gradient-heavy shading).
Shading done through deliberate pixel placement, not smooth gradients.
Avoid dithering unless used intentionally for subtle material transitions (e.g., worn fabric).


Shading Technique

Use flat color blocks with minimal manual shading (2–4 shade steps per material).
Light and shadow direction should loosely match the scene's primary light source.
Avoid heavy outlining — edges defined by geometry, not black pixel borders.


UV Mapping Rules

UV islands aligned to pixel grid to avoid texture warping.
No overlapping UVs unless intentional for tiling efficiency.
Texel density matched across all UV islands on the same object.


Texture Categories & Examples
Characters

Skin, clothing, hair — moderate detail, consistent with CHARACTER_ART.md.

Environment

Walls, floors, ceilings — tileable, seamless, medium detail.

Props

Story props get higher relative detail; set dressing stays simple.

UI (if pixel-styled elements are used)

Must follow same grid and filtering rules as in-world assets.


Tiling Rules

Tileable textures must have seamless edges (no visible seams at tile boundaries).
Pattern repetition should avoid obvious, repetitive visual blocks at normal viewing distance.


Workflow Standards

Textures created or edited at native pixel resolution (no upscale-then-downscale artifacts).
Export format preserves crisp pixel edges (no compression artifacts blurring pixels).
File naming follows NAMING_STANDARD.md.


Performance Rules

Smaller textures reused via tiling and atlasing wherever possible.
Texture compression settings must not introduce blur or color banding.


Forbidden Practices
Do not include:

Smooth gradients or photo-realistic shading inside pixel textures.
Bilinear/trilinear filtering on any in-game texture.
Mixed pixel densities within the same object or scene.
Upscaled/blurry pixel art (fake pixel look from downsampled photos).
Outline-heavy "cartoon pixel" style.


Final Rule
Every pixel art texture in ROOTS must look deliberate, consistent, and grounded — supporting the low poly geometry with believable detail, never drawing attention to itself as a stylistic gimmick.