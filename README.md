Revised Crop Safety
===================

A mod for Survivalist: Invisible Strain.

By default, workers on Farmer role will plant new crops unless the _current_
temperature is less than 0 C. This can lead to situations where workers will
plant crops that will die of frost before harvesting, because it is warm
enough _right now_.

This mod gives workers on Farmer role extra knowledge of the weather. Now, they
will predict the weather over the next 7 days and avoid planting if they expect
an average nighttime temperature below 0 C any time during that window. This
makes leaving workers on the Farmer role much safer as they will be less likely
to plant crops without a chance to survive until harvest.

Requirements
------------

* Survivalist: Invisible Strain v108 or later.

Install (from precompiled build)
--------------------------------

1. Create a folder called `DLLs` in your Story of choice (e.g. 'Sandbox'), if
   one doesn't already exist.
2. Drop both DLL files into the folder. You don't need to replace `0Harmony.dll`
   if one already exists.


Build
-----

1. Checkout the repository (for best results, to `dev/RevisedCropSafety`
   relative to your Survivalist: Invisible Strain directory, otherwise you have
   to re-point a bunch of assembly references).
2. Run `dotnet build` inside `src` directory.
3. From the `src/bin/Debug/net40/` directory, copy both `RevisedCropSafety.dll`
   and `0Harmony.dll` to your Story's `DLLs` folder (create this folder if it
   doesn't exist).
   Note that you shouldn't need to replace `0Harmony.dll` if your Story (or a 
   Story it depends on) already has it.

License
-------

This mod contains code from Survivalist: Invisible Strain. Bob the P.R. Bot
has confirmed that use of small amounts of such code in non-commercial mods
for Survivalist: Invisible Strain is permissible.

You may use other code from this mod in non-commercial mods for Survivalist: 
Invisible Strain if doing so meets your needs.

You may include compiled versions of this mod in your own Stories, including
Stories that you author and subsequently publish to Steam Workshop. (However,
future updates to Survivalist: Invisible Strain may render doing so
unnecessary.)

This project redistributes Harmony 2.0.4 under the terms of the MIT License. Its
license is reproduced in full in the `3rdparty/LICENSE.Harmony` file.