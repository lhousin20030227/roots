PERFORMANCE OPTIMIZATION
Purpose
Performance Optimization defines the technical standards for managing audio resources, streaming, memory usage, and playback efficiency in ROOTS, ensuring smooth audio delivery without stuttering, dropouts, or resource waste.

Audio Performance Philosophy
Audio must play reliably across target hardware without taxing CPU or memory resources unnecessarily.
Optimization is about smart implementation, not sacrificing quality — audio should sound excellent and run efficiently.

Audio File Management
File Format Standards

All audio compressed using efficient codecs (Ogg Vorbis, MP3, or platform-native formats).
No uncompressed WAV files for music or ambience (too large).
Dialogue optionally compressed or uncompressed depending on total dialogue volume.
Compression settings balanced between file size and quality loss.


File Size Optimization

Music loops: 2–4 MB per loop (compressed).
Ambience loops: 1–3 MB per loop (compressed).
Dialogue: 500 KB – 2 MB per line (compressed, depending on length).
SFX: 100 KB – 1 MB per effect (compressed).

Total audio asset size kept reasonable for target platform storage.

Resolution Scaling

Music/ambience: 44.1 kHz, 128–192 kbps (quality adequate for background audio).
Dialogue: 48 kHz, 192–256 kbps (higher quality for intelligibility).
SFX: 44.1 kHz, 128–192 kbps (quality adequate for short effects).

Higher sample rates and bitrates reserved for critical content only.

Memory Management
Audio Buffer Allocation

Streaming audio buffers (music, ambience) use moderate buffer sizes (prevent stuttering without excessive memory).
Short-duration SFX loaded into memory directly (no streaming overhead).
Dialogue loaded as needed (not all dialogue in memory simultaneously).


Memory Pooling

Audio sources pooled and reused (e.g., footstep sound pool for all character footsteps).
No constant memory allocation/deallocation (causes garbage collection spikes).
Pre-allocated pools sized appropriately (max simultaneous sounds estimated conservatively).


Memory Limits

Total audio assets: under 500 MB (including compressed and streaming assets).
Peak runtime memory: under 50 MB (depending on simultaneous audio streams and pools).


CPU Performance
Audio Processing

Real-time effects (reverb, compression) applied sparingly and only when necessary.
Most audio processing done offline during mixing/mastering, not in real-time during gameplay.
Audio engine configured for efficient playback (minimal CPU overhead per sound).


Simultaneous Audio Streams

Max simultaneous sounds: 32–64 (depending on platform).
Priority system: dialogue > music > SFX > ambience (lower priority sounds culled if limit exceeded).
Culling transparent to player (brief SFX interruption acceptable if needed).


Update Frequency

Audio logic updates every frame (tied to engine update cycle).
No unnecessary per-frame audio calculations.
Batch processing for multiple sounds (more efficient than individual updates).


Streaming & Playback
Music Streaming

Music streamed from disk (not loaded entirely into memory).
Stream buffer sized for seamless playback (prevent stuttering on disk access delays).
Stream lookahead allows smooth transitions between cues.


Ambience Streaming

Ambience streamed for long-duration loops (prevent repetition fatigue from short buffers).
Crossfade transitions prevent jarring switches between ambience cues.


Dialogue Playback

Dialogue loaded per-scene or per-chapter (not all dialogue at game start).
Preloading during scene transitions (dialogue ready before player needs it).
Unloading after scene complete (free memory for new scenes).


Compression Standards
Ogg Vorbis Compression

Quality setting: 6–8 (high quality, reasonable file size).
Bitrate: 128–256 kbps depending on content type.
Acceptable quality loss for background audio.


MP3 Compression

Bitrate: 192–320 kbps (higher quality if MP3 used).
More widely compatible but larger file size than Ogg.


Platform-Native Compression

Use platform-specific codecs if available (e.g., ADPCM on some platforms).
Reduces memory footprint on supported platforms.


Latency & Responsiveness

Interactive SFX latency: under 50 ms (imperceptible to player).
No noticeable delay between action and audio feedback.
Audio engine optimized to minimize playback latency.


Loading & Unloading
Scene-Based Unloading

Audio assets unloaded when scene no longer needed (free resources).
Ambience and music for scene unloaded on scene exit.
Dialogue for scene unloaded after scene complete.


Preloading During Transitions

Next scene's audio preloaded during current scene transitions.
Smooth audio transitions (no silence while loading).


Platform-Specific Optimization

PC (Windows): No specific optimization needed (audio APIs flexible).
If expanding to console: platform-specific audio API integration (PlayStation, Xbox, etc.).


Performance Monitoring

Audio performance tracked during development (memory, CPU, frame rate impact).
Profiling done with all audio systems active.
Issues addressed early (no last-minute optimization crunch).


Forbidden Optimization Practices
Do not include:

Uncompressed audio for large files (wastes memory).
Loading entire soundtrack into memory at startup (excessive memory waste).
Excessive real-time audio processing (CPU impact).
No audio culling system (audio priority management essential).
Ignoring platform limitations (test on actual target hardware).


Final Rule
Audio optimization is about respecting player hardware and delivering reliable, high-quality sound — efficient implementation is a sign of professional development, not a compromise to audio quality.
