using UnityEditor;
using UnityEditor.U2D.Sprites;
using UnityEngine;

namespace AsepriteImporter.DataProviders
{
    public class AsepriteTextureDataProvider : ITextureDataProvider
    {
        private readonly AseFileImporter aseFileImporter;

        public AsepriteTextureDataProvider(AseFileImporter aseFileImporter)
        {
            this.aseFileImporter = aseFileImporter;
        }

        public Texture2D texture => aseFileImporter.Texture;

        public Texture2D previewTexture => aseFileImporter.Texture;

        public Texture2D GetReadableTexture2D()
        {
            if (aseFileImporter.textureImporterSettings.spriteMode == (int)SpriteImportMode.Multiple)
            {
                return aseFileImporter.Texture;
            }
            return null;
        }

        public void GetTextureActualWidthAndHeight(out int width, out int height) {
            // [FIXME] There is a slight chance the texture is not readable, in that case we return 0/0. This is not ideal, but it is better than crashing.

            if (aseFileImporter.Texture == null) {
                width = 0;
                height = 0;

                return;
            }

            width = aseFileImporter.Texture.width;
            height = aseFileImporter.Texture.height;
        }
    }
}