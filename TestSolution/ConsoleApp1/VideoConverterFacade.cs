using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Converter;
using FileReader;

namespace Facade
{
    class VideoConverterFacade
    {
        public FileInfo ConvertVideo(string path, string fromFormat, string toFormat)
        {
            byte[] fileData = null;
            FileInfo convertedFile = null;

            switch (fromFormat)
            {
                case "mp4":
                {
                    fileData = Mp4Reader.Read(path);
                    break;
                }
                case "wav":
                {
                    fileData = WavReader.Read(path);
                    break;
                }
                case "flv":
                {
                    fileData = FlvReader.Read(path);
                    break;
                }
                //And other cases
            }

            switch (toFormat)
            {
                case "mp4":
                {
                    convertedFile = Mp4Converter.Convert(fileData);
                    break;
                }
                case "wav":
                {
                    convertedFile = WavConverter.Convert(fileData);
                    break;
                }
                case "flv":
                {
                    convertedFile = FlvConverter.Convert(fileData);
                    break;
                }
                //And other cases
            }
            return convertedFile;
        }
    }
}

namespace FileReader
{
    public class Mp4Reader
    {
        public static byte[] Read(string path)
        {
            return null;
        }
    }

    public class WavReader
    {
        public static byte[] Read(string path)
        {
            return null;
        }
    }

    public class FlvReader
    {
        public static byte[] Read(string path)
        {
            return null;
        }
    }
}


namespace Converter
{
    public class Mp4Converter
    {
        public static FileInfo Convert(byte[] fileData)
        {
            return null;
        }

    }

    public class WavConverter
    {
        public static FileInfo Convert(byte[] fileData)
        {
            return null;
        }

    }

    public class FlvConverter
    {
        public static FileInfo Convert(byte[] fileData)
        {
            return null;
        }

    }
}