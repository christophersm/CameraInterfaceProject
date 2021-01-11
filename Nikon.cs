using System;

namespace CameraInterfaceProject
{
      public class Nikon : DefaultCamera, ICamera
        {
            public void ShutterClick()
            {
                Console.WriteLine($"Capture images on your new {CameraBrand} {CameraModel} using any of the {CameraMountType} lenses. This is the second generation of {CameraFormat} camera types for {CameraBrand}.");
                Console.WriteLine();
            }
        }
}