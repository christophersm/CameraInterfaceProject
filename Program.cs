using System;

namespace CameraInterfaceProject
{
    class Program
    {
       static void Main(string[] args)
       {

           ICamera camera = new Nikon
            {
                CameraBrand = "Nikon",
                CameraModel = "Z 7 II",
                CameraMountType = "Z-mount",
                CameraFormat = "Mirrorless",
                CameraMegaPixels = "45 MP"
            };

            Console.WriteLine($"Capture images on your new {camera.CameraBrand} {camera.CameraModel} using any of the {camera.CameraMountType} lenses. This is the second generation of {camera.CameraFormat} camera types for {camera.CameraBrand}.");

            camera = new Sony
            {
                CameraBrand = "Sony",
                CameraModel = "Alpha a7s III",
                CameraMountType = "A-mount",
                CameraFormat = "Mirrorless",
                CameraMegaPixels = "12 MP"
            };

            Console.WriteLine($"Capture images on your new {camera.CameraBrand} {camera.CameraModel} using any of the {camera.CameraMountType} lenses.");

            camera = new Canon
            {
                CameraBrand = "Canon",
                CameraModel = "EOS R5",
                CameraMountType = "EF mount",
                CameraFormat = "Mirrorless",
                CameraMegaPixels = "45 MP"
            };

            Console.WriteLine($"Capture images on your new {camera.CameraBrand} {camera.CameraModel} using any of the {camera.CameraMountType} lenses.");

       }

    }
}
