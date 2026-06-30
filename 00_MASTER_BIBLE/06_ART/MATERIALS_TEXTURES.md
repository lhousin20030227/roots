MATERIALS & TEXTURES
Purpose
This document defines the technical and visual standards for all materials and textures used in ROOTS, ensuring consistency across characters, environments, and props.

Material Philosophy
Materials should feel real, worn, and grounded.
Nothing in ROOTS should look synthetic, plastic, or "game-engine default" — every surface should look like it has history.

Texture Resolution Standards

Hero/story props: higher pixel density (clear when inspected closely).
Environment surfaces (walls, floors): medium, consistent texel density.
Set dressing/background props: lower density, optimized for reuse.

Texel density must remain consistent within the same category across the entire game — no mismatched resolutions side by side.

Pixel Art Texture Rules

No anti-aliasing or texture blurring (point/nearest filtering only).
Consistent pixel grid size across all assets (defined per category).
No texture stretching — UV mapping must preserve correct pixel proportions.
Hand-painted feel, not photo-sourced or photogrammetry-based.


Material Types
Wood

Matte finish, warm tones.
Visible grain and wear (scratches, fading).
Never glossy or freshly varnished looking.

Metal

Dull, matte, slightly oxidized look.
Minimal reflectivity — no mirror-like surfaces.
Wear shown through dullness, not damage spam.

Fabric

Soft, muted tones.
Natural creasing and slight fading.
No glossy or silk-like shaders.

Paper / Documents

Slightly textured, off-white or aged tones.
Never pure white or glossy.
Legible at inspection distance.

Glass

Subtle transparency, slight dirt/smudge where narratively appropriate.
No exaggerated reflections or refraction effects.

Stone / Concrete

Matte, slightly rough texture.
Muted grey tones with subtle variation.


Shader Rules

Use simple, unlit or lightly-lit shaders compatible with low poly + pixel art style.
Avoid PBR-heavy reflective/specular setups that clash with the flat pixel art look.
Consistent shader logic across all asset categories for performance and visual unity.


Wear & Aging Rules
Wear must always be intentional and narratively justified:

Heavier wear in older, abandoned, or neglected spaces.
Lighter wear in well-maintained or recently used spaces.
Wear reinforces time passage and emotional tone, not just realism for its own sake.


Texture Atlas & Optimization

Shared texture atlases used for repeated props and modular environment pieces.
Minimize unique texture count through smart reuse and tiling where appropriate.
Texture compression settings consistent across asset categories.


Consistency Rules

All materials must pull from the same defined tone/wear language as COLOR_PALETTE.md.
No category mixing (e.g., no glossy plastic-style material in a "worn wood" context).
Material rules apply equally to characters, environment, and props.


Performance Rules

Limit unique material count per scene.
Reuse materials/textures across modular assets wherever possible.
Compress textures appropriately for target platform without visible quality loss at intended viewing distance.


Forbidden Material Traits
Do not include:

Glossy, plastic, or "shiny game asset" surfaces.
Pure white, pure black, or oversaturated material colors.
Photorealistic PBR materials clashing with the pixel art style.
Inconsistent wear logic (pristine objects in abandoned spaces, or vice versa).


Final Rule
Every material and texture in ROOTS must reinforce the feeling of a real, aged, lived-in world — consistent in technique, restrained in style, and always serving the story's emotional truth.