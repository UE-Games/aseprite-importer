# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.1.2] - 2022-08-23
### Changed
- Directory separators are now platform independent

## [1.1.1] - 2022-08-22
### Added
- Missing meta files

## [1.1.0] - 2022-08-22
### Added
- Slice importer; originally at:
    - https://github.com/gavriktonio/unity-aseprite-importer/commit/d228997384c0a50d5ffcc2416c84af66cd0657bd
    - https://github.com/gavriktonio/unity-aseprite-importer/commit/63e02ab6353e3ddaf3ec2a7b763efdb123917c82
    - https://github.com/gavriktonio/unity-aseprite-importer/commit/e084154b5872b8e644c05d8abcedc5434acf570b
    - https://github.com/gavriktonio/unity-aseprite-importer/commit/9b25617c870157a5a15ff0104bf376db80171f5e
    - https://github.com/gavriktonio/unity-aseprite-importer/commit/33fdec84bbb2e7b728890388dc2e9691a5f681cd
- Padding is now a parameter in import settings for animation aseprite importer. Padding by default is set to 0 instead of 1 (https://github.com/gavriktonio/unity-aseprite-importer/commit/62635a93893285b91f6e94d443976338cc9ef4dc)
- Skip Import option (https://github.com/gavriktonio/unity-aseprite-importer/commit/75a34c501ba8100b99d8ca85edcfa15b7443577e)

### Changed
- PPUs changed to float (https://github.com/gavriktonio/unity-aseprite-importer/commit/246e511d8b99120a84ba728a170ad940efd72a41)
- Normal type layers blending on import (https://github.com/gavriktonio/unity-aseprite-importer/commit/64d4ebac48e5019042f5182a277d7da8a862b614)
- Decrease update limit for the sprite importer (https://github.com/gavriktonio/unity-aseprite-importer/commit/15dd5860a2903232448bfdcb0ef557793a53e5da)
- Generating an extra row on atlas sometimes (https://github.com/gavriktonio/unity-aseprite-importer/commit/7b14c58d9de642a043f61dec61a1970c770aa206)
- Apply layer opacity when importing sprite as layers (https://github.com/thekidder/unity-aseprite-importer/commit/ffcc65982747359429b99f4efd20fb7d66715b15)
- Only process transform metadata layer when needed (https://github.com/thekidder/unity-aseprite-importer/commit/1ff84985a09b7beb216363fe9d0e7bfe97f1ae7a)
- Changing the clip to 120 FPS
- Imported animation clips now loop by default
- Clips are now generated in a subdirectory, and without a prefix
- Check for invalid texture
- Using Path.DirectorySeparatorChar as a separator instead of / or \
- Generating semi-random tag name when the original tag name is empty

## [1.0.4] - 2021-01-19
### Added
- Dependency for the Unity 2D Sprite in package.json
- Support for OpenUPM

## [1.0.3] - 2020-12-28
### Added
- Support for different import implementations
- Bundled Importer to keep the imported sprites and animations in one file
- Support for the sprite-editor with the Bundled Importer

### Changed
- The regular import was labelled "Generated" because it generates the content and creates new assets in a subfolder 

## [1.0.2] - 2020-12-28
### Added
- Creates a sprite sheet file (not dynamic)
- Editable meta data like custom physics shapes with the 'Sprite Editor'
- Generates tilemap with extended-padding (solves lines tearing issue between tiles)
- Makes animation files (not dynamic)
- Animation controller creation
- New tilemap name rule support (row-col)

### Changed
- Creates multiple assets instead of one single bundle

## [1.0.1] - 2020-02-04
### Added
- Transparent color option
- Tilemap empty behaviour

### Changed
- Support for Unity package manager was fixed

## [1.0.0] - 2018-11-05
### Added
- Different Import Modes (Sprite, Tilemap)
- Auto-Sprite creation
