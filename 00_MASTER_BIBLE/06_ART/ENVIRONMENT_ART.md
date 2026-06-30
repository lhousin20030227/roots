ENVIRONMENT ART
Purpose
Environment Art defines the visual standards for all locations in ROOTS, ensuring every space feels real, lived-in, and emotionally consistent with the story.

Visual Approach
Environments use 3D Low Poly geometry with Pixel Art textures, following the same visual language defined in ART_DIRECTION.md.
Every space should feel like a real place people once occupied — not a generic game level.

Environmental Storytelling Priority
Environments are not just backdrops — they are narrative tools.
Every location must communicate:

Who lived/worked there.
How much time has passed.
Emotional tone of that space.
Subtle clues supporting the investigation.


Geometry Rules

Low poly architecture, optimized for first-person interior/exterior viewing.
Modular building blocks (walls, floors, doors, windows) for consistency and efficiency.
Realistic room scale and proportions (matches character height and door standards).
Clean silhouettes — avoid unnecessary geometric clutter.


Texture Rules

Pixel Art textures applied consistently with PIXEL_ART_GUIDE.md density.
Consistent texel density across all surfaces in a scene.
Wear and age reflected through texture detail (cracks, fading, dust) rather than geometry.
No tiling artifacts visible at normal play distance.


Location Types
Interior Spaces
Examples: family home, bedrooms, kitchen, offices, abandoned rooms.

Dense with personal/environmental storytelling props.
Lighting must follow LIGHTING_SYSTEM.md.
Layout supports natural exploration and evidence discovery.


Exterior Spaces
Examples: streets, yards, neighborhood paths.

Simpler geometry, optimized for distance viewing.
Used mainly as connective spaces between interiors.
Weather and time-of-day variation supported (see TIME_SYSTEM.md).


Transitional Spaces
Examples: hallways, stairwells, entryways.

Kept visually simple to avoid distracting from main story spaces.
Used for pacing and emotional transition between scenes.


Set Dressing Rules

Every prop placed must have a reason (see OBJECT_SYSTEM.md).
Avoid empty, lifeless rooms — but avoid clutter without purpose.
Furniture and props scaled and positioned realistically.
Dust, wear, and disorganization used intentionally to convey time and emotion.


Consistency Rules

Same poly budget and texture resolution standards across all locations.
Architectural style remains consistent within the same building/area.
Recurring modular assets (doors, windows, furniture) keep identical style everywhere.


Performance Rules

Modular reuse to reduce unique asset count.
LOD and occlusion culling for larger exterior areas.
Baked lighting prioritized over real-time where possible.


Forbidden Visual Elements
Do not include:

Empty, purposeless rooms.
Overly cluttered "game-like" prop spam.
Inconsistent architectural scale or proportions.
High-poly detail clashing with the low poly standard.
Generic or copy-pasted layouts with no narrative identity.


Final Rule
Every environment in ROOTS must feel like a real place with a history — quiet, detailed enough to investigate, and emotionally aligned with the story being told within it.