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

* Unity Mod Manager installed into Survivalist: Invisible Strain.

Build
-----

1. Checkout to `Mods/RevisedCropSafety`.
2. From the `Mods/RevisedCropSafety/src` directory, run `dotnet build`.
3. Copy `Mods/RevisedCropSafety/src/bin/Debug/net40/RevisedCropSafety.dll` to
   `Mods/RevisedCropSafety`.