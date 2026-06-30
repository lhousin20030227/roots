# TEXTURES

## Purpose

This document defines the standards for all textures used in ROOTS.

Textures should enhance realism while remaining optimized for performance.

---

# Philosophy

Textures should represent real-world surfaces.

They should complement 3D models, not compensate for poor modeling.

High quality does not mean unnecessarily high resolution.

---

# Texture Categories

## Albedo (Base Color)

Defines the surface color.

Rules:

* No baked shadows.
* No baked highlights.
* No lighting information.
* Natural colors only.

---

## Normal Map

Adds fine surface detail without increasing polygon count.

Examples:

* Wood grain
* Fabric weave
* Cracks
* Scratches
* Stone detail

---

## Roughness Map

Controls how rough or smooth a surface appears.

Examples:

* Polished wood
* Matte paint
* Wet concrete
* Old paper

---

## Metallic Map

Defines metallic surfaces.

Only real metals should use metallic values.

Examples:

* Steel
* Copper
* Aluminum
* Brass

Wood, fabric, paper, and plastic should remain non-metallic.

---

## Ambient Occlusion (AO)

Adds subtle contact shadows where appropriate.

Should enhance realism without darkening the entire asset.

---

# Resolution Standards

Choose the smallest resolution that maintains quality.

Recommended sizes:

* Small Props → 512×512
* Medium Objects → 1024×1024
* Large Objects → 2048×2048
* Hero Assets → 4096×4096 (only when necessary)

Avoid oversized textures.

---

# Texture Style

Textures should include realistic imperfections.

Examples:

* Dust
* Dirt
* Scratches
* Paint wear
* Water stains
* Fingerprints
* Fabric fading

Perfect surfaces should be uncommon.

---

# Texture Tiling

Tileable textures should:

* Repeat seamlessly.
* Avoid visible patterns.
* Maintain consistent scale.

Used for:

* Walls
* Floors
* Roads
* Grass
* Concrete

---

# Compression

All textures should be compressed appropriately.

Balance:

* Image quality
* Memory usage
* Loading speed

Avoid unnecessary loss of detail.

---

# File Formats

Preferred formats:

* `.png` → Lossless textures with transparency.
* `.jpg` → Large opaque textures.
* `.webp` → Optimized textures where supported.

---

# Optimization Rules

* Reuse textures whenever possible.
* Avoid duplicate texture files.
* Remove unused textures.
* Keep texture memory efficient.
* Use atlases when practical.

---

# Design Rules

* Realistic colors.
* Consistent texel density.
* Proper UV alignment.
* Physically accurate materials.
* Optimized for real-time rendering.

---

# Final Rule

Textures in ROOTS should quietly reinforce realism. Players should notice the believable world—not the textures themselves.
