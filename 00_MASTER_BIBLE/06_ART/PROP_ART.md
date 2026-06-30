PROP ART
Purpose
Prop Art defines the visual and functional standards for all interactive and decorative objects in ROOTS, ensuring consistency with the established art style and supporting environmental storytelling.

Visual Approach
Props use 3D Low Poly geometry with Pixel Art textures, following the same visual language defined in ART_DIRECTION.md.
Every prop must feel like a real object that belongs to a real person's life — not a generic game asset.

Prop Categories
Story Props
Objects tied directly to narrative or evidence.
Examples: letters, photographs, personal belongings, official documents.

Highest visual fidelity within the poly/texture budget.
Must be clearly readable when inspected closely.


Functional Props
Objects the player interacts with mechanically.
Examples: doors, drawers, switches, keys, tools.

Must clearly communicate their function through shape and material.
Animation-ready (see ANIMATION.md) for opening, using, or activating.


Set Dressing Props
Objects placed for realism and atmosphere only.
Examples: books, dishes, clothing, small furniture items.

Lower visual priority, optimized for reuse and instancing.
Add believability without demanding focus.


Geometry Rules

Low poly count scaled to object importance (story props slightly more detailed than set dressing).
Clean, recognizable silhouettes at typical interaction distance.
Realistic scale relative to character and environment standards.


Texture Rules

Pixel Art textures applied consistently with PIXEL_ART_GUIDE.md density.
Wear, age, and use reflected through texture (scratches, fading, stains).
Consistent texel density relative to object size and importance.


Material Consistency

Wood: warm, matte, slightly worn.
Metal: dull, matte, naturally aged.
Paper: soft, slightly textured, never glossy.
Fabric: muted, naturally creased.

Must align with COLOR_PALETTE.md and MATERIALS_TEXTURES.md.

Reusability Rules

Common props (chairs, drawers, books) built as modular, reusable assets.
Unique story props built individually, but following the same style rules.
Variations (color/wear) used instead of entirely new models where possible.


Interaction Readability

Interactive props must visually communicate they can be interacted with (subtle distinction in detail or placement, not glowing outlines).
Functional parts (handles, switches, locks) clearly modeled, not flat textures pretending to be 3D.


Performance Rules

Heavy use of instancing for repeated props.
Simplified colliders matching object shape.
LOD applied to background/set dressing props in larger scenes.


Forbidden Visual Elements
Do not include:

Glowing outlines or "game-like" interaction highlights.
Floating, unanchored, or physically illogical prop placement.
Inconsistent texture resolution between similar prop types.
Decorative props with no narrative or atmospheric purpose.


Final Rule
Every prop in ROOTS must feel like it has a history and a reason to exist in its place — quietly supporting the story, the investigation, or the atmosphere, never existing as filler.