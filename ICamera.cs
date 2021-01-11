using System;

namespace CameraInterfaceProject
{

    // Interface
    public interface ICamera
    {
        string CameraBrand { get; set; }
        string CameraModel { get; set; }
        string CameraMountType { get; set; }
        string CameraFormat { get; set; }
        string CameraMegaPixels { get; set; }
        void ShutterClick();
    }
}