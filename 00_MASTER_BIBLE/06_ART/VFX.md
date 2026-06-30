VFX
Purpose
VFX (Visual Effects) defines the technical and creative standards for particle effects, dynamic visual phenomena, and visual feedback in ROOTS, ensuring all effects support atmosphere and storytelling without feeling artificial or gamey.

VFX Philosophy
Visual effects in ROOTS should feel like natural phenomena, lighting interactions, or realistic material behavior — never magical, never arcade-style.
Effects exist to reinforce mood, guide player attention subtly, or provide gameplay feedback.

Effect Categories
Environmental Effects
Subtle atmospheric effects that reinforce realism and mood.
Examples:

Dust particles floating in light rays (indoors).
Gentle wind particles (outdoors).
Smoke from extinguished candles or cigarettes.
Water droplets on surfaces in rain.
Fog in outdoor night scenes (sparingly).

Environmental effects should be understated — player should barely notice them, but miss them if absent.

Lighting Interaction Effects
Visual feedback when light interacts with environment.
Examples:

Light rays through windows (volumetric, subtle).
Shadows cast naturally by light sources.
Flickering candlelight (realistic, not erratic).
Lamp illumination bloom (minimal).

These effects support the LIGHTING_SYSTEM.md without competing with it.

Interaction Feedback Effects
Subtle visual feedback confirming player actions.
Examples:

Small particle burst when picking up an item.
Gentle glow when an objective is completed.
Soft fade when evidence is added to the board.

Feedback effects must be quick and non-intrusive — player never pauses to watch them.

Emotional/Story Effects
Effects tied directly to narrative moments.
Examples:

Warm glow during comforting memories.
Cold color shift during difficult discoveries.
Subtle camera distortion during emotional shock (rare, brief).
Gentle fade/transition between chapters.

Story effects serve emotional tone, never distract from dialogue or story content.

Weather Effects
Outdoor environmental effects reflecting time and season.
Examples:

Light rain (not heavy downpour).
Wind-blown leaves or dust.
Fog rolling across landscape.
Overcast sky transitions.

Weather effects enhance immersion — player should barely register them mechanically.

VFX Technical Standards
Particle Count

Keep total active particles low (under 500 per scene maximum).
No particle spam or overwhelming visual noise.
Each effect has a clear, justified visual purpose.


Color & Material

Particle colors pull from COLOR_PALETTE.md.
Particles use simple shaders matching the game's muted aesthetic.
No glowing neon or overly saturated particle colors.


Lifespan & Performance

Short lifespan for most effects (under 3 seconds).
Effects pool and reuse particles efficiently.
No frame rate spikes from VFX calculations.


Scale & Visibility

Particle scale appropriate to environment (not oversized or tiny).
Effects visible enough to serve their purpose, subtle enough not to distract.


Forbidden VFX
Do not include:

Magical glowing auras or spell effects.
Explosion or impact effects (no combat).
Lens flares or cinematic "game camera" effects.
Rainbow or excessively colorful particle systems.
Overly dense particle clouds obscuring visibility.
Screen-filling bloom or distortion effects.


Final Rule
VFX in ROOTS should enhance atmosphere and support story — they should work so quietly that the player attributes them to realism, never consciously thinks "I'm seeing visual effects."
When in doubt, use less, not more.