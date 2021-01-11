using System;

namespace CameraInterfaceProject
{
    public class DefaultCamera
        {
            public string CameraBrand { get; set; }
            public string CameraModel { get; set; }
            public string CameraMountType { get; set; }
            public string CameraFormat { get; set; }
            public string CameraMegaPixels { get; set; }
 
            protected string GetCameraInfo()
            {
                return $"{CameraBrand} {CameraModel} - Mount Type: {CameraMountType}; Format: {CameraFormat}; MegaPixels: {CameraMegaPixels};";
            }
        }
}