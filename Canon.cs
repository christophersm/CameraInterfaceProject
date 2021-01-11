using System;

namespace CameraInterfaceProject
{
      public class Canon : DefaultCamera, ICamera
        {
            public void ShutterClick()
            {
                Console.WriteLine($"Capture images on your new {CameraBrand} {CameraModel} using any of the {CameraMountType} lenses.");
                Console.WriteLine();
            }
        }
}